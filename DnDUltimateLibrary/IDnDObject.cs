namespace DnDUltimateLibrary
{
    public interface IDnDObject
    {
        ArmorClass AC { get; }
        HitPoints HP { get; }
        PhysicalProperties PhysicalProperties { get; }
        Resistance Resistance { get; }
    }
}