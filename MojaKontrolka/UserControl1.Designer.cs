namespace MojaKontrolka
{
    partial class UserControl1
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.MojPrzycisk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MojPrzycisk
            // 
            this.MojPrzycisk.Location = new System.Drawing.Point(12, 12);
            this.MojPrzycisk.Name = "MojPrzycisk";
            this.MojPrzycisk.Padding = new System.Windows.Forms.Padding(2);
            this.MojPrzycisk.Size = new System.Drawing.Size(114, 49);
            this.MojPrzycisk.TabIndex = 3;
            this.MojPrzycisk.Text = "MojPrzycisk";
            this.MojPrzycisk.UseVisualStyleBackColor = true;
            this.MojPrzycisk.Click += new System.EventHandler(this.MojPrzycisk_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MojPrzycisk);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(135, 74);
            this.Click += new System.EventHandler(this.MojPrzycisk_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MojPrzycisk;
    }
}
