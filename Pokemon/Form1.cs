using System.Reflection;
using System.Runtime.InteropServices;

namespace Pokemon
{


    public partial class Form1 : Form
    {
        private bool attaquesVisibles = false;
        private List<Pokemon> tousLesPokemons;

        public Form1()
        {
            InitializeComponent();
            //InitTableauAttaques();


            /*List<Pokemon> pokemonsAtk = new List<Pokemon>
            {
                new Pokemon("Pikachu", 100, 10,"�lectrique", new List<Attaque>
                {
                    new Attaque("�clair", "�lectrique", 30, 30),
                    new Attaque("Tonnerre", "�lectrique", 60, 10),
                    new Attaque("Vive-Attaque", "Normal", 30, 20)
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/pikachu.png"),

                new Pokemon("Carapuce", 100, 15, "Eau", new List<Attaque>
                {
                    new Attaque("Pistolet � O", "Eau",40, 25),
                    new Attaque("Charge", "Normal", 40, 35),
                    new Attaque("Morsure", "T�n�bres", 60, 25)
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/squirtle.png"),
            };

            //List<Pokemon> pokemonsDef = new List<Pokemon>
            {
                new Pokemon("Pikachu", 100, 10,"�lectrique", new List<Attaque>
                {
                    new Attaque("�clair", "�lectrique", 30, 30),
                    new Attaque("Tonnerre", "�lectrique", 60, 10),
                    new Attaque("Vive-Attaque", "Normal", 30, 20)
                }, "https://img.pokemondb.net/sprites/ruby-sapphire/normal/pikachu.png"),

                new Pokemon("Carapuce", 100, 15, "Eau", new List<Attaque>
                {
                    new Attaque("Pistolet � O", "Eau",40, 25),
                    new Attaque("Charge", "Normal", 40, 35),
                    new Attaque("Morsure", "T�n�bres", 60, 25)
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/normal/squirtle.png"),
            };*/

            //attaquant.DataSource = pokemonsAtk;
            //receveur.DataSource = pokemonsDef;
            InitialiserPokemons();

            //DispatcherAleatoire();

            attaquant.DisplayMember = "Nom";
            receveur.DisplayMember = "Nom";

            attaquant.SelectedIndex = 0;
            receveur.SelectedIndex = 1;

            progressBarAtk.SetState(1);
            progressBarDef.SetState(1);
        }

        private void InitialiserPokemons()
        {
            tousLesPokemons = new List<Pokemon>
            {
                new Pokemon("Pikachu", 100, 10, "�lectrique", new List<Attaque>
                {
                    new Attaque("�clair", "�lectrique", 30, 30, Properties.Resources.electrique),
                    new Attaque("Tonnerre", "�lectrique", 60, 10, Properties.Resources.electrique),
                    new Attaque("Vive-Attaque", "Normal", 30, 20, Properties.Resources.normal),
                    new Attaque("Cage-�clair", "�lectrique", 20, 15, Properties.Resources.electrique),
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/pikachu.png", "https://img.pokemondb.net/sprites/heartgold-soulsilver/normal/pikachu.png"),

                new Pokemon("Carapuce", 100, 15, "Eau", new List<Attaque>
                {
                    new Attaque("Pistolet � O", "Eau", 40, 25, Properties.Resources.eau),
                    new Attaque("Charge", "Normal", 40, 35, Properties.Resources.normal),
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/squirtle.png", "https://img.pokemondb.net/sprites/heartgold-soulsilver/normal/squirtle.png"),

                new Pokemon("Salam�che", 100, 12, "Feu", new List<Attaque>
                {
                    new Attaque("Flamm�che", "Feu", 40, 25, Properties.Resources.feu),
                    new Attaque("Griffe", "Normal", 35, 30, Properties.Resources.normal),
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/charmander.png", "https://img.pokemondb.net/sprites/heartgold-soulsilver/normal/charmander.png"),

                new Pokemon("Bulbizarre", 150, 14, "Plante", new List<Attaque>
                {
                    new Attaque("Fouet Lianes", "Plante", 45, 20, Properties.Resources.plante),
                    new Attaque("Charge", "Normal", 35, 30, Properties.Resources.normal),
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/bulbasaur.png", "https://img.pokemondb.net/sprites/heartgold-soulsilver/normal/bulbasaur.png"),

                new Pokemon("Ronflex", 200, 20, "Normal", new List<Attaque>
                {
                    new Attaque("Gros Lourd", "Normal", 50, 15, Properties.Resources.normal),
                    new Attaque("Coud'Boue", "Sol", 40, 20, Properties.Resources.sol),
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/snorlax.png", "https://img.pokemondb.net/sprites/heartgold-soulsilver/normal/snorlax.png"),

                new Pokemon("Tadmorv", 80, 8, "Poison", new List<Attaque>
                {
                    new Attaque("D�tritus", "Poison", 30, 25, Properties.Resources.poison),
                    new Attaque("Acide", "Poison", 40, 20, Properties.Resources.poison),
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/muk.png", "https://img.pokemondb.net/sprites/heartgold-soulsilver/normal/muk.png"),

                new Pokemon("Smogo", 90, 9, "Poison", new List<Attaque>
                {
                    new Attaque("Gaz Toxik", "Poison", 35, 20, Properties.Resources.poison),
                    new Attaque("Explosion", "Normal", 100, 5, Properties.Resources.normal),
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/weezing.png", "https://img.pokemondb.net/sprites/heartgold-soulsilver/normal/weezing.png"),

                new Pokemon("Fantominus", 70, 7, "Spectre", new List<Attaque>
                {
                    new Attaque("Onde Folie", "Psy", 30, 25, Properties.Resources.psy),
                    new Attaque("Ball'Ombre", "Spectre", 40, 20, Properties.Resources.spectre),
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/gastly.png", "https://img.pokemondb.net/sprites/heartgold-soulsilver/normal/gastly.png"),
            };

            DispatcherAleatoire();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Attaque_Click(object sender, EventArgs e)
        {
            /*Pokemon Attaquant = (Pokemon)attaquant.SelectedItem;
            Pokemon Receveur = (Pokemon)receveur.SelectedItem;

            if (Attaquant == Receveur)
            {
                Message("Un Pok�mon ne peut pas s'attaquer lui m�me !");
                return;
            }

            if (Receveur == null || Attaquant == null)
            {
                Message("Veuillez selectionner un Pok�mon dans votre �quipe !");
                return;
            }

            if (Attaquant.estKo(Attaquant) == true)
            {
                Message("Votre pok�mon est k.o. !");
                progressBarAtk.Value = 0;
            }
            else
            {
                Attaquant.Attaquer(Receveur, (Attaque)listBoxAtk.SelectedItem);
                Message($"{Attaquant.Nom} attaque {Receveur.Nom} !");
                labelR.Text = $"PV : {Receveur.PV}";
                //progressBarDef.Value = Receveur.PV;
                progressBarDef.Maximum = Receveur.PVMax;
                progressBarDef.Value = Math.Max(0, Math.Min(Receveur.PV, Receveur.PVMax));

                if (progressBarDef.Value >= 50) progressBarDef.SetState(1);
                else if (progressBarDef.Value <= 50 && progressBarDef.Value >= 25) progressBarDef.SetState(3);
                else if (progressBarDef.Value <= 25) progressBarDef.SetState(2);
            }

            if (Receveur.estKo(Receveur) == true)
            {
                Message("Votre pok�mon est k.o., il ne peut donc pas attaquer !");
                progressBarDef.Value = 0;
            }
            else
            {
                if (listBoxAtk.Items.Count > 0)
                {
                    Random rnd = new Random();
                    int index = rnd.Next(listBoxDef.Items.Count);
                    listBoxDef.SelectedIndex = index;
                }
                Receveur.Attaquer(Attaquant, (Attaque)listBoxDef.SelectedItem);
                Message($"{Receveur.Nom} attaque {Attaquant.Nom} !");
                labelA.Text = $"PV : {Attaquant.PV}";
                progressBarAtk.Maximum = Attaquant.PVMax;
                progressBarAtk.Value = Math.Max(0, Math.Min(Attaquant.PV, Attaquant.PVMax));

                if (progressBarAtk.Value >= 50) progressBarAtk.SetState(1);
                else if (progressBarAtk.Value <= 50 && progressBarAtk.Value >= 25) progressBarAtk.SetState(3);
                else if (progressBarAtk.Value <= 25) progressBarAtk.SetState(2);
            }*/
            attaquesVisibles = !attaquesVisibles;
            TableauAttaques.Visible = attaquesVisibles;
        }

        private void attaquant_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pokemon Attaquant = (Pokemon)attaquant.SelectedItem;

            labelA.Text = $"PV : {Attaquant.PV}";
            //progressBarAtk.Value = Attaquant.PV;
            progressBarAtk.Maximum = Attaquant.PVMax;
            progressBarAtk.Value = Math.Min(Attaquant.PV, Attaquant.PVMax);
            if (progressBarAtk.Value >= 50) progressBarAtk.SetState(1);
            else if (progressBarAtk.Value <= 50 && progressBarAtk.Value >= 25) progressBarAtk.SetState(3);
            else if (progressBarAtk.Value <= 25) progressBarAtk.SetState(2);

            //Image
            pictureBoxAttaque.ImageLocation = Attaquant.ImageAtk;
            pictureBoxAttaque.SizeMode = PictureBoxSizeMode.Normal;

            if (Attaquant == null)
            {
                Message("Attaquant est null !", Color.Red);
                return;
            }

            if (Attaquant.Attaques == null)
            {
                Message($"Le Pok�mon s�lectionn� ({Attaquant.Nom}) a une liste d�attaques null !", Color.Red);
                return;
            }

            if (attaquant.SelectedItem is Pokemon selectedPokemon)
            {

                TableauAttaques.Controls.Clear();
                //TableauAttaques.ColumnStyles.Clear();
                //TableauAttaques.RowStyles.Clear();

                int i = 0;
                foreach (var attaque in Attaquant.Attaques)
                {
                    var panel = new Panel();
                    panel.Dock = DockStyle.Fill;

                    Button btn = new Button();
                    btn.Enabled = true;
                    btn.AutoSize = false;
                    btn.Height = 50;
                    btn.Text = $"{attaque.Nom}\n DGT: {attaque.Puissance} | PP: {attaque.nbAttaques}";
                    btn.Dock = DockStyle.Fill;
                    btn.Font = new Font("Consolas", 10, FontStyle.Bold);
                    btn.BackColor = Color.LightYellow;

                    //Mise d'une image
                    btn.Image = attaque.TypeImage;
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.TextAlign = ContentAlignment.MiddleRight;


                    btn.Click += BtnAttaque_Click;
                    btn.Tag = attaque; // Stocke l'attaque dans le tag du bouton

                    Label label = new Label();
                    label.Text = $"D�g�ts : {attaque.Puissance}, PP : {attaque.nbAttaques}";

                    panel.Controls.Add(btn);

                    TableauAttaques.Controls.Add(panel, i % 2, i / 2); // colonne, ligne
                    i += 1;
                }
                this.Controls.Add(TableauAttaques);
            }
        }

        private void ActiverBoutonsAttaque(bool actif)
        {
            foreach (Control ctrl in TableauAttaques.Controls)
            {
                if (ctrl is Panel panel)
                {
                    var btn = panel.Controls.OfType<Button>().FirstOrDefault();
                    if (btn != null)
                    {
                        btn.Enabled = actif;
                    }
                }
            }
        }


        private void BtnAttaque_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            var attaque = btn.Tag as Attaque;
            if (attaque == null) return;

            Pokemon Attaquant = (Pokemon)attaquant.SelectedItem;
            Pokemon Receveur = (Pokemon)receveur.SelectedItem;

            Message($"Attaque {attaque.Nom} s�lectionn�e !", Color.Red);

            if (attaque.nbAttaques > 0)
            {
                attaque.nbAttaques--;
                btn.Text = $"{attaque.Nom}\n DGT: {attaque.Puissance} | PP: {attaque.nbAttaques}";
            }
            else
            {
                btn.Enabled = false;
            }

            if (Attaquant == Receveur)
            {
                Message("Un Pok�mon ne peut pas s'attaquer lui m�me !", Color.Green);
                return;
            }

            if (Receveur == null || Attaquant == null)
            {
                Message("Veuillez selectionner un Pok�mon dans votre �quipe !", Color.Green);
                return;
            }

            if (Attaquant.estKo() == true)
            {
                Message("Votre pok�mon est k.o. !", Color.Red);
                progressBarAtk.Value = 0;
                ActiverBoutonsAttaque(false);
                SelectionnerPokemonDisponible(attaquant);
            }
            else
            {
                ActiverBoutonsAttaque(true);
                Attaquant.Attaquer(Receveur, attaque, this);
                Message($"{Attaquant.Nom} attaque {Receveur.Nom} !", Color.Blue);
                labelR.Text = $"PV : {Receveur.PV}";
                //progressBarDef.Value = Receveur.PV;
                progressBarDef.Maximum = Receveur.PVMax;
                progressBarDef.Value = Math.Max(0, Math.Min(Receveur.PV, Receveur.PVMax));

                if (progressBarDef.Value >= 50) progressBarDef.SetState(1);
                else if (progressBarDef.Value <= 50 && progressBarDef.Value >= 25) progressBarDef.SetState(3);
                else if (progressBarDef.Value <= 25) progressBarDef.SetState(2);
                if (Attaquant.estKo() == true)
                {
                    Message($"{Attaquant.Nom} est k.o. !", Color.Red);
                    progressBarAtk.Value = 0;
                    //attaquant.SelectedIndex = attaquant.SelectedIndex + 1;
                    SelectionnerPokemonDisponible(attaquant);
                }
            }

            if (Receveur.estKo() == true)
            {
                Message("Votre pok�mon est k.o., il ne peut donc pas attaquer !", Color.Red);
                progressBarDef.Value = 0;
                //receveur.SelectedIndex = receveur.SelectedIndex + 1;
                SelectionnerPokemonDisponible(receveur);
            }
            else
            {
                /*if (listBoxAtk.Items.Count > 0)
                {
                    Random rnd = new Random();
                    int index = rnd.Next(listBoxDef.Items.Count);
                    listBoxDef.SelectedIndex = index;
                }
                Receveur.Attaquer(Attaquant, (Attaque)listBoxDef.SelectedItem);*/
                Random rnd = new Random();
                int index = rnd.Next(Receveur.Attaques.Count);
                Attaque attaqueChoisie = Receveur.Attaques[index];
                Receveur.Attaquer(Attaquant, attaqueChoisie, this);
                Message($"{Receveur.Nom} attaque {Attaquant.Nom} avec {attaqueChoisie.Nom} !", Color.Blue);
                Message($"{Receveur.Nom} attaque {Attaquant.Nom} !", Color.Blue);
                labelA.Text = $"PV : {Attaquant.PV}";
                progressBarAtk.Maximum = Attaquant.PVMax;
                progressBarAtk.Value = Math.Max(0, Math.Min(Attaquant.PV, Attaquant.PVMax));

                if (progressBarAtk.Value >= 50) progressBarAtk.SetState(1);
                else if (progressBarAtk.Value <= 50 && progressBarAtk.Value >= 25) progressBarAtk.SetState(3);
                else if (progressBarAtk.Value <= 25) progressBarAtk.SetState(2);
                if (Attaquant.estKo() == true)
                {
                    Message($"{Attaquant.Nom} est k.o. !", Color.Red);
                    progressBarAtk.Value = 0;
                    SelectionnerPokemonDisponible(receveur);
                }
            }

        }

        public void Message(string message, Color couleur)
        {
            chatBox.SelectionStart = chatBox.TextLength;
            chatBox.SelectionColor = couleur;
            chatBox.AppendText(message + "\n");
            chatBox.SelectionColor = chatBox.ForeColor;
            chatBox.ScrollToCaret();
        }


        private void receveur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pokemon Receveur = (Pokemon)receveur.SelectedItem;

            labelR.Text = $"PV : {Receveur.PV}";
            //progressBarDef.Value = Receveur.PV;

            progressBarDef.Maximum = Receveur.PVMax;
            progressBarDef.Value = Math.Min(Receveur.PV, Receveur.PVMax);

            if (progressBarDef.Value >= 50) progressBarDef.SetState(1);
            else if (progressBarDef.Value <= 50 && progressBarDef.Value >= 25) progressBarDef.SetState(3);
            else if (progressBarDef.Value <= 25) progressBarDef.SetState(2);

            //Image
            pictureBoxDefense.ImageLocation = Receveur.ImageDef;
            pictureBoxDefense.SizeMode = PictureBoxSizeMode.CenterImage;


            if (Receveur == null)
            {
                Message("Receveur est null !", Color.Red);
                return;
            }

            if (Receveur.Attaques == null)
            {
                Message($"Le Pok�mon s�lectionn� ({Receveur.Nom}) a une liste d�attaques null !", Color.Red);
                return;
            }

        }

        private void DispatcherAleatoire()
        {
            Random rnd = new Random();

            if (tousLesPokemons == null || tousLesPokemons.Count < 4)
            {
                Message("Il faut au moins 4 Pok�mon pour r�partir les �quipes !", Color.Red);
                return;
            }

            // M�lange les Pok�mon
            var melange = tousLesPokemons.OrderBy(p => rnd.Next()).ToList();

            // S�pare en 2 �quipes
            var equipeAttaque = melange.Take(tousLesPokemons.Count / 2).ToList();
            var equipeDefense = melange.Skip(tousLesPokemons.Count / 2).Take(tousLesPokemons.Count / 2).ToList();

            // Affecte aux ComboBox
            attaquant.DataSource = equipeAttaque;
            attaquant.DisplayMember = "Nom";

            receveur.DataSource = equipeDefense;
            receveur.DisplayMember = "Nom";

            // S�lectionne le premier Pok�mon de chaque �quipe
            attaquant.SelectedIndex = 0;
            receveur.SelectedIndex = 0;
        }

        private void SelectionnerPokemonDisponible(ComboBox comboBox)
        {
            // R�cup�re tous les Pok�mon de la ComboBox qui ne sont pas KO
            var pokemonsDisponibles = comboBox.Items.Cast<Pokemon>().Where(p => p.PV > 0).ToList();

            if (pokemonsDisponibles.Count == 0)
            {
                MessageBox.Show("Tous les Pok�mon sont K.O. !");
                return;
            }

            // S�lectionne un Pok�mon al�atoire parmi ceux disponibles
            Random rnd = new Random();
            Pokemon choisi = pokemonsDisponibles[rnd.Next(pokemonsDisponibles.Count)];
            comboBox.SelectedItem = choisi;
        }

    }
}