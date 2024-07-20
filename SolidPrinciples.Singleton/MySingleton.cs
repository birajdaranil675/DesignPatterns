using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class MySingleton
    {
        private static MySingleton instance;

        public MySingleton()
        {
            
        }

        public static MySingleton GetInstance()
        {
            lock (instance)
            {
                if (instance == null)
                {
                    instance = new MySingleton();
                }
            }

            return instance;
        }
    }
}
