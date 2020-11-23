
namespace BaskBallDB
{
    partial class Form9
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.Add_Players = new System.Windows.Forms.Button();
            this.Remove_players = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Add_Team = new System.Windows.Forms.Button();
            this.dataGridViewTeam = new System.Windows.Forms.DataGridView();
            this.labelTeam = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Players";
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(46, 60);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.Size = new System.Drawing.Size(240, 286);
            this.dataGridViewPlayers.TabIndex = 1;
            // 
            // Add_Players
            // 
            this.Add_Players.Location = new System.Drawing.Point(46, 352);
            this.Add_Players.Name = "Add_Players";
            this.Add_Players.Size = new System.Drawing.Size(75, 23);
            this.Add_Players.TabIndex = 2;
            this.Add_Players.Text = "Add";
            this.Add_Players.UseVisualStyleBackColor = true;
            // 
            // Remove_players
            // 
            this.Remove_players.Location = new System.Drawing.Point(211, 352);
            this.Remove_players.Name = "Remove_players";
            this.Remove_players.Size = new System.Drawing.Size(75, 23);
            this.Remove_players.TabIndex = 3;
            this.Remove_players.Text = "Remove";
            this.Remove_players.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(661, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Add_Team
            // 
            this.Add_Team.Location = new System.Drawing.Point(496, 352);
            this.Add_Team.Name = "Add_Team";
            this.Add_Team.Size = new System.Drawing.Size(75, 23);
            this.Add_Team.TabIndex = 6;
            this.Add_Team.Text = "Add";
            this.Add_Team.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTeam
            // 
            this.dataGridViewTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeam.Location = new System.Drawing.Point(496, 60);
            this.dataGridViewTeam.Name = "dataGridViewTeam";
            this.dataGridViewTeam.Size = new System.Drawing.Size(240, 286);
            this.dataGridViewTeam.TabIndex = 5;
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Location = new System.Drawing.Point(493, 32);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(34, 13);
            this.labelTeam.TabIndex = 4;
            this.labelTeam.Text = "Team";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(577, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(496, 415);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(658, 415);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Add_Team);
            this.Controls.Add(this.dataGridViewTeam);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.Remove_players);
            this.Controls.Add(this.Add_Players);
            this.Controls.Add(this.dataGridViewPlayers);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPlayers;
        private System.Windows.Forms.Button Add_Players;
        private System.Windows.Forms.Button Remove_players;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Add_Team;
        private System.Windows.Forms.DataGridView dataGridViewTeam;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}