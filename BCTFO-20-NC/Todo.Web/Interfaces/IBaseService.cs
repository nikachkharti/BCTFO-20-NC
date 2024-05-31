using Todo.Web.Models;

namespace Todo.Web.Interfaces
{
    public interface IBaseService
    {
        Task<ApiResponse> SendAsync(ApiRequest request);
    }
}
