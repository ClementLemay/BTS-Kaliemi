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
        public FormCalendrier(List<DateTime> unelistDates)
        {
            InitializeComponent();
            foreach (DateTime uneDate in unelistDates)
            {
                monthCalendar1.AddBoldedDate(uneDate);
            }
        }
    }
}
