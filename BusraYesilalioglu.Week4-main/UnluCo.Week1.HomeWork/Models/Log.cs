using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.Week1.HomeWork.Models
{
    
    public class Log
    {
        private static List<ErrorDetail>  _errorDetail = new List<ErrorDetail>();
        public static List<ErrorDetail> errorDetail
        {
            get { return _errorDetail; }
        }
    }
}
