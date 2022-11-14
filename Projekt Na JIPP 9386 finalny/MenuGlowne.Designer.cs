namespace Projekt_Na_JIPP_9386_finalny
{
    partial class MenuForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tytuł = new System.Windows.Forms.Label();
            this.przycisktworzeniapostaci = new System.Windows.Forms.Button();
            this.buttonopispostaci = new System.Windows.Forms.Button();
            this.buttonpojedynek = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Zamykanie = new MojaKontrolka.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tytuł
            // 
            this.Tytuł.AutoSize = true;
            this.Tytuł.Location = new System.Drawing.Point(21, 24);
            this.Tytuł.Name = "Tytuł";
            this.Tytuł.Size = new System.Drawing.Size(57, 13);
            this.Tytuł.TabIndex = 1;
            this.Tytuł.Text = "9386 RPG";
            // 
            // przycisktworzeniapostaci
            // 
            this.przycisktworzeniapostaci.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.przycisktworzeniapostaci.Location = new System.Drawing.Point(172, 372);
            this.przycisktworzeniapostaci.Name = "przycisktworzeniapostaci";
            this.przycisktworzeniapostaci.Size = new System.Drawing.Size(114, 49);
            this.przycisktworzeniapostaci.TabIndex = 2;
            this.przycisktworzeniapostaci.Text = "Stwórz Postać";
            this.przycisktworzeniapostaci.UseVisualStyleBackColor = true;
            this.przycisktworzeniapostaci.Click += new System.EventHandler(this.przycisktworzeniapostaci_Click);
            // 
            // buttonopispostaci
            // 
            this.buttonopispostaci.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonopispostaci.Location = new System.Drawing.Point(303, 372);
            this.buttonopispostaci.Name = "buttonopispostaci";
            this.buttonopispostaci.Size = new System.Drawing.Size(114, 49);
            this.buttonopispostaci.TabIndex = 3;
            this.buttonopispostaci.Text = "Opis twojej postaci";
            this.buttonopispostaci.UseVisualStyleBackColor = true;
            this.buttonopispostaci.Click += new System.EventHandler(this.buttonopispostaci_Click);
            // 
            // buttonpojedynek
            // 
            this.buttonpojedynek.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonpojedynek.Location = new System.Drawing.Point(172, 293);
            this.buttonpojedynek.Name = "buttonpojedynek";
            this.buttonpojedynek.Size = new System.Drawing.Size(114, 49);
            this.buttonpojedynek.TabIndex = 4;
            this.buttonpojedynek.Text = "Pojedynek";
            this.buttonpojedynek.UseVisualStyleBackColor = true;
            this.buttonpojedynek.Click += new System.EventHandler(this.buttonpojedynek_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Projekt_Na_JIPP_9386_finalny.Properties.Resources.goblin_wyvern_rider_age_of_wonders2;
            this.pictureBox1.Location = new System.Drawing.Point(409, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 220);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Zamykanie
            // 
            this.Zamykanie.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Zamykanie.BackColor = System.Drawing.Color.Transparent;
            this.Zamykanie.Location = new System.Drawing.Point(24, 360);
            this.Zamykanie.Name = "Zamykanie";
            this.Zamykanie.Nazwa = "Wyjdź";
            this.Zamykanie.Size = new System.Drawing.Size(135, 74);
            this.Zamykanie.TabIndex = 6;
            this.Zamykanie.Click += new System.EventHandler(this.Zamykanie_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Projekt_Na_JIPP_9386_finalny.Properties.Resources.fantasy_art_castle_fantasy_city_artwork_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 457);
            this.Controls.Add(this.Zamykanie);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonpojedynek);
            this.Controls.Add(this.buttonopispostaci);
            this.Controls.Add(this.przycisktworzeniapostaci);
            this.Controls.Add(this.Tytuł);
            this.DoubleBuffered = true;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Tytuł;
        private System.Windows.Forms.Button przycisktworzeniapostaci;
        private System.Windows.Forms.Button buttonopispostaci;
        private System.Windows.Forms.Button buttonpojedynek;
        private MojaKontrolka.UserControl1 Zamykanie;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

