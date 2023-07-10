namespace WindowsFormsApp5
{
    partial class frmbilligdetails
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTypeofproduct = new System.Windows.Forms.TextBox();
            this.txtSizeofgoods = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCustomerOrder = new System.Windows.Forms.DataGridView();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnCalculatetotal = new System.Windows.Forms.Button();
            this.btnGenerateReceipt = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(177, 43);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(247, 26);
            this.txtPrice.TabIndex = 0;
            // 
            // txtTypeofproduct
            // 
            this.txtTypeofproduct.Location = new System.Drawing.Point(177, 193);
            this.txtTypeofproduct.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTypeofproduct.Name = "txtTypeofproduct";
            this.txtTypeofproduct.Size = new System.Drawing.Size(247, 26);
            this.txtTypeofproduct.TabIndex = 3;
            // 
            // txtSizeofgoods
            // 
            this.txtSizeofgoods.Location = new System.Drawing.Point(177, 111);
            this.txtSizeofgoods.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSizeofgoods.Name = "txtSizeofgoods";
            this.txtSizeofgoods.Size = new System.Drawing.Size(247, 26);
            this.txtSizeofgoods.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(2, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "YOUR PRICE.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(2, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "THE QUANTITY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(2, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "YOUR PRODUCT";
            // 
            // dgvCustomerOrder
            // 
            this.dgvCustomerOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerOrder.Location = new System.Drawing.Point(434, 14);
            this.dgvCustomerOrder.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvCustomerOrder.Name = "dgvCustomerOrder";
            this.dgvCustomerOrder.Size = new System.Drawing.Size(336, 236);
            this.dgvCustomerOrder.TabIndex = 10;
            // 
            // btnAddItems
            // 
            this.btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddItems.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddItems.Location = new System.Drawing.Point(434, 268);
            this.btnAddItems.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(122, 57);
            this.btnAddItems.TabIndex = 11;
            this.btnAddItems.Text = "Add Items.";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnCalculatetotal
            // 
            this.btnCalculatetotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculatetotal.ForeColor = System.Drawing.Color.Maroon;
            this.btnCalculatetotal.Location = new System.Drawing.Point(578, 268);
            this.btnCalculatetotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCalculatetotal.Name = "btnCalculatetotal";
            this.btnCalculatetotal.Size = new System.Drawing.Size(121, 57);
            this.btnCalculatetotal.TabIndex = 12;
            this.btnCalculatetotal.Text = "Calculate Total.";
            this.btnCalculatetotal.UseVisualStyleBackColor = true;
            this.btnCalculatetotal.Click += new System.EventHandler(this.btnCalculatetotal_Click);
            // 
            // btnGenerateReceipt
            // 
            this.btnGenerateReceipt.BackColor = System.Drawing.Color.IndianRed;
            this.btnGenerateReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateReceipt.ForeColor = System.Drawing.Color.Maroon;
            this.btnGenerateReceipt.Location = new System.Drawing.Point(478, 357);
            this.btnGenerateReceipt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGenerateReceipt.Name = "btnGenerateReceipt";
            this.btnGenerateReceipt.Size = new System.Drawing.Size(183, 72);
            this.btnGenerateReceipt.TabIndex = 13;
            this.btnGenerateReceipt.Text = "Generate Receipt.";
            this.btnGenerateReceipt.UseVisualStyleBackColor = false;
            this.btnGenerateReceipt.Click += new System.EventHandler(this.btnGenerateReceipt_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(6, 268);
            this.txttotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(401, 26);
            this.txttotal.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(14, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "TOTAL";
            // 
            // frmbilligdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.Logos_King;
            this.ClientSize = new System.Drawing.Size(794, 472);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btnGenerateReceipt);
            this.Controls.Add(this.btnCalculatetotal);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.dgvCustomerOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSizeofgoods);
            this.Controls.Add(this.txtTypeofproduct);
            this.Controls.Add(this.txtPrice);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmbilligdetails";
            this.Text = "BILLING DETAILS.";
            this.Load += new System.EventHandler(this.frmbilligdetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTypeofproduct;
        private System.Windows.Forms.TextBox txtSizeofgoods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCustomerOrder;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnCalculatetotal;
        private System.Windows.Forms.Button btnGenerateReceipt;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label4;
    }
}