using BusinessEntities;
using BussinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiRest.Controllers
{
    public class usuarioController : ApiController
    {
        [HttpPost]
        [Route("Usuarios")]
        public HttpResponseMessage P0005SHPR_USUA(BESHMC_USUA oBe)
        {
            var oBr = new BRSHMC_USUA();
            var oBeR = new BESHMC_USUA_RESP();
            try
            {
                oBr.P0006SHPR_USUA(oBe);
                oBeR.IND_ESTA = true;
                oBeR.ALF_MESA = "";
                oBeR.ALF_AGEN = oBe.ALF_AGEN;
                return Request.CreateResponse(HttpStatusCode.OK, oBeR);
            }
            catch (Exception ex)
            {
                oBeR.IND_ESTA = false;
                oBeR.ALF_MESA = ex.Message;
                oBeR.ALF_AGEN = "";
                return Request.CreateResponse(HttpStatusCode.NotAcceptable, oBeR);
            }
        }
    }
}
