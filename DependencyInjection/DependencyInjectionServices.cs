using ExceptionManager.Abstractions.Interfaces;
using LocalizationManager.Abstractions.Interfaces;
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;

namespace DependencyInjection.Interfaces
{
    public class DependencyInjectionServices : IDisposable
    {
        private readonly IExceptionHandler exceptionService;
        private readonly ILocalizationHandler localizationService;
        private bool disposed = false;
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public DependencyInjectionServices(IExceptionHandler exceptionHandler, ILocalizationHandler localizationHandler)
        {
            this.exceptionService = exceptionHandler;
            this.localizationService = localizationHandler;
        }

        public IExceptionHandler ExceptionService
        {
            get
            {
                return this.exceptionService;
            }
        }

        public ILocalizationHandler LocalizationService
        {
            get
            {
                return this.localizationService;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
                return;
            if (disposing)
                handle.Dispose();
            this.disposed = true;
        }
    }
}
