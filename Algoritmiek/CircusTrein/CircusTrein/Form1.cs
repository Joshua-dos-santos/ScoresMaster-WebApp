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
        Dier dier = new Dier();
        public Form1()
        {
            InitializeComponent();

        }

        private void DierToevoegenBtn_Click(object sender, EventArgs e)
        {

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
        public void SorteerDieren()
        {
            for (int i = 0; i <= AlleDieren.Count; i++)
            {
                if(dier.Voeding == VleesRB.Text && dier.Grootte == KleinRB.Text)
                {
                    if(Wagon1.Items.Contains(dier.Voeding == PlantenRB.Text && dier.Grootte == MiddelgrootRB.Text || dier.Grootte == GrootRB.Text))
                    {
                        Wagon1.Items.Add(dier);
                    }
                    else if(Wagon2.Items.Contains(dier.Voeding == PlantenRB.Text && dier.Grootte == MiddelgrootRB.Text || dier.Grootte == GrootRB.Text))
                    {
                        Wagon2.Items.Add(dier);
                    }
                    else
                    {
                        Wagon3.Items.Add(dier);
                    }
                }
                else if(dier.Voeding == VleesRB.Text && dier.Grootte == MiddelgrootRB.Text)
                {
                    if(Wagon1.Items.Contains(dier.Voeding == PlantenRB.Text && dier.Grootte == GrootRB.Text) && !Wagon1.Items.Contains(dier.Voeding == VleesRB.Text && dier.Grootte == KleinRB.Text || dier.Voeding == VleesRB.Text && dier.Grootte == MiddelgrootRB.Text))
                    {
                        Wagon1.Items.Add(dier);
                    }
                    else if(Wagon2.Items.Contains(dier.Voeding == PlantenRB.Text && dier.Grootte == GrootRB.Text))
                    {
                        Wagon2.Items.Add(dier);
                    }
                    else
                    {
                        Wagon3.Items.Add(dier);
                    }
                }
                else if(dier.Voeding == VleesRB.Text && dier.Grootte == GrootRB.Text)
                {
                    
                }
            }
        }
    }
}
