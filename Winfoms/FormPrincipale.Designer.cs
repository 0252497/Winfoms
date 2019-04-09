namespace Winfoms
{
    partial class FormPrincipale
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
            this.buttonBonjour = new System.Windows.Forms.Button();
            this.btn_Jaunir = new System.Windows.Forms.Button();
            this.buttonBonjour2 = new System.Windows.Forms.Button();
            this.btn_Verdir = new System.Windows.Forms.Button();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBonjour
            // 
            this.buttonBonjour.AutoSize = true;
            this.buttonBonjour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBonjour.Location = new System.Drawing.Point(64, 39);
            this.buttonBonjour.Name = "buttonBonjour";
            this.buttonBonjour.Size = new System.Drawing.Size(119, 56);
            this.buttonBonjour.TabIndex = 0;
            this.buttonBonjour.Text = "Bonjour 1";
            this.buttonBonjour.UseVisualStyleBackColor = true;
            this.buttonBonjour.Click += new System.EventHandler(this.buttonBonjour_Click);
            // 
            // btn_Jaunir
            // 
            this.btn_Jaunir.AutoSize = true;
            this.btn_Jaunir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Jaunir.Location = new System.Drawing.Point(64, 131);
            this.btn_Jaunir.Name = "btn_Jaunir";
            this.btn_Jaunir.Size = new System.Drawing.Size(103, 55);
            this.btn_Jaunir.TabIndex = 2;
            this.btn_Jaunir.Text = "Jaunir";
            this.btn_Jaunir.UseVisualStyleBackColor = true;
            this.btn_Jaunir.Click += new System.EventHandler(this.modifierCouleurSelonTag);
            // 
            // buttonBonjour2
            // 
            this.buttonBonjour2.AutoSize = true;
            this.buttonBonjour2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBonjour2.Location = new System.Drawing.Point(228, 39);
            this.buttonBonjour2.Name = "buttonBonjour2";
            this.buttonBonjour2.Size = new System.Drawing.Size(119, 56);
            this.buttonBonjour2.TabIndex = 1;
            this.buttonBonjour2.Text = "Bonjour 2";
            this.buttonBonjour2.UseVisualStyleBackColor = true;
            this.buttonBonjour2.Click += new System.EventHandler(this.buttonBonjour_Click);
            // 
            // btn_Verdir
            // 
            this.btn_Verdir.AutoSize = true;
            this.btn_Verdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verdir.Location = new System.Drawing.Point(195, 131);
            this.btn_Verdir.Name = "btn_Verdir";
            this.btn_Verdir.Size = new System.Drawing.Size(103, 55);
            this.btn_Verdir.TabIndex = 3;
            this.btn_Verdir.Text = "Verdir";
            this.btn_Verdir.UseVisualStyleBackColor = true;
            this.btn_Verdir.Click += new System.EventHandler(this.modifierCouleurSelonTag);
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.AutoSize = true;
            this.btn_Quitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.Location = new System.Drawing.Point(620, 376);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(123, 47);
            this.btn_Quitter.TabIndex = 4;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = false;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.btn_Verdir);
            this.Controls.Add(this.buttonBonjour2);
            this.Controls.Add(this.btn_Jaunir);
            this.Controls.Add(this.buttonBonjour);
            this.Name = "FormPrincipale";
            this.Text = "Bonjour le monde";
            this.Click += new System.EventHandler(this.modifierCouleurSelonTag);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBonjour;
        private System.Windows.Forms.Button btn_Jaunir;
        private System.Windows.Forms.Button buttonBonjour2;
        private System.Windows.Forms.Button btn_Verdir;
        private System.Windows.Forms.Button btn_Quitter;
    }
}

