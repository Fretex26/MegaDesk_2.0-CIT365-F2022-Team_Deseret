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
            this.components = new System.ComponentModel.Container();
            this.view_All_Quotes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quoteListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.deskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // view_All_Quotes
            // 
            this.view_All_Quotes.AutoSize = true;
            this.view_All_Quotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_All_Quotes.Location = new System.Drawing.Point(297, 45);
            this.view_All_Quotes.Name = "view_All_Quotes";
            this.view_All_Quotes.Size = new System.Drawing.Size(183, 29);
            this.view_All_Quotes.TabIndex = 2;
            this.view_All_Quotes.Text = "View All Quotes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rushDaysDataGridViewTextBoxColumn,
            this.quoteDateDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.deskDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.quotesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(683, 316);
            this.dataGridView1.TabIndex = 3;
            // 
            // quoteListBindingSource
            // 
            this.quoteListBindingSource.DataSource = typeof(MegaDesk_Barragan.ViewAllQuotes.QuoteList);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // deskBindingSource
            // 
            this.deskBindingSource.DataSource = typeof(MegaDesk_Barragan.ViewAllQuotes.Desk);
            // 
            // quotesBindingSource
            // 
            this.quotesBindingSource.DataMember = "quotes";
            this.quotesBindingSource.DataSource = this.quoteListBindingSource;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "customerName";
            this.dataGridViewTextBoxColumn1.HeaderText = "customerName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "customerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // deskDataGridViewTextBoxColumn
            // 
            this.deskDataGridViewTextBoxColumn.DataPropertyName = "Desk";
            this.deskDataGridViewTextBoxColumn.HeaderText = "Desk";
            this.deskDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deskDataGridViewTextBoxColumn.Name = "deskDataGridViewTextBoxColumn";
            this.deskDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // quoteDateDataGridViewTextBoxColumn
            // 
            this.quoteDateDataGridViewTextBoxColumn.DataPropertyName = "quoteDate";
            this.quoteDateDataGridViewTextBoxColumn.HeaderText = "quoteDate";
            this.quoteDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quoteDateDataGridViewTextBoxColumn.Name = "quoteDateDataGridViewTextBoxColumn";
            this.quoteDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // rushDaysDataGridViewTextBoxColumn
            // 
            this.rushDaysDataGridViewTextBoxColumn.DataPropertyName = "rushDays";
            this.rushDaysDataGridViewTextBoxColumn.HeaderText = "rushDays";
            this.rushDaysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rushDaysDataGridViewTextBoxColumn.Name = "rushDaysDataGridViewTextBoxColumn";
            this.rushDaysDataGridViewTextBoxColumn.Width = 125;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.view_All_Quotes);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label view_All_Quotes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource quoteListBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource deskBindingSource;
        private System.Windows.Forms.BindingSource quotesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}