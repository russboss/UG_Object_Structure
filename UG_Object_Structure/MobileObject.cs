using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UG_Object_Structure
{
    abstract class MobileObject : AbstractObject
    {
        int cargoSpace = 0;
        List<dockMount> dockMount;
        List<int> weaponMount;
        List<int> sensorMount;
        List<int> shieldMount;
        List<int> externalMount; 
        List<int> equipment;

        //methods for retreiving mounts
        //methods for adding/removing a reference from a mount

    }
}
