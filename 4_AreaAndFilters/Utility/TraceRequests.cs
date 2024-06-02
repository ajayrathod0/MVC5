using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrease;

namespace _4_AreaAndFilters.Utility
{
    public class TraceRequestsAttribute : ActionFilterAttribute, IExceptionFilter
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controller = filterContext.RouteData.Values["controller"].ToString();
            string action = filterContext.RouteData.Values["action"].ToString();
            string massage = $"{controller} : {action} : OnActionExcuting : {DateTime.Now.ToString()}\n";

            LogMessageToFile(massage);
        }




        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string controller = filterContext.RouteData.Values["controller"].ToString();
            string action = filterContext.RouteData.Values["action"].ToString();
            string massage = $"{controller} : {action} : OnActionExcuting : {DateTime.Now.ToString()}\n";

            LogMessageToFile(massage);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string controller = filterContext.RouteData.Values["controller"].ToString();
            string action = filterContext.RouteData.Values["action"].ToString();
            string massage = $"{controller} : {action} : OnActionExcuting : {DateTime.Now.ToString()}\n";

            LogMessageToFile(massage);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string controller = filterContext.RouteData.Values["controller"].ToString();
            string action = filterContext.RouteData.Values["action"].ToString();
            string massage = $"{controller} : {action} : OnActionExcuting : {DateTime.Now.ToString()}\n";

            LogMessageToFile(massage);
        }

        public void LogMessageToFile(string message)
        {
            string logFilePath = AppDomain.CurrentDomain.BaseDirectory + "/Logs/Logs.txt";
            File.AppendAllText(logFilePath, message);
        }

        public void OnException(ExceptionContext filterContext)
        {
            string controller = filterContext.RouteData.Values["controller"].ToString();
            string action = filterContext.RouteData.Values["action"].ToString();
            string errorMessage = filterContext.Exception.Message;
            string massage = $"{controller} : {action} : OnActionExcuting : {DateTime.Now.ToString()}" +
                $"Error Message :{errorMessage} \n";

            LogMessageToFile(massage);

            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };

            filterContext.ExceptionHandled = true;

        }


    }
}