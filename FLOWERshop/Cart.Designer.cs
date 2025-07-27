namespace FLOWERshop
{
    partial class Cart
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
            this.orderitemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedplantsamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedplantspriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderitemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowerShopDataSet = new FLOWERshop.FlowerShopDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.plantidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantimageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantheightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantwidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planttypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowercoloridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.orderidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_accept = new System.Windows.Forms.Button();
            this.order_itemTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.Order_itemTableAdapter();
            this.plantTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.PlantTableAdapter();
            this.orderTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.OrderTableAdapter();
            this.userTableAdapter1 = new FLOWERshop.FlowerShopDataSetTableAdapters.UserTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderitemidDataGridViewTextBoxColumn,
            this.orderidDataGridViewTextBoxColumn,
            this.plantidDataGridViewTextBoxColumn,
            this.orderedplantsamountDataGridViewTextBoxColumn,
            this.orderedplantspriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderitemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(219, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderitemidDataGridViewTextBoxColumn
            // 
            this.orderitemidDataGridViewTextBoxColumn.DataPropertyName = "order_item_id";
            this.orderitemidDataGridViewTextBoxColumn.HeaderText = "order_item_id";
            this.orderitemidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderitemidDataGridViewTextBoxColumn.Name = "orderitemidDataGridViewTextBoxColumn";
            this.orderitemidDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderitemidDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "order_id";
            this.orderidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantidDataGridViewTextBoxColumn
            // 
            this.plantidDataGridViewTextBoxColumn.DataPropertyName = "plant_id";
            this.plantidDataGridViewTextBoxColumn.HeaderText = "plant_id";
            this.plantidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantidDataGridViewTextBoxColumn.Name = "plantidDataGridViewTextBoxColumn";
            this.plantidDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderedplantsamountDataGridViewTextBoxColumn
            // 
            this.orderedplantsamountDataGridViewTextBoxColumn.DataPropertyName = "ordered_plants_amount";
            this.orderedplantsamountDataGridViewTextBoxColumn.HeaderText = "ordered_plants_amount";
            this.orderedplantsamountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderedplantsamountDataGridViewTextBoxColumn.Name = "orderedplantsamountDataGridViewTextBoxColumn";
            this.orderedplantsamountDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderedplantspriceDataGridViewTextBoxColumn
            // 
            this.orderedplantspriceDataGridViewTextBoxColumn.DataPropertyName = "ordered_plants_price";
            this.orderedplantspriceDataGridViewTextBoxColumn.HeaderText = "ordered_plants_price";
            this.orderedplantspriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderedplantspriceDataGridViewTextBoxColumn.Name = "orderedplantspriceDataGridViewTextBoxColumn";
            this.orderedplantspriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderitemBindingSource
            // 
            this.orderitemBindingSource.DataMember = "Order_item";
            this.orderitemBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // flowerShopDataSet
            // 
            this.flowerShopDataSet.DataSetName = "FlowerShopDataSet";
            this.flowerShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plantidDataGridViewTextBoxColumn1,
            this.plantnameDataGridViewTextBoxColumn,
            this.plantdescriptionDataGridViewTextBoxColumn,
            this.plantimageDataGridViewTextBoxColumn,
            this.plantpriceDataGridViewTextBoxColumn,
            this.plantamountDataGridViewTextBoxColumn,
            this.plantheightDataGridViewTextBoxColumn,
            this.plantwidthDataGridViewTextBoxColumn,
            this.plantweightDataGridViewTextBoxColumn,
            this.categoryidDataGridViewTextBoxColumn,
            this.materialidDataGridViewTextBoxColumn,
            this.planttypeidDataGridViewTextBoxColumn,
            this.flowercoloridDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.plantBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(135, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(741, 360);
            this.dataGridView2.TabIndex = 1;
            // 
            // plantidDataGridViewTextBoxColumn1
            // 
            this.plantidDataGridViewTextBoxColumn1.DataPropertyName = "plant_id";
            this.plantidDataGridViewTextBoxColumn1.HeaderText = "plant_id";
            this.plantidDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.plantidDataGridViewTextBoxColumn1.Name = "plantidDataGridViewTextBoxColumn1";
            this.plantidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.plantidDataGridViewTextBoxColumn1.Width = 150;
            // 
            // plantnameDataGridViewTextBoxColumn
            // 
            this.plantnameDataGridViewTextBoxColumn.DataPropertyName = "plant_name";
            this.plantnameDataGridViewTextBoxColumn.HeaderText = "plant_name";
            this.plantnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantnameDataGridViewTextBoxColumn.Name = "plantnameDataGridViewTextBoxColumn";
            this.plantnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantdescriptionDataGridViewTextBoxColumn
            // 
            this.plantdescriptionDataGridViewTextBoxColumn.DataPropertyName = "plant_description";
            this.plantdescriptionDataGridViewTextBoxColumn.HeaderText = "plant_description";
            this.plantdescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantdescriptionDataGridViewTextBoxColumn.Name = "plantdescriptionDataGridViewTextBoxColumn";
            this.plantdescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantimageDataGridViewTextBoxColumn
            // 
            this.plantimageDataGridViewTextBoxColumn.DataPropertyName = "plant_image";
            this.plantimageDataGridViewTextBoxColumn.HeaderText = "plant_image";
            this.plantimageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantimageDataGridViewTextBoxColumn.Name = "plantimageDataGridViewTextBoxColumn";
            this.plantimageDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantpriceDataGridViewTextBoxColumn
            // 
            this.plantpriceDataGridViewTextBoxColumn.DataPropertyName = "plant_price";
            this.plantpriceDataGridViewTextBoxColumn.HeaderText = "plant_price";
            this.plantpriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantpriceDataGridViewTextBoxColumn.Name = "plantpriceDataGridViewTextBoxColumn";
            this.plantpriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantamountDataGridViewTextBoxColumn
            // 
            this.plantamountDataGridViewTextBoxColumn.DataPropertyName = "plant_amount";
            this.plantamountDataGridViewTextBoxColumn.HeaderText = "plant_amount";
            this.plantamountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantamountDataGridViewTextBoxColumn.Name = "plantamountDataGridViewTextBoxColumn";
            this.plantamountDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantheightDataGridViewTextBoxColumn
            // 
            this.plantheightDataGridViewTextBoxColumn.DataPropertyName = "plant_height";
            this.plantheightDataGridViewTextBoxColumn.HeaderText = "plant_height";
            this.plantheightDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantheightDataGridViewTextBoxColumn.Name = "plantheightDataGridViewTextBoxColumn";
            this.plantheightDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantwidthDataGridViewTextBoxColumn
            // 
            this.plantwidthDataGridViewTextBoxColumn.DataPropertyName = "plant_width";
            this.plantwidthDataGridViewTextBoxColumn.HeaderText = "plant_width";
            this.plantwidthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantwidthDataGridViewTextBoxColumn.Name = "plantwidthDataGridViewTextBoxColumn";
            this.plantwidthDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantweightDataGridViewTextBoxColumn
            // 
            this.plantweightDataGridViewTextBoxColumn.DataPropertyName = "plant_weight";
            this.plantweightDataGridViewTextBoxColumn.HeaderText = "plant_weight";
            this.plantweightDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantweightDataGridViewTextBoxColumn.Name = "plantweightDataGridViewTextBoxColumn";
            this.plantweightDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "category_id";
            this.categoryidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            this.categoryidDataGridViewTextBoxColumn.Width = 150;
            // 
            // materialidDataGridViewTextBoxColumn
            // 
            this.materialidDataGridViewTextBoxColumn.DataPropertyName = "material_id";
            this.materialidDataGridViewTextBoxColumn.HeaderText = "material_id";
            this.materialidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.materialidDataGridViewTextBoxColumn.Name = "materialidDataGridViewTextBoxColumn";
            this.materialidDataGridViewTextBoxColumn.Width = 150;
            // 
            // planttypeidDataGridViewTextBoxColumn
            // 
            this.planttypeidDataGridViewTextBoxColumn.DataPropertyName = "plant_type_id";
            this.planttypeidDataGridViewTextBoxColumn.HeaderText = "plant_type_id";
            this.planttypeidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.planttypeidDataGridViewTextBoxColumn.Name = "planttypeidDataGridViewTextBoxColumn";
            this.planttypeidDataGridViewTextBoxColumn.Width = 150;
            // 
            // flowercoloridDataGridViewTextBoxColumn
            // 
            this.flowercoloridDataGridViewTextBoxColumn.DataPropertyName = "flower_color_id";
            this.flowercoloridDataGridViewTextBoxColumn.HeaderText = "flower_color_id";
            this.flowercoloridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.flowercoloridDataGridViewTextBoxColumn.Name = "flowercoloridDataGridViewTextBoxColumn";
            this.flowercoloridDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantBindingSource
            // 
            this.plantBindingSource.DataMember = "Plant";
            this.plantBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn1,
            this.orderdateDataGridViewTextBoxColumn,
            this.orderpriceDataGridViewTextBoxColumn,
            this.orderstatusDataGridViewTextBoxColumn,
            this.deliveryaddressDataGridViewTextBoxColumn,
            this.paymenttypeDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.orderBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 420);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(246, 105);
            this.dataGridView3.TabIndex = 3;
            // 
            // orderidDataGridViewTextBoxColumn1
            // 
            this.orderidDataGridViewTextBoxColumn1.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn1.HeaderText = "order_id";
            this.orderidDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.orderidDataGridViewTextBoxColumn1.Name = "orderidDataGridViewTextBoxColumn1";
            this.orderidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orderidDataGridViewTextBoxColumn1.Width = 150;
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "order_date";
            this.orderdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            this.orderdateDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderpriceDataGridViewTextBoxColumn
            // 
            this.orderpriceDataGridViewTextBoxColumn.DataPropertyName = "order_price";
            this.orderpriceDataGridViewTextBoxColumn.HeaderText = "order_price";
            this.orderpriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderpriceDataGridViewTextBoxColumn.Name = "orderpriceDataGridViewTextBoxColumn";
            this.orderpriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderstatusDataGridViewTextBoxColumn
            // 
            this.orderstatusDataGridViewTextBoxColumn.DataPropertyName = "order_status";
            this.orderstatusDataGridViewTextBoxColumn.HeaderText = "order_status";
            this.orderstatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderstatusDataGridViewTextBoxColumn.Name = "orderstatusDataGridViewTextBoxColumn";
            this.orderstatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // deliveryaddressDataGridViewTextBoxColumn
            // 
            this.deliveryaddressDataGridViewTextBoxColumn.DataPropertyName = "delivery_address";
            this.deliveryaddressDataGridViewTextBoxColumn.HeaderText = "delivery_address";
            this.deliveryaddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deliveryaddressDataGridViewTextBoxColumn.Name = "deliveryaddressDataGridViewTextBoxColumn";
            this.deliveryaddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // paymenttypeDataGridViewTextBoxColumn
            // 
            this.paymenttypeDataGridViewTextBoxColumn.DataPropertyName = "payment_type";
            this.paymenttypeDataGridViewTextBoxColumn.HeaderText = "payment_type";
            this.paymenttypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.paymenttypeDataGridViewTextBoxColumn.Name = "paymenttypeDataGridViewTextBoxColumn";
            this.paymenttypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // button_accept
            // 
            this.button_accept.Location = new System.Drawing.Point(621, 420);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(255, 105);
            this.button_accept.TabIndex = 4;
            this.button_accept.Text = "Оформити замовлення";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button1_Click);
            // 
            // order_itemTableAdapter
            // 
            this.order_itemTableAdapter.ClearBeforeFill = true;
            // 
            // plantTableAdapter
            // 
            this.plantTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Змінити кількість";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "Видалити товар";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 569);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button_accept;
        private FlowerShopDataSet flowerShopDataSet;
        private System.Windows.Forms.BindingSource orderitemBindingSource;
        private FlowerShopDataSetTableAdapters.Order_itemTableAdapter order_itemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderitemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderedplantsamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderedplantspriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource plantBindingSource;
        private FlowerShopDataSetTableAdapters.PlantTableAdapter plantTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantimageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantheightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantwidthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planttypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowercoloridDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private FlowerShopDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private FlowerShopDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}