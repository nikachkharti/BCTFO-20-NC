using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Todo.Contracts;
using Todo.Models;
using Todo.Service.Exceptions;

namespace Todo.API.Controllers
{
    [Route("api/todos")]
    [ApiController]
    [Authorize]
    public class TodosController : ControllerBase
    {
        private readonly ITodoService _todoService;
        private ApiResponse _response;
        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
            _response = new();
        }


        [HttpGet("{userId:guid}")]
        public async Task<IActionResult> AllTodosOfUser([FromRoute] string userId)
        {
            try
            {
                var result = await _todoService.GetTodosOfUserAsync(userId);

                _response.Result = result;
                _response.IsSuccess = true;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                _response.Message = "Request completed successfully";
            }
            catch (TodoNotFoundException ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                _response.Message = ex.Message;
            }
            catch (ArgumentException ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                _response.Message = ex.Message;
            }
            catch (UnauthorizedAccessException ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.Forbidden);
                _response.Message = ex.Message;
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


        [HttpGet("{userId:guid}/{todoId:int}")]
        public async Task<IActionResult> SingleTodoOfUser([FromRoute] string userId, [FromRoute] int todoId)
        {
            try
            {
                var result = await _todoService.GetSingleTodoByUserId(todoId, userId);

                _response.Result = result;
                _response.IsSuccess = true;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                _response.Message = "Request completed successfully";
            }
            catch (UserNotFoundExcpetion ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                _response.Message = ex.Message;
            }
            catch (TodoNotFoundException ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                _response.Message = ex.Message;
            }
            catch (ArgumentException ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                _response.Message = ex.Message;
            }
            catch (UnauthorizedAccessException ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.Forbidden);
                _response.Message = ex.Message;
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


        [HttpPost]
        public async Task<IActionResult> AddTodo([FromBody] TodoForCreatingDto model)
        {
            try
            {
                await _todoService.AddTodoAsync(model);

                _response.Result = model;
                _response.IsSuccess = true;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                _response.Message = "Request completed successfully";
            }
            catch (ArgumentException ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                _response.Message = ex.Message;
            }
            catch (UnauthorizedAccessException ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.Forbidden);
                _response.Message = ex.Message;
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



        [HttpDelete("{todoId:int}")]
        public async Task<IActionResult> DeleteTodo([FromRoute] int todoId)
        {
            try
            {
                await _todoService.DeleteTodoAsync(todoId);

                _response.Result = todoId;
                _response.IsSuccess = true;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.NoContent);
                _response.Message = "Request completed successfully";
            }
            catch (TodoNotFoundException ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                _response.Message = ex.Message;
            }
            catch (ArgumentException ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                _response.Message = ex.Message;
            }
            catch (UnauthorizedAccessException ex)
            {
                _response.Result = null;
                _response.IsSuccess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.Forbidden);
                _response.Message = ex.Message;
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
