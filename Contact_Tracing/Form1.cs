using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        string textfile;
        StreamWriter outputFile;
        public Form1()
        {
            InitializeComponent();
         
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLN.Text) && string.IsNullOrEmpty(textBoxFN.Text))
            {
                btnSubmit.Enabled = false;
                MessageBox.Show("Required Inputs in FirstName And Lastname");
                checkBoxchecker.Checked = false;
            }
            else {
                btnSubmit.Enabled = true;
                textfile = textBoxLN.Text + " "  +  textBoxFN.Text + " " + textBoxMI.Text + ".txt";
            string path = @"C:\Users\Jv Cataquiz\output\" + textfile;
            outputFile = File.CreateText(path);
            outputFile.WriteLine(" " + labelName.Text + " " + textBoxLN.Text + ", " + textBoxFN.Text + " " + textBoxMI.Text + " " + textBoxSUF.Text);
            outputFile.WriteLine(" " + labelDate.Text + " " + dateTimePickerDATE.Value);
            outputFile.WriteLine(" " + labelEmail.Text + " " + textBoxEmail.Text);
            outputFile.WriteLine(" " + labelBday.Text + " " + dateTimePickerBDAY.Value);
            outputFile.WriteLine(" " + labelPhoneNum.Text + " " + textBoxPN.Text);
            outputFile.WriteLine(" " + labeltemp.Text + " " + numericUpDowntemp.Value + "°C");
            outputFile.WriteLine(" " + labelAddress.Text + " " + textBoxADDRESS.Text);
            outputFile.WriteLine("\n " + labelHD.Text);
            outputFile.WriteLine("\t" + labelPlease.Text);
            outputFile.WriteLine("\n\t 1.Are you experiencing(Nakakaranas ka ba ng) :");
            outputFile.Write("\n\t  " + labeloneA.Text);
            if (checkBox1ANo.Checked)
            {
                outputFile.Write("\t[ ]Yes  [✓]No\n");
            }
            else if (checkBox1AYes.Checked)
            {
                outputFile.Write("\t[✓]Yes  [ ]No\n");
            }
            outputFile.Write("\n\t  " + labeloneB.Text);
            if (checkBox1BNo.Checked)
            {
                outputFile.Write("\t[ ]Yes  [✓]No\n");
            }
            else if (checkBox1AYes.Checked)
            {
                outputFile.Write("\t[✓]Yes  [ ]No\n");
            }
            outputFile.Write("\n\t  " + labeloneC.Text);
            if (checkBox1CNo.Checked)
            {
                outputFile.Write("\t[ ]Yes  [✓]No\n");
            }
            else if (checkBox1CYes.Checked)
            {
                outputFile.Write("\t[✓]Yes  [ ]No\n");
            }
            outputFile.Write("\n\t  " + labeloneD.Text);
            if (checkBox1DNo.Checked)
            {
                outputFile.Write("\t[ ]Yes  [✓]No\n");
            }
            else if (checkBox1DYes.Checked)
            {
                outputFile.Write("\t[✓]Yes  [ ]No\n");
            }
            outputFile.Write("\n\t  " + labeloneE.Text);
            if (checkBox1ENo.Checked)
            {
                outputFile.Write("\t[ ]Yes  [✓]No\n");
            }
            else if (checkBox1EYes.Checked)
            {
                outputFile.Write("\t[✓]Yes  [ ]No\n");
            }
            outputFile.Write("\n\t  " + labeloneF.Text);
            if (checkBox1FNo.Checked)
            {
                outputFile.Write("\t[ ]Yes  [✓]No\n");
            }
            else if (checkBox1FYes.Checked)
            {
                outputFile.Write("\t[✓]Yes  [ ]No\n");
            }
            outputFile.Write("\n\t  " + labeloneG.Text);
            if (checkBox1GNo.Checked)
            {
                outputFile.Write("\t[ ]Yes  [✓]No\n");
            }
            else if (checkBox1GYes.Checked)
            {
                outputFile.Write("\t[✓]Yes  [ ]No\n");
            }
            outputFile.WriteLine("\n");
            outputFile.Write("\n\t 2. Have you worked together or stayed together in the same closed environment of a confirmed Covid-19 case? (May nakasama ka ba nakatrabahong tao na kumpirmadong may Covid-19 o corona virus?)");
            if (checkBox2No.Checked)
            {
                outputFile.Write("\t[ ]Yes  [✓]No\n");
            }
            else if (checkBox2Yes.Checked)
            {
                outputFile.Write("\t[✓]Yes  [ ]No\n");
            }
            outputFile.Write("\n\t 3. Have you had any contact with anyone with fever, cough, colds, and sore throat the past 2 weeks? (Mayroon ka bang nakasama na may lagnat, ubo, sipon, o sakit ng lalamunan sa nakalipas na 2 linggo?");
            if (checkBox3No.Checked)
            {
                outputFile.Write("\t[ ]Yes  [✓]No\n");
            }
            else if (checkBox3Yes.Checked)
            {
                outputFile.Write("\t[✓]Yes  [ ]No\n");
            }
            outputFile.Write("\n\t 4. Have you travelled outside the Philippines in the last 14 days? (Ikaw ba ay nagbiyahe sa labas ng Pilipinas sa nakalipas na 14 na araw?)");

            if (checkBox4No.Checked)
            {
                outputFile.Write("\t[ ]Yes  [✓]No\n");
            }
            else if (checkBox4Yes.Checked)
            {
                outputFile.Write("\t[✓]Yes  [ ]No\n");
            }
            outputFile.Write("\n\t 5. Have you travelled to any areas in NCR from your home? Specify where if your answer is Yes. (Ikaw ba ay nagpunta sa ibang parte ng NCR o Metro Manila bukod sa iyong bahay?) (Sabihin kung saan kung ang iyong sagot ay oo.)");
            if (checkBox5No.Checked)
            {
                outputFile.Write("\t[ ]Yes  [✓]No\n\n");
            }
            else if (checkBoxfiveYes.Checked)
            {
                outputFile.Write("\t[✓]Yes  [ ]No\n\n");
            }

            if (checkBoxchecker.Checked)
            {
                outputFile.Write("\t [✓]");
            }
            outputFile.WriteLine(" I hereby authorize Contact Tracing to collect and process the data indicated in survey for the purpose of effecting " +
                "\n control of the Covid-19 infection. I understand that my personal information is protected by RA 10173, Data Privacy Act of 2012, that I am" +
                "\n required by RA 11469, Bayanihan to Heal As One Act, to provide truthful information and that this health declaration is in accordance with " +
                "\n memoranda issued by various government institutions, including the Joint Memorandum Circular No. 20-04-A Series 2020 by the Department of Trade" +
                "\n and Industry (DTI) and the Department of Labor and Employment (DOLE), Memorandum Circular No. 2020-004 by the Department of Tourism (DoT), " +
                "\n and Memorandum Circular No. 2020-077 by the Department of Interior and Local Government (DILG).\n");

                outputFile.Close();
                MessageBox.Show(textfile + " Created Successfully!");
                Process.Start("notepad.exe", @"C:\Users\Jv Cataquiz\output\" + textfile);
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();

        }
        }


        private void onlyletters(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void allowdigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox1ANo_Click(object sender, EventArgs e)
        {
            checkBox1AYes.Checked = false;
            checkBox1ANo.Checked = true;
        }

        private void checkBox1AYes_Click(object sender, EventArgs e)
        {
            checkBox1AYes.Checked = true;
            checkBox1ANo.Checked = false;
        }
        private void checkBox1BNo_Click(object sender, EventArgs e)
        {
            checkBox1BNo.Checked = true;
            checkBox1BYes.Checked = false;
        }
        private void checkBox1BYes_Click(object sender, EventArgs e)
        {
            checkBox1BNo.Checked = false;
            checkBox1BYes.Checked = true;
        }
        private void checkBox1CNo_Click(object sender, EventArgs e)
        {
            checkBox1CNo.Checked = true;
            checkBox1CYes.Checked = false;
        }
        private void checkBox1CYes_Click(object sender, EventArgs e)
        {

            checkBox1CNo.Checked = false;
            checkBox1CYes.Checked = true;
        }

        private void checkBox1DNo_Click(object sender, EventArgs e)
        {
            checkBox1DNo.Checked = true;
            checkBox1DYes.Checked = false;
        }
        private void checkBox1DYes_Click(object sender, EventArgs e)
        {
            checkBox1DNo.Checked = false;
            checkBox1DYes.Checked = true;

        }
        
        private void checkBox1ENo_Click(object sender, EventArgs e)
        {
            checkBox1ENo.Checked = true;
            checkBox1EYes.Checked = false;
        }
        private void checkBox1EYes_Click(object sender, EventArgs e)
        {
            checkBox1ENo.Checked = false;
            checkBox1EYes.Checked = true;
        }

        private void checkBox1FNo_Click(object sender, EventArgs e)
        {
            checkBox1FNo.Checked = true;
            checkBox1FYes.Checked = false;
        }

        private void checkBox1FYes_Click(object sender, EventArgs e)
        {
            checkBox1FNo.Checked = false;
            checkBox1FYes.Checked = true;
        }
        private void checkBox1GNo_Click(object sender, EventArgs e)
        {
            checkBox1GNo.Checked = true;
            checkBox1GYes.Checked = false;
        }

        private void checkBox1GYes_Click(object sender, EventArgs e)
        {
            checkBox1GNo.Checked = false;
            checkBox1GYes.Checked = true;
        }

        private void checkBox2No_Click(object sender, EventArgs e)
        {
            checkBox2No.Checked = true;
            checkBox2Yes.Checked = false;
        }

        private void checkBox2Yes_Click(object sender, EventArgs e)
        {
            checkBox2No.Checked = false;
            checkBox2Yes.Checked = true;
        }

        private void checkBox3No_Click(object sender, EventArgs e)
        {
            checkBox3No.Checked = true;
            checkBox3Yes.Checked = false;
        }

        private void checkBox3Yes_Click(object sender, EventArgs e)
        {
            checkBox3No.Checked = false;
            checkBox3Yes.Checked = true;
        }

        private void checkBox4No_Click(object sender, EventArgs e)
        {
            checkBox4No.Checked = true;
            checkBox4Yes.Checked = false;
        }

        private void checkBox4Yes_Click(object sender, EventArgs e)
        {
            checkBox4No.Checked = false;
            checkBox4Yes.Checked = true;
        }

        private void checkBox5No_Click(object sender, EventArgs e)
        {
            checkBox5No.Checked = true;
            checkBoxfiveYes.Checked = false;
        }

        private void checkBoxfiveYes_Click(object sender, EventArgs e)
        {
            checkBox5No.Checked = false;
            checkBoxfiveYes.Checked = true;
        }

        private void checkBoxchecker_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBoxchecker_Click(object sender, EventArgs e)
        {
            if ((!checkBoxchecker.Checked))
            {
                btnSubmit.Enabled = false;
            }
            else
            {
                btnSubmit.Enabled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLN_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxLN_Validating(object sender, CancelEventArgs e)
        {
          
        }
    }
}
