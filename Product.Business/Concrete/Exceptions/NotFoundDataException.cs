using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Business.Concrete.Exceptions
{
    public class NotFoundDataException : BaseException
    {
        public NotFoundDataException() : base("Not Found.Please you try again.")
        {
        }
    }
}
