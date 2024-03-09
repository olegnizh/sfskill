using System;
using System.Collections.Generic;
using System.Text;

namespace DataFinder.BLL
{
    public class BusinessRuleException : Exception
    {
        public BusinessRuleException(string message) : base(message) { }
    }

}
