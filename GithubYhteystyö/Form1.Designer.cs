﻿namespace GithubYhteystyö
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
            OstikkoLB = new Label();
            VaihdaBT = new Button();
            SuspendLayout();
            // 
            // OstikkoLB
            // 
            OstikkoLB.AutoSize = true;
            OstikkoLB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OstikkoLB.Location = new Point(105, 109);
            OstikkoLB.Name = "OstikkoLB";
            OstikkoLB.Size = new Size(80, 25);
            OstikkoLB.TabIndex = 0;
            OstikkoLB.Text = "Ostikko";
            // 
            // VaihdaBT
            // 
            VaihdaBT.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VaihdaBT.Location = new Point(105, 149);
            VaihdaBT.Name = "VaihdaBT";
            VaihdaBT.Size = new Size(80, 45);
            VaihdaBT.TabIndex = 1;
            VaihdaBT.Text = "Vaihda";
            VaihdaBT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 343);
            Controls.Add(VaihdaBT);
            Controls.Add(OstikkoLB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OstikkoLB;
        private Button VaihdaBT;
    }
}
