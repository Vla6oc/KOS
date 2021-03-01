using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace KOS
{
    public partial class Form1 : Form
    {

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Вопросы.mdb;";
        private OleDbConnection myConnection;
        public string CmdText1 = "SELECT * FROM [Вопрос1]";
        public string CmdText2 = "SELECT * FROM [Вопрос2]";
        public string CmdText3 = "SELECT * FROM [Вопрос3]";
        public string CmdText4 = "SELECT * FROM [Вопрос4]";
        public string CmdText5 = "SELECT * FROM [Вопрос5]";
        public Form1()
        {

            InitializeComponent();
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);
            // открываем соединение с БД
            myConnection.Open();
            comboBox1.Text = "1";
            comboBox2.Text = "1";
        }
        private void button_Click(object sender, EventArgs e)
        {
            
        }
        public void rt1()
        {
            if
           (pictureBox1.Image == null &&
            pictureBox2.Image == null &&
            pictureBox3.Image == null &&
            pictureBox4.Image == null &&
            pictureBox5.Image == null &&
            pictureBox6.Image == null &&
            pictureBox7.Image == null &&
            pictureBox8.Image == null &&
            pictureBox9.Image == null &&
            pictureBox10.Image == null &&
            pictureBox11.Image == null &&
            pictureBox12.Image == null &&
            pictureBox13.Image == null &&
            pictureBox14.Image == null &&
            pictureBox15.Image == null &&
            pictureBox16.Image == null &&
            pictureBox17.Image == null &&
            pictureBox18.Image == null &&
            pictureBox19.Image == null &&
            pictureBox20.Image == null &&
            pictureBox21.Image == null &&
            pictureBox22.Image == null &&
            pictureBox23.Image == null &&
            pictureBox24.Image == null &&
            pictureBox25.Image == null &&
            pictureBox26.Image == null &&
            pictureBox27.Image == null &&
            pictureBox28.Image == null &&
            pictureBox29.Image == null &&
            pictureBox30.Image == null &&
            pictureBox31.Image == null &&
            pictureBox32.Image == null &&
            pictureBox33.Image == null &&
            pictureBox34.Image == null &&
            pictureBox35.Image == null &&
            pictureBox36.Image == null &&
            pictureBox37.Image == null &&
            pictureBox38.Image == null &&
            pictureBox39.Image == null &&
            pictureBox40.Image == null &&
            pictureBox41.Image == null &&
            pictureBox42.Image == null &&
            pictureBox43.Image == null &&
            pictureBox44.Image == null &&
            pictureBox45.Image == null &&
            pictureBox46.Image == null &&
            pictureBox47.Image == null &&
            pictureBox48.Image == null &&
            pictureBox49.Image == null &&
            pictureBox50.Image == null)
            {
                label1.Text = "Все уровни пройдены!";
            }

        }
        public void rt2()
        {
            if (
            pictureBox1.Image == null &&
            pictureBox2.Image == null &&
            pictureBox3.Image == null &&
            pictureBox4.Image == null &&
            pictureBox5.Image == null &&
            pictureBox6.Image == null &&
            pictureBox7.Image == null &&
            pictureBox8.Image == null &&
            pictureBox9.Image == null &&
            pictureBox10.Image == null &&
            pictureBox11.Image == null &&
            pictureBox12.Image == null &&
            pictureBox13.Image == null &&
            pictureBox14.Image == null &&
            pictureBox15.Image == null &&
            pictureBox16.Image == null &&
            pictureBox17.Image == null &&
            pictureBox18.Image == null &&
            pictureBox19.Image == null &&
            pictureBox20.Image == null &&
            pictureBox21.Image == null &&
            pictureBox22.Image == null &&
            pictureBox23.Image == null &&
            pictureBox24.Image == null &&
            pictureBox25.Image == null &&
            pictureBox26.Image == null &&
            pictureBox27.Image == null &&
            pictureBox28.Image == null &&
            pictureBox29.Image == null &&
            pictureBox30.Image == null &&
            pictureBox31.Image == null &&
            pictureBox32.Image == null &&
            pictureBox33.Image == null &&
            pictureBox34.Image == null &&
            pictureBox35.Image == null &&
            pictureBox36.Image == null &&
            pictureBox37.Image == null &&
            pictureBox38.Image == null &&
            pictureBox39.Image == null &&
            pictureBox40.Image == null &&
            pictureBox41.Image == null &&
            pictureBox42.Image == null &&
            pictureBox43.Image == null &&
            pictureBox44.Image == null &&
            pictureBox45.Image == null &&
            pictureBox46.Image == null &&
            pictureBox47.Image == null &&
            pictureBox48.Image == null &&
            pictureBox49.Image == null &&
            pictureBox50.Image == null)
            {
                pictureBox1.Image = Properties.Resources._1;
                pictureBox2.Image = Properties.Resources._2;
                pictureBox3.Image = Properties.Resources._3;
                pictureBox4.Image = Properties.Resources._4;
                pictureBox5.Image = Properties.Resources._5;
                pictureBox6.Image = Properties.Resources._6;
                pictureBox7.Image = Properties.Resources._7;
                pictureBox8.Image = Properties.Resources._8;
                pictureBox9.Image = Properties.Resources._9;
                pictureBox10.Image = Properties.Resources._10;
                pictureBox11.Image = Properties.Resources._11;
                pictureBox12.Image = Properties.Resources._12;
                pictureBox13.Image = Properties.Resources._13;
                pictureBox14.Image = Properties.Resources._14;
                pictureBox15.Image = Properties.Resources._15;
                pictureBox16.Image = Properties.Resources._16;
                pictureBox17.Image = Properties.Resources._17;
                pictureBox18.Image = Properties.Resources._18;
                pictureBox19.Image = Properties.Resources._19;
                pictureBox20.Image = Properties.Resources._20;
                pictureBox21.Image = Properties.Resources._21;
                pictureBox22.Image = Properties.Resources._22;
                pictureBox23.Image = Properties.Resources._23;
                pictureBox24.Image = Properties.Resources._24;
                pictureBox25.Image = Properties.Resources._25;
                pictureBox26.Image = Properties.Resources._26;
                pictureBox27.Image = Properties.Resources._27;
                pictureBox28.Image = Properties.Resources._28;
                pictureBox29.Image = Properties.Resources._29;
                pictureBox30.Image = Properties.Resources._30;
                pictureBox31.Image = Properties.Resources._31;
                pictureBox32.Image = Properties.Resources._32;
                pictureBox33.Image = Properties.Resources._33;
                pictureBox34.Image = Properties.Resources._34;
                pictureBox35.Image = Properties.Resources._35;
                pictureBox36.Image = Properties.Resources._36;
                pictureBox37.Image = Properties.Resources._37;
                pictureBox38.Image = Properties.Resources._38;
                pictureBox39.Image = Properties.Resources._39;
                pictureBox40.Image = Properties.Resources._40;
                pictureBox41.Image = Properties.Resources._41;
                pictureBox42.Image = Properties.Resources._42;
                pictureBox43.Image = Properties.Resources._43;
                pictureBox44.Image = Properties.Resources._44;
                pictureBox45.Image = Properties.Resources._45;
                pictureBox46.Image = Properties.Resources._46;
                pictureBox47.Image = Properties.Resources._47;
                pictureBox48.Image = Properties.Resources._48;
                pictureBox49.Image = Properties.Resources._49;
                pictureBox50.Image = Properties.Resources._50;
                label1.Text = "Второй уровень!";
                int count = 0;
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    if (Convert.ToString(dataGridView2.Rows[i].Cells[1].Value) == "")
                        count++;
                }
                for (int j = 1; j < count; j++)
                {
                    try
                    {
                        (panel1.Controls["pictureBox" + (51 - j)] as PictureBox).Image = null;
                        (panel1.Controls["pictureBox" + j] as PictureBox).Enabled = true;
                        (panel1.Controls["pictureBox" + (51 - j)] as PictureBox).Enabled = false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка! Вопросы не найдены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        public void rt3()
        {
            if (
            pictureBox1.Image == null &&
            pictureBox2.Image == null &&
            pictureBox3.Image == null &&
            pictureBox4.Image == null &&
            pictureBox5.Image == null &&
            pictureBox6.Image == null &&
            pictureBox7.Image == null &&
            pictureBox8.Image == null &&
            pictureBox9.Image == null &&
            pictureBox10.Image == null &&
            pictureBox11.Image == null &&
            pictureBox12.Image == null &&
            pictureBox13.Image == null &&
            pictureBox14.Image == null &&
            pictureBox15.Image == null &&
            pictureBox16.Image == null &&
            pictureBox17.Image == null &&
            pictureBox18.Image == null &&
            pictureBox19.Image == null &&
            pictureBox20.Image == null &&
            pictureBox21.Image == null &&
            pictureBox22.Image == null &&
            pictureBox23.Image == null &&
            pictureBox24.Image == null &&
            pictureBox25.Image == null &&
            pictureBox26.Image == null &&
            pictureBox27.Image == null &&
            pictureBox28.Image == null &&
            pictureBox29.Image == null &&
            pictureBox30.Image == null &&
            pictureBox31.Image == null &&
            pictureBox32.Image == null &&
            pictureBox33.Image == null &&
            pictureBox34.Image == null &&
            pictureBox35.Image == null &&
            pictureBox36.Image == null &&
            pictureBox37.Image == null &&
            pictureBox38.Image == null &&
            pictureBox39.Image == null &&
            pictureBox40.Image == null &&
            pictureBox41.Image == null &&
            pictureBox42.Image == null &&
            pictureBox43.Image == null &&
            pictureBox44.Image == null &&
            pictureBox45.Image == null &&
            pictureBox46.Image == null &&
            pictureBox47.Image == null &&
            pictureBox48.Image == null &&
            pictureBox49.Image == null &&
            pictureBox50.Image == null)
            {
                pictureBox1.Image = Properties.Resources._1;
                pictureBox2.Image = Properties.Resources._2;
                pictureBox3.Image = Properties.Resources._3;
                pictureBox4.Image = Properties.Resources._4;
                pictureBox5.Image = Properties.Resources._5;
                pictureBox6.Image = Properties.Resources._6;
                pictureBox7.Image = Properties.Resources._7;
                pictureBox8.Image = Properties.Resources._8;
                pictureBox9.Image = Properties.Resources._9;
                pictureBox10.Image = Properties.Resources._10;
                pictureBox11.Image = Properties.Resources._11;
                pictureBox12.Image = Properties.Resources._12;
                pictureBox13.Image = Properties.Resources._13;
                pictureBox14.Image = Properties.Resources._14;
                pictureBox15.Image = Properties.Resources._15;
                pictureBox16.Image = Properties.Resources._16;
                pictureBox17.Image = Properties.Resources._17;
                pictureBox18.Image = Properties.Resources._18;
                pictureBox19.Image = Properties.Resources._19;
                pictureBox20.Image = Properties.Resources._20;
                pictureBox21.Image = Properties.Resources._21;
                pictureBox22.Image = Properties.Resources._22;
                pictureBox23.Image = Properties.Resources._23;
                pictureBox24.Image = Properties.Resources._24;
                pictureBox25.Image = Properties.Resources._25;
                pictureBox26.Image = Properties.Resources._26;
                pictureBox27.Image = Properties.Resources._27;
                pictureBox28.Image = Properties.Resources._28;
                pictureBox29.Image = Properties.Resources._29;
                pictureBox30.Image = Properties.Resources._30;
                pictureBox31.Image = Properties.Resources._31;
                pictureBox32.Image = Properties.Resources._32;
                pictureBox33.Image = Properties.Resources._33;
                pictureBox34.Image = Properties.Resources._34;
                pictureBox35.Image = Properties.Resources._35;
                pictureBox36.Image = Properties.Resources._36;
                pictureBox37.Image = Properties.Resources._37;
                pictureBox38.Image = Properties.Resources._38;
                pictureBox39.Image = Properties.Resources._39;
                pictureBox40.Image = Properties.Resources._40;
                pictureBox41.Image = Properties.Resources._41;
                pictureBox42.Image = Properties.Resources._42;
                pictureBox43.Image = Properties.Resources._43;
                pictureBox44.Image = Properties.Resources._44;
                pictureBox45.Image = Properties.Resources._45;
                pictureBox46.Image = Properties.Resources._46;
                pictureBox47.Image = Properties.Resources._47;
                pictureBox48.Image = Properties.Resources._48;
                pictureBox49.Image = Properties.Resources._49;
                pictureBox50.Image = Properties.Resources._50;
                label1.Text = "Третий уровень!";
                int count = 0;
                for (int i = 0; i < dataGridView3.RowCount; i++)
                {
                    if (Convert.ToString(dataGridView3.Rows[i].Cells[1].Value) == "")
                        count++;
                }
                for (int j = 1; j < count; j++)
                {
                    try
                    {
                        (panel1.Controls["pictureBox" + (51 - j)] as PictureBox).Image = null;
                        (panel1.Controls["pictureBox" + j] as PictureBox).Enabled = true;
                        (panel1.Controls["pictureBox" + (51 - j)] as PictureBox).Enabled = false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка! Вопросы не найдены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        public void rt4()
        {
            if (
            pictureBox1.Image == null &&
            pictureBox2.Image == null &&
            pictureBox3.Image == null &&
            pictureBox4.Image == null &&
            pictureBox5.Image == null &&
            pictureBox6.Image == null &&
            pictureBox7.Image == null &&
            pictureBox8.Image == null &&
            pictureBox9.Image == null &&
            pictureBox10.Image == null &&
            pictureBox11.Image == null &&
            pictureBox12.Image == null &&
            pictureBox13.Image == null &&
            pictureBox14.Image == null &&
            pictureBox15.Image == null &&
            pictureBox16.Image == null &&
            pictureBox17.Image == null &&
            pictureBox18.Image == null &&
            pictureBox19.Image == null &&
            pictureBox20.Image == null &&
            pictureBox21.Image == null &&
            pictureBox22.Image == null &&
            pictureBox23.Image == null &&
            pictureBox24.Image == null &&
            pictureBox25.Image == null &&
            pictureBox26.Image == null &&
            pictureBox27.Image == null &&
            pictureBox28.Image == null &&
            pictureBox29.Image == null &&
            pictureBox30.Image == null &&
            pictureBox31.Image == null &&
            pictureBox32.Image == null &&
            pictureBox33.Image == null &&
            pictureBox34.Image == null &&
            pictureBox35.Image == null &&
            pictureBox36.Image == null &&
            pictureBox37.Image == null &&
            pictureBox38.Image == null &&
            pictureBox39.Image == null &&
            pictureBox40.Image == null &&
            pictureBox41.Image == null &&
            pictureBox42.Image == null &&
            pictureBox43.Image == null &&
            pictureBox44.Image == null &&
            pictureBox45.Image == null &&
            pictureBox46.Image == null &&
            pictureBox47.Image == null &&
            pictureBox48.Image == null &&
            pictureBox49.Image == null &&
            pictureBox50.Image == null)
            {
                pictureBox1.Image = Properties.Resources._1;
                pictureBox2.Image = Properties.Resources._2;
                pictureBox3.Image = Properties.Resources._3;
                pictureBox4.Image = Properties.Resources._4;
                pictureBox5.Image = Properties.Resources._5;
                pictureBox6.Image = Properties.Resources._6;
                pictureBox7.Image = Properties.Resources._7;
                pictureBox8.Image = Properties.Resources._8;
                pictureBox9.Image = Properties.Resources._9;
                pictureBox10.Image = Properties.Resources._10;
                pictureBox11.Image = Properties.Resources._11;
                pictureBox12.Image = Properties.Resources._12;
                pictureBox13.Image = Properties.Resources._13;
                pictureBox14.Image = Properties.Resources._14;
                pictureBox15.Image = Properties.Resources._15;
                pictureBox16.Image = Properties.Resources._16;
                pictureBox17.Image = Properties.Resources._17;
                pictureBox18.Image = Properties.Resources._18;
                pictureBox19.Image = Properties.Resources._19;
                pictureBox20.Image = Properties.Resources._20;
                pictureBox21.Image = Properties.Resources._21;
                pictureBox22.Image = Properties.Resources._22;
                pictureBox23.Image = Properties.Resources._23;
                pictureBox24.Image = Properties.Resources._24;
                pictureBox25.Image = Properties.Resources._25;
                pictureBox26.Image = Properties.Resources._26;
                pictureBox27.Image = Properties.Resources._27;
                pictureBox28.Image = Properties.Resources._28;
                pictureBox29.Image = Properties.Resources._29;
                pictureBox30.Image = Properties.Resources._30;
                pictureBox31.Image = Properties.Resources._31;
                pictureBox32.Image = Properties.Resources._32;
                pictureBox33.Image = Properties.Resources._33;
                pictureBox34.Image = Properties.Resources._34;
                pictureBox35.Image = Properties.Resources._35;
                pictureBox36.Image = Properties.Resources._36;
                pictureBox37.Image = Properties.Resources._37;
                pictureBox38.Image = Properties.Resources._38;
                pictureBox39.Image = Properties.Resources._39;
                pictureBox40.Image = Properties.Resources._40;
                pictureBox41.Image = Properties.Resources._41;
                pictureBox42.Image = Properties.Resources._42;
                pictureBox43.Image = Properties.Resources._43;
                pictureBox44.Image = Properties.Resources._44;
                pictureBox45.Image = Properties.Resources._45;
                pictureBox46.Image = Properties.Resources._46;
                pictureBox47.Image = Properties.Resources._47;
                pictureBox48.Image = Properties.Resources._48;
                pictureBox49.Image = Properties.Resources._49;
                pictureBox50.Image = Properties.Resources._50;
                label1.Text = "Четвертый уровень!";
                int count = 0;
                for (int i = 0; i < dataGridView4.RowCount; i++)
                {
                    if (Convert.ToString(dataGridView4.Rows[i].Cells[1].Value) == "")
                        count++;
                }
                for (int j = 1; j < count; j++)
                {
                    try
                    {
                        (panel1.Controls["pictureBox" + (51 - j)] as PictureBox).Image = null;
                        (panel1.Controls["pictureBox" + j] as PictureBox).Enabled = true;
                        (panel1.Controls["pictureBox" + (51 - j)] as PictureBox).Enabled = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка! Вопросы не найдены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        public void rt5()
        {
            if (
                        pictureBox1.Image == null &&
            pictureBox2.Image == null &&
            pictureBox3.Image == null &&
            pictureBox4.Image == null &&
            pictureBox5.Image == null &&
            pictureBox6.Image == null &&
            pictureBox7.Image == null &&
            pictureBox8.Image == null &&
            pictureBox9.Image == null &&
            pictureBox10.Image == null &&
            pictureBox11.Image == null &&
            pictureBox12.Image == null &&
            pictureBox13.Image == null &&
            pictureBox14.Image == null &&
            pictureBox15.Image == null &&
            pictureBox16.Image == null &&
            pictureBox17.Image == null &&
            pictureBox18.Image == null &&
            pictureBox19.Image == null &&
            pictureBox20.Image == null &&
            pictureBox21.Image == null &&
            pictureBox22.Image == null &&
            pictureBox23.Image == null &&
            pictureBox24.Image == null &&
            pictureBox25.Image == null &&
            pictureBox26.Image == null &&
            pictureBox27.Image == null &&
            pictureBox28.Image == null &&
            pictureBox29.Image == null &&
            pictureBox30.Image == null &&
            pictureBox31.Image == null &&
            pictureBox32.Image == null &&
            pictureBox33.Image == null &&
            pictureBox34.Image == null &&
            pictureBox35.Image == null &&
            pictureBox36.Image == null &&
            pictureBox37.Image == null &&
            pictureBox38.Image == null &&
            pictureBox39.Image == null &&
            pictureBox40.Image == null &&
            pictureBox41.Image == null &&
            pictureBox42.Image == null &&
            pictureBox43.Image == null &&
            pictureBox44.Image == null &&
            pictureBox45.Image == null &&
            pictureBox46.Image == null &&
            pictureBox47.Image == null &&
            pictureBox48.Image == null &&
            pictureBox49.Image == null &&
            pictureBox50.Image == null)
            {
                pictureBox1.Image = Properties.Resources._1;
                pictureBox2.Image = Properties.Resources._2;
                pictureBox3.Image = Properties.Resources._3;
                pictureBox4.Image = Properties.Resources._4;
                pictureBox5.Image = Properties.Resources._5;
                pictureBox6.Image = Properties.Resources._6;
                pictureBox7.Image = Properties.Resources._7;
                pictureBox8.Image = Properties.Resources._8;
                pictureBox9.Image = Properties.Resources._9;
                pictureBox10.Image = Properties.Resources._10;
                pictureBox11.Image = Properties.Resources._11;
                pictureBox12.Image = Properties.Resources._12;
                pictureBox13.Image = Properties.Resources._13;
                pictureBox14.Image = Properties.Resources._14;
                pictureBox15.Image = Properties.Resources._15;
                pictureBox16.Image = Properties.Resources._16;
                pictureBox17.Image = Properties.Resources._17;
                pictureBox18.Image = Properties.Resources._18;
                pictureBox19.Image = Properties.Resources._19;
                pictureBox20.Image = Properties.Resources._20;
                pictureBox21.Image = Properties.Resources._21;
                pictureBox22.Image = Properties.Resources._22;
                pictureBox23.Image = Properties.Resources._23;
                pictureBox24.Image = Properties.Resources._24;
                pictureBox25.Image = Properties.Resources._25;
                pictureBox26.Image = Properties.Resources._26;
                pictureBox27.Image = Properties.Resources._27;
                pictureBox28.Image = Properties.Resources._28;
                pictureBox29.Image = Properties.Resources._29;
                pictureBox30.Image = Properties.Resources._30;
                pictureBox31.Image = Properties.Resources._31;
                pictureBox32.Image = Properties.Resources._32;
                pictureBox33.Image = Properties.Resources._33;
                pictureBox34.Image = Properties.Resources._34;
                pictureBox35.Image = Properties.Resources._35;
                pictureBox36.Image = Properties.Resources._36;
                pictureBox37.Image = Properties.Resources._37;
                pictureBox38.Image = Properties.Resources._38;
                pictureBox39.Image = Properties.Resources._39;
                pictureBox40.Image = Properties.Resources._40;
                pictureBox41.Image = Properties.Resources._41;
                pictureBox42.Image = Properties.Resources._42;
                pictureBox43.Image = Properties.Resources._43;
                pictureBox44.Image = Properties.Resources._44;
                pictureBox45.Image = Properties.Resources._45;
                pictureBox46.Image = Properties.Resources._46;
                pictureBox47.Image = Properties.Resources._47;
                pictureBox48.Image = Properties.Resources._48;
                pictureBox49.Image = Properties.Resources._49;
                pictureBox50.Image = Properties.Resources._50;
                label1.Text = "Пятый уровень!";
                int count = 0;
                for (int i = 0; i < dataGridView5.RowCount; i++)
                {
                    if (Convert.ToString(dataGridView5.Rows[i].Cells[1].Value) == "")
                        count++;
                }
                for (int j = 1; j < count; j++)
                {
                    try
                    {
                        (panel1.Controls["pictureBox" + (51 - j)] as PictureBox).Image = null;
                        (panel1.Controls["pictureBox" + j] as PictureBox).Enabled = true;
                        (panel1.Controls["pictureBox" + (51 - j)] as PictureBox).Enabled = false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка! Вопросы не найдены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter dA1 = new OleDbDataAdapter(CmdText1, connectString);
            DataSet ds1 = new DataSet();
            dA1.Fill(ds1, "[Вопрос1]");
            dataGridView1.DataSource = ds1.Tables[0].DefaultView;
            OleDbDataAdapter dA2 = new OleDbDataAdapter(CmdText2, connectString);
            DataSet ds2 = new DataSet();
            dA2.Fill(ds2, "[Вопрос2]");
            dataGridView2.DataSource = ds2.Tables[0].DefaultView;
            OleDbDataAdapter dA3 = new OleDbDataAdapter(CmdText3, connectString);
            DataSet ds3 = new DataSet();
            dA3.Fill(ds3, "[Вопрос3]");
            dataGridView3.DataSource = ds3.Tables[0].DefaultView;
            OleDbDataAdapter dA4 = new OleDbDataAdapter(CmdText4, connectString);
            DataSet ds4 = new DataSet();
            dA4.Fill(ds4, "[Вопрос4]");
            dataGridView4.DataSource = ds4.Tables[0].DefaultView;
            OleDbDataAdapter dA5 = new OleDbDataAdapter(CmdText5, connectString);
            DataSet ds5 = new DataSet();
            dA5.Fill(ds5, "[Вопрос5]");
            dataGridView5.DataSource = ds5.Tables[0].DefaultView;
            int count = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) == "")
                    count++;
            }
            for (int j = 1; j < count; j++)
            {
                try
                {
                    (panel1.Controls["pictureBox" + (51 - j)] as PictureBox).Image = null;
                    (panel1.Controls["pictureBox" + (51 - j)] as PictureBox).Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка! Вопросы не найдены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            button4.Visible = true;
            button3.Visible = true;
            button2.Visible = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }//весь экран

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }//окно

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }//закрыт проги

        private void button1_Click(object sender, EventArgs e) //кнопка назад
        {
            button1.Visible = false;
            textBox3.Visible = false;
            label1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
            pictureBox20.Visible = true;
            pictureBox21.Visible = true;
            pictureBox22.Visible = true;
            pictureBox23.Visible = true;
            pictureBox24.Visible = true;
            pictureBox25.Visible = true;
            pictureBox26.Visible = true;
            pictureBox27.Visible = true;
            pictureBox28.Visible = true;
            pictureBox29.Visible = true;
            pictureBox30.Visible = true;
            pictureBox31.Visible = true;
            pictureBox32.Visible = true;
            pictureBox33.Visible = true;
            pictureBox34.Visible = true;
            pictureBox35.Visible = true;
            pictureBox36.Visible = true;
            pictureBox37.Visible = true;
            pictureBox38.Visible = true;
            pictureBox39.Visible = true;
            pictureBox40.Visible = true;
            pictureBox41.Visible = true;
            pictureBox42.Visible = true;
            pictureBox43.Visible = true;
            pictureBox44.Visible = true;
            pictureBox45.Visible = true;
            pictureBox46.Visible = true;
            pictureBox47.Visible = true;
            pictureBox48.Visible = true;
            pictureBox49.Visible = true;
            pictureBox50.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e) //удал вопроса
        {
            try
            {
                // текст запроса
                string query = "UPDATE Вопрос" + comboBox1.Text + " SET Вопрос = ''";
                // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                OleDbCommand command = new OleDbCommand(query, myConnection);
                // выполняем запрос к MS Access
                command.ExecuteNonQuery();
                MessageBox.Show("Удалено!", "Inf", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка! Откройте инструкцию пользования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Text = "";
            button8.PerformClick();
        }
        private void button6_Click(object sender, EventArgs e) //добавл/изм
        {
            if (textBox1.Text != "")
            {
                try
                {
                    // текст запроса
                    string query = "UPDATE Вопрос" + comboBox1.Text + " SET Вопрос = '" + textBox1.Text + "' WHERE Номер_вопроса = " + comboBox2.Text + "";
                    // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                    OleDbCommand command = new OleDbCommand(query, myConnection);
                    // выполняем запрос к MS Access
                    command.ExecuteNonQuery();
                    MessageBox.Show("Добавлено / Изменено!", "Inf", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка! Откройте инструкцию пользования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                int l = Convert.ToInt32(comboBox2.Text);
                l++;
                comboBox2.Text = Convert.ToString(l);
                textBox1.Text = "";
                button8.PerformClick();
            }
            else MessageBox.Show("Пустое поле!", "Inf", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button8_Click(object sender, EventArgs e) //Обновление
        {
            OleDbDataAdapter dA1 = new OleDbDataAdapter(CmdText1, connectString);
            DataSet ds1 = new DataSet();
            dA1.Fill(ds1, "[Вопрос1]");
            dataGridView1.DataSource = ds1.Tables[0].DefaultView;
            OleDbDataAdapter dA2 = new OleDbDataAdapter(CmdText2, connectString);
            DataSet ds2 = new DataSet();
            dA2.Fill(ds2, "[Вопрос2]");
            dataGridView2.DataSource = ds2.Tables[0].DefaultView;
            OleDbDataAdapter dA3 = new OleDbDataAdapter(CmdText3, connectString);
            DataSet ds3 = new DataSet();
            dA3.Fill(ds3, "[Вопрос3]");
            dataGridView3.DataSource = ds3.Tables[0].DefaultView;
            OleDbDataAdapter dA4 = new OleDbDataAdapter(CmdText4, connectString);
            DataSet ds4 = new DataSet();
            dA4.Fill(ds4, "[Вопрос4]");
            dataGridView4.DataSource = ds4.Tables[0].DefaultView;
            OleDbDataAdapter dA5 = new OleDbDataAdapter(CmdText5, connectString);
            DataSet ds5 = new DataSet();
            dA5.Fill(ds5, "[Вопрос5]");
            dataGridView5.DataSource = ds5.Tables[0].DefaultView;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void dataGridView5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        private void dataGridView4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            {
                if (e.ColumnIndex == 0)
                {
                    e.Value = e.RowIndex + 1;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e) //Удалние табл
        {
            try
            {
                // текст запроса
                string query = "UPDATE Вопрос" + comboBox1.Text + " SET Вопрос = '' WHERE Номер_вопроса = " + comboBox2.Text + "";
                // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                OleDbCommand command = new OleDbCommand(query, myConnection);
                // выполняем запрос к MS Access
                command.ExecuteNonQuery();
                MessageBox.Show("Удалено!", "Inf", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка! Откройте инструкцию пользования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            button8.PerformClick();
            int l1 = Convert.ToInt32(comboBox2.Text);
            l1++;
            comboBox2.Text = Convert.ToString(l1);
            textBox1.Text = "";
        }
        void PoiskInArray1()
        {

            List<int> lst = new List<int>();
            int count = 0;
            bool flag = true;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) != "" && flag)
                {
                    lst.Add(i);
                    count++;
                    flag = false;
                }
                flag = true;
            }
            Random rnd = new Random();
            int z = 0;
            List<int> lst2 = new List<int>();
            while (lst.Count > 1)
            {
                z = rnd.Next(lst.Count);
                lst2.Add(lst[z]);
                lst.RemoveAt(z);
            }
            lst2.Add(lst[rnd.Next(0)]);

            foreach (int y in lst2)
            {
                textBox3.Text = Convert.ToString(dataGridView1.Rows[y].Cells[1].Value);
                dataGridView1.Rows[y].Cells[1].Value = "";
                break;
            }

        }
        void PoiskInArray2()
        {
            List<int> lst = new List<int>();
            int count = 0;
            bool flag = true;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (Convert.ToString(dataGridView2.Rows[i].Cells[1].Value) != "" && flag)
                {
                    lst.Add(i);
                    count++;
                    flag = false;
                }
                flag = true;
            }
            Random rnd = new Random();
            int z = 0;
            List<int> lst2 = new List<int>();
            while (lst.Count > 1)
            {
                z = rnd.Next(lst.Count);
                lst2.Add(lst[z]);
                lst.RemoveAt(z);
            }
            lst2.Add(lst[rnd.Next(0)]);

            foreach (int y in lst2)
            {
                textBox3.Text = Convert.ToString(dataGridView2.Rows[y].Cells[1].Value);
                dataGridView2.Rows[y].Cells[1].Value = "";
                break;
            }
        }
        void PoiskInArray3()
        {
            List<int> lst = new List<int>();
            int count = 0;
            bool flag = true;
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                if (Convert.ToString(dataGridView3.Rows[i].Cells[1].Value) != "" && flag)
                {
                    lst.Add(i);
                    count++;
                    flag = false;
                }
                flag = true;
            }
            Random rnd = new Random();
            int z = 0;
            List<int> lst2 = new List<int>();
            while (lst.Count > 1)
            {
                z = rnd.Next(lst.Count);
                lst2.Add(lst[z]);
                lst.RemoveAt(z);
            }
            lst2.Add(lst[rnd.Next(0)]);

            foreach (int y in lst2)
            {
                textBox3.Text = Convert.ToString(dataGridView3.Rows[y].Cells[1].Value);
                dataGridView3.Rows[y].Cells[1].Value = "";
                break;
            }
        }
        void PoiskInArray4()
        {
            List<int> lst = new List<int>();
            int count = 0;
            bool flag = true;
            for (int i = 0; i < dataGridView4.RowCount; i++)
            {
                if (Convert.ToString(dataGridView4.Rows[i].Cells[1].Value) != "" && flag)
                {
                    lst.Add(i);
                    count++;
                    flag = false;
                }
                flag = true;
            }
            Random rnd = new Random();
            int z = 0;
            List<int> lst2 = new List<int>();
            while (lst.Count > 1)
            {
                z = rnd.Next(lst.Count);
                lst2.Add(lst[z]);
                lst.RemoveAt(z);
            }
            lst2.Add(lst[rnd.Next(0)]);

            foreach (int y in lst2)
            {
                textBox3.Text = Convert.ToString(dataGridView4.Rows[y].Cells[1].Value);
                dataGridView4.Rows[y].Cells[1].Value = "";
                break;
            }

        }
        void PoiskInArray5()
        {
            List<int> lst = new List<int>();
            int count = 0;
            bool flag = true;
            for (int i = 0; i < dataGridView5.RowCount; i++)
            {
                if (Convert.ToString(dataGridView5.Rows[i].Cells[1].Value) != "" && flag)
                {
                    lst.Add(i);
                    count++;
                    flag = false;
                }
                flag = true;
            }
            Random rnd = new Random();
            int z = 0;
            List<int> lst2 = new List<int>();
            while (lst.Count > 1)
            {
                z = rnd.Next(lst.Count);
                lst2.Add(lst[z]);
                lst.RemoveAt(z);
            }
            lst2.Add(lst[rnd.Next(0)]);

            foreach (int y in lst2)
            {
                textBox3.Text = Convert.ToString(dataGridView5.Rows[y].Cells[1].Value);
                dataGridView5.Rows[y].Cells[1].Value = "";
                break;
            }

        }
        public int k1 = 0; public int k11 = 0; public int k21 = 0; public int k31 = 0; public int k41 = 0;
        public int k2 = 0; public int k12 = 0; public int k22 = 0; public int k32 = 0; public int k42 = 0;
        public int k3 = 0; public int k13 = 0; public int k23 = 0; public int k33 = 0; public int k43 = 0;
        public int k4 = 0; public int k14 = 0; public int k24 = 0; public int k34 = 0; public int k44 = 0;
        public int k5 = 0; public int k15 = 0; public int k25 = 0; public int k35 = 0; public int k45 = 0;
        public int k6 = 0; public int k16 = 0; public int k26 = 0; public int k36 = 0; public int k46 = 0;
        public int k7 = 0; public int k17 = 0; public int k27 = 0; public int k37 = 0; public int k47 = 0;
        public int k8 = 0; public int k18 = 0; public int k28 = 0; public int k38 = 0; public int k48 = 0;
        public int k9 = 0; public int k19 = 0; public int k29 = 0; public int k39 = 0; public int k49 = 0;
        public int k10 = 0; public int k20 = 0; public int k30 = 0; public int k40 = 0; public int k50 = 0;
        public void r2()
        {
            button1.Visible = true;
            label1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            pictureBox36.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox47.Visible = false;
            pictureBox48.Visible = false;
            pictureBox49.Visible = false;
            pictureBox50.Visible = false;
        }
        void r3()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            pictureBox13.Image = null;
            pictureBox14.Image = null;
            pictureBox15.Image = null;
            pictureBox16.Image = null;
            pictureBox17.Image = null;
            pictureBox18.Image = null;
            pictureBox19.Image = null;
            pictureBox20.Image = null;
            pictureBox21.Image = null;
            pictureBox22.Image = null;
            pictureBox23.Image = null;
            pictureBox24.Image = null;
            pictureBox25.Image = null;
            pictureBox26.Image = null;
            pictureBox27.Image = null;
            pictureBox28.Image = null;
            pictureBox29.Image = null;
            pictureBox30.Image = null;
            pictureBox31.Image = null;
            pictureBox32.Image = null;
            pictureBox33.Image = null;
            pictureBox34.Image = null;
            pictureBox35.Image = null;
            pictureBox36.Image = null;
            pictureBox37.Image = null;
            pictureBox38.Image = null;
            pictureBox39.Image = null;
            pictureBox40.Image = null;
            pictureBox41.Image = null;
            pictureBox42.Image = null;
            pictureBox43.Image = null;
            pictureBox44.Image = null;
            pictureBox45.Image = null;
            pictureBox46.Image = null;
            pictureBox47.Image = null;
            pictureBox48.Image = null;
            pictureBox49.Image = null;
            pictureBox50.Image = null;
        }
        void y1()
        {
            k1 = 5; k11 = 5; k21 = 5; k31 = 5; k41 = 5;
            k2 = 5; k12 = 5; k22 = 5; k32 = 5; k42 = 5;
            k3 = 5; k13 = 5; k23 = 5; k33 = 5; k43 = 5;
            k4 = 5; k14 = 5; k24 = 5; k34 = 5; k44 = 5;
            k5 = 5; k15 = 5; k25 = 5; k35 = 5; k45 = 5;
            k6 = 5; k16 = 5; k26 = 5; k36 = 5; k46 = 5;
            k7 = 5; k17 = 5; k27 = 5; k37 = 5; k47 = 5;
            k8 = 5; k18 = 5; k28 = 5; k38 = 5; k48 = 5;
            k9 = 5; k19 = 5; k29 = 5; k39 = 5; k49 = 5;
            k10 = 5; k20 = 5; k30 = 5; k40 = 5; k50 = 5;
        }
        void y2()
        {
             k1 = 1; k11 = 1; k21 = 1; k31 = 1; k41 = 1;
             k2 = 1; k12 = 1; k22 = 1; k32 = 1; k42 = 1;
            k3 = 1; k13 = 1; k23 = 1; k33 = 1; k43 = 1;
            k4 = 1; k14 = 1; k24 = 1; k34 = 1; k44 = 1;
            k5 = 1; k15 = 1; k25 = 1; k35 = 1; k45 = 1;
            k6 = 1; k16 = 1; k26 = 1; k36 = 1; k46 = 1;
            k7 = 1; k17 = 1; k27 = 1; k37 = 1; k47 = 1;
            k8 = 1; k18 = 1; k28 = 1; k38 = 1; k48 = 1;
            k9 = 1; k19 = 1; k29 = 1; k39 = 1; k49 = 1;
            k10 = 1; k20 = 1; k30 = 1; k40 = 1; k50 = 1;
        }
        void y3()
        {
            k1 = 2; k11 = 2; k21 = 2; k31 = 2; k41 = 2;
            k2 = 2; k12 = 2; k22 = 2; k32 = 2; k42 = 2;
            k3 = 2; k13 = 2; k23 = 2; k33 = 2; k43 = 2;
            k4 = 2; k14 = 2; k24 = 2; k34 = 2; k44 = 2;
            k5 = 2; k15 = 2; k25 = 2; k35 = 2; k45 = 2;
            k6 = 2; k16 = 2; k26 = 2; k36 = 2; k46 = 2;
            k7 = 2; k17 = 2; k27 = 2; k37 = 2; k47 = 2;
            k8 = 2; k18 = 2; k28 = 2; k38 = 2; k48 = 2;
            k9 = 2; k19 = 2; k29 = 2; k39 = 2; k49 = 2;
            k10 = 2; k20 = 2; k30 = 2; k40 = 2; k50 = 2;
        }
        void y4()
        {
            k1 = 3; k11 = 3; k21 = 3; k31 = 3; k41 = 3;
            k2 = 3; k12 = 3; k22 = 3; k32 = 3; k42 = 3;
            k3 = 3; k13 = 3; k23 = 3; k33 = 3; k43 = 3;
            k4 = 3; k14 = 3; k24 = 3; k34 = 3; k44 = 3;
            k5 = 3; k15 = 3; k25 = 3; k35 = 3; k45 = 3;
            k6 = 3; k16 = 3; k26 = 3; k36 = 3; k46 = 3;
            k7 = 3; k17 = 3; k27 = 3; k37 = 3; k47 = 3;
            k8 = 3; k18 = 3; k28 = 3; k38 = 3; k48 = 3;
            k9 = 3; k19 = 3; k29 = 3; k39 = 3; k49 = 3;
            k10 = 3; k20 = 3; k30 = 3; k40 = 3; k50 = 3;
        }
        void y5()
        {
            k1 = 4; k11 = 4; k21 = 4; k31 = 4; k41 = 4;
            k2 = 4; k12 = 4; k22 = 4; k32 = 4; k42 = 4;
            k3 = 4; k13 = 4; k23 = 4; k33 = 4; k43 = 4;
            k4 = 4; k14 = 4; k24 = 4; k34 = 4; k44 = 4;
            k5 = 4; k15 = 4; k25 = 4; k35 = 4; k45 = 4;
            k6 = 4; k16 = 4; k26 = 4; k36 = 4; k46 = 4;
            k7 = 4; k17 = 4; k27 = 4; k37 = 4; k47 = 4;
            k8 = 4; k18 = 4; k28 = 4; k38 = 4; k48 = 4;
            k9 = 4; k19 = 4; k29 = 4; k39 = 4; k49 = 4;
            k10 = 4; k20 = 4; k30 = 4; k40 = 4; k50 = 4;
        }

        public int prov = 0;
        public int m = 0;
        private void button7_Click(object sender, EventArgs e)
        {
             if (m == 0) { y2(); r3(); rt2(); }
             if (m == 1) { y3(); r3(); rt3(); }
             if (m == 2) { y4(); r3(); rt4(); }
             if (m == 3) { y5(); r3(); rt5(); }
             if (m == 4) { y1(); r3(); rt1(); } 
             m++;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            r2();
            pictureBox1.Image = null;
            textBox3.Visible = true;
            if (k1 == 0)
            {
                try
                {

                        PoiskInArray1();
                        rt2();
                }
                catch (Exception)
                {
                    k1++;
                }

            }
            if (k1 == 1)
            {
                try
                {
                        PoiskInArray2();
                        rt3();
                }
                catch (Exception)
                {
                    k1++;
                }

            }
            if (k1 == 2)
            {
                try
                {
                        PoiskInArray3();
                        rt4();
                }
                catch (Exception)
                {
                    k1++;
                }

            }
            if (k1 == 3)
            {
                try
                {
                        PoiskInArray4();
                        rt5();
                }
                catch (Exception)
                {
                    k1++;
                }

            }
            if (k1 == 4)
            {
                try
                {
                        PoiskInArray5();
                        rt1();
                }
                catch (Exception)
                {
                    k1++;
                }

            }
            k1++;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Enabled = true;
            pictureBox2.Image = null;
            textBox3.Visible = true;
            r2();
            if (k2 == 0)
           {
                try
                {
                    PoiskInArray1(); rt2();
                }
                catch (Exception)
                {
                    k2++;
                }

            }
            if (k2 == 1)
            {
                try
                {
                    PoiskInArray2(); rt3();
                }
                catch (Exception)
                {
                    k2++;
                }

            }
            if (k2 == 2)
            {
                try
                {
                    PoiskInArray3(); 
                }
                catch (Exception)
                {
                    k2++;
                }

            }
            if (k2 == 3)
            {
                try
                {
                    rt5();
                    PoiskInArray4();
                }
                catch (Exception)
                {
                    k2++;
                }

            }
            if (k2 == 4)
            {
                try
                {
                    rt1();
                    PoiskInArray5(); 
                }
                catch (Exception)
                {
                    k2++;
                }

            }
            k2++;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Enabled = true;
            pictureBox3.Image = null;
            textBox3.Visible = true;
            button1.Visible = true;
            r2();
            if (k3 == 0)
            {
                try
                {
                    rt2();
                    PoiskInArray1(); 
                }
                catch (Exception)
                {
                    k3++;
                }

            }
            if (k3 == 1)
            {
                try
                {
                    rt3();
                    PoiskInArray2(); 
                }
                catch (Exception)
                {
                    k3++;
                }

            }
            if (k3 == 2)
            {
                try
                {
                    rt4();
                    PoiskInArray3(); 
                }
                catch (Exception)
                {
                    k3++;
                }

            }
            if (k3 == 3)
            {
                try
                {
                    rt5();
                    PoiskInArray4(); 
                }
                catch (Exception)
                {
                    k3++;
                }

            }
            if (k3 == 4)
            {
                try
                {
                    rt1();
                    PoiskInArray5(); 
                }
                catch (Exception)
                {
                    k3++;
                }

            }
            k3++;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Enabled = true;
            pictureBox4.Image = null;
            textBox3.Visible = true;
            r2();
            if (k4 == 0)
            {
                try
                {
                    PoiskInArray1(); rt2();
                }
                catch (Exception)
                {
                    k4++;
                }

            }
            if (k4 == 1)
            {
                try
                {
                    PoiskInArray2(); rt3();
                }
                catch (Exception)
                {
                    //MessageBox.Show("Вопросы отсутствуют!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    k4++;
                }

            }
            if (k4 == 2)
            {
                try
                {
                    PoiskInArray3(); rt4();
                }
                catch (Exception)
                {
                    //MessageBox.Show("Вопросы отсутствуют!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    k4++;
                }

            }
            if (k4 == 3)
            {
                try
                {
                    PoiskInArray4(); rt5();
                }
                catch (Exception)
                {
                    //MessageBox.Show("Вопросы отсутствуют!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    k4++;
                }

            }
            if (k4 == 4)
            {
                try
                {
                    PoiskInArray5(); rt1();
                }
                catch (Exception)
                {
                    //MessageBox.Show("Вопросы отсутствуют!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    k4++;
                }

            }
            k4++;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Enabled = true;
            pictureBox5.Image = null;
            textBox3.Visible = true;
            r2();
            if (k5 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k5 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k5 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k5 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k5 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k5++;
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Enabled = true;
            pictureBox6.Image = null;
            textBox3.Visible = true;
            r2();
            if (k6 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k6 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k6 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k6 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k6 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k6++;
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Enabled = true;
            pictureBox7.Image = null;
            textBox3.Visible = true;
            r2();
            if (k7 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k7 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k7 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k7 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k7 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k7++;
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Enabled = true;
            pictureBox8.Image = null;
            textBox3.Visible = true;
            r2();
            if (k8 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k8 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k8 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k8 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k8 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k8++;
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Enabled = true;
            pictureBox9.Image = null;
            textBox3.Visible = true;
            r2();
            if (k9 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k9 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k9 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k9 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k9 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k9++;
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Enabled = true;
            pictureBox10.Image = null;
            textBox3.Visible = true;
            r2();
            if (k10 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k10 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k10 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k10 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k10 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k10++;
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Enabled = true;
            pictureBox11.Image = null;
            textBox3.Visible = true;
            r2();
            if (k11 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k11 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k11 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k11 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k11 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k11++;
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Enabled = true;
            pictureBox12.Image = null;
            textBox3.Visible = true;
            r2();
            if (k12 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k12 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k12 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k12 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k12 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k12++;
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Enabled = true;
            pictureBox13.Image = null;
            textBox3.Visible = true;
            r2();
            if (k13 == 0)
            {
                rt2();
                PoiskInArray1();
            }
            if (k13 == 1)
            {
                rt3();
                PoiskInArray2();
               
            }
            if (k13 == 2)
            {
                rt4();
                PoiskInArray3();
               
            }
            if (k13 == 3)
            {
                rt5();
                PoiskInArray4();
                
            }
            if (k13 == 4)
            {
                rt1();
                PoiskInArray5();
                
            }
            k13++;
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Enabled = true;
            pictureBox14.Image = null;
            textBox3.Visible = true;
            r2();
            if (k14 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k14 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k14 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k14 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k14 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k14++;
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Enabled = true;
            pictureBox15.Image = null;
            textBox3.Visible = true;
            r2();
            if (k15 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k15 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k15 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k15 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k15 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k15++;
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Enabled = true;
            pictureBox16.Image = null;
            textBox3.Visible = true;
            r2();
            if (k16 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k16 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k16 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k16 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k16 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k16++;
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Enabled = true;
            pictureBox17.Image = null;
            textBox3.Visible = true;
            r2();
            if (k17 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k17 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k17 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k17 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k17 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k17++;
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.Enabled = true;
            pictureBox18.Image = null;
            textBox3.Visible = true;
            r2();
            if (k18 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k18 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k18 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k18 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k18 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k18++;
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.Enabled = true;
            pictureBox19.Image = null;
            textBox3.Visible = true;
            r2();
            if (k19 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k19 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k19 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k19 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k19 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k19++;
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.Enabled = true;
            pictureBox20.Image = null;
            textBox3.Visible = true;
            r2();
            if (k20 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k20 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k20 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k20 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k20 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k20++;
        }
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox21.Enabled = true;
            pictureBox21.Image = null;
            textBox3.Visible = true;
            r2();
            if (k21 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k21== 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k21 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k21 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k21 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k21++;
        }
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pictureBox22.Enabled = true;
            pictureBox22.Image = null;
            textBox3.Visible = true;
            r2();
            if (k22 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k22 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k22 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k22 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k22 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k22++;
        }
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox23.Enabled = true;
            pictureBox23.Image = null;
            textBox3.Visible = true;
            r2();
            if (k23== 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k23 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k23 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k23 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k23 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k23++;
        }
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox24.Enabled = true;
            pictureBox24.Image = null;
            textBox3.Visible = true;
            r2();
            if (k24 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k24 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k24 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k24 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k24 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k24++;
        }
        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox25.Enabled = true;
            pictureBox25.Image = null;
            textBox3.Visible = true;
            r2();
            if (k25 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k25 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k25 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k25 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k25 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k25++;
        }
        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox26.Enabled = true;
            pictureBox26.Image = null;
            textBox3.Visible = true;
            r2();
            if (k26 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k26 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k26 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k26 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k26 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k26++;
        }
        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pictureBox27.Enabled = true;
            pictureBox27.Image = null;
            textBox3.Visible = true;
            r2();
            if (k27 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k27 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k27 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k27 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k27 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k27++;
        }
        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pictureBox28.Enabled = true;
            pictureBox28.Image = null;
            textBox3.Visible = true;
            r2();
            if (k28 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k28 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k28 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k28 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k28 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k28++;
        }
        private void pictureBox29_Click(object sender, EventArgs e)
        {
            pictureBox29.Enabled = true;
            pictureBox29.Image = null;
            textBox3.Visible = true;
            r2();
            if (k29 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k29 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k29 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k29 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k29 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k29++;
        }
        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pictureBox30.Enabled = true;
            pictureBox30.Image = null;
            textBox3.Visible = true;
            r2();
            if (k30 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k30 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k30 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k30 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k30 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k30++;
        }
        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pictureBox31.Enabled = true;
            pictureBox31.Image = null;
            textBox3.Visible = true;
            r2();
            if (k31 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k31 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k31 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k31 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k31 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k31++;
        }
        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pictureBox32.Enabled = true;
            pictureBox32.Image = null;
            textBox3.Visible = true;
            r2();
            if (k32 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k32 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k32 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k32 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k32 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k32++;
        }
        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pictureBox33.Enabled = true;
            pictureBox33.Image = null;
            textBox3.Visible = true;
            r2();
            if (k33 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k33 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k33 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k33 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k33 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k33++;
        }
        private void pictureBox34_Click(object sender, EventArgs e)
        {
            pictureBox34.Enabled = true;
            pictureBox34.Image = null;
            textBox3.Visible = true;
            r2();
            if (k34 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k34 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k34 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k34== 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k34 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k34++;
        }
        private void pictureBox35_Click(object sender, EventArgs e)
        {
            pictureBox35.Enabled = true;
            pictureBox35.Image = null;
            textBox3.Visible = true;
            r2();
            if (k35 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k35 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k35 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k35== 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k35 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k35++;
        }
        private void pictureBox36_Click(object sender, EventArgs e)
        {
            pictureBox36.Enabled = true;
            pictureBox36.Image = null;
            textBox3.Visible = true;
            r2();
            if (k36 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k36 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k36 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k36 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k36 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k36++;
        }
        private void pictureBox37_Click(object sender, EventArgs e)
        {
            pictureBox37.Enabled = true;
            textBox3.Visible = true;
            r2();
            if (k37 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k37 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k37 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k37 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k37 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k37++;
        }
        private void pictureBox38_Click(object sender, EventArgs e)
        {
            pictureBox38.Enabled = true;
            pictureBox38.Image = null;
            textBox3.Visible = true;
            r2();
            if (k38 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k38 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k38 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k38 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k38 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k38++;
        }
        private void pictureBox39_Click(object sender, EventArgs e)
        {
            pictureBox39.Enabled = true;
            pictureBox39.Image = null;
            textBox3.Visible = true;
            r2();
            if (k39 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k39 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k39 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k39 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k39 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k39++;
        }
        private void pictureBox40_Click(object sender, EventArgs e)
        {
            pictureBox40.Enabled = true;
            pictureBox40.Image = null;
            textBox3.Visible = true;
            r2();
            if (k40 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k40 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k40 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k40 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k40 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k40++;
        }
        private void pictureBox41_Click(object sender, EventArgs e)
        {
            pictureBox41.Enabled = true;
            pictureBox41.Image = null;
            textBox3.Visible = true;
            r2();
            if (k41 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k41 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k41 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k41 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k41 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k41++;
        }
        private void pictureBox42_Click(object sender, EventArgs e)
        {
            pictureBox42.Enabled = true;
            pictureBox42.Image = null;
            textBox3.Visible = true;
            r2();
            if (k42== 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k42 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k42 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k42 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k42 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k42++;
        }
        private void pictureBox43_Click(object sender, EventArgs e)
        {
            pictureBox43.Enabled = true;
            pictureBox43.Image = null;
            textBox3.Visible = true;
            r2();
            if (k43 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k43== 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k43 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k43 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k43 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k43++;
        }
        private void pictureBox44_Click(object sender, EventArgs e)
        {
            pictureBox44.Enabled = true;
            pictureBox44.Image = null;
            textBox3.Visible = true;
            r2();
            if (k44 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k44 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k44 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k44 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k44 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k44++;
        }
        private void pictureBox45_Click(object sender, EventArgs e)
        {
            pictureBox45.Enabled = true;
            pictureBox45.Image = null;
            textBox3.Visible = true;
            r2();
            if (k45 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k45 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k45 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k45 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k45 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k45++;
        }
        private void pictureBox46_Click(object sender, EventArgs e)
        {
            pictureBox46.Enabled = true;
            pictureBox46.Image = null;
            textBox3.Visible = true;
            r2();
            if (k46 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k46 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k46 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k46 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k46 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k46++;
        }
        private void pictureBox47_Click(object sender, EventArgs e)
        {
            pictureBox47.Enabled = true;
            pictureBox47.Image = null;
            textBox3.Visible = true;
            r2();
            if (k47 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k47 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k47 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k47 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k47 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k47++;
        }
        private void pictureBox48_Click(object sender, EventArgs e)
        {
            pictureBox48.Enabled = true;
            pictureBox48.Image = null;
            textBox3.Visible = true;
            r2();
            if (k48 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k48 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k48 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k48 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k48 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k48++;
        }
        private void pictureBox49_Click(object sender, EventArgs e)
        {
            pictureBox49.Enabled = true;
            pictureBox49.Image = null;
            textBox3.Visible = true;
            r2();
            if (k49 == 0)
            {
                PoiskInArray1();
                rt2();
            }
            if (k49 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k49 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k49 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k49 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k49++;
        }
        private void pictureBox50_Click(object sender, EventArgs e)
        {
            pictureBox50.Enabled = true;
            pictureBox50.Image = null;
            textBox3.Visible = true;
            r2();
            if (k50 == 0)
            {
                    PoiskInArray1();
                    rt2();
            }
            if (k50 == 1)
            {
                PoiskInArray2();
                rt3();
            }
            if (k50 == 2)
            {
                PoiskInArray3();
                rt4();
            }
            if (k50 == 3)
            {
                PoiskInArray4();
                rt5();
            }
            if (k50 == 4)
            {
                PoiskInArray5();
                rt1();
            }
            k50++;
        }
    }
}
