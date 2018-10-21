using System;
using System.Collections.Generic;
using System.Text;

namespace DnDUltimateLibrary.factories
{
    public class Factory
    {

        public ArmorClass CreateArmorClass()
        {
            return new ArmorClass();
        }

        public HitPoints CreateHitPoints()
        {
            return new HitPoints();
        }
        public Resistance CreateResistance()
        {
            return new Resistance();
        }
        public PhysicalProperties CreatePhysicalProperties()
        {
            return new PhysicalProperties();
        }

        public IDnDObject CreateDnDObject()
        {
            return new DnDObject(this.CreateArmorClass(), this.CreateHitPoints(), this.CreatePhysicalProperties(), this.CreateResistance());
        }
    }
}
