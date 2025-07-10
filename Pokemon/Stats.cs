public class Stats
{
    public int PV { get; set; }
    public int PVMax { get; set; }
    public int Attaque { get; set; }
    public int Defense { get; set; }
    public int Vitesse { get; set; }
    public int AttaqueSpe { get; set; }
    public int DefenseSpe { get; set; }

    public Stats(int pv, int atk, int def, int vit, int atkSpe, int defSpe)
    {
        PV = pv;
        PVMax = pv;
        Attaque = atk;
        Defense = def;
        Vitesse = vit;
        AttaqueSpe = atkSpe;
        DefenseSpe = defSpe;
    }

    /*public override string ToString()
    {
        return $"{Nom} ({Puissance} | {nbAttaques})";
    }*/
}