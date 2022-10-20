
namespace Gym_DBC
{
    partial class DtFilter5
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
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.backButton5 = new System.Windows.Forms.Button();
            this.WhenTarrifPaidLabel = new System.Windows.Forms.Label();
            this.filter5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(0, 48);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(800, 341);
            this.dataGridView5.TabIndex = 0;
            // 
            // backButton5
            // 
            this.backButton5.Location = new System.Drawing.Point(713, 405);
            this.backButton5.Name = "backButton5";
            this.backButton5.Size = new System.Drawing.Size(75, 23);
            this.backButton5.TabIndex = 1;
            this.backButton5.Text = "Back";
            this.backButton5.UseVisualStyleBackColor = true;
            this.backButton5.Click += new System.EventHandler(this.backButton5_Click);
            // 
            // WhenTarrifPaidLabel
            // 
            this.WhenTarrifPaidLabel.AutoSize = true;
            this.WhenTarrifPaidLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhenTarrifPaidLabel.ForeColor = System.Drawing.Color.Gray;
            this.WhenTarrifPaidLabel.Location = new System.Drawing.Point(12, 9);
            this.WhenTarrifPaidLabel.Name = "WhenTarrifPaidLabel";
            this.WhenTarrifPaidLabel.Size = new System.Drawing.Size(297, 21);
            this.WhenTarrifPaidLabel.TabIndex = 20;
            this.WhenTarrifPaidLabel.Text = "5. When tariff was paid by tariff ID:";
            // 
            // filter5
            // 
            this.filter5.Location = new System.Drawing.Point(316, 13);
            this.filter5.Name = "filter5";
            this.filter5.Size = new System.Drawing.Size(100, 20);
            this.filter5.TabIndex = 21;
            this.filter5.TextChanged += new System.EventHandler(this.filter5_TextChanged);
            // 
            // DtFilter5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filter5);
            this.Controls.Add(this.WhenTarrifPaidLabel);
            this.Controls.Add(this.backButton5);
            this.Controls.Add(this.dataGridView5);
            this.Name = "DtFilter5";
            this.Text = "DtFilter5";
            this.Load += new System.EventHandler(this.DtFilter5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button backButton5;
        private System.Windows.Forms.Label WhenTarrifPaidLabel;
        private System.Windows.Forms.TextBox filter5;
    }
}