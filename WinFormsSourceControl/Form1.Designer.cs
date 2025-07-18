namespace WinFormsSourceControl
{
    partial class FormAreaAndPerimeterCalculator
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
            lblLength = new Label();
            lblWidth = new Label();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            btnCalculate = new Button();
            txtPerimeter = new TextBox();
            txtArea = new TextBox();
            SuspendLayout();
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(12, 45);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(54, 20);
            lblLength.TabIndex = 0;
            lblLength.Text = "Length";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(12, 98);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(49, 20);
            lblWidth.TabIndex = 1;
            lblWidth.Text = "Width";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(79, 42);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(125, 27);
            txtLength.TabIndex = 2;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(79, 95);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(125, 27);
            txtWidth.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(42, 146);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(137, 49);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate Area and Perimeter";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtPerimeter
            // 
            txtPerimeter.Location = new Point(229, 179);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.ReadOnly = true;
            txtPerimeter.Size = new Size(125, 27);
            txtPerimeter.TabIndex = 5;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(229, 146);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(125, 27);
            txtArea.TabIndex = 6;
            // 
            // FormAreaAndPerimeterCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 274);
            Controls.Add(txtArea);
            Controls.Add(txtPerimeter);
            Controls.Add(btnCalculate);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(lblWidth);
            Controls.Add(lblLength);
            Name = "FormAreaAndPerimeterCalculator";
            Text = "Area and Perimeter Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLength;
        private Label lblWidth;
        private TextBox txtLength;
        private TextBox txtWidth;
        private Button btnCalculate;
        private TextBox txtPerimeter;
        private TextBox txtArea;
    }
}
