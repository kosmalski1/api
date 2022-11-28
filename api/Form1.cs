using System.Xml.Linq;

namespace api
{
    public partial class Form1 : Form
    {   private Dictionary<string, float> _rates = new Dictionary<string, float>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument api = XDocument.Load("http://api.nbp.pl/api/exchangerates/tables/a/?format=xml");
            //debugTextBox.Text = api.ToString();
            var rates = api.Descendants("Rate");
            _rates.Clear();
            foreach (var rate in rates)
            {
                string code = rate.Element("Code").Value;
                float mid = float.Parse(rate.Element("Mid").Value, System.Globalization.CultureInfo.InvariantCulture);
                _rates.Add(code, mid);
            }
            USDratetextBox.Text = _rates["USD"].ToString();
            EURratetextBox.Text = _rates["EUR"].ToString();
            CHFratetextBox.Text = _rates["CHF"].ToString();
        }

        private void Echange(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            string code = radio.Text;
            float pln = float.Parse(PLNammounttextbox.Text);
            float exchanged = pln / _rates[code];
            textBox1.Text = exchanged.ToString();
        }
    }
}