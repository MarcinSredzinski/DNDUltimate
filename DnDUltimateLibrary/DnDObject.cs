using System;
using System.Collections.Generic;
using System.Text;

namespace DnDUltimateLibrary
{
    public class DnDObject : IDnDObject
    {
        public ArmorClass AC { get; }
        public HitPoints HP { get; }
        public PhysicalProperties PhysicalProperties { get; }
        public Resistance Resistance { get; }

        public DnDObject(ArmorClass ac, HitPoints hp, PhysicalProperties physicalProperties, Resistance resistance)
        {
            AC = ac;
            HP = hp;
            PhysicalProperties = physicalProperties;
            Resistance = resistance;
        }
    }
}
