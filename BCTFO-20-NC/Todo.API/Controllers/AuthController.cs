using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Todo.Contracts;
using Todo.Models.Identity;

namespace Todo.API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private ApiResponse _response;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
            _response = new();
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register([FromForm] RegistrationRequestDto model)
        {
            try
            {
                await _authService.Register(model);

                _response.Result = model;
                _response.IsSuccess = true;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                _response.Message = "User registered succesfully";
            }
            catch (Exception ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                _response.Message = ex.Message;
            }

            return StatusCode(_response.StatusCode, _response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromForm] LoginRequestDto model)
        {
            try
            {
                var loginResponse = await _authService.Login(model);

                if (loginResponse == null)
                {
                    _response.Result = null;
                    _response.IsSuccess = false;
                    _response.StatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                    _response.Message = "Username or password is incorrect";

                    return StatusCode(_response.StatusCode, _response);
                }

                _response.Result = loginResponse;
                _response.IsSuccess = true;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                _response.Message = "User logged in successfully";
            }
            catch (Exception ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                _response.Message = ex.Message;
            }

            return StatusCode(_response.StatusCode, _response);
        }


        [HttpPost("registeradmin")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RegisterAdmin([FromForm] RegistrationRequestDto model)
        {
            try
            {
                await _authService.RegisterAdmin(model);

                _response.Result = model;
                _response.IsSuccess = true;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                _response.Message = "Admin registered succesfully";
            }
            catch (Exception ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                _response.Message = ex.Message;
            }

            return StatusCode(_response.StatusCode, _response);
        }

    }
}
