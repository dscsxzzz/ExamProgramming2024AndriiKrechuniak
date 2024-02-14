using System.Diagnostics;
using System.Globalization;

namespace ExpensesManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            var content = File.ReadAllText(path);
            content = content.Replace("|", "\t");



            resultTextBox.Text = content;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;

            var path = pathTextBox.Text;
            var lines = File.ReadAllLines(path);
            var totalExpenses = (decimal)0;
            var categories = new Dictionary<string, decimal>();
            var dates = new Dictionary<DateTime, int>();
            var numberOfCategories = 0;
            var totalDatesOfPayments = 0;
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                var split = line.Split('|');
                var price = decimal.Parse(split[1], culture);
                var date = DateTime.Parse(split[0]);
                totalExpenses += price;
                var category = split[2];
                if (categories.ContainsKey(category) && dates.ContainsKey(date))
                {
                    categories[category] += price;
                    dates[date] += 1;
                }
                else
                {
                    categories[category] = price;
                    dates[date] = 1;

                }



            }
            resultTextBox.Clear();
                
            resultTextBox.Text += "Total expenses :" + totalExpenses + Environment.NewLine;
                
            resultTextBox.Text += "Number of categories: " + categories.Count + Environment.NewLine;
                
            resultTextBox.Text += "Total dates of payments: " + dates.Count + Environment.NewLine;
        }
    }
}