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

        List<Part> Parts = new List<Part>();
        Part currentPart;
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

                    Parts.Clear();
                    SaveFile.BaseStream.Seek(partsLoc, SeekOrigin.Begin);
                    Part n = new Part(SaveFile.ReadBytes(84));
                    while(n.ID != 0)
                    {
                        Parts.Add(n);
                        n = new Part(SaveFile.ReadBytes(84));
                    }
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

                cbParts.Items.Clear();
                for (int i = 0; i < Parts.Count; i++)
                    cbParts.Items.Add(Parts[i].ID);

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

                    SaveFile.BaseStream.Seek(partsLoc, SeekOrigin.Begin);
                    for (int i = 0; i < Parts.Count; i++)
                        SaveFile.Write(Parts[i].data);
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

        private void cbParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPart = Parts[cbParts.SelectedIndex];
            txtID.Text = currentPart.ID.ToString();
            txtDPS.Text = currentPart.WeaponDPS.ToString();
            txtSlot.Text = currentPart.Slot.ToString();
            cbLabel.SelectedIndex = currentPart.Label;
            numLevel.Value = currentPart.Level;
            cbRarity.SelectedIndex = currentPart.Rarity;

            txtAb1.Text = currentPart.getAbility(0).ToString();
            txtAb2.Text = currentPart.getAbility(1).ToString();
            txtAb3.Text = currentPart.getAbility(2).ToString();
            txtAb4.Text = currentPart.getAbility(3).ToString();
            txtAb5.Text = currentPart.getAbility(4).ToString();
            txtAb6.Text = currentPart.getAbility(5).ToString();
            txtAb7.Text = currentPart.getAbility(6).ToString();
            txtAb8.Text = currentPart.getAbility(7).ToString();
            txtAb9.Text = currentPart.getAbility(8).ToString();
            txtAb10.Text = currentPart.getAbility(9).ToString();

            numAb1.Value = (decimal)currentPart.getAbilityValue(0);
            numAb2.Value = (decimal)currentPart.getAbilityValue(1);
            numAb3.Value = (decimal)currentPart.getAbilityValue(2);
            numAb4.Value = (decimal)currentPart.getAbilityValue(3);
            numAb5.Value = (decimal)currentPart.getAbilityValue(4);
            numAb6.Value = (decimal)currentPart.getAbilityValue(5);
            numAb7.Value = (decimal)currentPart.getAbilityValue(6);
            numAb8.Value = (decimal)currentPart.getAbilityValue(7);
            numAb9.Value = (decimal)currentPart.getAbilityValue(8);
            numAb10.Value = (decimal)currentPart.getAbilityValue(9);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            int p;
            if (int.TryParse(txtID.Text, out p))
            {
                currentPart.ID = p;
                Parts[cbParts.SelectedIndex] = currentPart;
            }
        }

        private void txtDPS_TextChanged(object sender, EventArgs e)
        {
            short p;
            if (short.TryParse(txtDPS.Text,out p))
            {
                currentPart.WeaponDPS = p;
                Parts[cbParts.SelectedIndex] = currentPart;
            }

        }

        private void txtSlot_TextChanged(object sender, EventArgs e)
        {
            short p;
            if (short.TryParse(txtSlot.Text, out p))
            {
                currentPart.Slot = p;
                Parts[cbParts.SelectedIndex] = currentPart;
            }
        }

        private void cbLabel_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPart.Label = (byte)cbLabel.SelectedIndex;
            Parts[cbParts.SelectedIndex] = currentPart;
        }

        private void numLevel_ValueChanged(object sender, EventArgs e)
        {
            currentPart.Level = (byte)numLevel.Value;
            Parts[cbParts.SelectedIndex] = currentPart;
        }

        private void cbRarity_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPart.Rarity = (byte)cbRarity.SelectedIndex;
            Parts[cbParts.SelectedIndex] = currentPart;
        }

        private void txtAb1_TextChanged(object sender, EventArgs e)
        {
            short p;
            if (short.TryParse(txtAb1.Text, out p))
            {
                currentPart.setAbility(0, p);
                Parts[cbParts.SelectedIndex] = currentPart;
            }
        }

        private void numAb1_ValueChanged(object sender, EventArgs e)
        {
            currentPart.setAbilityValue(0, (float)numAb1.Value);
            Parts[cbParts.SelectedIndex] = currentPart;
        }

        private void txtAb2_TextChanged(object sender, EventArgs e)
        {
            short p;
            if (short.TryParse(txtAb2.Text, out p))
            {
                currentPart.setAbility(1, p);
                Parts[cbParts.SelectedIndex] = currentPart;
            }
        }

        private void numAb2_ValueChanged(object sender, EventArgs e)
        {
            currentPart.setAbilityValue(1, (float)numAb2.Value);
            Parts[cbParts.SelectedIndex] = currentPart;
        }

        private void txtAb3_TextChanged(object sender, EventArgs e)
        {
            short p;
            if (short.TryParse(txtAb3.Text, out p))
            {
                currentPart.setAbility(2, p);
                Parts[cbParts.SelectedIndex] = currentPart;
            }
        }

        private void numAb3_ValueChanged(object sender, EventArgs e)
        {
            currentPart.setAbilityValue(2, (float)numAb3.Value);
            Parts[cbParts.SelectedIndex] = currentPart;
        }

        private void txtAb4_TextChanged(object sender, EventArgs e)
        {
            short p;
            if (short.TryParse(txtAb4.Text, out p))
            {
                currentPart.setAbility(3, p);
                Parts[cbParts.SelectedIndex] = currentPart;
            }
        }

        private void numAb4_ValueChanged(object sender, EventArgs e)
        {
            currentPart.setAbilityValue(3, (float)numAb4.Value);
            Parts[cbParts.SelectedIndex] = currentPart;
        }

        private void txtAb5_TextChanged(object sender, EventArgs e)
        {
            short p;
            if (short.TryParse(txtAb5.Text, out p))
            {
                currentPart.setAbility(4, p);
                Parts[cbParts.SelectedIndex] = currentPart;
            }
        }

        private void numAb5_ValueChanged(object sender, EventArgs e)
        {
            currentPart.setAbilityValue(4, (float)numAb5.Value);
            Parts[cbParts.SelectedIndex] = currentPart;
        }

        private void txtAb6_TextChanged(object sender, EventArgs e)
        {
            short p;
            if (short.TryParse(txtAb6.Text, out p))
            {
                currentPart.setAbility(5, p);
                Parts[cbParts.SelectedIndex] = currentPart;
            }
        }

        private void numAb6_ValueChanged(object sender, EventArgs e)
        {
            currentPart.setAbilityValue(5, (float)numAb6.Value);
            Parts[cbParts.SelectedIndex] = currentPart;
        }

        private void txtAb7_TextChanged(object sender, EventArgs e)
        {
            short p;
            if (short.TryParse(txtAb7.Text, out p))
            {
                currentPart.setAbility(6, p);
                Parts[cbParts.SelectedIndex] = currentPart;
            }
        }

        private void numAb7_ValueChanged(object sender, EventArgs e)
        {
            currentPart.setAbilityValue(6, (float)numAb7.Value);
            Parts[cbParts.SelectedIndex] = currentPart;
        }

        private void txtAb8_TextChanged(object sender, EventArgs e)
        {
            short p;
            if (short.TryParse(txtAb8.Text, out p))
            {
                currentPart.setAbility(7, p);
                Parts[cbParts.SelectedIndex] = currentPart;
            }
        }

        private void numAb8_ValueChanged(object sender, EventArgs e)
        {
            currentPart.setAbilityValue(7, (float)numAb8.Value);
            Parts[cbParts.SelectedIndex] = currentPart;
        }

        private void txtAb9_TextChanged(object sender, EventArgs e)
        {
            short p;
            if (short.TryParse(txtAb9.Text, out p))
            {
                currentPart.setAbility(8, p);
                Parts[cbParts.SelectedIndex] = currentPart;
            }
        }

        private void numAb9_ValueChanged(object sender, EventArgs e)
        {
            currentPart.setAbilityValue(8, (float)numAb9.Value);
            Parts[cbParts.SelectedIndex] = currentPart;
        }

        private void txtAb10_TextChanged(object sender, EventArgs e)
        {
            short p;
            if (short.TryParse(txtAb10.Text, out p))
            {
                currentPart.setAbility(9, p);
                Parts[cbParts.SelectedIndex] = currentPart;
            }
        }

        private void numAb10_ValueChanged(object sender, EventArgs e)
        {
            currentPart.setAbilityValue(9, (float)numAb10.Value);
            Parts[cbParts.SelectedIndex] = currentPart;
        }

        private void btnLevel_Click(object sender, EventArgs e)
        {
            byte p = (byte)numLevel.Value;
            Part temp;
            for (int i = 0; i < Parts.Count; i++)
            {
                temp = Parts[i];
                temp.Level = p;
                Parts[i] = temp;
            }
        }

        private void btnRarity_Click(object sender, EventArgs e)
        {
            byte p = (byte)cbRarity.SelectedIndex;
            Part temp;
            for (int i = 0; i < Parts.Count; i++)
            {
                temp = Parts[i];
                temp.Rarity = p;
                Parts[i] = temp;
            }
        }
    }
}
