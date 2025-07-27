namespace FLOWERshop
{
    partial class OrderItemEditor
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
            this.comboBox_order = new System.Windows.Forms.ComboBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowerShopDataSet = new FLOWERshop.FlowerShopDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox_plant = new System.Windows.Forms.ComboBox();
            this.plantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.OrderTableAdapter();
            this.plantTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.PlantTableAdapter();
            this.order_itemTableAdapter1 = new FLOWERshop.FlowerShopDataSetTableAdapters.Order_itemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_order
            // 
            this.comboBox_order.DataSource = this.orderBindingSource;
            this.comboBox_order.DisplayMember = "order_id";
            this.comboBox_order.FormattingEnabled = true;
            this.comboBox_order.Location = new System.Drawing.Point(303, 132);
            this.comboBox_order.Name = "comboBox_order";
            this.comboBox_order.Size = new System.Drawing.Size(318, 28);
            this.comboBox_order.TabIndex = 86;
            this.comboBox_order.ValueMember = "order_id";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // flowerShopDataSet
            // 
            this.flowerShopDataSet.DataSetName = "FlowerShopDataSet";
            this.flowerShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 59);
            this.button2.TabIndex = 83;
            this.button2.Text = "Зберегти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox_plant
            // 
            this.comboBox_plant.DataSource = this.plantBindingSource;
            this.comboBox_plant.DisplayMember = "plant_name";
            this.comboBox_plant.FormattingEnabled = true;
            this.comboBox_plant.Location = new System.Drawing.Point(303, 174);
            this.comboBox_plant.Name = "comboBox_plant";
            this.comboBox_plant.Size = new System.Drawing.Size(318, 28);
            this.comboBox_plant.TabIndex = 82;
            this.comboBox_plant.ValueMember = "plant_id";
            // 
            // plantBindingSource
            // 
            this.plantBindingSource.DataMember = "Plant";
            this.plantBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(303, 221);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(318, 26);
            this.textBox_amount.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 79;
            this.label10.Text = "Рослина";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 40);
            this.label5.TabIndex = 77;
            this.label5.Text = "Кількість\r\nзамовленої рослини";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Замовлення";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(157, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 40);
            this.label1.TabIndex = 74;
            this.label1.Text = "Елемент замовлення";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(303, 273);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(318, 26);
            this.textBox_price.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Сума";
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // plantTableAdapter
            // 
            this.plantTableAdapter.ClearBeforeFill = true;
            // 
            // order_itemTableAdapter1
            // 
            this.order_itemTableAdapter1.ClearBeforeFill = true;
            // 
            // OrderItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 448);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_order);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox_plant);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "OrderItemEditor";
            this.Text = "OrderItemEditor";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_order;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox_plant;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label2;
        private FlowerShopDataSet flowerShopDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private FlowerShopDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource plantBindingSource;
        private FlowerShopDataSetTableAdapters.PlantTableAdapter plantTableAdapter;
        private FlowerShopDataSetTableAdapters.Order_itemTableAdapter order_itemTableAdapter1;
    }
}