namespace MegaDesk_Barragan
{
    partial class ViewAllQuotes
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
            this.view_All_Quotes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesktopMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RushDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // view_All_Quotes
            // 
            this.view_All_Quotes.AutoSize = true;
            this.view_All_Quotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_All_Quotes.Location = new System.Drawing.Point(448, 44);
            this.view_All_Quotes.Name = "view_All_Quotes";
            this.view_All_Quotes.Size = new System.Drawing.Size(183, 29);
            this.view_All_Quotes.TabIndex = 2;
            this.view_All_Quotes.Text = "View All Quotes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.QuoteDate,
            this.DeskWidth,
            this.DeskDepth,
            this.DeskDrawers,
            this.DesktopMaterial,
            this.RushDays,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(24, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 316);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "customerName";
            this.dataGridViewTextBoxColumn1.HeaderText = "customerName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "customerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "customerName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 125;
            // 
            // QuoteDate
            // 
            this.QuoteDate.HeaderText = "Quote Date";
            this.QuoteDate.MinimumWidth = 6;
            this.QuoteDate.Name = "QuoteDate";
            this.QuoteDate.ReadOnly = true;
            this.QuoteDate.Width = 125;
            // 
            // DeskWidth
            // 
            this.DeskWidth.HeaderText = "Desk Width";
            this.DeskWidth.MinimumWidth = 6;
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.ReadOnly = true;
            this.DeskWidth.Width = 125;
            // 
            // DeskDepth
            // 
            this.DeskDepth.HeaderText = "Desk Depth";
            this.DeskDepth.MinimumWidth = 6;
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.ReadOnly = true;
            this.DeskDepth.Width = 125;
            // 
            // DeskDrawers
            // 
            this.DeskDrawers.HeaderText = "Amount of Drawers";
            this.DeskDrawers.MinimumWidth = 6;
            this.DeskDrawers.Name = "DeskDrawers";
            this.DeskDrawers.ReadOnly = true;
            this.DeskDrawers.Width = 125;
            // 
            // DesktopMaterial
            // 
            this.DesktopMaterial.HeaderText = "Desktop Material";
            this.DesktopMaterial.MinimumWidth = 6;
            this.DesktopMaterial.Name = "DesktopMaterial";
            this.DesktopMaterial.ReadOnly = true;
            this.DesktopMaterial.Width = 125;
            // 
            // RushDays
            // 
            this.RushDays.HeaderText = "Rush Days";
            this.RushDays.MinimumWidth = 6;
            this.RushDays.Name = "RushDays";
            this.RushDays.ReadOnly = true;
            this.RushDays.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.view_All_Quotes);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label view_All_Quotes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesktopMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn RushDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}