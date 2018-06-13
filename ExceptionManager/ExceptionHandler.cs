using ExceptionManager.Abstractions.Interfaces;
using System;

namespace ExceptionManager
{
    public class ExceptionHandler : IExceptionHandler
    {
        public ExceptionHandler()
        {

        }

        public void SaveError()
        {
            throw new System.NotImplementedException();
        }
    }
}
