﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UG_Object_Structure
{
    abstract class MobileObject : AbstractObject
    {
        int cargoSpace = 0;
        int speed = 0;
        int turnSpeed = 0;
        List<dockMount> dockMount = null;
        List<int> weaponMount = null;
        List<int> sensorMount = null;
        List<int> shieldMount = null;
        List<int> externalMount = null;
        List<int> equipment = null;

        //methods for retreiving mounts
        //methods for adding/removing a reference from a mount

        //should be called when a piece is added or removed

        public void calculateMass()
        {
            //AbstractMount mount = null;
            List<AbstractMount>.Enumerator mount;
            mount = weaponMount.GetEnumerator();
            addMasses(mount);
            mount = sensorMount.GetEnumerator();
            addMasses(mount);
            mount = shieldMount.GetEnumerator();
            addMasses(mount);
            mount = externalMount.GetEnumerator();
            addMasses(mount);
            mount = equipment.GetEnumerator();
            addMasses(mount);

        }

        private void addMasses(IEnumerator<AbstractMount> mount)
        {
            while (mount.MoveNext())
            {
                incrementMass(mount.Current.getParent().getMass());
            }
        }

    }
}