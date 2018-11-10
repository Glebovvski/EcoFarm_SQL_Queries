namespace EcoFarm_SQL_Lab2
{
    partial class ParametrForm
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewParam = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ParamTB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DateTB = new System.Windows.Forms.TextBox();
            this.SupCodeTB = new System.Windows.Forms.TextBox();
            this.InvoiceTypeTB = new System.Windows.Forms.TextBox();
            this.SupplierTB = new System.Windows.Forms.TextBox();
            this.RecieverTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TotalPriceTB = new System.Windows.Forms.TextBox();
            this.UnitPriceTB = new System.Windows.Forms.TextBox();
            this.NumOfUnitsTB = new System.Windows.Forms.TextBox();
            this.UnitsTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.InvNumberTB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParam)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewParam
            // 
            this.dataGridViewParam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParam.Location = new System.Drawing.Point(12, 288);
            this.dataGridViewParam.Name = "dataGridViewParam";
            this.dataGridViewParam.RowTemplate.Height = 24;
            this.dataGridViewParam.Size = new System.Drawing.Size(909, 242);
            this.dataGridViewParam.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.Location = new System.Drawing.Point(12, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select ODBC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Invoice",
            "Invoice products"});
            this.comboBox1.Location = new System.Drawing.Point(117, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Table:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Column:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Invoice",
            "Invoice products"});
            this.comboBox2.Location = new System.Drawing.Point(117, 59);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter: ";
            // 
            // ParamTB
            // 
            this.ParamTB.Location = new System.Drawing.Point(117, 110);
            this.ParamTB.Name = "ParamTB";
            this.ParamTB.Size = new System.Drawing.Size(145, 22);
            this.ParamTB.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.Location = new System.Drawing.Point(140, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Select Scalar ODBC";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.Location = new System.Drawing.Point(396, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 44);
            this.button3.TabIndex = 10;
            this.button3.Text = "Select Scalar SQL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button4.Location = new System.Drawing.Point(268, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "Select SQL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(524, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 44);
            this.button5.TabIndex = 11;
            this.button5.Text = "Insert Invoice ODBC";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(652, 238);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 44);
            this.button6.TabIndex = 12;
            this.button6.Text = "Insert Invoice Product SQL";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RecieverTB);
            this.groupBox1.Controls.Add(this.SupplierTB);
            this.groupBox1.Controls.Add(this.InvoiceTypeTB);
            this.groupBox1.Controls.Add(this.SupCodeTB);
            this.groupBox1.Controls.Add(this.DateTB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(301, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 174);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Supplier code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Invoice type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Supplier";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Reciever";
            // 
            // DateTB
            // 
            this.DateTB.Location = new System.Drawing.Point(107, 26);
            this.DateTB.Name = "DateTB";
            this.DateTB.Size = new System.Drawing.Size(146, 22);
            this.DateTB.TabIndex = 21;
            // 
            // SupCodeTB
            // 
            this.SupCodeTB.Location = new System.Drawing.Point(107, 54);
            this.SupCodeTB.Name = "SupCodeTB";
            this.SupCodeTB.Size = new System.Drawing.Size(146, 22);
            this.SupCodeTB.TabIndex = 22;
            // 
            // InvoiceTypeTB
            // 
            this.InvoiceTypeTB.Location = new System.Drawing.Point(107, 82);
            this.InvoiceTypeTB.Name = "InvoiceTypeTB";
            this.InvoiceTypeTB.Size = new System.Drawing.Size(146, 22);
            this.InvoiceTypeTB.TabIndex = 23;
            // 
            // SupplierTB
            // 
            this.SupplierTB.Location = new System.Drawing.Point(107, 109);
            this.SupplierTB.Name = "SupplierTB";
            this.SupplierTB.Size = new System.Drawing.Size(146, 22);
            this.SupplierTB.TabIndex = 24;
            // 
            // RecieverTB
            // 
            this.RecieverTB.Location = new System.Drawing.Point(107, 137);
            this.RecieverTB.Name = "RecieverTB";
            this.RecieverTB.Size = new System.Drawing.Size(146, 22);
            this.RecieverTB.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InvNumberTB);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.TotalPriceTB);
            this.groupBox2.Controls.Add(this.UnitPriceTB);
            this.groupBox2.Controls.Add(this.NumOfUnitsTB);
            this.groupBox2.Controls.Add(this.UnitsTB);
            this.groupBox2.Controls.Add(this.NameTB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(590, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 200);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice Products";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TotalPriceTB
            // 
            this.TotalPriceTB.Location = new System.Drawing.Point(118, 137);
            this.TotalPriceTB.Name = "TotalPriceTB";
            this.TotalPriceTB.Size = new System.Drawing.Size(146, 22);
            this.TotalPriceTB.TabIndex = 25;
            // 
            // UnitPriceTB
            // 
            this.UnitPriceTB.Location = new System.Drawing.Point(118, 109);
            this.UnitPriceTB.Name = "UnitPriceTB";
            this.UnitPriceTB.Size = new System.Drawing.Size(146, 22);
            this.UnitPriceTB.TabIndex = 24;
            // 
            // NumOfUnitsTB
            // 
            this.NumOfUnitsTB.Location = new System.Drawing.Point(118, 82);
            this.NumOfUnitsTB.Name = "NumOfUnitsTB";
            this.NumOfUnitsTB.Size = new System.Drawing.Size(146, 22);
            this.NumOfUnitsTB.TabIndex = 23;
            // 
            // UnitsTB
            // 
            this.UnitsTB.Location = new System.Drawing.Point(118, 53);
            this.UnitsTB.Name = "UnitsTB";
            this.UnitsTB.Size = new System.Drawing.Size(146, 22);
            this.UnitsTB.TabIndex = 22;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(118, 26);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(146, 22);
            this.NameTB.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Unit price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Number of units";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Units";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Name";
            // 
            // InvNumberTB
            // 
            this.InvNumberTB.Location = new System.Drawing.Point(118, 165);
            this.InvNumberTB.Name = "InvNumberTB";
            this.InvNumberTB.Size = new System.Drawing.Size(146, 22);
            this.InvNumberTB.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Invoice Number";
            // 
            // ParametrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ParamTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewParam);
            this.Name = "ParametrForm";
            this.Text = "ParametrForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParam)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewParam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ParamTB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RecieverTB;
        private System.Windows.Forms.TextBox SupplierTB;
        private System.Windows.Forms.TextBox InvoiceTypeTB;
        private System.Windows.Forms.TextBox SupCodeTB;
        private System.Windows.Forms.TextBox DateTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TotalPriceTB;
        private System.Windows.Forms.TextBox UnitPriceTB;
        private System.Windows.Forms.TextBox NumOfUnitsTB;
        private System.Windows.Forms.TextBox UnitsTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox InvNumberTB;
        private System.Windows.Forms.Label label14;
    }
}