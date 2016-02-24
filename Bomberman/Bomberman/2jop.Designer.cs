namespace Bomberman
{
    partial class _2jop
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
            this.cb_map = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_map = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_player_1_model = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_player_2_model = new System.Windows.Forms.ComboBox();
            this.pb_player_1_model = new System.Windows.Forms.PictureBox();
            this.pb_player_2_model = new System.Windows.Forms.PictureBox();
            this.b_start = new System.Windows.Forms.Button();
            this.b_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player_1_model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player_2_model)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_map
            // 
            this.cb_map.FormattingEnabled = true;
            this.cb_map.Items.AddRange(new object[] {
        "DEFAULT - TEST"});
            this.cb_map.Location = new System.Drawing.Point(15, 25);
            this.cb_map.Name = "cb_map";
            this.cb_map.Size = new System.Drawing.Size(121, 21);
            this.cb_map.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mapa";
            // 
            // pb_map
            // 
            this.pb_map.Location = new System.Drawing.Point(142, 12);
            this.pb_map.Name = "pb_map";
            this.pb_map.Size = new System.Drawing.Size(500, 500);
            this.pb_map.TabIndex = 2;
            this.pb_map.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player 1 - Model";
            // 
            // cb_player_1_model
            // 
            this.cb_player_1_model.FormattingEnabled = true;
            this.cb_player_1_model.Items.AddRange(new object[] {
        "DEFAULT - TEST"});
            this.cb_player_1_model.Location = new System.Drawing.Point(15, 131);
            this.cb_player_1_model.Name = "cb_player_1_model";
            this.cb_player_1_model.Size = new System.Drawing.Size(121, 21);
            this.cb_player_1_model.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player 2 - Model";
            // 
            // cb_player_2_model
            // 
            this.cb_player_2_model.FormattingEnabled = true;
            this.cb_player_2_model.Items.AddRange(new object[] {
        "DEFAULT - TEST"});
            this.cb_player_2_model.Location = new System.Drawing.Point(15, 227);
            this.cb_player_2_model.Name = "cb_player_2_model";
            this.cb_player_2_model.Size = new System.Drawing.Size(121, 21);
            this.cb_player_2_model.TabIndex = 5;
            this.cb_player_2_model.SelectedIndexChanged += new System.EventHandler(this.cb_player_2_model_SelectedIndexChanged);
            // 
            // pb_player_1_model
            // 
            this.pb_player_1_model.Location = new System.Drawing.Point(15, 158);
            this.pb_player_1_model.Name = "pb_player_1_model";
            this.pb_player_1_model.Size = new System.Drawing.Size(50, 50);
            this.pb_player_1_model.TabIndex = 7;
            this.pb_player_1_model.TabStop = false;
            // 
            // pb_player_2_model
            // 
            this.pb_player_2_model.Location = new System.Drawing.Point(15, 254);
            this.pb_player_2_model.Name = "pb_player_2_model";
            this.pb_player_2_model.Size = new System.Drawing.Size(50, 50);
            this.pb_player_2_model.TabIndex = 8;
            this.pb_player_2_model.TabStop = false;
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(12, 489);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(75, 23);
            this.b_start.TabIndex = 9;
            this.b_start.Text = "PLAY!";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(12, 460);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(75, 23);
            this.b_exit.TabIndex = 10;
            this.b_exit.Text = "<-- BACK";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // _2jop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 522);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.pb_player_2_model);
            this.Controls.Add(this.pb_player_1_model);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_player_2_model);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_player_1_model);
            this.Controls.Add(this.pb_map);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_map);
            this.Name = "_2jop";
            this.Text = "2 jogadores - opções";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this._2jop_FormClosed);
            this.Load += new System.EventHandler(this._2jop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player_1_model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player_2_model)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_map;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_player_1_model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_player_2_model;
        private System.Windows.Forms.PictureBox pb_player_1_model;
        private System.Windows.Forms.PictureBox pb_player_2_model;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Button b_exit;
    }
}
