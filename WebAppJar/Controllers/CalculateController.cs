using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppJar.Controllers
{
    public class CalculateController : ApiController
    {
        [HttpPost]
        public IHttpActionResult DetermineShape(Shape shape)
        {
            string ret = string.Empty;
            try
            {
                if (shape.IsValidShape())
                {
                    if (shape.Side1 == shape.Side3 && shape.Side2 == shape.Side4)
                    {
                        if (shape.Side1 == shape.Side2)
                        {
                            return Ok("Square");
                        }
                        else
                        {
                            return Ok("Rectangle");
                        }
                    }
                }
                else
                {
                    return Ok("Invalid Shape");
                }

                return Ok("Neither");
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
        
    }
}
