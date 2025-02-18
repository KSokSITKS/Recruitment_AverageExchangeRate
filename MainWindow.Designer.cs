namespace AverageExchangeRate
{
    partial class MainWindow
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
            this.lblLoadCurrentRates = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblLoadArchiveRates = new System.Windows.Forms.Label();
            this.btnLoadCurrentRates = new System.Windows.Forms.Button();
            this.cbArchiveDataMonth = new System.Windows.Forms.ComboBox();
            this.lblArchiveDataMonth = new System.Windows.Forms.Label();
            this.txtArchiveDataYear = new System.Windows.Forms.TextBox();
            this.lblArchiveDataYear = new System.Windows.Forms.Label();
            this.btnLoadArchiveData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRatesTableTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoadCurrentRates
            // 
            this.lblLoadCurrentRates.AutoSize = true;
            this.lblLoadCurrentRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadCurrentRates.Location = new System.Drawing.Point(3, 9);
            this.lblLoadCurrentRates.Name = "lblLoadCurrentRates";
            this.lblLoadCurrentRates.Size = new System.Drawing.Size(321, 25);
            this.lblLoadCurrentRates.TabIndex = 0;
            this.lblLoadCurrentRates.Text = "Pobieranie aktualnych kursów walut";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnLoadCurrentRates);
            this.splitContainer1.Panel1.Controls.Add(this.lblLoadCurrentRates);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnLoadArchiveData);
            this.splitContainer1.Panel2.Controls.Add(this.lblArchiveDataYear);
            this.splitContainer1.Panel2.Controls.Add(this.txtArchiveDataYear);
            this.splitContainer1.Panel2.Controls.Add(this.lblArchiveDataMonth);
            this.splitContainer1.Panel2.Controls.Add(this.cbArchiveDataMonth);
            this.splitContainer1.Panel2.Controls.Add(this.lblLoadArchiveRates);
            this.splitContainer1.Size = new System.Drawing.Size(776, 180);
            this.splitContainer1.SplitterDistance = 388;
            this.splitContainer1.TabIndex = 1;
            // 
            // lblLoadArchiveRates
            // 
            this.lblLoadArchiveRates.AutoSize = true;
            this.lblLoadArchiveRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadArchiveRates.Location = new System.Drawing.Point(3, 9);
            this.lblLoadArchiveRates.Name = "lblLoadArchiveRates";
            this.lblLoadArchiveRates.Size = new System.Drawing.Size(340, 25);
            this.lblLoadArchiveRates.TabIndex = 1;
            this.lblLoadArchiveRates.Text = "Pobieranie archiwalnych kursów walut";
            // 
            // btnLoadCurrentRates
            // 
            this.btnLoadCurrentRates.Location = new System.Drawing.Point(8, 37);
            this.btnLoadCurrentRates.Name = "btnLoadCurrentRates";
            this.btnLoadCurrentRates.Size = new System.Drawing.Size(131, 29);
            this.btnLoadCurrentRates.TabIndex = 1;
            this.btnLoadCurrentRates.Text = "Pobierz Aktualne Dane";
            this.btnLoadCurrentRates.UseVisualStyleBackColor = true;
            // 
            // cbArchiveDataMonth
            // 
            this.cbArchiveDataMonth.FormattingEnabled = true;
            this.cbArchiveDataMonth.Location = new System.Drawing.Point(54, 37);
            this.cbArchiveDataMonth.Name = "cbArchiveDataMonth";
            this.cbArchiveDataMonth.Size = new System.Drawing.Size(121, 21);
            this.cbArchiveDataMonth.TabIndex = 2;
            // 
            // lblArchiveDataMonth
            // 
            this.lblArchiveDataMonth.AutoSize = true;
            this.lblArchiveDataMonth.Location = new System.Drawing.Point(5, 40);
            this.lblArchiveDataMonth.Name = "lblArchiveDataMonth";
            this.lblArchiveDataMonth.Size = new System.Drawing.Size(43, 13);
            this.lblArchiveDataMonth.TabIndex = 3;
            this.lblArchiveDataMonth.Text = "Miesiąc";
            // 
            // txtArchiveDataYear
            // 
            this.txtArchiveDataYear.Location = new System.Drawing.Point(54, 65);
            this.txtArchiveDataYear.Name = "txtArchiveDataYear";
            this.txtArchiveDataYear.Size = new System.Drawing.Size(121, 20);
            this.txtArchiveDataYear.TabIndex = 4;
            // 
            // lblArchiveDataYear
            // 
            this.lblArchiveDataYear.AutoSize = true;
            this.lblArchiveDataYear.Location = new System.Drawing.Point(5, 68);
            this.lblArchiveDataYear.Name = "lblArchiveDataYear";
            this.lblArchiveDataYear.Size = new System.Drawing.Size(27, 13);
            this.lblArchiveDataYear.TabIndex = 5;
            this.lblArchiveDataYear.Text = "Rok";
            // 
            // btnLoadArchiveData
            // 
            this.btnLoadArchiveData.Location = new System.Drawing.Point(8, 91);
            this.btnLoadArchiveData.Name = "btnLoadArchiveData";
            this.btnLoadArchiveData.Size = new System.Drawing.Size(167, 29);
            this.btnLoadArchiveData.TabIndex = 2;
            this.btnLoadArchiveData.Text = "Pobierz Archiwalne Dane";
            this.btnLoadArchiveData.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 196);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblRatesTableTitle
            // 
            this.lblRatesTableTitle.AutoSize = true;
            this.lblRatesTableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatesTableTitle.Location = new System.Drawing.Point(12, 214);
            this.lblRatesTableTitle.Name = "lblRatesTableTitle";
            this.lblRatesTableTitle.Size = new System.Drawing.Size(145, 25);
            this.lblRatesTableTitle.TabIndex = 2;
            this.lblRatesTableTitle.Text = "Dane walutowe";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRatesTableTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainWindow";
            this.Text = "Average Echange Rate";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoadCurrentRates;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblLoadArchiveRates;
        private System.Windows.Forms.Button btnLoadCurrentRates;
        private System.Windows.Forms.Button btnLoadArchiveData;
        private System.Windows.Forms.Label lblArchiveDataYear;
        private System.Windows.Forms.TextBox txtArchiveDataYear;
        private System.Windows.Forms.Label lblArchiveDataMonth;
        private System.Windows.Forms.ComboBox cbArchiveDataMonth;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRatesTableTitle;
    }
}

