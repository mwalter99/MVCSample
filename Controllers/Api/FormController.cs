using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using MVCSample.Models;
using System.Web.Mvc;
using MVCSample.Models.Context;

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
                Lead lead = new Lead()
                {
                    FirstName = data.FirstName,
                    LastName = data.LastName,
                    Gender = data.Gender,
                    State = data.State,
                    Birthdate = data.Birthdate,
                    PrimaryPhone = data.PrimaryPhone,
                    SecondaryPhone = data.SecondaryPhone
                };

                // save new lead
                try
                {
                    using (LeadDbContext db = new LeadDbContext())
                    {
                        // add new lead object
                        db.Leads.Add(lead);

                        // commit changes to database
                        db.SaveChanges();
                    }
                }
                catch(Exception ex)
                {
                    return BadRequest("Invalid Request");
                }
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
