using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UG_Object_Structure
{
    abstract class AbstractMount
    {
        MobileObject parent;
        //position data ??specific for local location ??
        //rotation data ??specific for mount or standard ??
        //link and unlink methods
        
        //method for return linked
        public MobileObject getParent()
        {
            return parent;
        }
    }
}
