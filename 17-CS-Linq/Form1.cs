using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _17_CS_Linq
{
    public partial class Form1 : Form
    {
        class Human
        {
            private DateTime dtDOB;
            public DateTime DOB { get { return dtDOB; } set { dtDOB = value; } }
            private String strName;
            public String Name { get { return strName; } set { strName = value; } }
            public int AgeInYears 
            { 
                get 
                {
                    DateTime dtNow = DateTime.Now;
                    int iYr = dtNow.Year - dtDOB.Year;
                    if (dtNow.Month > dtDOB.Month)
                        return iYr;

                    if (dtNow.Month == dtDOB.Month && dtNow.Day >= dtDOB.Day)
                        return iYr;

                    return iYr - 1;
                } 
            }

            public int AgeInDays
            {
                get
                {
                    DateTime dtNow = DateTime.Now;
                    TimeSpan ts = dtNow - dtDOB;
                    return (int)ts.TotalDays;
                }
            }

            public Human(string strName, DateTime dtDOB)
            {
                this.strName = strName;
                this.dtDOB = dtDOB;
            }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Human p1 = new Human("John", new DateTime(1990, 1, 2));
            Human p2 = new Human("Mary", new DateTime(1970, 2, 2));
            Human p3 = new Human("Jane", new DateTime(1979, 3, 27));
            Human p4 = new Human("Clive", new DateTime(2023, 1, 2));
            Human p5 = new Human("Don", new DateTime(2023, 2, 3));
            List<Human> lstP = new(new Human[] { p1, p2, p3, p4, p5 });
            WriteInTrace("Print the original list");
            fnPrint(lstP);
            WriteInTrace("Print the list sorted by Age/Days");
            lstP.Sort((x, y) => x.AgeInDays.CompareTo(y.AgeInDays));
            fnPrint(lstP);
            WriteInTrace("Print the list sorted by Age/Years");
            lstP.Sort((x, y) => x.AgeInYears.CompareTo(y.AgeInYears));
            fnPrint(lstP);
            WriteInTrace("Print the list sorted by Name");
            lstP.Sort((x, y) => x.Name.CompareTo(y.Name));
            fnPrint(lstP);

            WriteInTrace("Print the list sorted by Age/Days - Descending");
            lstP.Sort((x, y) => y.AgeInDays.CompareTo(x.AgeInDays));
            fnPrint(lstP);
        }

        private void fnPrint(List<Human> lst)
        {
            foreach(Human h in lst)
            {
                if (h.AgeInYears <= 0)
                    WriteInTrace($"Name: {h.Name}, DOD: {h.DOB}, Age: {h.AgeInDays} day(s)");
                else
                    WriteInTrace($"Name: {h.Name}, DOD: {h.DOB}, Age: {h.AgeInYears} year(s)");
            }
        }

        private void WriteInTrace(string str)
        {
            txtTrace.Text = txtTrace.Text + Environment.NewLine + str;
        }
    }
}
