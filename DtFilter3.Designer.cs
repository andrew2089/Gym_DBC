
namespace Gym_DBC
{
    partial class DtFilter3
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.backButton3 = new System.Windows.Forms.Button();
            this.coachPhoneLabel = new System.Windows.Forms.Label();
            this.sortName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 47);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(800, 347);
            this.dataGridView3.TabIndex = 0;
            // 
            // backButton3
            // 
            this.backButton3.Location = new System.Drawing.Point(713, 415);
            this.backButton3.Name = "backButton3";
            this.backButton3.Size = new System.Drawing.Size(75, 23);
            this.backButton3.TabIndex = 1;
            this.backButton3.Text = "Back";
            this.backButton3.UseVisualStyleBackColor = true;
            this.backButton3.Click += new System.EventHandler(this.backButton3_Click);
            // 
            // coachPhoneLabel
            // 
            this.coachPhoneLabel.AutoSize = true;
            this.coachPhoneLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coachPhoneLabel.ForeColor = System.Drawing.Color.Gray;
            this.coachPhoneLabel.Location = new System.Drawing.Point(12, 9);
            this.coachPhoneLabel.Name = "coachPhoneLabel";
            this.coachPhoneLabel.Size = new System.Drawing.Size(340, 21);
            this.coachPhoneLabel.TabIndex = 14;
            this.coachPhoneLabel.Text = "3. Find coach phone number by coach name:";
            // 
            // sortName
            // 
            this.sortName.Location = new System.Drawing.Point(359, 13);
            this.sortName.Name = "sortName";
            this.sortName.Size = new System.Drawing.Size(100, 20);
            this.sortName.TabIndex = 15;
            this.sortName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DtFilter3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortName);
            this.Controls.Add(this.coachPhoneLabel);
            this.Controls.Add(this.backButton3);
            this.Controls.Add(this.dataGridView3);
            this.Name = "DtFilter3";
            this.Text = "DtFilter3";
            this.Load += new System.EventHandler(this.DtFilter3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button backButton3;
        private System.Windows.Forms.Label coachPhoneLabel;
        private System.Windows.Forms.TextBox sortName;
    }
}