using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Todo.Contracts;
using Todo.Models;

namespace Todo.API.Controllers
{
    [Produces("application/json")]
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


        /// <summary>
        /// აბრუნებს კონკრეტული მომხმარებლის ყველა საქმეს
        /// </summary>
        /// <param name="userId">მომხმარებლის id</param>
        /// <returns>List TodoForGettingDto</returns>
        [HttpGet("{userId:guid}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> AllTodosOfUser([FromRoute] string userId)
        {
            var result = await _todoService.GetTodosOfUserAsync(userId);

            _response.Result = result;
            _response.IsSuccess = true;
            _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
            _response.Message = "Request completed successfully";

            return StatusCode(_response.StatusCode, _response);
        }


        [HttpGet("{userId:guid}/{todoId:int}")]
        public async Task<IActionResult> SingleTodoOfUser([FromRoute] string userId, [FromRoute] int todoId)
        {
            var result = await _todoService.GetSingleTodoByUserId(todoId, userId);

            _response.Result = result;
            _response.IsSuccess = true;
            _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
            _response.Message = "Request completed successfully";

            return StatusCode(_response.StatusCode, _response);
        }


        [HttpPost]
        public async Task<IActionResult> AddTodo([FromBody] TodoForCreatingDto model)
        {
            await _todoService.AddTodoAsync(model);

            _response.Result = model;
            _response.IsSuccess = true;
            _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
            _response.Message = "Request completed successfully";


            return StatusCode(_response.StatusCode, _response);
        }


        [HttpDelete("{todoId:int}")]
        public async Task<IActionResult> DeleteTodo([FromRoute] int todoId)
        {
            await _todoService.DeleteTodoAsync(todoId);

            _response.Result = todoId;
            _response.IsSuccess = true;
            _response.StatusCode = Convert.ToInt32(HttpStatusCode.NoContent);
            _response.Message = "Request completed successfully";

            return StatusCode(_response.StatusCode, _response);
        }



        [HttpPatch("{todoId:int}")]
        public async Task<IActionResult> UpdateTodo([FromRoute] int todoId, [FromBody] JsonPatchDocument<TodoForUpdatingDto> patchDocument)
        {
            await _todoService.UpdateTodoAsync(todoId, patchDocument);

            _response.Result = patchDocument;
            _response.IsSuccess = true;
            _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
            _response.Message = "Todo updated successfully";

            return StatusCode(_response.StatusCode, _response);
        }


        //[HttpPut]
        //public async Task<IActionResult> UpdateTodo([FromBody] TodoForUpdatingDto todoForUpdatingDto)
        //{
        //    await _todoService.UpdateTodoAsync(todoForUpdatingDto);

        //    _response.Result = todoForUpdatingDto;
        //    _response.IsSuccess = true;
        //    _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
        //    _response.Message = "Request completed successfully";

        //    return StatusCode(_response.StatusCode, _response);
        //}

    }
}
