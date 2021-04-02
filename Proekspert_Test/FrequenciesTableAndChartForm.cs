using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proekspert_Test
{
    public partial class FrequenciesTableAndChartForm : Form
    {
        private const string FilePath = @"files\MyTest.txt";
        private const string ChartName = "Frequencies";

        public FrequenciesTableAndChartForm()
        {
            InitializeComponent();
            LetterCombinations letterCombinations = new LetterCombinations();
            FileReader fileReader = new FileReader();

            string input = fileReader.GetInputFromFile(FilePath);

            frequencyTable.DataSource = (from entry in letterCombinations.FindCommonLetterCombinations(input)
                                             orderby entry.Value descending
                                             select new {Combinations = entry.Key, Frequencies = entry.Value + "%"}
                                         ).ToList();
            

            Series chart = new Series(ChartName);
            barChart.Series.Add(chart);
            barChart.Series[ChartName].Points.DataBindXY(letterCombinations.FindCommonLetterCombinations(input).Keys,
                letterCombinations.FindCommonLetterCombinations(input).Values);
        }
    }
}
