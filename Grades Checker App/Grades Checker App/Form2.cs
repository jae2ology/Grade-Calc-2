namespace Grades_Checker_App;

public partial class Form2 : Form
{
    private int grades;
    private List<int> weights;
    private List<TextBox> gradeInputs = new List<TextBox>();

    public Form2(string course, int grades, List<int> weight)
    {
        InitializeComponent();
        label1.Text = course + " Grade Input";
        this.grades = grades;
        this.weights = weight;
    }

    private void Form2_Load(object sender, EventArgs e)
    {
        int centerX = this.ClientSize.Width / 2;
        int startY = 100; 
        int spacingY = 60;

        for (int i = 0; i < grades; i++)
        {
            Label lbl = new Label();
            lbl.Text = $"Grade {i + 1} (Weight: {weights[i]}):";
            lbl.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lbl.Location = new Point(centerX - 120, startY + i * spacingY);
            this.Controls.Add(lbl);
            

            TextBox txt = new TextBox();
            txt.Name = $"txtGrade{i}";
            txt.Font = new Font("Segoe UI", 12);
            txt.Size = new Size(150, 30);
            txt.Location = new Point(centerX + 10, startY + i * spacingY);
            this.Controls.Add(txt);
            gradeInputs.Add(txt);
        }

    }

    private void CalculateGrades(object sender, EventArgs e)
    {
        List<double> inputtedGrades = new List<double>();
        for (int i = 0; i < grades; i++)
        {
            if (double.TryParse(gradeInputs[i].Text, out double grade))
            {
                inputtedGrades.Add(grade);
            }
            else
            {
                MessageBox.Show($"Invalid input for Grade {i + 1}");
                return;
            }
        }

        double totalWeighted = 0;
        int totalWeight = 0;

        for (int i = 0; i < grades; i++)
        {
            totalWeighted += inputtedGrades[i] * weights[i];
            totalWeight += weights[i];
        }

        double finalGrade = (totalWeighted / totalWeight) * 0.01;
        MessageBox.Show($"Your final grade is: {finalGrade:F2}");
        Reset();
    }


    private void Reset()
    {
        Form1 f1 = new Form1();
        f1.Show();
        this.Hide();
    }
}