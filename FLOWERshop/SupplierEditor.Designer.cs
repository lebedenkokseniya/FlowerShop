namespace FLOWERshop
{
    partial class SupplierEditor
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_physicalAddress = new System.Windows.Forms.TextBox();
            this.textBox_legalAddress = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_contactPerson = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.supplierTableAdapter1 = new FLOWERshop.FlowerShopDataSetTableAdapters.SupplierTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flowerShopDataSet1 = new FLOWERshop.FlowerShopDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 59);
            this.button2.TabIndex = 53;
            this.button2.Text = "Зберегти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_physicalAddress
            // 
            this.textBox_physicalAddress.Location = new System.Drawing.Point(345, 346);
            this.textBox_physicalAddress.Name = "textBox_physicalAddress";
            this.textBox_physicalAddress.Size = new System.Drawing.Size(318, 26);
            this.textBox_physicalAddress.TabIndex = 47;
            // 
            // textBox_legalAddress
            // 
            this.textBox_legalAddress.Location = new System.Drawing.Point(345, 304);
            this.textBox_legalAddress.Name = "textBox_legalAddress";
            this.textBox_legalAddress.Size = new System.Drawing.Size(318, 26);
            this.textBox_legalAddress.TabIndex = 46;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(345, 261);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(318, 26);
            this.textBox_email.TabIndex = 45;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(345, 221);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(318, 26);
            this.textBox_phone.TabIndex = 44;
            // 
            // textBox_contactPerson
            // 
            this.textBox_contactPerson.Location = new System.Drawing.Point(345, 180);
            this.textBox_contactPerson.Name = "textBox_contactPerson";
            this.textBox_contactPerson.Size = new System.Drawing.Size(318, 26);
            this.textBox_contactPerson.TabIndex = 42;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(345, 138);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(318, 26);
            this.textBox_name.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Фізична адреса";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Юридична адреса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Електронна адреса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Номер телефону";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Контактна особа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Назва";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(236, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 40);
            this.label1.TabIndex = 28;
            this.label1.Text = "Постачальник";
            // 
            // supplierTableAdapter1
            // 
            this.supplierTableAdapter1.ClearBeforeFill = true;
            // 
            // flowerShopDataSet1
            // 
            this.flowerShopDataSet1.DataSetName = "FlowerShopDataSet";
            this.flowerShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SupplierEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 537);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_physicalAddress);
            this.Controls.Add(this.textBox_legalAddress);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_contactPerson);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SupplierEditor";
            this.Text = "SupplierEditor";
            this.Load += new System.EventHandler(this.SupplierEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_physicalAddress;
        private System.Windows.Forms.TextBox textBox_legalAddress;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_contactPerson;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private FlowerShopDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter1;
        private FlowerShopDataSet flowerShopDataSet1;
    }
}