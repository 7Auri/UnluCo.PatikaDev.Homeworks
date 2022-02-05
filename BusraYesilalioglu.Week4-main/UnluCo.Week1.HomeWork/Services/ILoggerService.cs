using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using UnluCo.Week1.HomeWork.MyIdentity;

namespace UnluCo.Week1.HomeWork.Services
{
    public interface ILoggerService
    {
        public void Write(string message);

    }
   
}