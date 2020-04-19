﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAdvance.Models
{
    public class MyErrorHandler: FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.Result = new ViewResult()
            {
                ViewName = "Customerrorpage"
            };
            filterContext.ExceptionHandled = true;
        }
    }
}