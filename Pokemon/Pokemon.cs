using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Pokemon
    {
        public string Nom { get; set; }

        public Stats Statistiques { get; set; }

        public string Type { get; set; }

        public List<Attaque> Attaques { get; set; }

        public string ImageAtk { get; set; }
        public string ImageDef { get; set; }
        
        public Pokemon(string nom, Stats stats, string type, List <Attaque> atk, string imageAtk, string imageDef)
        {
            Nom = nom;
            Statistiques = stats;
            Type = type;
            Attaques = atk;
            ImageAtk = imageAtk;
            ImageDef = imageDef;
        }

        public override string ToString()
        {
            return Nom;
        }

        public void Attaquer(Pokemon cible, Attaque atk, Form1 form)
        {
            int degats = DamageType(atk, cible.Type);
            form.Message($"{Nom} attaque {cible.Nom} avec {degats} points d'attaque !, Type Atk = {atk.Type}, Type def = {cible.Type}", Color.Green);
            if (degats < 1) degats = 1;
            cible.Statistiques.PV -= degats;
            //cible.nbAttaque -= 1;

            if(cible.Statistiques.PV < 0) cible.Statistiques.PV = 0;
        }

        public static int DamageType(Attaque atk, string typeDef)
        {
            if (atk.Type == "Normal")
            {
                if (typeDef == "Roche" || typeDef == "Acier")
                    return atk.Puissance / 2;

                if (typeDef == "Spectre")
                    return 0;
            }

            if (atk.Type == "Feu")
            {
                if (typeDef == "Feu" || typeDef == "Eau" || typeDef == "Roche" || typeDef == "Dragon")
                    return atk.Puissance / 2;

                if (typeDef == "Plante" || typeDef == "Glace" || typeDef == "Insecte" || typeDef == "Acier")
                    return atk.Puissance * 2;
            }

            if (atk.Type == "Eau")
            {
                if (typeDef == "Feu" || typeDef == "Sol" || typeDef == "Roche")
                    return atk.Puissance * 2;

                if (typeDef == "Eau" || typeDef == "Plante" || typeDef == "Dragon")
                    return atk.Puissance / 2;
            }

            if (atk.Type == "Plante")
            {
                if (typeDef == "Eau" || typeDef == "Sol" || typeDef == "Roche")
                    return atk.Puissance * 2;

                if (typeDef == "Feu" || typeDef == "Plante" || typeDef == "Poison" || typeDef == "Vol" || typeDef == "Insecte" || typeDef == "Dragon" || typeDef == "Acier")
                    return atk.Puissance / 2;
            }

            if (atk.Type == "Électrique")
            {
                if (typeDef == "Eau" || typeDef == "Vol")
                    return atk.Puissance * 2;

                if (typeDef == "Électrique" || typeDef == "Plante" || typeDef == "Dragon")
                    return atk.Puissance / 2;

                if (typeDef == "Sol")
                    return 0;
            }

            if (atk.Type == "Glace")
            {
                if (typeDef == "Plante" || typeDef == "Sol" || typeDef == "Vol" || typeDef == "Dragon")
                    return atk.Puissance * 2;

                if (typeDef == "Feu" || typeDef == "Eau" || typeDef == "Glace" || typeDef == "Acier")
                    return atk.Puissance / 2;
            }

            if (atk.Type == "Combat")
            {
                if (typeDef == "Normal" || typeDef == "Glace" || typeDef == "Roche" || typeDef == "Ténèbres" || typeDef == "Acier")
                    return atk.Puissance * 2;

                if (typeDef == "Poison" || typeDef == "Vol" || typeDef == "Psy" || typeDef == "Insecte" || typeDef == "Fée")
                    return atk.Puissance / 2;

                if (typeDef == "Spectre")
                    return 0;
            }

            if (atk.Type == "Ténèbres")
            {
                if (typeDef == "Psy" || typeDef == "Spectre")
                    return atk.Puissance * 2;

                if (typeDef == "Combat" || typeDef == "Ténèbres" || typeDef == "Fée")
                    return atk.Puissance / 2;
            }

            if (atk.Type == "Psy")
            {
                if (typeDef == "Combat" || typeDef == "Poison")
                    return atk.Puissance * 2;

                if (typeDef == "Psy" || typeDef == "Acier")
                    return atk.Puissance / 2;

                if (typeDef == "Ténèbres")
                    return 0;
            }

            if (atk.Type == "Sol")
            {
                if (typeDef == "Feu" || typeDef == "Électrique" || typeDef == "Poison" || typeDef == "Roche" || typeDef == "Acier")
                    return atk.Puissance * 2;

                if (typeDef == "Plante" || typeDef == "Insecte")
                    return atk.Puissance / 2;

                if (typeDef == "Vol")
                    return 0;
            }

            if (atk.Type == "Vol")
            {
                if (typeDef == "Plante" || typeDef == "Combat" || typeDef == "Insecte")
                    return atk.Puissance * 2;

                if (typeDef == "Électrique" || typeDef == "Roche" || typeDef == "Acier")
                    return atk.Puissance / 2;
            }

            if (atk.Type == "Spectre")
            {
                if (typeDef == "Spectre" || typeDef == "Psy")
                    return atk.Puissance * 2;

                if (typeDef == "Ténèbres")
                    return atk.Puissance / 2;

                if (typeDef == "Normal")
                    return 0;
            }

            if (atk.Type == "Dragon")
            {
                if (typeDef == "Dragon")
                    return atk.Puissance * 2;

                if (typeDef == "Acier")
                    return atk.Puissance / 2;

                if (typeDef == "Fée")
                    return 0;
            }

            if (atk.Type == "Fée")
            {
                if (typeDef == "Combat" || typeDef == "Dragon" || typeDef == "Ténèbres")
                    return atk.Puissance * 2;

                if (typeDef == "Feu" || typeDef == "Poison" || typeDef == "Acier")
                    return atk.Puissance / 2;
            }

            if (atk.Type == "Poison")
            {
                if (typeDef == "Plante" || typeDef == "Fée")
                    return atk.Puissance * 2;

                if (typeDef == "Poison" || typeDef == "Sol" || typeDef == "Roche" || typeDef == "Spectre")
                    return atk.Puissance / 2;

                if (typeDef == "Acier")
                    return 0;
            }

            if (atk.Type == "Insecte")
            {
                if (typeDef == "Plante" || typeDef == "Psy" || typeDef == "Ténèbres")
                    return atk.Puissance * 2;

                if (typeDef == "Feu" || typeDef == "Combat" || typeDef == "Poison" || typeDef == "Vol" || typeDef == "Spectre" || typeDef == "Acier" || typeDef == "Fée")
                    return atk.Puissance / 2;
            }

            if (atk.Type == "Acier")
            {
                if (typeDef == "Glace" || typeDef == "Roche" || typeDef == "Fée")
                    return atk.Puissance * 2;

                if (typeDef == "Feu" || typeDef == "Eau" || typeDef == "Électrique" || typeDef == "Acier")
                    return atk.Puissance / 2;
            }

            // Aucun effet spécial : dégâts normaux
            return atk.Puissance;
        }
        
        public bool estKo()
        {
            return Statistiques.PV <= 0;
        }
    }
}
