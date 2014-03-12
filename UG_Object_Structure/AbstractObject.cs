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
        private int power = 0;
        private int maxSpeed = 0;

        public void calculateMass()
        {
            //get mass from all objects attached
            //mass += mount.getParrent().getMass()

        }

        public int getMass()
        {
            return mass;
        }

        public int getPower()
        {
            return power;
        }

        public int getSpeed()
        {
            return maxSpeed;
        }

        public void massDelta(int delta)
        {
            mass += delta;
        }

        public void powerDelta(int delta)
        {
            power += delta;
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
