using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrein
{
    public partial class Form1 : Form
    {
        List<Dier> AlleDieren = new List<Dier>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void DierToevoegenBtn_Click(object sender, EventArgs e)
        {
            Dier dier = new Dier();
            dier.DierType = DierNaamTB.Text;
            if (KleinRB.Checked == true)
            {
                dier.Grootte = KleinRB.Text;
                if (PlantenRB.Checked == true)
                {
                    dier.Voeding = PlantenRB.Text;
                }
                else if (VleesRB.Checked == true)
                {
                    dier.Voeding = VleesRB.Text;
                }
                AlleDieren.Add(dier);
            }
            else if (MiddelgrootRB.Checked == true)
            {
                dier.Grootte = MiddelgrootRB.Text;
                if (PlantenRB.Checked == true)
                {
                    dier.Voeding = PlantenRB.Text;
                }
                else if (VleesRB.Checked == true)
                {
                    dier.Voeding = VleesRB.Text;
                }
                AlleDieren.Add(dier);
            }
            else if (GrootRB.Checked == true)
            {
                dier.Grootte = GrootRB.Text;
                if (PlantenRB.Checked == true)
                {
                    dier.Voeding = PlantenRB.Text;
                }
                else if (VleesRB.Checked == true)
                {
                    dier.Voeding = VleesRB.Text;
                }
                AlleDieren.Add(dier);
            }
        }

        
    }
}
