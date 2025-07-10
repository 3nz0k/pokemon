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
                new Pokemon("Pikachu", 100, 10,"Électrique", new List<Attaque>
                {
                    new Attaque("Éclair", "Électrique", 30, 30),
                    new Attaque("Tonnerre", "Électrique", 60, 10),
                    new Attaque("Vive-Attaque", "Normal", 30, 20)
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/pikachu.png"),

                new Pokemon("Carapuce", 100, 15, "Eau", new List<Attaque>
                {
                    new Attaque("Pistolet à O", "Eau",40, 25),
                    new Attaque("Charge", "Normal", 40, 35),
                    new Attaque("Morsure", "Ténèbres", 60, 25)
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/squirtle.png"),
            };

            //List<Pokemon> pokemonsDef = new List<Pokemon>
            {
                new Pokemon("Pikachu", 100, 10,"Électrique", new List<Attaque>
                {
                    new Attaque("Éclair", "Électrique", 30, 30),
                    new Attaque("Tonnerre", "Électrique", 60, 10),
                    new Attaque("Vive-Attaque", "Normal", 30, 20)
                }, "https://img.pokemondb.net/sprites/ruby-sapphire/normal/pikachu.png"),

                new Pokemon("Carapuce", 100, 15, "Eau", new List<Attaque>
                {
                    new Attaque("Pistolet à O", "Eau",40, 25),
                    new Attaque("Charge", "Normal", 40, 35),
                    new Attaque("Morsure", "Ténèbres", 60, 25)
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
                //Pokemon(string nom, List<Stats> stats, string type, List<Attaque> atk, string imageAtk, string imageDef)
                new Pokemon("Pikachu", new Stats(35, 55, 40, 90, 50, 50), "Électrique", new List<Attaque>
                {
                    //Attaque(string nom, string type, int puissance, int nbMax, string typecap, Bitmap imgType)
                    new Attaque("Éclair", "Électrique", 30, 30, "special",Properties.Resources.electrique),
                    new Attaque("Tonnerre", "Électrique", 60, 10, "special", Properties.Resources.electrique),
                    new Attaque("Vive-Attaque", "Normal", 30, 20, "physique", Properties.Resources.normal),
                    new Attaque("Cage-Éclair", "Électrique", 20, 15, "status", Properties.Resources.electrique),
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/pikachu.png", "https://img.pokemondb.net/sprites/heartgold-soulsilver/normal/pikachu.png"),

                new Pokemon("Carapuce", new Stats(44, 48, 65, 43, 50, 64), "Eau", new List<Attaque>
                {
                    new Attaque("Pistolet à O", "Eau", 40, 25, "special", Properties.Resources.eau),
                    new Attaque("Charge", "Normal", 40, 35, "physique", Properties.Resources.normal),
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/squirtle.png", "https://img.pokemondb.net/sprites/heartgold-soulsilver/normal/squirtle.png"),

                new Pokemon("Salamèche", new Stats(39, 52, 43, 65, 60, 50), "Feu", new List<Attaque>
                {
                    new Attaque("Flammèche", "Feu", 40, 25, "special", Properties.Resources.feu),
                    new Attaque("Griffe", "Normal", 35, 30, "physique", Properties.Resources.normal),
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/charmander.png", "https://img.pokemondb.net/sprites/heartgold-soulsilver/normal/charmander.png"),

                new Pokemon("Bulbizarre", new Stats(45, 49, 49, 45, 65, 65), "Plante", new List<Attaque>
                {
                    new Attaque("Fouet Lianes", "Plante", 45, 20, "special", Properties.Resources.plante),
                    new Attaque("Charge", "Normal", 35, 30, "physique", Properties.Resources.normal),
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/bulbasaur.png", "https://img.pokemondb.net/sprites/heartgold-soulsilver/normal/bulbasaur.png"),

                new Pokemon("Ronflex", new Stats(160, 110, 65, 30, 65, 110), "Normal", new List<Attaque>
                {
                    new Attaque("Giga Impact", "Normal", 150, 5, "physique", Properties.Resources.normal),
                    new Attaque("Coud'Boue", "Sol", 40, 20, "special", Properties.Resources.sol),
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/snorlax.png", "https://img.pokemondb.net/sprites/heartgold-soulsilver/normal/snorlax.png"),

                new Pokemon("Tadmorv", new Stats(80, 80, 50, 25, 40, 50), "Poison", new List<Attaque>
                {
                    new Attaque("Détritus", "Poison", 65, 20, "special", Properties.Resources.poison),
                    new Attaque("Écras'Face", "Normal", 40, 35, "physique", Properties.Resources.poison),
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/muk.png", "https://img.pokemondb.net/sprites/heartgold-soulsilver/normal/muk.png"),

                new Pokemon("Smogo", new Stats(65, 90, 120, 40, 85, 70), "Poison", new List<Attaque>
                {
                    new Attaque("Gaz Toxik", "Poison", 35, 20, "status", Properties.Resources.poison),
                    new Attaque("Explosion", "Normal", 250, 5, "physique", Properties.Resources.normal),
                }, "https://img.pokemondb.net/sprites/heartgold-soulsilver/back-normal/weezing.png", "https://img.pokemondb.net/sprites/heartgold-soulsilver/normal/weezing.png"),

                new Pokemon("Fantominus", new Stats(30, 35, 30, 80, 100, 35), "Spectre", new List<Attaque>
                {
                    new Attaque("Léchouille", "Spectre", 30, 30, "physique", Properties.Resources.psy),
                    new Attaque("Ball'Ombre", "Spectre", 60, 10, "special", Properties.Resources.spectre),
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
                Message("Un Pokémon ne peut pas s'attaquer lui même !");
                return;
            }

            if (Receveur == null || Attaquant == null)
            {
                Message("Veuillez selectionner un Pokémon dans votre équipe !");
                return;
            }

            if (Attaquant.estKo(Attaquant) == true)
            {
                Message("Votre pokémon est k.o. !");
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
                Message("Votre pokémon est k.o., il ne peut donc pas attaquer !");
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

            labelA.Text = $"PV : {Attaquant.Statistiques.PV}";
            //progressBarAtk.Value = Attaquant.PV;
            progressBarAtk.Maximum = Attaquant.Statistiques.PVMax;
            progressBarAtk.Value = Math.Min(Attaquant.Statistiques.PV, Attaquant.Statistiques.PVMax);
            if (progressBarAtk.Value >= 50) progressBarAtk.SetState(1);
            else if (progressBarAtk.Value <= 50 && progressBarAtk.Value >= 25) progressBarAtk.SetState(3);
            else if (progressBarAtk.Value <= 25) progressBarAtk.SetState(2);

            //Image
            pictureBoxAttaque.BackColor = Color.Transparent;
            pictureBoxAttaque.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxAttaque.ImageLocation = Attaquant.ImageAtk;

            if (Attaquant == null)
            {
                Message("Attaquant est null !", Color.Red);
                return;
            }

            if (Attaquant.Attaques == null)
            {
                Message($"Le Pokémon sélectionné ({Attaquant.Nom}) a une liste d’attaques null !", Color.Red);
                return;
            }

            if (attaquant.SelectedItem is Pokemon selectedPokemon)
            {
                TableauAttaques.Controls.Clear();
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
                    //btn.Text = $"{attaque.Nom}";
                    btn.Dock = DockStyle.Fill;
                    btn.Font = new Font("Consolas", 10, FontStyle.Bold);
                    if (attaque.TypeCap == "physique")
                        btn.BackColor = Color.LightPink;
                    else if (attaque.TypeCap == "special")
                        btn.BackColor = Color.LightBlue;
                    else if (attaque.TypeCap == "status")
                        btn.BackColor = Color.LightYellow;

                    //Mise d'une image
                    btn.Image = attaque.TypeImage;
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.TextAlign = ContentAlignment.MiddleRight;

                    //Label label = new Label();
                    //label.Text = $"Dégâts : {attaque.Puissance}, PP : {attaque.nbAttaques}";

                    btn.Click += BtnAttaque_Click;
                    btn.Tag = attaque; // Stocke l'attaque dans le tag du bouton

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

            Message($"Attaque {attaque.Nom} sélectionnée !", Color.Red);

            if (attaque.nbAttaques > 0)
            {
                attaque.nbAttaques--;
                btn.Text = $"{attaque.Nom}\n DGT: {attaque.Puissance} | PP: {attaque.nbAttaques}";
            }
            else
            {
                btn.Enabled = false;
            }

            /*if (Attaquant == Receveur)
            {
                Message("Un Pokémon ne peut pas s'attaquer lui même !", Color.Green);
                return;
            }*/

            if (Receveur == null || Attaquant == null)
            {
                Message("Veuillez selectionner un Pokémon dans votre équipe !", Color.Green);
                return;
            }

            if (Attaquant.estKo() == true)
            {
                Message("Votre pokémon est k.o. !", Color.Red);
                progressBarAtk.Value = 0;
                ActiverBoutonsAttaque(false);
                SelectionnerPokemonDisponible(attaquant);
            }
            else
            {
                ActiverBoutonsAttaque(true);
                Attaquant.Attaquer(Receveur, attaque, this);
                Message($"{Attaquant.Nom} attaque {Receveur.Nom} !", Color.Blue);
                labelR.Text = $"PV : {Receveur.Statistiques.PV}";
                //progressBarDef.Value = Receveur.PV;
                progressBarDef.Maximum = Receveur.Statistiques.PVMax;
                progressBarDef.Value = Math.Max(0, Math.Min(Receveur.Statistiques.PV, Receveur.Statistiques.PVMax));

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
                Message("Votre pokémon est k.o., il ne peut donc pas attaquer !", Color.Red);
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
                labelA.Text = $"PV : {Attaquant.Statistiques.PV}";
                progressBarAtk.Maximum = Attaquant.Statistiques.PVMax;
                progressBarAtk.Value = Math.Max(0, Math.Min(Attaquant.Statistiques.PV, Attaquant.Statistiques.PVMax));

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

            labelR.Text = $"PV : {Receveur.Statistiques.PV}";
            //progressBarDef.Value = Receveur.PV;

            progressBarDef.Maximum = Receveur.Statistiques.PVMax;
            progressBarDef.Value = Math.Min(Receveur.Statistiques.PV, Receveur.Statistiques.PVMax);

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
                Message($"Le Pokémon sélectionné ({Receveur.Nom}) a une liste d’attaques null !", Color.Red);
                return;
            }

        }

        private void DispatcherAleatoire()
        {
            Random rnd = new Random();

            if (tousLesPokemons == null || tousLesPokemons.Count < 4)
            {
                Message("Il faut au moins 4 Pokémon pour répartir les équipes !", Color.Red);
                return;
            }

            // Mélange les Pokémon
            var melange = tousLesPokemons.OrderBy(p => rnd.Next()).ToList();

            // Sépare en 2 équipes
            var equipeAttaque = melange.Take(tousLesPokemons.Count / 2).ToList();
            var equipeDefense = melange.Skip(tousLesPokemons.Count / 2).Take(tousLesPokemons.Count / 2).ToList();

            // Affecte aux ComboBox
            attaquant.DataSource = equipeAttaque;
            attaquant.DisplayMember = "Nom";

            receveur.DataSource = equipeDefense;
            receveur.DisplayMember = "Nom";

            // Sélectionne le premier Pokémon de chaque équipe
            attaquant.SelectedIndex = 0;
            receveur.SelectedIndex = 0;
        }

        private void SelectionnerPokemonDisponible(ComboBox comboBox)
        {
            // Récupère tous les Pokémon de la ComboBox qui ne sont pas KO
            var pokemonsDisponibles = comboBox.Items.Cast<Pokemon>().Where(p => p.Statistiques.PV > 0).ToList();

            if (pokemonsDisponibles.Count == 0)
            {
                MessageBox.Show("Tous les Pokémon sont K.O. !");
                return;
            }

            // Sélectionne un Pokémon aléatoire parmi ceux disponibles
            Random rnd = new Random();
            Pokemon choisi = pokemonsDisponibles[rnd.Next(pokemonsDisponibles.Count)];
            comboBox.SelectedItem = choisi;
        }

    }
}