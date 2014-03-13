using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UG_Object_Structure
{
    class shipStation : MobileObject
    {
        //List<shipEngine> engine = null;
        //methods to add and remove engines
        //cruseDrive cruzeDrive = null;
        //jumpDrive jumpDrive
        Boolean stationMode = false;



        public shipStation(int baseMass)//, shipEngine> engine)
        {
            setMass(baseMass);
            //engine = new List<shipEngine>

        }
    }
}
