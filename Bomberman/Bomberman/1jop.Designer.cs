namespace Bomberman
{
    partial class _1jop
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
            this.b_start_2 = new System.Windows.Forms.Button();
            this.pb_bot_model = new System.Windows.Forms.PictureBox();
            this.pb_player_model = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_bot_model = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_player_model = new System.Windows.Forms.ComboBox();
            this.pb_map = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_map = new System.Windows.Forms.ComboBox();
            this.b_back_2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bot_model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player_model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_map)).BeginInit();
            this.SuspendLayout();
            // 
            // b_start_2
            // 
            this.b_start_2.Location = new System.Drawing.Point(12, 490);
            this.b_start_2.Name = "b_start_2";
            this.b_start_2.Size = new System.Drawing.Size(75, 23);
            this.b_start_2.TabIndex = 19;
            this.b_start_2.Text = "PLAY!";
            this.b_start_2.UseVisualStyleBackColor = true;
            // 
            // pb_bot_model
            // 
            this.pb_bot_model.Location = new System.Drawing.Point(15, 255);
            this.pb_bot_model.Name = "pb_bot_model";
            this.pb_bot_model.Size = new System.Drawing.Size(50, 50);
            this.pb_bot_model.TabIndex = 18;
            this.pb_bot_model.TabStop = false;
            // 
            // pb_player_model
            // 
            this.pb_player_model.Location = new System.Drawing.Point(15, 159);
            this.pb_player_model.Name = "pb_player_model";
            this.pb_player_model.Size = new System.Drawing.Size(50, 50);
            this.pb_player_model.TabIndex = 17;
            this.pb_player_model.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bot ";
            // 
            // cb_bot_model
            // 
            this.cb_bot_model.FormattingEnabled = true;
            this.cb_bot_model.Items.AddRange(new object[] {
            "DEFAULT - TEST"});
            this.cb_bot_model.Location = new System.Drawing.Point(15, 228);
            this.cb_bot_model.Name = "cb_bot_model";
            this.cb_bot_model.Size = new System.Drawing.Size(121, 21);
            this.cb_bot_model.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Player ";
            // 
            // cb_player_model
            // 
            this.cb_player_model.FormattingEnabled = true;
            this.cb_player_model.Items.AddRange(new object[] {
            "DEFAULT - TEST"});
            this.cb_player_model.Location = new System.Drawing.Point(15, 132);
            this.cb_player_model.Name = "cb_player_model";
            this.cb_player_model.Size = new System.Drawing.Size(121, 21);
            this.cb_player_model.TabIndex = 13;
            // 
            // pb_map
            // 
            this.pb_map.Location = new System.Drawing.Point(142, 13);
            this.pb_map.Name = "pb_map";
            this.pb_map.Size = new System.Drawing.Size(500, 500);
            this.pb_map.TabIndex = 12;
            this.pb_map.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mapa";
            // 
            // cb_map
            // 
            this.cb_map.FormattingEnabled = true;
            this.cb_map.Items.AddRange(new object[] {
            "DEFAULT - TEST"});
            this.cb_map.Location = new System.Drawing.Point(15, 26);
            this.cb_map.Name = "cb_map";
            this.cb_map.Size = new System.Drawing.Size(121, 21);
            this.cb_map.TabIndex = 10;
            // 
            // b_back_2
            // 
            this.b_back_2.Location = new System.Drawing.Point(12, 461);
            this.b_back_2.Name = "b_back_2";
            this.b_back_2.Size = new System.Drawing.Size(75, 23);
            this.b_back_2.TabIndex = 20;
            this.b_back_2.Text = "<-- BACK";
            this.b_back_2.UseVisualStyleBackColor = true;
            this.b_back_2.Click += new System.EventHandler(this.b_back_2_Click);
            // 
            // _1jop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 522);
            this.Controls.Add(this.b_back_2);
            this.Controls.Add(this.b_start_2);
            this.Controls.Add(this.pb_bot_model);
            this.Controls.Add(this.pb_player_model);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_bot_model);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_player_model);
            this.Controls.Add(this.pb_map);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_map);
            this.Name = "_1jop";
            this.Text = "_1jop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this._1jop_FormClosed);
            this.Load += new System.EventHandler(this._1jop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_bot_model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player_model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_start_2;
        private System.Windows.Forms.PictureBox pb_bot_model;
        private System.Windows.Forms.PictureBox pb_player_model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_bot_model;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_player_model;
        private System.Windows.Forms.PictureBox pb_map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_map;
        private System.Windows.Forms.Button b_back_2;
    }
}