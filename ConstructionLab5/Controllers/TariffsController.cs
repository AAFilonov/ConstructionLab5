using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

using System.Data.SqlClient;


namespace ConstructionLab5.Controllers
{
    public class TariffsController : ApiController
    {

        private static readonly string[] Summaries = new[]
       {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [Route("api/[controller]/get_tariffs_data")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var actionResult = new Dictionary<string, string> {
               {  "Квартирный  S","Длинное описание тарифа Квартирный S"},
            {  "Квартирный  M", "Длинное описание тарифа Квартирный M"},
            {  "Квартирный  L",  "Длинное описание тарифа Квартирный L" }
          };
            return new JsonResult(actionResult);

        }
    }
}