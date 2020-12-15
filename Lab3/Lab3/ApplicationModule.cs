using Nest;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>));
        }
    }
}
