using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UG_Object_Structure
{
    abstract class AbstractObject
    {
        private PostitionData position = null;
        private RotationData rotation = null;
        
        private int mass = 0;

        public void calculateMass()
        {
            //get mass from all objects attached
            //mass += mount.getParrent().getMass()

        }

        public int getMass()
        {
            return mass;
        }

        public void incrementMass(int additionalMass)
        {
            mass += additionalMass;
        }

        public PostitionData getPosition()
        {
            return position;
        }

        public RotationData getRotation()
        {
            return rotation;
        }




    }
}
