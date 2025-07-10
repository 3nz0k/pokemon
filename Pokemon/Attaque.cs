public class Attaque
{
    public string Nom { get; set; }
    public string Type { get; set; }
    public int Puissance { get; set; }
    public int nbAttaques { get; set; }
    public string TypeCap { get; set; }
    public System.Drawing.Bitmap TypeImage { get; set; }

    public Attaque(string nom, string type, int puissance, int nbMax, string typecap, System.Drawing.Bitmap imgType)
    {
        Nom = nom;
        Type = type;
        Puissance = puissance;
        nbAttaques = nbMax;
        TypeCap = typecap;
        TypeImage = imgType;
    }

    public override string ToString()
    {
        return $"{Nom} ({Puissance} | {nbAttaques} | {Type})";
    }
}