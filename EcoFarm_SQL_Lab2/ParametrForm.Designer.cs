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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParam)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(12, 199);
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
            this.comboBox1.Location = new System.Drawing.Point(117, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Table:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 76);
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
            this.comboBox2.Location = new System.Drawing.Point(117, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter: ";
            // 
            // ParamTB
            // 
            this.ParamTB.Location = new System.Drawing.Point(117, 127);
            this.ParamTB.Name = "ParamTB";
            this.ParamTB.Size = new System.Drawing.Size(145, 22);
            this.ParamTB.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.Location = new System.Drawing.Point(140, 199);
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
            this.button3.Location = new System.Drawing.Point(396, 199);
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
            this.button4.Location = new System.Drawing.Point(268, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "Select SQL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ParametrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 542);
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
    }
}