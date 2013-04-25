using System.Web.Http;
using CodeCamper.Data.Contracts;

namespace CodeCamper.Web.Controllers
{
    public abstract class ApiControllerBase : ApiController
    {
        protected IUnitOfWork Uow { get; set; }
    }
}