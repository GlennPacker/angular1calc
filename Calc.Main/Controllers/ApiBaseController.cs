using Calc.Core;
using Calc.Entities;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Calc.Main.Controllers
{
    [EnableCors(origins: "http://localhost:44379", headers: "*", methods: "*")]
    public class ApiBaseController : ApiController
    {
        protected string FindIPAddress()
        {
            System.Web.HttpContext context = System.Web.HttpContext.Current;
            string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipAddress))
            {
                string[] addresses = ipAddress.Split(',');
                if (addresses.Length != 0)
                {
                    return addresses[0];
                }
            }

            return context.Request.ServerVariables["REMOTE_ADDR"];
        }
    }
}