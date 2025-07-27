namespace FLOWERshop
{
    partial class OrderDetails
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowerShopDataSet = new FLOWERshop.FlowerShopDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.CategoryTableAdapter();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.MaterialTableAdapter();
            this.flowerColorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowerColorTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.FlowerColorTableAdapter();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.OrderTableAdapter();
            this.orderitemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_itemTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.Order_itemTableAdapter();
            this.plantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.PlantTableAdapter();
            this.plantTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantTypeTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.PlantTypeTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerColorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(701, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // flowerShopDataSet
            // 
            this.flowerShopDataSet.DataSetName = "FlowerShopDataSet";
            this.flowerShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // flowerColorBindingSource
            // 
            this.flowerColorBindingSource.DataMember = "FlowerColor";
            this.flowerColorBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // flowerColorTableAdapter
            // 
            this.flowerColorTableAdapter.ClearBeforeFill = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // orderitemBindingSource
            // 
            this.orderitemBindingSource.DataMember = "Order_item";
            this.orderitemBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // order_itemTableAdapter
            // 
            this.order_itemTableAdapter.ClearBeforeFill = true;
            // 
            // plantBindingSource
            // 
            this.plantBindingSource.DataMember = "Plant";
            this.plantBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // plantTableAdapter
            // 
            this.plantTableAdapter.ClearBeforeFill = true;
            // 
            // plantTypeBindingSource
            // 
            this.plantTypeBindingSource.DataMember = "PlantType";
            this.plantTypeBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // plantTypeTableAdapter
            // 
            this.plantTypeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(730, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(861, 388);
            this.dataGridView2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(966, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 54);
            this.button3.TabIndex = 8;
            this.button3.Text = "Видалити";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "Редагувати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 537);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            this.Load += new System.EventHandler(this.OrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerColorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FlowerShopDataSet flowerShopDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private FlowerShopDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private FlowerShopDataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.BindingSource flowerColorBindingSource;
        private FlowerShopDataSetTableAdapters.FlowerColorTableAdapter flowerColorTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private FlowerShopDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource orderitemBindingSource;
        private FlowerShopDataSetTableAdapters.Order_itemTableAdapter order_itemTableAdapter;
        private System.Windows.Forms.BindingSource plantBindingSource;
        private FlowerShopDataSetTableAdapters.PlantTableAdapter plantTableAdapter;
        private System.Windows.Forms.BindingSource plantTypeBindingSource;
        private FlowerShopDataSetTableAdapters.PlantTypeTableAdapter plantTypeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}