using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinitaDotNet
{
     public class BaseClass
    {
        public string message;
        public BaseClass(string message) 
        {
            this.message= message;
        }
        public virtual string Method1()
        {
            return "It is a Bass Class method";
        }
        public virtual string Method2()
        {
            return "It is a bass class method 2 ";
        }
    }
}
