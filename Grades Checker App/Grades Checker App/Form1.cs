namespace Grades_Checker_App;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }


    private void ClickWhenDone(object sender, EventArgs e)
    {
        string courseName = textBox1.Text;
        int gradeNumber = int.Parse(textBox2.Text);
        string[] gradeWeights = textBox3.Text.Split(',');
        List<int> grades = new List<int>();

        for (int i = 0; i < gradeWeights.Length; i++)
        {
            grades.Add(int.Parse(gradeWeights[i]));
        }
        
        Form2 form2 = new Form2(courseName, gradeNumber, grades);
        form2.Show();
        this.Hide();
        
    }
}