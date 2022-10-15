using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Barragan
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            BindingSource bindingSource1 = new BindingSource();
            string fileName = @"quotes\quotes.json";
            StreamReader streamReader = new StreamReader(fileName);
            string jsonLine;
            List<string> theQuotes = new List<string>();
            while ((jsonLine = streamReader.ReadLine()) != null)
            {
                theQuotes.Add(jsonLine);
            };
            QuoteList quoteList = new QuoteList();
            foreach (string str in theQuotes)
            {
                quoteList = JsonConvert.DeserializeObject<QuoteList>(str);
            }
            bindingSource1.DataSource = quoteList;
            dataGridView1.DataSource = bindingSource1;

    }
        public class QuoteList
        {
            public List<Rootobject> quotes { get; set; }
        }


        public class Rootobject
        {
            public int rushDays { get; set; }
            public object customerName { get; set; }
            public DateTime quoteDate { get; set; }
            public int total { get; set; }
            public Desk Desk { get; set; }
        }

        public class Desk
        {
            public int width { get; set; }
            public int depth { get; set; }
            public int numberOfDrawers { get; set; }
            public int DesktopMaterial { get; set; }
            public int Area { get; set; }
        }

    }
}
