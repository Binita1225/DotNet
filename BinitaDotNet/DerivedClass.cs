using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinitaDotNet
{
    public class DerivedClass:BaseClass
    {
        public DerivedClass(string message) : base(message)
        {
        }
   
        public override string Method1()
        {
            return "It is derived Method1\n message:"+message;
        }
    }
}
