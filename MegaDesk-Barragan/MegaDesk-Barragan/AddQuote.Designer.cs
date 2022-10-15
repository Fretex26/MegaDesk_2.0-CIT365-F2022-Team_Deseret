namespace MegaDesk_Barragan
{
    partial class AddQuote
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
            this.add_Quote = new System.Windows.Forms.Label();
            this.customer_Name = new System.Windows.Forms.Label();
            this.desk_Width = new System.Windows.Forms.Label();
            this.desk_Depth = new System.Windows.Forms.Label();
            this.number_Of_Drawers = new System.Windows.Forms.Label();
            this.desktop_Material = new System.Windows.Forms.Label();
            this.rush_Order = new System.Windows.Forms.Label();
            this.custName = new System.Windows.Forms.TextBox();
            this.withTextBox = new System.Windows.Forms.TextBox();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.drawersTextBox = new System.Windows.Forms.TextBox();
            this.errorDepth = new System.Windows.Forms.Label();
            this.errorWidth = new System.Windows.Forms.Label();
            this.submitQuote = new System.Windows.Forms.Button();
            this.errorDrawers = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.materialUpDown = new System.Windows.Forms.DomainUpDown();
            this.rushOrderTextBox = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // add_Quote
            // 
            this.add_Quote.AutoSize = true;
            this.add_Quote.BackColor = System.Drawing.Color.Transparent;
            this.add_Quote.Font = new System.Drawing.Font("Malgun Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Quote.Location = new System.Drawing.Point(140, 295);
            this.add_Quote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_Quote.Name = "add_Quote";
            this.add_Quote.Size = new System.Drawing.Size(290, 67);
            this.add_Quote.TabIndex = 0;
            this.add_Quote.Text = "Add Quote";
            this.add_Quote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // customer_Name
            // 
            this.customer_Name.AutoSize = true;
            this.customer_Name.BackColor = System.Drawing.Color.Transparent;
            this.customer_Name.Font = new System.Drawing.Font("Malgun Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_Name.Location = new System.Drawing.Point(177, 423);
            this.customer_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customer_Name.Name = "customer_Name";
            this.customer_Name.Size = new System.Drawing.Size(279, 47);
            this.customer_Name.TabIndex = 0;
            this.customer_Name.Text = "Customer Name";
            this.customer_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // desk_Width
            // 
            this.desk_Width.AutoSize = true;
            this.desk_Width.BackColor = System.Drawing.Color.Transparent;
            this.desk_Width.Font = new System.Drawing.Font("Malgun Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desk_Width.Location = new System.Drawing.Point(177, 537);
            this.desk_Width.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.desk_Width.Name = "desk_Width";
            this.desk_Width.Size = new System.Drawing.Size(260, 47);
            this.desk_Width.TabIndex = 0;
            this.desk_Width.Text = "Desk width (in)";
            this.desk_Width.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // desk_Depth
            // 
            this.desk_Depth.AutoSize = true;
            this.desk_Depth.BackColor = System.Drawing.Color.Transparent;
            this.desk_Depth.Font = new System.Drawing.Font("Malgun Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desk_Depth.Location = new System.Drawing.Point(177, 651);
            this.desk_Depth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.desk_Depth.Name = "desk_Depth";
            this.desk_Depth.Size = new System.Drawing.Size(265, 47);
            this.desk_Depth.TabIndex = 0;
            this.desk_Depth.Text = "Desk depth (in)";
            this.desk_Depth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // number_Of_Drawers
            // 
            this.number_Of_Drawers.AutoSize = true;
            this.number_Of_Drawers.BackColor = System.Drawing.Color.Transparent;
            this.number_Of_Drawers.Font = new System.Drawing.Font("Malgun Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_Of_Drawers.Location = new System.Drawing.Point(177, 765);
            this.number_Of_Drawers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.number_Of_Drawers.Name = "number_Of_Drawers";
            this.number_Of_Drawers.Size = new System.Drawing.Size(220, 47);
            this.number_Of_Drawers.TabIndex = 0;
            this.number_Of_Drawers.Text = "# of drawers";
            this.number_Of_Drawers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // desktop_Material
            // 
            this.desktop_Material.AutoSize = true;
            this.desktop_Material.BackColor = System.Drawing.Color.Transparent;
            this.desktop_Material.Font = new System.Drawing.Font("Malgun Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktop_Material.Location = new System.Drawing.Point(177, 878);
            this.desktop_Material.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.desktop_Material.Name = "desktop_Material";
            this.desktop_Material.Size = new System.Drawing.Size(292, 47);
            this.desktop_Material.TabIndex = 0;
            this.desktop_Material.Text = "Desktop Material";
            this.desktop_Material.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rush_Order
            // 
            this.rush_Order.AutoSize = true;
            this.rush_Order.BackColor = System.Drawing.Color.Transparent;
            this.rush_Order.Font = new System.Drawing.Font("Malgun Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rush_Order.Location = new System.Drawing.Point(177, 992);
            this.rush_Order.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rush_Order.Name = "rush_Order";
            this.rush_Order.Size = new System.Drawing.Size(364, 47);
            this.rush_Order.TabIndex = 0;
            this.rush_Order.Text = "Rush order (Optional)";
            this.rush_Order.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // custName
            // 
            this.custName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custName.Location = new System.Drawing.Point(177, 474);
            this.custName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(488, 32);
            this.custName.TabIndex = 1;
            // 
            // withTextBox
            // 
            this.withTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.withTextBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withTextBox.Location = new System.Drawing.Point(177, 588);
            this.withTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.withTextBox.Name = "withTextBox";
            this.withTextBox.Size = new System.Drawing.Size(488, 32);
            this.withTextBox.TabIndex = 2;
            this.withTextBox.TextChanged += new System.EventHandler(this.withTextBox_TextChanged);
            // 
            // depthTextBox
            // 
            this.depthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.depthTextBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthTextBox.Location = new System.Drawing.Point(177, 702);
            this.depthTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(488, 32);
            this.depthTextBox.TabIndex = 3;
            this.depthTextBox.TextChanged += new System.EventHandler(this.depthTextBox_TextChanged);
            this.depthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthTextBox_KeyPress);
            // 
            // drawersTextBox
            // 
            this.drawersTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drawersTextBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersTextBox.Location = new System.Drawing.Point(177, 815);
            this.drawersTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drawersTextBox.Name = "drawersTextBox";
            this.drawersTextBox.Size = new System.Drawing.Size(488, 32);
            this.drawersTextBox.TabIndex = 4;
            this.drawersTextBox.TextChanged += new System.EventHandler(this.drawersTextBox_TextChanged);
            // 
            // errorDepth
            // 
            this.errorDepth.AutoSize = true;
            this.errorDepth.BackColor = System.Drawing.Color.Transparent;
            this.errorDepth.ForeColor = System.Drawing.Color.Maroon;
            this.errorDepth.Location = new System.Drawing.Point(458, 674);
            this.errorDepth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorDepth.Name = "errorDepth";
            this.errorDepth.Size = new System.Drawing.Size(0, 20);
            this.errorDepth.TabIndex = 2;
            // 
            // errorWidth
            // 
            this.errorWidth.AutoSize = true;
            this.errorWidth.BackColor = System.Drawing.Color.Transparent;
            this.errorWidth.ForeColor = System.Drawing.Color.Maroon;
            this.errorWidth.Location = new System.Drawing.Point(446, 560);
            this.errorWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorWidth.Name = "errorWidth";
            this.errorWidth.Size = new System.Drawing.Size(0, 20);
            this.errorWidth.TabIndex = 2;
            // 
            // submitQuote
            // 
            this.submitQuote.Location = new System.Drawing.Point(177, 1103);
            this.submitQuote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitQuote.Name = "submitQuote";
            this.submitQuote.Size = new System.Drawing.Size(112, 35);
            this.submitQuote.TabIndex = 7;
            this.submitQuote.Text = "Submit Quote";
            this.submitQuote.UseVisualStyleBackColor = true;
            this.submitQuote.Click += new System.EventHandler(this.submitQuote_Click);
            // 
            // errorDrawers
            // 
            this.errorDrawers.AutoSize = true;
            this.errorDrawers.BackColor = System.Drawing.Color.Transparent;
            this.errorDrawers.ForeColor = System.Drawing.Color.Maroon;
            this.errorDrawers.Location = new System.Drawing.Point(442, 788);
            this.errorDrawers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorDrawers.Name = "errorDrawers";
            this.errorDrawers.Size = new System.Drawing.Size(0, 20);
            this.errorDrawers.TabIndex = 2;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(552, 1102);
            this.returnButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(112, 35);
            this.returnButton.TabIndex = 8;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // materialUpDown
            // 
            this.materialUpDown.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialUpDown.Items.Add("Laminate");
            this.materialUpDown.Items.Add("Oak");
            this.materialUpDown.Items.Add("Rosewood");
            this.materialUpDown.Items.Add("Veneer");
            this.materialUpDown.Items.Add("Pine");
            this.materialUpDown.Location = new System.Drawing.Point(177, 926);
            this.materialUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialUpDown.Name = "materialUpDown";
            this.materialUpDown.ReadOnly = true;
            this.materialUpDown.Size = new System.Drawing.Size(488, 39);
            this.materialUpDown.TabIndex = 5;
            this.materialUpDown.Text = "Choose Material";
            this.materialUpDown.SelectedItemChanged += new System.EventHandler(this.materialUpDown_SelectedItemChanged);
            // 
            // rushOrderTextBox
            // 
            this.rushOrderTextBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrderTextBox.Items.Add("3");
            this.rushOrderTextBox.Items.Add("5");
            this.rushOrderTextBox.Items.Add("7");
            this.rushOrderTextBox.Items.Add("Normal");
            this.rushOrderTextBox.Location = new System.Drawing.Point(177, 1038);
            this.rushOrderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rushOrderTextBox.Name = "rushOrderTextBox";
            this.rushOrderTextBox.ReadOnly = true;
            this.rushOrderTextBox.Size = new System.Drawing.Size(488, 39);
            this.rushOrderTextBox.TabIndex = 6;
            this.rushOrderTextBox.Text = "Rush?";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaDesk_Barragan.Properties.Resources.pexels_karolina_grabowska_Quotes;
            this.ClientSize = new System.Drawing.Size(752, 1204);
            this.Controls.Add(this.rushOrderTextBox);
            this.Controls.Add(this.materialUpDown);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.submitQuote);
            this.Controls.Add(this.errorWidth);
            this.Controls.Add(this.errorDrawers);
            this.Controls.Add(this.errorDepth);
            this.Controls.Add(this.drawersTextBox);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(this.withTextBox);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.rush_Order);
            this.Controls.Add(this.desktop_Material);
            this.Controls.Add(this.number_Of_Drawers);
            this.Controls.Add(this.desk_Depth);
            this.Controls.Add(this.desk_Width);
            this.Controls.Add(this.customer_Name);
            this.Controls.Add(this.add_Quote);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_Quote;
        private System.Windows.Forms.Label customer_Name;
        private System.Windows.Forms.Label desk_Width;
        private System.Windows.Forms.Label desk_Depth;
        private System.Windows.Forms.Label number_Of_Drawers;
        private System.Windows.Forms.Label desktop_Material;
        private System.Windows.Forms.Label rush_Order;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.TextBox withTextBox;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.TextBox drawersTextBox;
        private System.Windows.Forms.Label errorDepth;
        private System.Windows.Forms.Label errorWidth;
        private System.Windows.Forms.Button submitQuote;
        private System.Windows.Forms.Label errorDrawers;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.DomainUpDown materialUpDown;
        private System.Windows.Forms.DomainUpDown rushOrderTextBox;
    }
}