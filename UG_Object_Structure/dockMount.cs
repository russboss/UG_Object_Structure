using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UG_Object_Structure
{
    class dockMount : AbstractMount
    {
        dockMount link;

        public dockMount getLink()
        {
            return link;
        }




        override public void attachSequence()
        {
        }

        override public void detachSequence()
        {
        }


        /*
        public void attach(dockMount linkNew)
        {
            link = linkNew;
            link.setLink(this);
            MobileObject a = this.getLink().getParent();
            int b = a.getMass();
            this.getParent().incrementMass(b);
        }

        public void detach()
        {
            link = null;

            MobileObject a = this.getLink().getParent();
            int b = a.getMass();
            this.getParent().decrementMass(b);
        }
        */

    }
}
