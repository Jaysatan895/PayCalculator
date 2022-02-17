namespace PayCalculator
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
            this.hoursLabel = new System.Windows.Forms.Label();
            this.payLabel = new System.Windows.Forms.Label();
            this.hoursInput = new System.Windows.Forms.TextBox();
            this.payInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.pretaxLabel = new System.Windows.Forms.Label();
            this.pretaxOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.Location = new System.Drawing.Point(22, 67);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(149, 25);
            this.hoursLabel.TabIndex = 0;
            this.hoursLabel.Text = "Hours Worked";
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payLabel.Location = new System.Drawing.Point(71, 112);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(100, 25);
            this.payLabel.TabIndex = 1;
            this.payLabel.Text = "Pay Rate";
            // 
            // hoursInput
            // 
            this.hoursInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursInput.Location = new System.Drawing.Point(177, 64);
            this.hoursInput.Name = "hoursInput";
            this.hoursInput.Size = new System.Drawing.Size(100, 31);
            this.hoursInput.TabIndex = 2;
            // 
            // payInput
            // 
            this.payInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payInput.Location = new System.Drawing.Point(177, 106);
            this.payInput.Name = "payInput";
            this.payInput.Size = new System.Drawing.Size(100, 31);
            this.payInput.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(105, 171);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(119, 42);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // pretaxLabel
            // 
            this.pretaxLabel.AutoSize = true;
            this.pretaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretaxLabel.Location = new System.Drawing.Point(97, 246);
            this.pretaxLabel.Name = "pretaxLabel";
            this.pretaxLabel.Size = new System.Drawing.Size(74, 25);
            this.pretaxLabel.TabIndex = 5;
            this.pretaxLabel.Text = "Pretax";
            // 
            // pretaxOutput
            // 
            this.pretaxOutput.BackColor = System.Drawing.Color.White;
            this.pretaxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretaxOutput.Location = new System.Drawing.Point(177, 246);
            this.pretaxOutput.Name = "pretaxOutput";
            this.pretaxOutput.Size = new System.Drawing.Size(100, 25);
            this.pretaxOutput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(303, 450);
            this.Controls.Add(this.pretaxOutput);
            this.Controls.Add(this.pretaxLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.payInput);
            this.Controls.Add(this.hoursInput);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.hoursLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.TextBox hoursInput;
        private System.Windows.Forms.TextBox payInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label pretaxLabel;
        private System.Windows.Forms.Label pretaxOutput;
    }
}

