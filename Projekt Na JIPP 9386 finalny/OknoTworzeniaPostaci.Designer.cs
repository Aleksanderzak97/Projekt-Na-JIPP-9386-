namespace Projekt_Na_JIPP_9386_finalny
{
    partial class tworzeniepostaciform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelnick = new System.Windows.Forms.Label();
            this.textBoxnick = new System.Windows.Forms.TextBox();
            this.groupBoxplci = new System.Windows.Forms.GroupBox();
            this.radioButtonkobieta = new System.Windows.Forms.RadioButton();
            this.radioButtonmezczyzna = new System.Windows.Forms.RadioButton();
            this.comboBoxklasy = new System.Windows.Forms.ComboBox();
            this.labelklasy = new System.Windows.Forms.Label();
            this.tworzeniepostacibutton = new System.Windows.Forms.Button();
            this.buttontworzeniepowrot = new System.Windows.Forms.Button();
            this.groupBoxplci.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelnick
            // 
            this.labelnick.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelnick.AutoSize = true;
            this.labelnick.Location = new System.Drawing.Point(12, 19);
            this.labelnick.Name = "labelnick";
            this.labelnick.Size = new System.Drawing.Size(40, 13);
            this.labelnick.TabIndex = 0;
            this.labelnick.Text = "Nazwa";
            // 
            // textBoxnick
            // 
            this.textBoxnick.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxnick.Location = new System.Drawing.Point(66, 19);
            this.textBoxnick.Name = "textBoxnick";
            this.textBoxnick.Size = new System.Drawing.Size(100, 20);
            this.textBoxnick.TabIndex = 1;
            // 
            // groupBoxplci
            // 
            this.groupBoxplci.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxplci.Controls.Add(this.radioButtonkobieta);
            this.groupBoxplci.Controls.Add(this.radioButtonmezczyzna);
            this.groupBoxplci.Location = new System.Drawing.Point(15, 61);
            this.groupBoxplci.Name = "groupBoxplci";
            this.groupBoxplci.Size = new System.Drawing.Size(200, 59);
            this.groupBoxplci.TabIndex = 2;
            this.groupBoxplci.TabStop = false;
            this.groupBoxplci.Text = "Wybierz płeć";
            this.groupBoxplci.Enter += new System.EventHandler(this.groupBoxplci_Enter);
            // 
            // radioButtonkobieta
            // 
            this.radioButtonkobieta.AutoSize = true;
            this.radioButtonkobieta.Location = new System.Drawing.Point(110, 31);
            this.radioButtonkobieta.Name = "radioButtonkobieta";
            this.radioButtonkobieta.Size = new System.Drawing.Size(61, 17);
            this.radioButtonkobieta.TabIndex = 1;
            this.radioButtonkobieta.TabStop = true;
            this.radioButtonkobieta.Text = "Kobieta";
            this.radioButtonkobieta.UseVisualStyleBackColor = true;
            this.radioButtonkobieta.CheckedChanged += new System.EventHandler(this.radioButtonkobieta_CheckedChanged);
            // 
            // radioButtonmezczyzna
            // 
            this.radioButtonmezczyzna.AutoSize = true;
            this.radioButtonmezczyzna.Location = new System.Drawing.Point(6, 31);
            this.radioButtonmezczyzna.Name = "radioButtonmezczyzna";
            this.radioButtonmezczyzna.Size = new System.Drawing.Size(78, 17);
            this.radioButtonmezczyzna.TabIndex = 0;
            this.radioButtonmezczyzna.TabStop = true;
            this.radioButtonmezczyzna.Text = "Mężczyzna";
            this.radioButtonmezczyzna.UseVisualStyleBackColor = true;
            this.radioButtonmezczyzna.CheckedChanged += new System.EventHandler(this.radioButtonmezczyzna_CheckedChanged);
            // 
            // comboBoxklasy
            // 
            this.comboBoxklasy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxklasy.FormattingEnabled = true;
            this.comboBoxklasy.Items.AddRange(new object[] {
            "Wojownik",
            "Mag",
            "Łucznik",
            "Kapłan"});
            this.comboBoxklasy.Location = new System.Drawing.Point(12, 162);
            this.comboBoxklasy.Name = "comboBoxklasy";
            this.comboBoxklasy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxklasy.TabIndex = 3;
            this.comboBoxklasy.SelectedIndexChanged += new System.EventHandler(this.comboBoxklasy_SelectedIndexChanged);
            // 
            // labelklasy
            // 
            this.labelklasy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelklasy.AutoSize = true;
            this.labelklasy.Location = new System.Drawing.Point(15, 143);
            this.labelklasy.Name = "labelklasy";
            this.labelklasy.Size = new System.Drawing.Size(103, 13);
            this.labelklasy.TabIndex = 4;
            this.labelklasy.Text = "Wybierz swoją klase";
            // 
            // tworzeniepostacibutton
            // 
            this.tworzeniepostacibutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tworzeniepostacibutton.Location = new System.Drawing.Point(4, 428);
            this.tworzeniepostacibutton.Name = "tworzeniepostacibutton";
            this.tworzeniepostacibutton.Size = new System.Drawing.Size(114, 49);
            this.tworzeniepostacibutton.TabIndex = 5;
            this.tworzeniepostacibutton.Text = "Stwórz Postać";
            this.tworzeniepostacibutton.UseVisualStyleBackColor = true;
            this.tworzeniepostacibutton.Click += new System.EventHandler(this.tworzeniepostacibutton_Click);
            // 
            // buttontworzeniepowrot
            // 
            this.buttontworzeniepowrot.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttontworzeniepowrot.Location = new System.Drawing.Point(137, 428);
            this.buttontworzeniepowrot.Name = "buttontworzeniepowrot";
            this.buttontworzeniepowrot.Size = new System.Drawing.Size(114, 49);
            this.buttontworzeniepowrot.TabIndex = 6;
            this.buttontworzeniepowrot.Text = "Powrót";
            this.buttontworzeniepowrot.UseVisualStyleBackColor = true;
            this.buttontworzeniepowrot.Click += new System.EventHandler(this.buttontworzeniepowrot_Click);
            // 
            // tworzeniepostaciform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(526, 489);
            this.Controls.Add(this.buttontworzeniepowrot);
            this.Controls.Add(this.tworzeniepostacibutton);
            this.Controls.Add(this.labelklasy);
            this.Controls.Add(this.comboBoxklasy);
            this.Controls.Add(this.groupBoxplci);
            this.Controls.Add(this.textBoxnick);
            this.Controls.Add(this.labelnick);
            this.MaximumSize = new System.Drawing.Size(542, 528);
            this.MinimumSize = new System.Drawing.Size(542, 528);
            this.Name = "tworzeniepostaciform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tworzenie Postaci";
            this.Load += new System.EventHandler(this.tworzeniepostaciform_Load);
            this.groupBoxplci.ResumeLayout(false);
            this.groupBoxplci.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnick;
        private System.Windows.Forms.TextBox textBoxnick;
        private System.Windows.Forms.GroupBox groupBoxplci;
        private System.Windows.Forms.RadioButton radioButtonkobieta;
        private System.Windows.Forms.RadioButton radioButtonmezczyzna;
        private System.Windows.Forms.ComboBox comboBoxklasy;
        private System.Windows.Forms.Label labelklasy;
        private System.Windows.Forms.Button tworzeniepostacibutton;
        private System.Windows.Forms.Button buttontworzeniepowrot;
    }
}