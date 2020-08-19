using Calc.Core;
using Calc.Dal;
using Calc.Entities;
using System;
using System.Web.Http;

namespace Calc.Main.Controllers
{
    public class CalcController : ApiBaseController
    {
        private readonly ICalcService _calcService;
        private readonly ILogService _logService;

        public CalcController(ICalcService calcService, ILogService logService)
        {
            _calcService = calcService;
            _logService = logService;
        }

        public IHttpActionResult PostSum([FromUri] string sum)
        {
            try
            {
                var log = new Log(FindIPAddress());
                _logService.Add(log);

                var result = _calcService.Calculate(sum);
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest("Error In Calculation");
            }
        }
    }
}
