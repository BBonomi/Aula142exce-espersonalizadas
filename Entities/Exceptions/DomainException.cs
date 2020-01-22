using System;
using System.Collections.Generic;
using System.Text;

namespace Aula142exceçõespersonalizadas.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}