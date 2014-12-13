using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Conversion.Models;
using System.Net.Http;
using System.Web.Http;

namespace Conversion.Controllers
{
    public class ConversionApiController : ApiController
    {
        [HttpGet]
        public int ConvertDateTimeToUnixTime([FromUri]DateModel dateModel) 
        {
            
            return (int)dateModel.ToDateTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }

        [HttpGet]
        public DateTime ConvertUnixTimeToDateTime([FromUri]int timestamp)
        {

            return (new DateTime(1970, 1, 1)).AddSeconds(timestamp);
        }
    }
}
