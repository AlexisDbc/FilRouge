namespace TP3
{
    partial class ConnectionPage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPlay = new System.Windows.Forms.Button();
            this.tBuser = new System.Windows.Forms.TextBox();
            this.tBpwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(92, 87);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(93, 31);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Connexion";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // tBuser
            // 
            this.tBuser.Location = new System.Drawing.Point(92, 6);
            this.tBuser.Name = "tBuser";
            this.tBuser.Size = new System.Drawing.Size(100, 20);
            this.tBuser.TabIndex = 1;
            // 
            // tBpwd
            // 
            this.tBpwd.Location = new System.Drawing.Point(92, 33);
            this.tBpwd.Name = "tBpwd";
            this.tBpwd.Size = new System.Drawing.Size(100, 20);
            this.tBpwd.TabIndex = 2;
            this.tBpwd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Utilisateur:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de passe:";
            // 
            // ConnectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 142);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBpwd);
            this.Controls.Add(this.tBuser);
            this.Controls.Add(this.buttonPlay);
            this.Name = "ConnectionPage";
            this.Text = "PlastProd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TextBox tBuser;
        private System.Windows.Forms.TextBox tBpwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

