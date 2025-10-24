namespace Grades_Checker_App;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        textBox2 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        label4 = new System.Windows.Forms.Label();
        textBox3 = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)));
        label1.Location = new System.Drawing.Point(285, 35);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(332, 67);
        label1.TabIndex = 0;
        label1.Text = "Grade Calculator";
        label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)));
        label2.Location = new System.Drawing.Point(12, 168);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(413, 67);
        label2.TabIndex = 1;
        label2.Text = "Input Name of Course:";
        label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // textBox1
        // 
        textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
        textBox1.Font = new System.Drawing.Font("Segoe UI", 20F);
        textBox1.Location = new System.Drawing.Point(431, 168);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(389, 52);
        textBox1.TabIndex = 2;
        textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)));
        label3.Location = new System.Drawing.Point(26, 279);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(423, 67);
        label3.TabIndex = 3;
        label3.Text = "Input Number of Grades:";
        label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // textBox2
        // 
        textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
        textBox2.Font = new System.Drawing.Font("Segoe UI", 20F);
        textBox2.Location = new System.Drawing.Point(583, 276);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(120, 52);
        textBox2.TabIndex = 4;
        textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        button1.Location = new System.Drawing.Point(285, 575);
        button1.Name = "button1";
        button1.Padding = new System.Windows.Forms.Padding(10);
        button1.Size = new System.Drawing.Size(347, 82);
        button1.TabIndex = 5;
        button1.Text = "Click When Done!";
        button1.UseVisualStyleBackColor = false;
        button1.Click += ClickWhenDone;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)));
        label4.Location = new System.Drawing.Point(12, 394);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(888, 67);
        label4.TabIndex = 6;
        label4.Text = "Input Weights of Grades (separated by commas):";
        label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // textBox3
        // 
        textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
        textBox3.Font = new System.Drawing.Font("Segoe UI", 20F);
        textBox3.Location = new System.Drawing.Point(180, 479);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(539, 52);
        textBox3.TabIndex = 7;
        textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(926, 669);
        Controls.Add(textBox3);
        Controls.Add(label4);
        Controls.Add(button1);
        Controls.Add(textBox2);
        Controls.Add(label3);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "Grade Calculator";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox3;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}