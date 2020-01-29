using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class NotFoundException : ApplicationException //Exceção personalizada
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
