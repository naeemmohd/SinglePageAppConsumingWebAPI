using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using HelloApp.Patterns.Implementations;
using HelloApp.Patterns.Interfaces;
using Newtonsoft.Json;

namespace HelloApp.Controllers
{
    public class HelloWorldController : ApiController
    {
        public JsonResult GetHelloWorld()
        {
            string strReturnData = string.Empty;
            try
            {
                IHelloWorld oHelloWold = null;

                //this code can be called to return Simple hardcoded implementation of HelloWold
                oHelloWold = new SimpleHelloWorld();

                //this code can be called to return Database implementation of HelloWold - commented as of now
                //oHelloWold = new DBHelloWorld();

                oHelloWold.TxtData = "This is success data.";
                strReturnData = oHelloWold.GetText();
            }
            catch (Exception ex)
            {
                strReturnData = "This is error data.";
                //TO DO - call a centrallized logger(log4net, loggly etc) to log the error 
            }

            // return the JSON Data 
            return new JsonResult { Data = strReturnData };
        }

    }
}
