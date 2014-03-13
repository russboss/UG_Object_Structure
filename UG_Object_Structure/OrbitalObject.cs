using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UG_Object_Structure
{
    class OrbitalObject : AbstractObject
    {
        double gravity = 9.8;
        double spinSpeed = 1; //research into what units this should be

        OrbitalObject parent = null;
        List<OrbitalObject> child;

        public OrbitalObject(OrbitalObject newParent, int mass)
        {
            parent = newParent;
            setMass(mass);
            child = new List<OrbitalObject>();
        }
        //List<ResourceType> resource;
        override public void calculateMass()
        {
            //mass = size*density
        }

        public OrbitalObject getParent(){
            return parent;
        }
        public void setParent(OrbitalObject newParent){
            parent = newParent;
        }

        public void addChild(OrbitalObject newChild)
        {
            child.Add(newChild);
        }


    }
}
