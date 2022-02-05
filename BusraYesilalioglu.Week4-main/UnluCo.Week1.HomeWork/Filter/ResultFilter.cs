using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;
using System.Text;
using UnluCo.Week1.HomeWork.Models;

namespace UnluCo.Week1.HomeWork.Filter
{
    public class ResultFilter : IResultFilter
    {

        public void OnResultExecuted(ResultExecutedContext context)
        {
            Log.errorDetail.Add(new ErrorDetail()
            {
               /* Action = context.RouteData.Values["action"].ToString(),
                CreationDate = DateTime.Now,*/


            });
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            var headerName = "OnResultExecuting";
            context.HttpContext.Response.Headers.Add(
            headerName, new string[] { "ResultExecutingSuccessfully" });
           
            
            
            var creationDate = "CreationDate"; // Header'da tarihi görmek için
            context.HttpContext.Response.Headers.Add(
            creationDate, new string[] { "Creation Date: " + DateTime.Now.ToString(), });

           

        }
    }
}