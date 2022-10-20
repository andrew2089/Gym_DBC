
namespace Gym_DBC
{
    partial class DtFilter4
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
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.backButton4 = new System.Windows.Forms.Button();
            this.TariffByTittleLabel = new System.Windows.Forms.Label();
            this.FilterDt4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView4.Location = new System.Drawing.Point(0, 47);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(800, 350);
            this.dataGridView4.TabIndex = 0;
            // 
            // backButton4
            // 
            this.backButton4.Location = new System.Drawing.Point(713, 415);
            this.backButton4.Name = "backButton4";
            this.backButton4.Size = new System.Drawing.Size(75, 23);
            this.backButton4.TabIndex = 1;
            this.backButton4.Text = "Back";
            this.backButton4.UseVisualStyleBackColor = true;
            this.backButton4.Click += new System.EventHandler(this.backButton4_Click);
            // 
            // TariffByTittleLabel
            // 
            this.TariffByTittleLabel.AutoSize = true;
            this.TariffByTittleLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TariffByTittleLabel.ForeColor = System.Drawing.Color.Gray;
            this.TariffByTittleLabel.Location = new System.Drawing.Point(12, 9);
            this.TariffByTittleLabel.Name = "TariffByTittleLabel";
            this.TariffByTittleLabel.Size = new System.Drawing.Size(278, 21);
            this.TariffByTittleLabel.TabIndex = 17;
            this.TariffByTittleLabel.Text = "4. Find tariff price by tariff tittle:";
            // 
            // FilterDt4
            // 
            this.FilterDt4.Location = new System.Drawing.Point(297, 13);
            this.FilterDt4.Name = "FilterDt4";
            this.FilterDt4.Size = new System.Drawing.Size(100, 20);
            this.FilterDt4.TabIndex = 18;
            this.FilterDt4.TextChanged += new System.EventHandler(this.FilterDt4_TextChanged_1);
            // 
            // DtFilter4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilterDt4);
            this.Controls.Add(this.TariffByTittleLabel);
            this.Controls.Add(this.backButton4);
            this.Controls.Add(this.dataGridView4);
            this.Name = "DtFilter4";
            this.Text = "DtFilter4";
            this.Load += new System.EventHandler(this.DtFilter4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button backButton4;
        private System.Windows.Forms.Label TariffByTittleLabel;
        private System.Windows.Forms.TextBox FilterDt4;
    }
}