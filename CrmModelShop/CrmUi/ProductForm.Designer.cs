namespace CrmUi
{
    partial class ProductForm
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
            button1 = new Button();
            label1 = new Label();
            textName = new TextBox();
            numericPrice = new NumericUpDown();
            label2 = new Label();
            numericCount = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCount).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(321, 266);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 7;
            label1.Text = "Input name";
            // 
            // textName
            // 
            textName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textName.Location = new Point(105, 18);
            textName.Name = "textName";
            textName.Size = new Size(310, 27);
            textName.TabIndex = 6;
            // 
            // numericPrice
            // 
            numericPrice.DecimalPlaces = 2;
            numericPrice.Location = new Point(105, 51);
            numericPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericPrice.Name = "numericPrice";
            numericPrice.Size = new Size(310, 27);
            numericPrice.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 53);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 10;
            label2.Text = "Input price";
            // 
            // numericCount
            // 
            numericCount.Location = new Point(105, 84);
            numericCount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericCount.Name = "numericCount";
            numericCount.Size = new Size(310, 27);
            numericCount.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 86);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 12;
            label3.Text = "Input count";
            // 
            // ProductForm
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 313);
            Controls.Add(label3);
            Controls.Add(numericCount);
            Controls.Add(label2);
            Controls.Add(numericPrice);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textName);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textName;
        private NumericUpDown numericPrice;
        private Label label2;
        private NumericUpDown numericCount;
        private Label label3;
    }
}