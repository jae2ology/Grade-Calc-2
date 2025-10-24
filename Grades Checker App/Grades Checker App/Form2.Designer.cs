using System.ComponentModel;

namespace Grades_Checker_App;

partial class Form2
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        label1 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)));
        label1.Location = new System.Drawing.Point(179, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(573, 72);
        label1.TabIndex = 0;
        label1.Text = "Course Grades";
        label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        button1.Location = new System.Drawing.Point(128, 497);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(663, 90);
        button1.TabIndex = 2;
        button1.Text = "Calculate!";
        button1.UseVisualStyleBackColor = false;
        button1.Click += CalculateGrades;
        // 
        // Form2
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(926, 669);
        Controls.Add(button1);
        Controls.Add(label1);
        Text = "Form2";
        Load += Form2_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label1;

    #endregion
}