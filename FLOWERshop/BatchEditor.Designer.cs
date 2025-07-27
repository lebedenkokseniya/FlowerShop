namespace FLOWERshop
{
    partial class BatchEditor
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
            this.textBox_quantityReserved = new System.Windows.Forms.TextBox();
            this.textBox_quantitySold = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_supply = new System.Windows.Forms.ComboBox();
            this.supplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowerShopDataSet = new FLOWERshop.FlowerShopDataSet();
            this.comboBox_plant = new System.Windows.Forms.ComboBox();
            this.plantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.SupplyTableAdapter();
            this.plantTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.PlantTableAdapter();
            this.batchTableAdapter1 = new FLOWERshop.FlowerShopDataSetTableAdapters.BatchTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 59);
            this.button2.TabIndex = 67;
            this.button2.Text = "Зберегти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_quantityReserved
            // 
            this.textBox_quantityReserved.Location = new System.Drawing.Point(335, 250);
            this.textBox_quantityReserved.Name = "textBox_quantityReserved";
            this.textBox_quantityReserved.Size = new System.Drawing.Size(318, 26);
            this.textBox_quantityReserved.TabIndex = 64;
            // 
            // textBox_quantitySold
            // 
            this.textBox_quantitySold.Location = new System.Drawing.Point(335, 210);
            this.textBox_quantitySold.Name = "textBox_quantitySold";
            this.textBox_quantitySold.Size = new System.Drawing.Size(318, 26);
            this.textBox_quantitySold.TabIndex = 63;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(335, 169);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(318, 26);
            this.textBox_price.TabIndex = 62;
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(335, 127);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(318, 26);
            this.textBox_amount.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "Рослина";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "Поставка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Кількість зарезервованих";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Кількість проданих";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Загальна ціна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Кількість рослини";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(285, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 40);
            this.label1.TabIndex = 54;
            this.label1.Text = "Партія";
            // 
            // comboBox_supply
            // 
            this.comboBox_supply.DataSource = this.supplyBindingSource;
            this.comboBox_supply.DisplayMember = "invoice_number";
            this.comboBox_supply.FormattingEnabled = true;
            this.comboBox_supply.Location = new System.Drawing.Point(335, 296);
            this.comboBox_supply.Name = "comboBox_supply";
            this.comboBox_supply.Size = new System.Drawing.Size(318, 28);
            this.comboBox_supply.TabIndex = 68;
            this.comboBox_supply.ValueMember = "supply_id";
            // 
            // supplyBindingSource
            // 
            this.supplyBindingSource.DataMember = "Supply";
            this.supplyBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // flowerShopDataSet
            // 
            this.flowerShopDataSet.DataSetName = "FlowerShopDataSet";
            this.flowerShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_plant
            // 
            this.comboBox_plant.DataSource = this.plantBindingSource;
            this.comboBox_plant.DisplayMember = "plant_name";
            this.comboBox_plant.FormattingEnabled = true;
            this.comboBox_plant.Location = new System.Drawing.Point(335, 338);
            this.comboBox_plant.Name = "comboBox_plant";
            this.comboBox_plant.Size = new System.Drawing.Size(318, 28);
            this.comboBox_plant.TabIndex = 69;
            this.comboBox_plant.ValueMember = "plant_id";
            // 
            // plantBindingSource
            // 
            this.plantBindingSource.DataMember = "Plant";
            this.plantBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // supplyTableAdapter
            // 
            this.supplyTableAdapter.ClearBeforeFill = true;
            // 
            // plantTableAdapter
            // 
            this.plantTableAdapter.ClearBeforeFill = true;
            // 
            // batchTableAdapter1
            // 
            this.batchTableAdapter1.ClearBeforeFill = true;
            // 
            // BatchEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 508);
            this.Controls.Add(this.comboBox_plant);
            this.Controls.Add(this.comboBox_supply);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_quantityReserved);
            this.Controls.Add(this.textBox_quantitySold);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BatchEditor";
            this.Text = "BatchEditor";
            this.Load += new System.EventHandler(this.BatchEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_quantityReserved;
        private System.Windows.Forms.TextBox textBox_quantitySold;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_supply;
        private System.Windows.Forms.ComboBox comboBox_plant;
        private FlowerShopDataSet flowerShopDataSet;
        private System.Windows.Forms.BindingSource supplyBindingSource;
        private FlowerShopDataSetTableAdapters.SupplyTableAdapter supplyTableAdapter;
        private System.Windows.Forms.BindingSource plantBindingSource;
        private FlowerShopDataSetTableAdapters.PlantTableAdapter plantTableAdapter;
        private FlowerShopDataSetTableAdapters.BatchTableAdapter batchTableAdapter1;
    }
}