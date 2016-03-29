using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using MVCSample.Models;
using System.Web.Mvc;

namespace MVCSample.Controllers.Api
{
    public class FormController : ApiController
    {
        /// <summary>
        /// Handle form submit
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public dynamic Sumbit(FormData data)
        {
            // Check if model is valid that was posted
            if (ModelState.IsValid)
            {
                // process submitted form data
            }
            else
            {
                // invalid model data, return 400 error
                return BadRequest("Invalid Request");
            }

            // success
            return Json(new { success = true });  
        }
    }
}
