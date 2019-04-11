using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CustomerPortal.CommonUtils.Shared
{
    public abstract class Presenter<TView> : IDisposable
    {
        protected Presenter()
        { }

        public TView View { get; set; }

        public virtual void OnViewInitialized()
        { }

        public virtual void OnViewLoaded()
        { }

        public virtual void Dispose()
        { }
    }
}
