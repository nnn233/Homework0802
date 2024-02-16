namespace Homework0802
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCsv = new Button();
            buttonTxt = new Button();
            dataGridView1 = new DataGridView();
            VendorCode = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonCsv
            // 
            buttonCsv.Location = new Point(514, 365);
            buttonCsv.Name = "buttonCsv";
            buttonCsv.Size = new Size(94, 53);
            buttonCsv.TabIndex = 0;
            buttonCsv.Text = "Выгрузить в csv";
            buttonCsv.UseVisualStyleBackColor = true;
            buttonCsv.Click += buttonCsv_Click;
            // 
            // buttonTxt
            // 
            buttonTxt.Location = new Point(677, 365);
            buttonTxt.Name = "buttonTxt";
            buttonTxt.Size = new Size(94, 53);
            buttonTxt.TabIndex = 1;
            buttonTxt.Text = "Выгрузить в txt";
            buttonTxt.UseVisualStyleBackColor = true;
            buttonTxt.Click += buttonTxt_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { VendorCode, Title, Price });
            dataGridView1.Location = new Point(27, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(744, 311);
            dataGridView1.TabIndex = 2;
            // 
            // VendorCode
            // 
            VendorCode.HeaderText = "Артикул";
            VendorCode.MinimumWidth = 6;
            VendorCode.Name = "VendorCode";
            VendorCode.ReadOnly = true;
            // 
            // Title
            // 
            Title.HeaderText = "Название";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Цена";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(buttonTxt);
            Controls.Add(buttonCsv);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCsv;
        private Button buttonTxt;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn VendorCode;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Price;
    }
}