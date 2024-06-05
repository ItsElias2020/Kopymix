using CommonModel;

namespace ApiWeb.Midleware
{
    public interface IHelperHttpContext
    {
        InfoRequest GetInfoRequest(HttpContext request);
    }
}
