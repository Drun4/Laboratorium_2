
namespace Laboratorium_2
{
    partial class Form1
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.showValueButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.rootButton = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.activeMethodLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.ctrlStatusLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.backgroundCheck = new System.Windows.Forms.CheckBox();
            this.fontColorCheck = new System.Windows.Forms.CheckBox();
            this.fontCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(39, 70);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(149, 22);
            this.inputBox.TabIndex = 0;
            // 
            // showValueButton
            // 
            this.showValueButton.Location = new System.Drawing.Point(599, 149);
            this.showValueButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showValueButton.Name = "showValueButton";
            this.showValueButton.Size = new System.Drawing.Size(151, 28);
            this.showValueButton.TabIndex = 1;
            this.showValueButton.Text = "Show Value";
            this.showValueButton.UseVisualStyleBackColor = true;
            this.showValueButton.Click += new System.EventHandler(this.showValueButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(315, 70);
            this.squareButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(151, 28);
            this.squareButton.TabIndex = 2;
            this.squareButton.Text = "Square";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // rootButton
            // 
            this.rootButton.Location = new System.Drawing.Point(315, 149);
            this.rootButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rootButton.Name = "rootButton";
            this.rootButton.Size = new System.Drawing.Size(151, 28);
            this.rootButton.TabIndex = 3;
            this.rootButton.Text = "Root";
            this.rootButton.UseVisualStyleBackColor = true;
            this.rootButton.Click += new System.EventHandler(this.rootButton_Click);
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(315, 228);
            this.reverseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(151, 28);
            this.reverseButton.TabIndex = 4;
            this.reverseButton.Text = "Reverse";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(599, 70);
            this.outputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(149, 22);
            this.outputBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Active method:";
            // 
            // activeMethodLabel
            // 
            this.activeMethodLabel.AutoSize = true;
            this.activeMethodLabel.Location = new System.Drawing.Point(411, 50);
            this.activeMethodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activeMethodLabel.Name = "activeMethodLabel";
            this.activeMethodLabel.Size = new System.Drawing.Size(20, 17);
            this.activeMethodLabel.TabIndex = 9;
            this.activeMethodLabel.Text = "...";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(599, 228);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(151, 28);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear Output";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ctrlStatusLabel
            // 
            this.ctrlStatusLabel.AutoSize = true;
            this.ctrlStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.ctrlStatusLabel.Location = new System.Drawing.Point(105, 373);
            this.ctrlStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ctrlStatusLabel.Name = "ctrlStatusLabel";
            this.ctrlStatusLabel.Size = new System.Drawing.Size(27, 17);
            this.ctrlStatusLabel.TabIndex = 11;
            this.ctrlStatusLabel.Text = "Off";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 373);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ctrl status:";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(38, 228);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(149, 28);
            this.applyButton.TabIndex = 13;
            this.applyButton.Text = "Apply Changes";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // backgroundCheck
            // 
            this.backgroundCheck.AutoSize = true;
            this.backgroundCheck.Location = new System.Drawing.Point(38, 127);
            this.backgroundCheck.Name = "backgroundCheck";
            this.backgroundCheck.Size = new System.Drawing.Size(196, 21);
            this.backgroundCheck.TabIndex = 14;
            this.backgroundCheck.Text = "Change Background Color";
            this.backgroundCheck.UseVisualStyleBackColor = true;
            // 
            // fontColorCheck
            // 
            this.fontColorCheck.AutoSize = true;
            this.fontColorCheck.Location = new System.Drawing.Point(39, 154);
            this.fontColorCheck.Name = "fontColorCheck";
            this.fontColorCheck.Size = new System.Drawing.Size(183, 21);
            this.fontColorCheck.TabIndex = 15;
            this.fontColorCheck.Text = "Change Input Font Color";
            this.fontColorCheck.UseVisualStyleBackColor = true;
            // 
            // fontCheck
            // 
            this.fontCheck.AutoSize = true;
            this.fontCheck.Location = new System.Drawing.Point(39, 181);
            this.fontCheck.Name = "fontCheck";
            this.fontCheck.Size = new System.Drawing.Size(146, 21);
            this.fontCheck.TabIndex = 16;
            this.fontCheck.Text = "Change Input Font";
            this.fontCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(911, 400);
            this.Controls.Add(this.fontCheck);
            this.Controls.Add(this.fontColorCheck);
            this.Controls.Add(this.backgroundCheck);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctrlStatusLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.activeMethodLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.rootButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.showValueButton);
            this.Controls.Add(this.inputBox);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Delegaty & Zdarzenia";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button showValueButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button rootButton;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label activeMethodLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label ctrlStatusLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.CheckBox backgroundCheck;
        private System.Windows.Forms.CheckBox fontColorCheck;
        private System.Windows.Forms.CheckBox fontCheck;
    }
}

