namespace FLOWERshop
{
    partial class Catalogue
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.кошикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.plantidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.flowerShopDataSet = new FLOWERshop.FlowerShopDataSet();
            this.plantTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.PlantTableAdapter();
            this.userTableAdapter1 = new FLOWERshop.FlowerShopDataSetTableAdapters.UserTableAdapter();
            this.orderTableAdapter1 = new FLOWERshop.FlowerShopDataSetTableAdapters.OrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plantidDataGridViewTextBoxColumn,
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
            this.dataGridView1.DataSource = this.plantBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(967, 407);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Додати до кошика";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кошикToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // кошикToolStripMenuItem
            // 
            this.кошикToolStripMenuItem.Name = "кошикToolStripMenuItem";
            this.кошикToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.кошикToolStripMenuItem.Text = "Кошик";
            this.кошикToolStripMenuItem.Click += new System.EventHandler(this.кошикToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Немає",
            "За ціною (спадання)",
            "За ціною (зростання)",
            "В алфавітному порядку (назва)",
            "За висотою (спадання)",
            "За висотою (зростання)",
            "За вагою (спадання)",
            "За вагою (зростання)"});
            this.comboBox1.Location = new System.Drawing.Point(572, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Сортувати";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(797, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Застосувати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Колір: Червоні",
            "Рожеві",
            "Білі",
            "Жовті",
            "Фіолетові",
            "Помаранчеві",
            "Сині",
            "Не цвіте",
            "Матеріал: Пластик",
            "Метал",
            "Фоамін",
            "Шовк",
            "Категорія: Штучні квіти в горщиках",
            "Штучні квіти поштучно",
            "Букети штучних квітів",
            "Штучні квіти на стіну",
            "Квіти для двору",
            "Квіти підвісні",
            "Тип рослини: Квітучі",
            "Листяні",
            "Пальми",
            "Плодові",
            "Кактуси",
            "Ліани"});
            this.checkedListBox1.Location = new System.Drawing.Point(336, 45);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(328, 487);
            this.checkedListBox1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(507, 472);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Підтвердити";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(350, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 26);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Фільтрувати";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(507, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 37);
            this.button4.TabIndex = 10;
            this.button4.Text = "Скасувати";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // plantidDataGridViewTextBoxColumn
            // 
            this.plantidDataGridViewTextBoxColumn.DataPropertyName = "plant_id";
            this.plantidDataGridViewTextBoxColumn.HeaderText = "plant_id";
            this.plantidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantidDataGridViewTextBoxColumn.Name = "plantidDataGridViewTextBoxColumn";
            this.plantidDataGridViewTextBoxColumn.ReadOnly = true;
            this.plantidDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantnameDataGridViewTextBoxColumn
            // 
            this.plantnameDataGridViewTextBoxColumn.DataPropertyName = "plant_name";
            this.plantnameDataGridViewTextBoxColumn.HeaderText = "plant_name";
            this.plantnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantnameDataGridViewTextBoxColumn.Name = "plantnameDataGridViewTextBoxColumn";
            this.plantnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.plantnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantdescriptionDataGridViewTextBoxColumn
            // 
            this.plantdescriptionDataGridViewTextBoxColumn.DataPropertyName = "plant_description";
            this.plantdescriptionDataGridViewTextBoxColumn.HeaderText = "plant_description";
            this.plantdescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantdescriptionDataGridViewTextBoxColumn.Name = "plantdescriptionDataGridViewTextBoxColumn";
            this.plantdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.plantdescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantimageDataGridViewTextBoxColumn
            // 
            this.plantimageDataGridViewTextBoxColumn.DataPropertyName = "plant_image";
            this.plantimageDataGridViewTextBoxColumn.HeaderText = "plant_image";
            this.plantimageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantimageDataGridViewTextBoxColumn.Name = "plantimageDataGridViewTextBoxColumn";
            this.plantimageDataGridViewTextBoxColumn.ReadOnly = true;
            this.plantimageDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantpriceDataGridViewTextBoxColumn
            // 
            this.plantpriceDataGridViewTextBoxColumn.DataPropertyName = "plant_price";
            this.plantpriceDataGridViewTextBoxColumn.HeaderText = "plant_price";
            this.plantpriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantpriceDataGridViewTextBoxColumn.Name = "plantpriceDataGridViewTextBoxColumn";
            this.plantpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.plantpriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantamountDataGridViewTextBoxColumn
            // 
            this.plantamountDataGridViewTextBoxColumn.DataPropertyName = "plant_amount";
            this.plantamountDataGridViewTextBoxColumn.HeaderText = "plant_amount";
            this.plantamountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantamountDataGridViewTextBoxColumn.Name = "plantamountDataGridViewTextBoxColumn";
            this.plantamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.plantamountDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantheightDataGridViewTextBoxColumn
            // 
            this.plantheightDataGridViewTextBoxColumn.DataPropertyName = "plant_height";
            this.plantheightDataGridViewTextBoxColumn.HeaderText = "plant_height";
            this.plantheightDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantheightDataGridViewTextBoxColumn.Name = "plantheightDataGridViewTextBoxColumn";
            this.plantheightDataGridViewTextBoxColumn.ReadOnly = true;
            this.plantheightDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantwidthDataGridViewTextBoxColumn
            // 
            this.plantwidthDataGridViewTextBoxColumn.DataPropertyName = "plant_width";
            this.plantwidthDataGridViewTextBoxColumn.HeaderText = "plant_width";
            this.plantwidthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantwidthDataGridViewTextBoxColumn.Name = "plantwidthDataGridViewTextBoxColumn";
            this.plantwidthDataGridViewTextBoxColumn.ReadOnly = true;
            this.plantwidthDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantweightDataGridViewTextBoxColumn
            // 
            this.plantweightDataGridViewTextBoxColumn.DataPropertyName = "plant_weight";
            this.plantweightDataGridViewTextBoxColumn.HeaderText = "plant_weight";
            this.plantweightDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.plantweightDataGridViewTextBoxColumn.Name = "plantweightDataGridViewTextBoxColumn";
            this.plantweightDataGridViewTextBoxColumn.ReadOnly = true;
            this.plantweightDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "category_id";
            this.categoryidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            this.categoryidDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryidDataGridViewTextBoxColumn.Width = 150;
            // 
            // materialidDataGridViewTextBoxColumn
            // 
            this.materialidDataGridViewTextBoxColumn.DataPropertyName = "material_id";
            this.materialidDataGridViewTextBoxColumn.HeaderText = "material_id";
            this.materialidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.materialidDataGridViewTextBoxColumn.Name = "materialidDataGridViewTextBoxColumn";
            this.materialidDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialidDataGridViewTextBoxColumn.Width = 150;
            // 
            // planttypeidDataGridViewTextBoxColumn
            // 
            this.planttypeidDataGridViewTextBoxColumn.DataPropertyName = "plant_type_id";
            this.planttypeidDataGridViewTextBoxColumn.HeaderText = "plant_type_id";
            this.planttypeidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.planttypeidDataGridViewTextBoxColumn.Name = "planttypeidDataGridViewTextBoxColumn";
            this.planttypeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.planttypeidDataGridViewTextBoxColumn.Width = 150;
            // 
            // flowercoloridDataGridViewTextBoxColumn
            // 
            this.flowercoloridDataGridViewTextBoxColumn.DataPropertyName = "flower_color_id";
            this.flowercoloridDataGridViewTextBoxColumn.HeaderText = "flower_color_id";
            this.flowercoloridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.flowercoloridDataGridViewTextBoxColumn.Name = "flowercoloridDataGridViewTextBoxColumn";
            this.flowercoloridDataGridViewTextBoxColumn.ReadOnly = true;
            this.flowercoloridDataGridViewTextBoxColumn.Width = 150;
            // 
            // plantBindingSource
            // 
            this.plantBindingSource.DataMember = "Plant";
            this.plantBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // flowerShopDataSet
            // 
            this.flowerShopDataSet.DataSetName = "FlowerShopDataSet";
            this.flowerShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plantTableAdapter
            // 
            this.plantTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // orderTableAdapter1
            // 
            this.orderTableAdapter1.ClearBeforeFill = true;
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 592);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Catalogue";
            this.Text = "Catalogue";
            this.Load += new System.EventHandler(this.Catalogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private FlowerShopDataSet flowerShopDataSet;
        private System.Windows.Forms.BindingSource plantBindingSource;
        private FlowerShopDataSetTableAdapters.PlantTableAdapter plantTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem кошикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantidDataGridViewTextBoxColumn;
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
        private FlowerShopDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private FlowerShopDataSetTableAdapters.OrderTableAdapter orderTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
    }
}