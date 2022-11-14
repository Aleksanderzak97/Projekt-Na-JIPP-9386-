namespace Projekt_Na_JIPP_9386_finalny
{
    partial class Dane_Postaci
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
            this.labelnickdane = new System.Windows.Forms.Label();
            this.labelplecdane = new System.Windows.Forms.Label();
            this.labelklasadane = new System.Windows.Forms.Label();
            this.danebutton = new System.Windows.Forms.Button();
            this.labeldanezdrowie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelnickdane
            // 
            this.labelnickdane.AutoSize = true;
            this.labelnickdane.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelnickdane.Location = new System.Drawing.Point(144, 34);
            this.labelnickdane.Name = "labelnickdane";
            this.labelnickdane.Size = new System.Drawing.Size(77, 25);
            this.labelnickdane.TabIndex = 1;
            this.labelnickdane.Text = "Nazwa";
            // 
            // labelplecdane
            // 
            this.labelplecdane.AutoSize = true;
            this.labelplecdane.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelplecdane.Location = new System.Drawing.Point(144, 74);
            this.labelplecdane.Name = "labelplecdane";
            this.labelplecdane.Size = new System.Drawing.Size(54, 25);
            this.labelplecdane.TabIndex = 2;
            this.labelplecdane.Text = "Płeć";
            // 
            // labelklasadane
            // 
            this.labelklasadane.AutoSize = true;
            this.labelklasadane.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelklasadane.Location = new System.Drawing.Point(144, 113);
            this.labelklasadane.Name = "labelklasadane";
            this.labelklasadane.Size = new System.Drawing.Size(67, 25);
            this.labelklasadane.TabIndex = 3;
            this.labelklasadane.Text = "Klasa";
            // 
            // danebutton
            // 
            this.danebutton.Location = new System.Drawing.Point(129, 280);
            this.danebutton.Name = "danebutton";
            this.danebutton.Size = new System.Drawing.Size(114, 49);
            this.danebutton.TabIndex = 6;
            this.danebutton.Text = "Do Walki";
            this.danebutton.UseVisualStyleBackColor = true;
            this.danebutton.Click += new System.EventHandler(this.danebutton_Click);
            // 
            // labeldanezdrowie
            // 
            this.labeldanezdrowie.AutoSize = true;
            this.labeldanezdrowie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labeldanezdrowie.Location = new System.Drawing.Point(144, 153);
            this.labeldanezdrowie.Name = "labeldanezdrowie";
            this.labeldanezdrowie.Size = new System.Drawing.Size(88, 25);
            this.labeldanezdrowie.TabIndex = 7;
            this.labeldanezdrowie.Text = "Zdrowie";
            // 
            // Dane_Postaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 405);
            this.Controls.Add(this.labeldanezdrowie);
            this.Controls.Add(this.danebutton);
            this.Controls.Add(this.labelklasadane);
            this.Controls.Add(this.labelplecdane);
            this.Controls.Add(this.labelnickdane);
            this.Name = "Dane_Postaci";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Dane_Postaci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnickdane;
        private System.Windows.Forms.Label labelplecdane;
        private System.Windows.Forms.Label labelklasadane;
        private System.Windows.Forms.Button danebutton;
        private System.Windows.Forms.Label labeldanezdrowie;
    }
}