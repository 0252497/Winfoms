namespace Winforms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipale));
            this.buttonBonjour = new System.Windows.Forms.Button();
            this.btn_Jaunir = new System.Windows.Forms.Button();
            this.buttonBonjour2 = new System.Windows.Forms.Button();
            this.btn_Verdir = new System.Windows.Forms.Button();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCouleurDeFond = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bonjourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bonjour3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bonjour4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enNoirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enRoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirIllicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coordonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusLabelCoordonnées = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBonjour
            // 
            this.buttonBonjour.AutoSize = true;
            this.buttonBonjour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBonjour.Location = new System.Drawing.Point(64, 76);
            this.buttonBonjour.Name = "buttonBonjour";
            this.buttonBonjour.Size = new System.Drawing.Size(119, 56);
            this.buttonBonjour.TabIndex = 0;
            this.buttonBonjour.Text = "Bonjour &1";
            this.buttonBonjour.UseVisualStyleBackColor = true;
            this.buttonBonjour.Click += new System.EventHandler(this.direBonjourSelonText);
            // 
            // btn_Jaunir
            // 
            this.btn_Jaunir.AutoSize = true;
            this.btn_Jaunir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Jaunir.Location = new System.Drawing.Point(64, 192);
            this.btn_Jaunir.Name = "btn_Jaunir";
            this.btn_Jaunir.Size = new System.Drawing.Size(103, 55);
            this.btn_Jaunir.TabIndex = 2;
            this.btn_Jaunir.Text = "&Jaunir";
            this.toolTip1.SetToolTip(this.btn_Jaunir, "Pour mettre en jaune le fond du formulaire");
            this.btn_Jaunir.UseVisualStyleBackColor = true;
            this.btn_Jaunir.Click += new System.EventHandler(this.modifierCouleurSelonTag);
            // 
            // buttonBonjour2
            // 
            this.buttonBonjour2.AutoSize = true;
            this.buttonBonjour2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBonjour2.Location = new System.Drawing.Point(217, 76);
            this.buttonBonjour2.Name = "buttonBonjour2";
            this.buttonBonjour2.Size = new System.Drawing.Size(119, 56);
            this.buttonBonjour2.TabIndex = 1;
            this.buttonBonjour2.Text = "Bonjour &2";
            this.buttonBonjour2.UseVisualStyleBackColor = true;
            this.buttonBonjour2.Click += new System.EventHandler(this.direBonjourSelonText);
            // 
            // btn_Verdir
            // 
            this.btn_Verdir.AutoSize = true;
            this.btn_Verdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verdir.Location = new System.Drawing.Point(217, 192);
            this.btn_Verdir.Name = "btn_Verdir";
            this.btn_Verdir.Size = new System.Drawing.Size(103, 55);
            this.btn_Verdir.TabIndex = 3;
            this.btn_Verdir.Text = "&Verdir";
            this.toolTip1.SetToolTip(this.btn_Verdir, "Pour mettre en vert le fond du formulaire");
            this.btn_Verdir.UseVisualStyleBackColor = true;
            this.btn_Verdir.Click += new System.EventHandler(this.modifierCouleurSelonTag);
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.AutoSize = true;
            this.btn_Quitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.Location = new System.Drawing.Point(655, 365);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(123, 47);
            this.btn_Quitter.TabIndex = 4;
            this.btn_Quitter.Text = "&Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = false;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCouleurDeFond,
            this.toolStripStatusLabelAction,
            this.toolStripStatusLabelCoordonnées});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.MouseHover += new System.EventHandler(this.statusStrip1_MouseHover);
            // 
            // toolStripStatusLabelCouleurDeFond
            // 
            this.toolStripStatusLabelCouleurDeFond.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelCouleurDeFond.Name = "toolStripStatusLabelCouleurDeFond";
            this.toolStripStatusLabelCouleurDeFond.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabelCouleurDeFond.Text = "Couleur de fond";
            // 
            // toolStripStatusLabelAction
            // 
            this.toolStripStatusLabelAction.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabelAction.Name = "toolStripStatusLabelAction";
            this.toolStripStatusLabelAction.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabelAction.Text = "Action";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bonjourToolStripMenuItem,
            this.colorerToolStripMenuItem,
            this.diversToolStripMenuItem,
            this.àProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bonjourToolStripMenuItem
            // 
            this.bonjourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bonjour3ToolStripMenuItem,
            this.bonjour4ToolStripMenuItem});
            this.bonjourToolStripMenuItem.Name = "bonjourToolStripMenuItem";
            this.bonjourToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bonjourToolStripMenuItem.Text = "&Bonjour";
            // 
            // bonjour3ToolStripMenuItem
            // 
            this.bonjour3ToolStripMenuItem.Name = "bonjour3ToolStripMenuItem";
            this.bonjour3ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.bonjour3ToolStripMenuItem.Text = "Bonjour &3";
            this.bonjour3ToolStripMenuItem.Click += new System.EventHandler(this.direBonjourSelonText);
            // 
            // bonjour4ToolStripMenuItem
            // 
            this.bonjour4ToolStripMenuItem.Name = "bonjour4ToolStripMenuItem";
            this.bonjour4ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.bonjour4ToolStripMenuItem.Text = "Bonjour &4";
            this.bonjour4ToolStripMenuItem.Click += new System.EventHandler(this.direBonjourSelonText);
            // 
            // colorerToolStripMenuItem
            // 
            this.colorerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enNoirToolStripMenuItem,
            this.enRoseToolStripMenuItem});
            this.colorerToolStripMenuItem.Name = "colorerToolStripMenuItem";
            this.colorerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.colorerToolStripMenuItem.Text = "&Colorer";
            // 
            // enNoirToolStripMenuItem
            // 
            this.enNoirToolStripMenuItem.Name = "enNoirToolStripMenuItem";
            this.enNoirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.enNoirToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.enNoirToolStripMenuItem.Text = "En &noir";
            this.enNoirToolStripMenuItem.Click += new System.EventHandler(this.modifierCouleurSelonTag);
            // 
            // enRoseToolStripMenuItem
            // 
            this.enRoseToolStripMenuItem.Name = "enRoseToolStripMenuItem";
            this.enRoseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.enRoseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.enRoseToolStripMenuItem.Text = "En &rose";
            this.enRoseToolStripMenuItem.Click += new System.EventHandler(this.modifierCouleurSelonTag);
            // 
            // diversToolStripMenuItem
            // 
            this.diversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortirIllicoToolStripMenuItem,
            this.coordonnéesToolStripMenuItem});
            this.diversToolStripMenuItem.Name = "diversToolStripMenuItem";
            this.diversToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.diversToolStripMenuItem.Text = "&Divers";
            // 
            // sortirIllicoToolStripMenuItem
            // 
            this.sortirIllicoToolStripMenuItem.Checked = true;
            this.sortirIllicoToolStripMenuItem.CheckOnClick = true;
            this.sortirIllicoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sortirIllicoToolStripMenuItem.Name = "sortirIllicoToolStripMenuItem";
            this.sortirIllicoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.sortirIllicoToolStripMenuItem.Text = "&Sortir illico";
            // 
            // coordonnéesToolStripMenuItem
            // 
            this.coordonnéesToolStripMenuItem.Name = "coordonnéesToolStripMenuItem";
            this.coordonnéesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.coordonnéesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.coordonnéesToolStripMenuItem.Text = "&Coordonnées";
            this.coordonnéesToolStripMenuItem.Click += new System.EventHandler(this.coordonnéesToolStripMenuItem_Click);
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.àProposToolStripMenuItem.Text = "&À propos";
            this.àProposToolStripMenuItem.Click += new System.EventHandler(this.àProposToolStripMenuItem_Click);
            // 
            // toolStripStatusLabelCoordonnées
            // 
            this.toolStripStatusLabelCoordonnées.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabelCoordonnées.Name = "toolStripStatusLabelCoordonnées";
            this.toolStripStatusLabelCoordonnées.Size = new System.Drawing.Size(78, 17);
            this.toolStripStatusLabelCoordonnées.Text = "Coordonnées";
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.btn_Verdir);
            this.Controls.Add(this.buttonBonjour2);
            this.Controls.Add(this.btn_Jaunir);
            this.Controls.Add(this.buttonBonjour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipale";
            this.Text = "Bonjour le monde";
            this.toolTip1.SetToolTip(this, "Cliquer pour mettre en rouge le fond du formulaire");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipale_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipale_FormClosed);
            this.SizeChanged += new System.EventHandler(this.FormPrincipale_SizeChanged);
            this.Click += new System.EventHandler(this.modifierCouleurSelonTag);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPrincipale_MouseDown);
            this.MouseEnter += new System.EventHandler(this.FormPrincipale_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FormPrincipale_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormPrincipale_MouseMove);
            this.Move += new System.EventHandler(this.FormPrincipale_Move);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBonjour;
        private System.Windows.Forms.Button btn_Jaunir;
        private System.Windows.Forms.Button buttonBonjour2;
        private System.Windows.Forms.Button btn_Verdir;
        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCouleurDeFond;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAction;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bonjourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bonjour3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bonjour4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enNoirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enRoseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortirIllicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem coordonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCoordonnées;
    }
}

