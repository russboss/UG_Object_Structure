using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UG_Object_Structure
{
    abstract class AbstractObject
    {
        private PostitionData position;
        private RotationData rotation;
        
        private int mass;

        //should be called when a piece is added or removed
        public void calculateMass()
        {
            //get mass from all objects attached
            mass = 10;
        }

        public int getMass()
        {
            return mass;
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
