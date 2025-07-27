namespace FLOWERshop
{
    partial class SupplyEditor
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
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.textBox_invoiceNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.comboBox_supplier = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowerShopDataSet = new FLOWERshop.FlowerShopDataSet();
            this.dateTimePicker_deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_supplyDate = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.supplierTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.SupplierTableAdapter();
            this.supplyTableAdapter1 = new FLOWERshop.FlowerShopDataSetTableAdapters.SupplyTableAdapter();
            this.plantTableAdapter1 = new FLOWERshop.FlowerShopDataSetTableAdapters.PlantTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 59);
            this.button2.TabIndex = 67;
            this.button2.Text = "Зберегти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(366, 189);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(318, 26);
            this.textBox_amount.TabIndex = 62;
            // 
            // textBox_invoiceNumber
            // 
            this.textBox_invoiceNumber.Location = new System.Drawing.Point(366, 147);
            this.textBox_invoiceNumber.Name = "textBox_invoiceNumber";
            this.textBox_invoiceNumber.Size = new System.Drawing.Size(318, 26);
            this.textBox_invoiceNumber.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "Постачальник";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "Статус поставки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Дата доставки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Дата оформлення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "КІлькість рослин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Номер накладної";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(286, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 40);
            this.label1.TabIndex = 54;
            this.label1.Text = "Поставка";
            // 
            // comboBox_status
            // 
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "Доставлено",
            "Очікується",
            "Скасовано"});
            this.comboBox_status.Location = new System.Drawing.Point(366, 313);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(318, 28);
            this.comboBox_status.TabIndex = 68;
            // 
            // comboBox_supplier
            // 
            this.comboBox_supplier.DataSource = this.supplierBindingSource;
            this.comboBox_supplier.DisplayMember = "supplier_name";
            this.comboBox_supplier.FormattingEnabled = true;
            this.comboBox_supplier.Location = new System.Drawing.Point(366, 358);
            this.comboBox_supplier.Name = "comboBox_supplier";
            this.comboBox_supplier.Size = new System.Drawing.Size(318, 28);
            this.comboBox_supplier.TabIndex = 69;
            this.comboBox_supplier.ValueMember = "supplier_id";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // flowerShopDataSet
            // 
            this.flowerShopDataSet.DataSetName = "FlowerShopDataSet";
            this.flowerShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker_deliveryDate
            // 
            this.dateTimePicker_deliveryDate.Location = new System.Drawing.Point(366, 276);
            this.dateTimePicker_deliveryDate.Name = "dateTimePicker_deliveryDate";
            this.dateTimePicker_deliveryDate.Size = new System.Drawing.Size(318, 26);
            this.dateTimePicker_deliveryDate.TabIndex = 70;
            this.dateTimePicker_deliveryDate.Value = new System.DateTime(2024, 12, 26, 0, 0, 0, 0);
            // 
            // dateTimePicker_supplyDate
            // 
            this.dateTimePicker_supplyDate.Location = new System.Drawing.Point(366, 233);
            this.dateTimePicker_supplyDate.Name = "dateTimePicker_supplyDate";
            this.dateTimePicker_supplyDate.Size = new System.Drawing.Size(318, 26);
            this.dateTimePicker_supplyDate.TabIndex = 71;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(366, 278);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(204, 24);
            this.checkBox1.TabIndex = 72;
            this.checkBox1.Text = "Поставка доставлена";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // supplyTableAdapter1
            // 
            this.supplyTableAdapter1.ClearBeforeFill = true;
            // 
            // plantTableAdapter1
            // 
            this.plantTableAdapter1.ClearBeforeFill = true;
            // 
            // SupplyEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 530);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker_supplyDate);
            this.Controls.Add(this.dateTimePicker_deliveryDate);
            this.Controls.Add(this.comboBox_supplier);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.textBox_invoiceNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SupplyEditor";
            this.Text = "SupplyEditor";
            this.Load += new System.EventHandler(this.SupplyEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.TextBox textBox_invoiceNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.ComboBox comboBox_supplier;
        private System.Windows.Forms.DateTimePicker dateTimePicker_supplyDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_deliveryDate;
        private System.Windows.Forms.CheckBox checkBox1;
        private FlowerShopDataSet flowerShopDataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private FlowerShopDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private FlowerShopDataSetTableAdapters.SupplyTableAdapter supplyTableAdapter1;
        private FlowerShopDataSetTableAdapters.PlantTableAdapter plantTableAdapter1;
    }
}