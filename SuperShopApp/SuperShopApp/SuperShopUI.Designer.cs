namespace SuperShopApp
{
    partial class SuperShopUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showDetailButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameShopTextBox = new System.Windows.Forms.TextBox();
            this.addressShopTextBox = new System.Windows.Forms.TextBox();
            this.saveShopButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveShopButton);
            this.groupBox1.Controls.Add(this.addressShopTextBox);
            this.groupBox1.Controls.Add(this.nameShopTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(55, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shop Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addItemButton);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.productTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(59, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Information";
            // 
            // showDetailButton
            // 
            this.showDetailButton.Location = new System.Drawing.Point(193, 362);
            this.showDetailButton.Name = "showDetailButton";
            this.showDetailButton.Size = new System.Drawing.Size(162, 23);
            this.showDetailButton.TabIndex = 0;
            this.showDetailButton.Text = "Show Details";
            this.showDetailButton.UseVisualStyleBackColor = true;
            this.showDetailButton.Click += new System.EventHandler(this.showDetailButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // nameShopTextBox
            // 
            this.nameShopTextBox.Location = new System.Drawing.Point(109, 35);
            this.nameShopTextBox.Name = "nameShopTextBox";
            this.nameShopTextBox.Size = new System.Drawing.Size(261, 20);
            this.nameShopTextBox.TabIndex = 0;
            // 
            // addressShopTextBox
            // 
            this.addressShopTextBox.Location = new System.Drawing.Point(109, 75);
            this.addressShopTextBox.Name = "addressShopTextBox";
            this.addressShopTextBox.Size = new System.Drawing.Size(261, 20);
            this.addressShopTextBox.TabIndex = 1;
            // 
            // saveShopButton
            // 
            this.saveShopButton.Location = new System.Drawing.Point(295, 101);
            this.saveShopButton.Name = "saveShopButton";
            this.saveShopButton.Size = new System.Drawing.Size(75, 23);
            this.saveShopButton.TabIndex = 2;
            this.saveShopButton.Text = "Save";
            this.saveShopButton.UseVisualStyleBackColor = true;
            this.saveShopButton.Click += new System.EventHandler(this.saveShopButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(291, 97);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(105, 71);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(261, 20);
            this.quantityTextBox.TabIndex = 1;
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(105, 31);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(261, 20);
            this.productTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product/Item";
            // 
            // SuperShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 416);
            this.Controls.Add(this.showDetailButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SuperShopUI";
            this.Text = "SuperShopUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button showDetailButton;
        private System.Windows.Forms.Button saveShopButton;
        private System.Windows.Forms.TextBox addressShopTextBox;
        private System.Windows.Forms.TextBox nameShopTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

