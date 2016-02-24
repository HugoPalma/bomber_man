namespace Bomberman
{
    partial class Form1
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
            this.b_jogador_um = new System.Windows.Forms.Button();
            this.b_jogador_dois = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.b_creditos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_jogador_um
            // 
            this.b_jogador_um.Location = new System.Drawing.Point(74, 47);
            this.b_jogador_um.Name = "b_jogador_um";
            this.b_jogador_um.Size = new System.Drawing.Size(134, 38);
            this.b_jogador_um.TabIndex = 0;
            this.b_jogador_um.Text = "1 Jogador";
            this.b_jogador_um.UseVisualStyleBackColor = true;
            this.b_jogador_um.Click += new System.EventHandler(this.b_jogador_um_Click);
            // 
            // b_jogador_dois
            // 
            this.b_jogador_dois.Location = new System.Drawing.Point(74, 91);
            this.b_jogador_dois.Name = "b_jogador_dois";
            this.b_jogador_dois.Size = new System.Drawing.Size(134, 38);
            this.b_jogador_dois.TabIndex = 1;
            this.b_jogador_dois.Text = "2 Jogadores";
            this.b_jogador_dois.UseVisualStyleBackColor = true;
            this.b_jogador_dois.Click += new System.EventHandler(this.b_jogador_dois_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "2 Jogadores (LAN)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // b_creditos
            // 
            this.b_creditos.Location = new System.Drawing.Point(74, 179);
            this.b_creditos.Name = "b_creditos";
            this.b_creditos.Size = new System.Drawing.Size(134, 38);
            this.b_creditos.TabIndex = 3;
            this.b_creditos.Text = "Créditos";
            this.b_creditos.UseVisualStyleBackColor = true;
            this.b_creditos.Click += new System.EventHandler(this.b_creditos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.b_creditos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.b_jogador_dois);
            this.Controls.Add(this.b_jogador_um);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_jogador_um;
        private System.Windows.Forms.Button b_jogador_dois;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button b_creditos;
    }
}

