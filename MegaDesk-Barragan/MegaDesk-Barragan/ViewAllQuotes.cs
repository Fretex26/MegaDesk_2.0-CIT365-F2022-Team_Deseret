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
            //QuoteList quoteList = new QuoteList();
            //Rootobject quoteList = new Rootobject();
            List<object> allQuotes = new List<object>();
            int x = 0;
            foreach (string str in theQuotes)
            {
                
                Rootobject aQuote = JsonConvert.DeserializeObject<Rootobject>(str);
                string customerName = "Invalid";
                int rushDays = aQuote.rushDays;
                if (aQuote.customerName != null) { customerName = aQuote.customerName.ToString(); }
                System.DateTime quoteDate = aQuote.quoteDate;
                string total = aQuote.total.ToString();
                int deskWidth = aQuote.Desk.width;
                int deskDepth = aQuote.Desk.depth;
                int deskDrawers = aQuote.Desk.numberOfDrawers;
                MegaDesk_Barragan.Desk.Material desktopMaterial = (MegaDesk_Barragan.Desk.Material)aQuote.Desk.DesktopMaterial;
                string area = aQuote.Desk.Area.ToString();
                //DeskQuote newQuote = new DeskQuote(customerName, quoteDate, deskWidth, deskDepth, deskDrawers, desktopMaterial, rushDays);
                //allQuotes.Add(newQuote);
                dataGridView1.Rows.Add();
                dataGridView1[0, x].Value = customerName;
                dataGridView1[1, x].Value = quoteDate;
                dataGridView1[2, x].Value = deskWidth;
                dataGridView1[3, x].Value = deskDepth;
                dataGridView1[4, x].Value = deskDrawers;
                dataGridView1[5, x].Value = desktopMaterial;
                dataGridView1[6, x].Value = rushDays;
                dataGridView1[7, x].Value = total;
                x++;
            }

        }
        /*public class QuoteList
        {
            public List<DeskQuote> { get; set; }
        }*/


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
