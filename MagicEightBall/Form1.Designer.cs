
namespace MagicEightBall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.thinkOfQuestionLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // thinkOfQuestionLabel
            // 
            this.thinkOfQuestionLabel.AutoSize = true;
            this.thinkOfQuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.thinkOfQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thinkOfQuestionLabel.ForeColor = System.Drawing.Color.White;
            this.thinkOfQuestionLabel.Location = new System.Drawing.Point(210, 25);
            this.thinkOfQuestionLabel.Name = "thinkOfQuestionLabel";
            this.thinkOfQuestionLabel.Size = new System.Drawing.Size(385, 46);
            this.thinkOfQuestionLabel.TabIndex = 0;
            this.thinkOfQuestionLabel.Text = "Think of a Question";
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(65, 650);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(673, 84);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputButton
            // 
            this.inputButton.BackColor = System.Drawing.Color.Transparent;
            this.inputButton.FlatAppearance.BorderSize = 0;
            this.inputButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.inputButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.inputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputButton.Image = global::MagicEightBall.Properties.Resources.clickBall1;
            this.inputButton.Location = new System.Drawing.Point(125, 75);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(557, 525);
            this.inputButton.TabIndex = 3;
            this.inputButton.UseVisualStyleBackColor = false;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 760);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.thinkOfQuestionLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Magic 8 Ball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label thinkOfQuestionLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button inputButton;
    }
}

