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

        //List<ResourceType> resource;

    }
}
