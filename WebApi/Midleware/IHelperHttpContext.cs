using CommonModel;

namespace WebApi.Midleware
{
    public interface IHelperHttpContext
    {
        InfoRequest GetInfoRequest(HttpContext request);
    }
}
