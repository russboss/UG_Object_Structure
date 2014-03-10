using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UG_Object_Structure
{
    abstract class AbstractMount
    {
        MobileObject parent = null;
        AbstractMount link = null;
        //position data ??specific for local location ??
        //rotation data ??specific for mount or standard ??
        
        //method for return linked
        public MobileObject getParent()
        {
            return parent;
        }
        public void setParent(MobileObject newParent)
        {
            this.parent = newParent;
        }

        public void attach(AbstractMount linkNew){
            //procedure to link this mount to the paired mount
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

        public AbstractMount getLink()
        {
            return link;
        }

        public void updateMass(Boolean attach)
        {
            int deltaMass = ( this.getLink().getParent() ).getMass();
            if (attach == true)
            {
                this.getParent().incrementMass(deltaMass);
            }
            else
            {
                this.getParent().decrementMass(deltaMass);
            }
        }

        public void updatePower(Boolean attach)
        {
            if (attach == true)
            {
            }
            else
            {
            }
        }
        public void updateSpeed(Boolean attach)
        {
            if (attach == true)
            {
            }
            else
            {
            }
        }

    
    }
}
