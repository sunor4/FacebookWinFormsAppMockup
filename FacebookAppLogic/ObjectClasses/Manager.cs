using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAppLogic.ObjectClasses
{
    public abstract class Manager
    {
        private volatile object m_LockObject = new object();

        public object Lock
        {
            get { return m_LockObject; }
        }

        // ctor is bound to be protected to remove the option to create instances out of ManagersFactory
        protected Manager() 
        {
            
        }
    }
}
