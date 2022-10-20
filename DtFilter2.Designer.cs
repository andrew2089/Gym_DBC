
namespace Gym_DBC
{
    partial class DtFilter2
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.backButton2 = new System.Windows.Forms.Button();
            this.tariffByID = new System.Windows.Forms.Label();
            this.sortDT2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(800, 337);
            this.dataGridView2.TabIndex = 0;
            // 
            // backButton2
            // 
            this.backButton2.Location = new System.Drawing.Point(713, 405);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(75, 23);
            this.backButton2.TabIndex = 1;
            this.backButton2.Text = "Back";
            this.backButton2.UseVisualStyleBackColor = true;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // tariffByID
            // 
            this.tariffByID.AutoSize = true;
            this.tariffByID.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tariffByID.ForeColor = System.Drawing.Color.Gray;
            this.tariffByID.Location = new System.Drawing.Point(12, 9);
            this.tariffByID.Name = "tariffByID";
            this.tariffByID.Size = new System.Drawing.Size(169, 21);
            this.tariffByID.TabIndex = 11;
            this.tariffByID.Text = "2. Find tariff by ID:";
            // 
            // sortDT2
            // 
            this.sortDT2.Location = new System.Drawing.Point(188, 13);
            this.sortDT2.Name = "sortDT2";
            this.sortDT2.Size = new System.Drawing.Size(100, 20);
            this.sortDT2.TabIndex = 12;
            this.sortDT2.TextChanged += new System.EventHandler(this.sortDT2_TextChanged_1);
            // 
            // DtFilter2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortDT2);
            this.Controls.Add(this.tariffByID);
            this.Controls.Add(this.backButton2);
            this.Controls.Add(this.dataGridView2);
            this.Name = "DtFilter2";
            this.Text = "DtFilter2";
            this.Load += new System.EventHandler(this.DtFilter2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.Label tariffByID;
        private System.Windows.Forms.TextBox sortDT2;
    }
}