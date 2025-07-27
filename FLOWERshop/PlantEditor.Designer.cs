namespace FLOWERshop
{
    partial class PlantEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_image = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowerShopDataSet = new FLOWERshop.FlowerShopDataSet();
            this.comboBox_material = new System.Windows.Forms.ComboBox();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_plantType = new System.Windows.Forms.ComboBox();
            this.plantTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_flowerColor = new System.Windows.Forms.ComboBox();
            this.flowerColorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.CategoryTableAdapter();
            this.materialTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.MaterialTableAdapter();
            this.plantTypeTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.PlantTypeTableAdapter();
            this.flowerColorTableAdapter = new FLOWERshop.FlowerShopDataSetTableAdapters.FlowerColorTableAdapter();
            this.plantTableAdapter1 = new FLOWERshop.FlowerShopDataSetTableAdapters.PlantTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerColorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(234, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рослина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Назва";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Опис";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Зображення";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ціна";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Кількість на складі";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Висота";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ширина";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Вага";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Категорія";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 439);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Матеріал";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 484);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Тип рослини";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(106, 523);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Колір рослини";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(317, 120);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(318, 26);
            this.textBox_name.TabIndex = 14;
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(317, 156);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(318, 26);
            this.textBox_description.TabIndex = 15;
            // 
            // textBox_image
            // 
            this.textBox_image.Location = new System.Drawing.Point(317, 193);
            this.textBox_image.Name = "textBox_image";
            this.textBox_image.Size = new System.Drawing.Size(318, 26);
            this.textBox_image.TabIndex = 16;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(317, 229);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(318, 26);
            this.textBox_price.TabIndex = 17;
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(317, 262);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(318, 26);
            this.textBox_amount.TabIndex = 18;
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(317, 294);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(318, 26);
            this.textBox_height.TabIndex = 19;
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(317, 329);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(318, 26);
            this.textBox_width.TabIndex = 20;
            // 
            // textBox_weight
            // 
            this.textBox_weight.Location = new System.Drawing.Point(317, 369);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(318, 26);
            this.textBox_weight.TabIndex = 21;
            // 
            // comboBox_category
            // 
            this.comboBox_category.DataSource = this.categoryBindingSource;
            this.comboBox_category.DisplayMember = "category_name";
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(317, 405);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(318, 28);
            this.comboBox_category.TabIndex = 22;
            this.comboBox_category.ValueMember = "category_id";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // flowerShopDataSet
            // 
            this.flowerShopDataSet.DataSetName = "FlowerShopDataSet";
            this.flowerShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_material
            // 
            this.comboBox_material.DataSource = this.materialBindingSource;
            this.comboBox_material.DisplayMember = "material_name";
            this.comboBox_material.FormattingEnabled = true;
            this.comboBox_material.Location = new System.Drawing.Point(317, 440);
            this.comboBox_material.Name = "comboBox_material";
            this.comboBox_material.Size = new System.Drawing.Size(318, 28);
            this.comboBox_material.TabIndex = 23;
            this.comboBox_material.ValueMember = "material_id";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // comboBox_plantType
            // 
            this.comboBox_plantType.DataSource = this.plantTypeBindingSource;
            this.comboBox_plantType.DisplayMember = "plant_type_name";
            this.comboBox_plantType.FormattingEnabled = true;
            this.comboBox_plantType.Location = new System.Drawing.Point(317, 484);
            this.comboBox_plantType.Name = "comboBox_plantType";
            this.comboBox_plantType.Size = new System.Drawing.Size(318, 28);
            this.comboBox_plantType.TabIndex = 24;
            this.comboBox_plantType.ValueMember = "plant_type_id";
            // 
            // plantTypeBindingSource
            // 
            this.plantTypeBindingSource.DataMember = "PlantType";
            this.plantTypeBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // comboBox_flowerColor
            // 
            this.comboBox_flowerColor.DataSource = this.flowerColorBindingSource;
            this.comboBox_flowerColor.DisplayMember = "flower_color_name";
            this.comboBox_flowerColor.FormattingEnabled = true;
            this.comboBox_flowerColor.Location = new System.Drawing.Point(317, 523);
            this.comboBox_flowerColor.Name = "comboBox_flowerColor";
            this.comboBox_flowerColor.Size = new System.Drawing.Size(318, 28);
            this.comboBox_flowerColor.TabIndex = 25;
            this.comboBox_flowerColor.ValueMember = "flower_color_id";
            // 
            // flowerColorBindingSource
            // 
            this.flowerColorBindingSource.DataMember = "FlowerColor";
            this.flowerColorBindingSource.DataSource = this.flowerShopDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 591);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 59);
            this.button2.TabIndex = 27;
            this.button2.Text = "Зберегти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // plantTypeTableAdapter
            // 
            this.plantTypeTableAdapter.ClearBeforeFill = true;
            // 
            // flowerColorTableAdapter
            // 
            this.flowerColorTableAdapter.ClearBeforeFill = true;
            // 
            // plantTableAdapter1
            // 
            this.plantTableAdapter1.ClearBeforeFill = true;
            // 
            // PlantEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 694);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox_flowerColor);
            this.Controls.Add(this.comboBox_plantType);
            this.Controls.Add(this.comboBox_material);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.textBox_weight);
            this.Controls.Add(this.textBox_width);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_image);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PlantEditor";
            this.Text = "PlantEditor";
            this.Load += new System.EventHandler(this.PlantEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerColorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_image;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.ComboBox comboBox_material;
        private System.Windows.Forms.ComboBox comboBox_plantType;
        private System.Windows.Forms.ComboBox comboBox_flowerColor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private FlowerShopDataSet flowerShopDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private FlowerShopDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private FlowerShopDataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.BindingSource plantTypeBindingSource;
        private FlowerShopDataSetTableAdapters.PlantTypeTableAdapter plantTypeTableAdapter;
        private System.Windows.Forms.BindingSource flowerColorBindingSource;
        private FlowerShopDataSetTableAdapters.FlowerColorTableAdapter flowerColorTableAdapter;
        private FlowerShopDataSetTableAdapters.PlantTableAdapter plantTableAdapter1;
    }
}