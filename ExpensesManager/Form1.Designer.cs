namespace ExpensesManager
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
            pathTextBox = new TextBox();
            pathButton = new Button();
            resultTextBox = new RichTextBox();
            calculateButton = new Button();
            SuspendLayout();
            // 
            // pathTextBox
            // 
            pathTextBox.Location = new Point(27, 22);
            pathTextBox.Name = "pathTextBox";
            pathTextBox.Size = new Size(392, 23);
            pathTextBox.TabIndex = 0;
            // 
            // pathButton
            // 
            pathButton.Location = new Point(447, 22);
            pathButton.Name = "pathButton";
            pathButton.Size = new Size(103, 23);
            pathButton.TabIndex = 1;
            pathButton.Text = "Load Data";
            pathButton.UseVisualStyleBackColor = true;
            pathButton.Click += pathButton_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(27, 51);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(523, 349);
            resultTextBox.TabIndex = 2;
            resultTextBox.Text = "";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(570, 22);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(91, 23);
            calculateButton.TabIndex = 3;
            calculateButton.Text = "Total";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 564);
            Controls.Add(calculateButton);
            Controls.Add(resultTextBox);
            Controls.Add(pathButton);
            Controls.Add(pathTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pathTextBox;
        private Button pathButton;
        private RichTextBox resultTextBox;
        private Button calculateButton;
    }
}