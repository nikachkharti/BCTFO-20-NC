using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Todo.Contracts;
using Todo.Data;
using Todo.Models.Identity;
using Todo.Service.Exceptions;

namespace Todo.Service.Implementations
{
    public class AuthService : IAuthService
    {
        //TODO გადავკეთო, შემოვიტანო რეპოზიტორი
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IJwtGenerator _jwtTokenGenerator;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string _adminRole = "Admin";
        private const string _customerRole = "Customer";

        public AuthService(ApplicationDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IJwtGenerator jwtTokenGenerator, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _jwtTokenGenerator = jwtTokenGenerator;
            _httpContextAccessor = httpContextAccessor;
            _mapper = MappingInitializer.Initialize();
        }

        public async Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName.ToLower() == loginRequestDto.UserName.ToLower());
            bool isValid = await _userManager.CheckPasswordAsync(user, loginRequestDto.Password);

            if (user == null || isValid == false)
            {
                return new LoginResponseDto()
                {
                    Token = string.Empty,
                    User = null
                };
            }

            var roles = await _userManager.GetRolesAsync(user);
            var token = _jwtTokenGenerator.GenerateToken(user, roles);

            UserDto userDto = new()
            {
                Id = user.Id,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };

            LoginResponseDto result = new()
            {
                User = userDto,
                Token = token
            };

            return result;
        }

        public async Task Register(RegistrationRequestDto registrationRequestDto)
        {
            IdentityUser user = new()
            {
                UserName = registrationRequestDto.Email,
                NormalizedUserName = registrationRequestDto.Email.ToUpper(),
                Email = registrationRequestDto.Email,
                NormalizedEmail = registrationRequestDto.Email.ToUpper(),
                PhoneNumber = registrationRequestDto.PhoneNumber
            };

            try
            {
                var result = await _userManager.CreateAsync(user, registrationRequestDto.Password);

                if (result.Succeeded)
                {
                    var userToReturn = await _context.Users.FirstOrDefaultAsync(x => x.Email.ToLower() == registrationRequestDto.Email.ToLower());

                    if (userToReturn != null)
                    {
                        if (!await _roleManager.RoleExistsAsync(_customerRole))
                        {
                            await _roleManager.CreateAsync(new IdentityRole(_customerRole));
                        }

                        await _userManager.AddToRoleAsync(userToReturn, _customerRole);

                        UserDto userDto = new()
                        {
                            Email = userToReturn.Email,
                            Id = userToReturn.Id,
                            PhoneNumber = userToReturn.PhoneNumber
                        };
                    }
                }
                else
                {
                    throw new RegustrationFaliureException(result.Errors.FirstOrDefault().Description);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task RegisterAdmin(RegistrationRequestDto registrationRequestDto)
        {
            IdentityUser user = new()
            {
                UserName = registrationRequestDto.Email,
                NormalizedUserName = registrationRequestDto.Email.ToUpper(),
                Email = registrationRequestDto.Email,
                NormalizedEmail = registrationRequestDto.Email.ToUpper(),
                PhoneNumber = registrationRequestDto.PhoneNumber
            };

            try
            {
                var result = await _userManager.CreateAsync(user, registrationRequestDto.Password);

                if (result.Succeeded)
                {
                    var userToReturn = await _context.Users.FirstOrDefaultAsync(x => x.Email.ToLower() == registrationRequestDto.Email.ToLower());

                    if (userToReturn != null)
                    {
                        if (!await _roleManager.RoleExistsAsync(_adminRole))
                        {
                            await _roleManager.CreateAsync(new IdentityRole(_adminRole));
                        }

                        await _userManager.AddToRoleAsync(userToReturn, _adminRole);

                        UserDto userDto = new()
                        {
                            Email = userToReturn.Email,
                            Id = userToReturn.Id,
                            PhoneNumber = userToReturn.PhoneNumber
                        };
                    }
                }
                else
                {
                    throw new RegustrationFaliureException(result.Errors.FirstOrDefault().Description);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private string GetAuthenticatedUserId()
        {
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                return _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            }
            else
            {
                throw new UnauthorizedAccessException("Can't get credentials of unauthorzied user");
            }
        }
        private string GetAuthenticatedUserRole()
        {
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                return _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
            }
            else
            {
                throw new UnauthorizedAccessException("Can't get credentials of unauthorzied user");
            }
        }

    }
}
