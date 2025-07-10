
namespace Pokemon
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Quitter = new Button();
            attaquant = new ComboBox();
            receveur = new ComboBox();
            boutonAttaque = new Button();
            labelR = new Label();
            labelA = new Label();
            progressBarAtk = new ProgressBar();
            progressBarDef = new ProgressBar();
            pictureBoxAttaque = new PictureBox();
            pictureBoxDefense = new PictureBox();
            TableauAttaques = new TableLayoutPanel();
            chatBox = new RichTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAttaque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDefense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Quitter
            // 
            Quitter.Location = new Point(1363, 606);
            Quitter.Name = "Quitter";
            Quitter.Size = new Size(75, 23);
            Quitter.TabIndex = 0;
            Quitter.Text = "Quitter";
            Quitter.UseVisualStyleBackColor = true;
            Quitter.Click += Quitter_Click;
            // 
            // attaquant
            // 
            attaquant.DrawMode = DrawMode.OwnerDrawFixed;
            attaquant.DropDownStyle = ComboBoxStyle.DropDownList;
            attaquant.FormattingEnabled = true;
            attaquant.Location = new Point(28, 291);
            attaquant.Name = "attaquant";
            attaquant.Size = new Size(270, 24);
            attaquant.TabIndex = 1;
            attaquant.DrawItem += ComboBox_DrawItem;
            attaquant.SelectedIndexChanged += attaquant_SelectedIndexChanged;
            // 
            // receveur
            // 
            receveur.DrawMode = DrawMode.OwnerDrawFixed;
            receveur.DropDownStyle = ComboBoxStyle.DropDownList;
            receveur.FormattingEnabled = true;
            receveur.Location = new Point(574, 292);
            receveur.Name = "receveur";
            receveur.Size = new Size(313, 24);
            receveur.TabIndex = 2;
            receveur.DrawItem += ComboBox_DrawItem;
            receveur.SelectedIndexChanged += receveur_SelectedIndexChanged;
            // 
            // boutonAttaque
            // 
            boutonAttaque.Location = new Point(812, 562);
            boutonAttaque.Name = "boutonAttaque";
            boutonAttaque.Size = new Size(75, 23);
            boutonAttaque.TabIndex = 3;
            boutonAttaque.Text = "Attaque";
            boutonAttaque.UseVisualStyleBackColor = true;
            boutonAttaque.Click += Attaque_Click;
            // 
            // labelR
            // 
            labelR.AutoSize = true;
            labelR.Location = new Point(718, 319);
            labelR.Name = "labelR";
            labelR.Size = new Size(27, 15);
            labelR.TabIndex = 4;
            labelR.Text = "PV :";
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(147, 319);
            labelA.Name = "labelA";
            labelA.Size = new Size(27, 15);
            labelA.TabIndex = 5;
            labelA.Text = "PV :";
            // 
            // progressBarAtk
            // 
            progressBarAtk.Location = new Point(28, 263);
            progressBarAtk.Name = "progressBarAtk";
            progressBarAtk.Size = new Size(270, 23);
            progressBarAtk.TabIndex = 6;
            // 
            // progressBarDef
            // 
            progressBarDef.Location = new Point(574, 263);
            progressBarDef.Name = "progressBarDef";
            progressBarDef.Size = new Size(313, 23);
            progressBarDef.TabIndex = 7;
            // 
            // pictureBoxAttaque
            // 
            pictureBoxAttaque.Location = new Point(302, 182);
            pictureBoxAttaque.Name = "pictureBoxAttaque";
            pictureBoxAttaque.Size = new Size(92, 75);
            pictureBoxAttaque.TabIndex = 10;
            pictureBoxAttaque.TabStop = false;
            // 
            // pictureBoxDefense
            // 
            pictureBoxDefense.Location = new Point(534, 77);
            pictureBoxDefense.Name = "pictureBoxDefense";
            pictureBoxDefense.Size = new Size(95, 73);
            pictureBoxDefense.TabIndex = 11;
            pictureBoxDefense.TabStop = false;
            // 
            // TableauAttaques
            // 
            TableauAttaques.ColumnCount = 2;
            TableauAttaques.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableauAttaques.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableauAttaques.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            TableauAttaques.Location = new Point(28, 466);
            TableauAttaques.Name = "TableauAttaques";
            TableauAttaques.RowCount = 2;
            TableauAttaques.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
            TableauAttaques.RowStyles.Add(new RowStyle(SizeType.Percent, 48F));
            TableauAttaques.Size = new Size(778, 119);
            TableauAttaques.TabIndex = 12;
            // 
            // chatBox
            // 
            chatBox.Location = new Point(926, 223);
            chatBox.Name = "chatBox";
            chatBox.Size = new Size(512, 347);
            chatBox.TabIndex = 13;
            chatBox.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(223, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(485, 226);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 641);
            Controls.Add(chatBox);
            Controls.Add(TableauAttaques);
            Controls.Add(pictureBoxDefense);
            Controls.Add(pictureBoxAttaque);
            Controls.Add(progressBarDef);
            Controls.Add(progressBarAtk);
            Controls.Add(labelA);
            Controls.Add(labelR);
            Controls.Add(boutonAttaque);
            Controls.Add(receveur);
            Controls.Add(attaquant);
            Controls.Add(Quitter);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Combat Pokémon";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAttaque).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDefense).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ComboBox cb = (ComboBox)sender;
            Pokemon pkm = (Pokemon)cb.Items[e.Index];

            // Déterminer la couleur du texte selon l'état du Pokémon
            Color textColor = (pkm.Statistiques.PV <= 0) ? Color.Gray : SystemColors.ControlText;

            e.DrawBackground();
            using (SolidBrush brush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(pkm.Nom, e.Font, brush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        #endregion

        private Button Quitter;
        private ComboBox attaquant;
        private ComboBox receveur;
        private Button boutonAttaque; // renommé ici
        private Label labelR;
        private Label labelA;
        private ProgressBar progressBarAtk;
        private ProgressBar progressBarDef;
        private PictureBox pictureBoxAttaque;
        private PictureBox pictureBoxDefense;
        private TableLayoutPanel TableauAttaques;
        private RichTextBox chatBox;
        private PictureBox pictureBox1;
    }
}
