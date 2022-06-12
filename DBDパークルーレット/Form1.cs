using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBDパークルーレット
{
    public partial class Form1 : Form
    {
        Perk perk = new Perk();
        ToolTip tooltip = new ToolTip();
        bool isExecuting = false;

        public Form1()
        {
            InitializeComponent();
            tooltip.AutoPopDelay = 32767;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void startRouletteButton_Click(object sender, EventArgs e)
        {
            isExecuting = true;
            stopRouletteButton.Enabled = true;
            startRouletteButton.Enabled = false;
            perk1PageTextBox.Text = "";
            perk2PageTextBox.Text = "";
            perk3PageTextBox.Text = "";
            perk4PageTextBox.Text = "";
            perk1PositionTextBox.Text = "";
            perk2PositionTextBox.Text = "";
            perk3PositionTextBox.Text = "";
            perk4PositionTextBox.Text = "";
            Task task = Task.Run(() => { ExecuteRoullete(); });
        }

        private void ExecuteRoullete()
        {
            List<int> indices = new List<int>();
            while (isExecuting)
            {
                indices.Clear();
                int index;
                Random rand = new Random();

                for (int i = 0; i < 4; i++)
                {
                    while (true)
                    {
                        index = rand.Next(0, perk.Perks.SurvivorPerks.Length);
                        if (!indices.Contains(index))
                        {
                            indices.Add(index);
                            break;
                        }
                    }
                }
                this.Invoke((Action)(() =>
                {
                    perk1Label.Text = perk.Perks.SurvivorPerks[indices[0]].Perk;
                    perk2Label.Text = perk.Perks.SurvivorPerks[indices[1]].Perk;
                    perk3Label.Text = perk.Perks.SurvivorPerks[indices[2]].Perk;
                    perk4Label.Text = perk.Perks.SurvivorPerks[indices[3]].Perk;
                }));
            }

            this.Invoke((Action)(() =>
            {
                tooltip.RemoveAll();
                tooltip.SetToolTip(perk1Label, perk.Perks.SurvivorPerks[indices[0]].GetTooltipText());
                tooltip.SetToolTip(perk2Label, perk.Perks.SurvivorPerks[indices[1]].GetTooltipText());
                tooltip.SetToolTip(perk3Label, perk.Perks.SurvivorPerks[indices[2]].GetTooltipText());
                tooltip.SetToolTip(perk4Label, perk.Perks.SurvivorPerks[indices[3]].GetTooltipText());

                perk1PageTextBox.Text = perk.Perks.SurvivorPerks[indices[0]].Page.ToString();
                perk2PageTextBox.Text = perk.Perks.SurvivorPerks[indices[1]].Page.ToString();
                perk3PageTextBox.Text = perk.Perks.SurvivorPerks[indices[2]].Page.ToString();
                perk4PageTextBox.Text = perk.Perks.SurvivorPerks[indices[3]].Page.ToString();
                perk1PositionTextBox.Text = GetPosition(perk.Perks.SurvivorPerks[indices[0]].Order);
                perk2PositionTextBox.Text = GetPosition(perk.Perks.SurvivorPerks[indices[1]].Order);
                perk3PositionTextBox.Text = GetPosition(perk.Perks.SurvivorPerks[indices[2]].Order);
                perk4PositionTextBox.Text = GetPosition(perk.Perks.SurvivorPerks[indices[3]].Order);
            }));   
        }

        private void stopRouletteButton_Click(object sender, EventArgs e)
        {
            isExecuting = false;
            stopRouletteButton.Enabled = false;
            startRouletteButton.Enabled = true;
        }

        private string GetPosition(int order)
        {
            string result = "";

            if(order <= 5)
            {
                result += "上段　";
            }
            else if(order <= 10)
            {
                result += "中段　";
            }
            else
            {
                result += "下段　";
            }
            if(order%5 == 0)
            {
                result += $"5番目";
            }
            else
            {
                result += $"{order % 5}番目";
            }
            return result;
        }
    }
}
