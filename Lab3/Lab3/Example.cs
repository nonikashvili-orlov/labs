using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class CompositionRoot
    {
        private static IKernel _ninjectKernel;

        public static void Wire(INinjectModule module)
        {
            _ninjectKernel = new StandardKernel(module);
        }

        public static T Resolve<T>()
        {
            return _ninjectKernel.Get<T>();
        }
    }
}
