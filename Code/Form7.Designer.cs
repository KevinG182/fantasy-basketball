
namespace BaskBallDB
{
    partial class Form7
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvLeagueUsers = new System.Windows.Forms.DataGridView();
            this.dgvDraftOrder = new System.Windows.Forms.DataGridView();
            this.dgvLeagueComp = new System.Windows.Forms.DataGridView();
            this.dgvPointSystem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeagueUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDraftOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeagueComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(753, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(728, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Draft Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LeagueComp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PointSystem";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(308, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Draft Date";
            // 
            // dgvLeagueUsers
            // 
            this.dgvLeagueUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeagueUsers.Location = new System.Drawing.Point(548, 39);
            this.dgvLeagueUsers.Name = "dgvLeagueUsers";
            this.dgvLeagueUsers.Size = new System.Drawing.Size(240, 150);
            this.dgvLeagueUsers.TabIndex = 6;
            // 
            // dgvDraftOrder
            // 
            this.dgvDraftOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDraftOrder.Location = new System.Drawing.Point(548, 225);
            this.dgvDraftOrder.Name = "dgvDraftOrder";
            this.dgvDraftOrder.Size = new System.Drawing.Size(240, 150);
            this.dgvDraftOrder.TabIndex = 7;
            // 
            // dgvLeagueComp
            // 
            this.dgvLeagueComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeagueComp.Location = new System.Drawing.Point(42, 23);
            this.dgvLeagueComp.Name = "dgvLeagueComp";
            this.dgvLeagueComp.Size = new System.Drawing.Size(240, 150);
            this.dgvLeagueComp.TabIndex = 8;
            // 
            // dgvPointSystem
            // 
            this.dgvPointSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPointSystem.Location = new System.Drawing.Point(42, 225);
            this.dgvPointSystem.Name = "dgvPointSystem";
            this.dgvPointSystem.Size = new System.Drawing.Size(240, 150);
            this.dgvPointSystem.TabIndex = 9;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPointSystem);
            this.Controls.Add(this.dgvLeagueComp);
            this.Controls.Add(this.dgvDraftOrder);
            this.Controls.Add(this.dgvLeagueUsers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeagueUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDraftOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeagueComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointSystem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvLeagueUsers;
        private System.Windows.Forms.DataGridView dgvDraftOrder;
        private System.Windows.Forms.DataGridView dgvLeagueComp;
        private System.Windows.Forms.DataGridView dgvPointSystem;
    }
}