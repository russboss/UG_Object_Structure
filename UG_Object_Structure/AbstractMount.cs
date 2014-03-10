using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UG_Object_Structure
{
    abstract class AbstractMount
    {
        MobileObject parent;
        AbstractMount link= null;
        //position data ??specific for local location ??
        //rotation data ??specific for mount or standard ??
        //link and unlink methods
        
        //method for return linked
        public MobileObject getParent()
        {
            return parent;
        }

        public void attach(AbstractMount linkNew){
            link = linkNew;
            link.setLink(this);

            this.attachSequence();
        }

        public void detach(AbstractMount linkNew)
        {
            //set linked AbstractMount.link to null
            link.setLink(null);
            link = null;


            this.detachSequence();
        }


        abstract public void attachSequence();

        abstract public void detachSequence();

        private void setLink(AbstractMount linkNew)
        {
            link = linkNew;
        }

    }
}
