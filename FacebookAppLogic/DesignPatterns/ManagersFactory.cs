using FacebookAppLogic.ObjectClasses;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace FacebookAppLogic.DesignPatterns
{
    public static class ManagersFactory
    {
        private static volatile Dictionary<Type, Manager> s_ManagerInstancesCollection = new Dictionary<Type, Manager>();
        private static volatile object s_LockObject = new object();

        public static T GetInstance<T>() 
            where T : Manager
        {
            lock (s_LockObject)
            {
                bool doesInstanceExist = s_ManagerInstancesCollection.TryGetValue(typeof(T), out Manager instance);
                if (!doesInstanceExist)
                {
                    instance = (T)createInstanceOfType(typeof(T));
                }

                return (T)instance;
            }
        }

        private static Manager createInstanceOfType(Type s_InstanceType)
        {
            ConstructorInfo constructor = null;

            try
            {
                constructor = s_InstanceType.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null);
            }
            catch (Exception exception)
            {
                throw new Exception(null, exception);
            }
            if (constructor == null || constructor.IsAssembly)
            {
                throw new Exception(string.Format("A private or protected constructor is missing for '{0}'.", s_InstanceType.Name));
            }

            Manager instance = (Manager)constructor.Invoke(null);
            addInstanceToCollection(s_InstanceType, instance);
            return instance;
        }

        private static void addInstanceToCollection(Type s_InstanceType, Manager s_Instance)
        {
            s_ManagerInstancesCollection.Add(s_InstanceType, s_Instance);
        }
    }
}
