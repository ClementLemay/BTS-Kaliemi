using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUser
{
    public partial class FormCalendrier : Form
    {
        DateTime prochainRDV;
        
        public FormCalendrier(List<DateTime> unelistDates)
        {
            InitializeComponent();
            List<DateTime> lesDatesSup = new List<DateTime>();
            foreach (DateTime uneDate in unelistDates)
            {
                monthCalendar1.AddBoldedDate(uneDate);
                if(uneDate.Date >= DateTime.Now )
                {
                    lesDatesSup.Add(uneDate);
                }
            }
            try
            {
                prochainRDV = lesDatesSup.Min();
            }
            catch (Exception) { }
        }

        private void btAjouterSV_Click(object sender, EventArgs e)
        {
            try
            {
                monthCalendar1.SelectionStart = prochainRDV;
                monthCalendar1.SelectionEnd = prochainRDV;
            }
            catch (Exception)
            {
                lbEvent.ForeColor = Color.Red;
                lbEvent.Text = "Aucune visite à venir";
            }
        }
    }
}
