using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UG_Object_Structure
{
    class OrbitalObject : AbstractObject
    {
        private double gravity = 9.8;
        private double spinSpeed = 1; //research into what units this should be

        private OrbitalObject parent = null;
        private List<OrbitalObject> child;
        
        //List<ResourceType> resource;


        void addchild(OrbitalObject newChild)
        {
            child.Add(newChild);
        }
        List<OrbitalObject> getChildList()
        {
            return child;
        }
        OrbitalObject getChildByName(String searchName)
        {
            //return child.;
        }

        void setParent(OrbitalObject newParent)
        {
            parent = newParent;
        }
        OrbitalObject getParent()
        {
            return parent;
        }
        void setGravity(double newGravity){
            gravity = newGravity;
        }
        double getGravity()
        {
            return gravity;
        }
        void setSpinSpeed(double newSpin)
        {
            spinSpeed = newSpin;
        }
        double getSpinSpeed()
        {
            return spinSpeed;
        }
        


    }
}
