using System;
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
        List<AbstractMount> weaponMount = null;
        List<AbstractMount> sensorMount = null;
        List<AbstractMount> shieldMount = null;
        List<AbstractMount> externalMount = null;
        List<AbstractMount> equipment = null;

        //methods for retreiving mounts
        //methods for adding/removing a reference from a mount

        //should be called when a piece is added or removed


        private int updateMass(AbstractMount lastMount)
        {
            IEnumerator<AbstractMount> mount = dockMount.GetEnumerator();
            int mass = getMass();

            while (mount.MoveNext())
            {
                if (lastMount != mount.Current && mount.Current.getLink() != null)
                {
                    mass += mount.Current.getParent().updateMass(mount.Current);
                }
            }
            return mass;
        }

        public void addDockMount(dockMount newMount)
        {
            dockMount.Add(newMount);
        }
        public void addWeaponMount(AbstractMount newMount)
        {
            weaponMount.Add(newMount);
        }
        public void addSensorMount(AbstractMount newMount)
        {
            sensorMount.Add(newMount);
        }
        public void addShieldMount(AbstractMount newMount)
        {
            shieldMount.Add(newMount);
        }
        public void addExternalMount(AbstractMount newMount)
        {
            externalMount.Add(newMount);
        }
        public void addEquipment(AbstractMount newMount)
        {
            equipment.Add(newMount);
        }
    }
}
