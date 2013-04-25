using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using CodeCamper.Data.Contracts;
using CodeCamper.Model;

namespace CodeCamper.Web.Controllers
{
    public class SpeakersController : ApiControllerBase
    {
        /// <summary>
        /// passed by IOC !
        /// </summary>
        /// <param name="uow"></param>
        public SpeakersController(IUnitOfWork uow) : base()
        {
            Uow = uow;
        }

        // GET api/speakers
        public IEnumerable<Person> Get()
        {
            return Uow.Persons.GetAll().OrderBy(item => item.FirstName);
        }
    }
}
