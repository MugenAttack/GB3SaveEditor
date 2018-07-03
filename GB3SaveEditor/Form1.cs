using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GB3SaveEditor
{
    public partial class Form1 : Form
    {
        const long playerData = 0x19590; //Credits, Experience, Rank   (Int32)
        const long plasticLoc = 0xc93fc;
        const long partsLoc = 0x1D25C;
        const long cubeLoc = 0xC10BC;
        int Credits;
        int Experience;
        int Rank;
        short[] plastics = new short[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (BinaryReader SaveFile = new BinaryReader(File.Open(ofd.FileName, FileMode.Open)))
                {
                    SaveFile.BaseStream.Seek(playerData, SeekOrigin.Begin);
                    Credits = SaveFile.ReadInt32();
                    Experience = SaveFile.ReadInt32();
                    Rank = SaveFile.ReadInt32();

                    SaveFile.BaseStream.Seek(plasticLoc, SeekOrigin.Begin);
                    for (int i = 0; i < 6; i++)
                        plastics[i] = SaveFile.ReadInt16();
                }

                txtCredits.Text = Credits.ToString();
                txtExp.Text = Experience.ToString();
                txtRank.Text = Rank.ToString();

                numPLow.Value = plastics[0];
                numPMed.Value = plastics[1];
                numPHigh.Value = plastics[2];
                numHPLow.Value = plastics[3];
                numHPMed.Value = plastics[4];
                numHPHigh.Value = plastics[5];

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save File";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (BinaryWriter SaveFile = new BinaryWriter(File.Open(sfd.FileName, FileMode.Open)))
                {
                    SaveFile.BaseStream.Seek(playerData, SeekOrigin.Begin);
                    SaveFile.Write(Credits);
                    SaveFile.Write(Experience);
                    SaveFile.Write(Rank);

                    SaveFile.BaseStream.Seek(plasticLoc, SeekOrigin.Begin);
                    for (int i = 0; i < 6; i++)
                        SaveFile.Write(plastics[i]);
                }
            }
        }

        private void txtCredits_TextChanged(object sender, EventArgs e)
        {
            int p;
            if (int.TryParse(txtCredits.Text,out p))
            {
                Credits = p;
            }
        }

        private void txtExp_TextChanged(object sender, EventArgs e)
        {
            int p;
            if (int.TryParse(txtExp.Text, out p))
            {
                Experience = p;
            }
        }

        private void txtRank_TextChanged(object sender, EventArgs e)
        {
            int p;
            if (int.TryParse(txtRank.Text, out p))
            {
                if (p > 999)
                {
                    Rank = 999;
                    txtRank.Text = 999.ToString();
                }
                else
                    Rank = p;
            }
        }

        private void numPLow_ValueChanged(object sender, EventArgs e)
        {
            plastics[0] = (short)numPLow.Value;
        }

        private void numPMed_ValueChanged(object sender, EventArgs e)
        {
            plastics[1] = (short)numPMed.Value;
        }

        private void numPHigh_ValueChanged(object sender, EventArgs e)
        {
            plastics[2] = (short)numPHigh.Value;
        }

        private void numHPLow_ValueChanged(object sender, EventArgs e)
        {
            plastics[3] = (short)numHPLow.Value;
        }

        private void numHPMed_ValueChanged(object sender, EventArgs e)
        {
            plastics[4] = (short)numHPMed.Value;
        }

        private void numHPHigh_ValueChanged(object sender, EventArgs e)
        {
            plastics[5] = (short)numHPHigh.Value;
        }
    }
}
