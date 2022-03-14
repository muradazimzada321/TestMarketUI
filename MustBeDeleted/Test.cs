using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMarketUI.MustBeDeleted
{ // Singleton Pattern
    class Test
    {
        private string MyField = null;
        public string MyProperty
        {
            get
            {
                if (MyField == null)
                    MyField = "MyField";
                return MyField;

            }

        }
        private Test()
        {

        }
        private static Test test = null;

        public static Test Create()
        {
            if (test == null)
            {
                test = new Test();

            }
            return test;
        }

    }

}
