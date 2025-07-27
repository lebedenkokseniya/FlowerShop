namespace FLOWERshop
{
    partial class AmountOfPlant
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flowerShopDataSet1 = new FLOWERshop.FlowerShopDataSet();
            this.plantTableAdapter1 = new FLOWERshop.FlowerShopDataSetTableAdapters.PlantTableAdapter();
            this.orderTableAdapter1 = new FLOWERshop.FlowerShopDataSetTableAdapters.OrderTableAdapter();
            this.order_itemTableAdapter1 = new FLOWERshop.FlowerShopDataSetTableAdapters.Order_itemTableAdapter();
            this.numericUpDown_amount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть кількість продукту,\r\nякий хочете додати до кошика";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Підтвердити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowerShopDataSet1
            // 
            this.flowerShopDataSet1.DataSetName = "FlowerShopDataSet";
            this.flowerShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plantTableAdapter1
            // 
            this.plantTableAdapter1.ClearBeforeFill = true;
            // 
            // orderTableAdapter1
            // 
            this.orderTableAdapter1.ClearBeforeFill = true;
            // 
            // order_itemTableAdapter1
            // 
            this.order_itemTableAdapter1.ClearBeforeFill = true;
            // 
            // numericUpDown_amount
            // 
            this.numericUpDown_amount.Location = new System.Drawing.Point(178, 127);
            this.numericUpDown_amount.Name = "numericUpDown_amount";
            this.numericUpDown_amount.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_amount.TabIndex = 4;
            // 
            // AmountOfPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 290);
            this.Controls.Add(this.numericUpDown_amount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AmountOfPlant";
            this.Text = "AmountOfPlant";
            this.Load += new System.EventHandler(this.AmountOfPlant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flowerShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private FlowerShopDataSet flowerShopDataSet1;
        private FlowerShopDataSetTableAdapters.PlantTableAdapter plantTableAdapter1;
        private FlowerShopDataSetTableAdapters.OrderTableAdapter orderTableAdapter1;
        private FlowerShopDataSetTableAdapters.Order_itemTableAdapter order_itemTableAdapter1;
        private System.Windows.Forms.NumericUpDown numericUpDown_amount;
    }
}