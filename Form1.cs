// Decompiled with JetBrains decompiler
// Type: StickersASCO.Form1
// Assembly: StickersASCO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 84161D57-7025-41DC-978A-9B3AAFCE6EC5
// Assembly location: C:\Users\profi\Desktop\StickersASCO.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace StickersASCO
{
  public class Form1 : Form
  {
    public string buf;
    public int init = 0;
    public int colpp = 0;
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private RadioButton radioButton8;
    private RadioButton radioButton7;
    private RadioButton radioButton6;
    private RadioButton radioButton5;
    private GroupBox groupBox7;
    private GroupBox groupBox9;
    private GroupBox groupBox8;
    private Button button5;
    private TextBox textBox3;
    private TextBox textBox2;
    private RadioButton radioButton10;
    private RadioButton radioButton9;
    private Label label3;
    private Label label2;
    private RichTextBox richTextBox1;
    private GroupBox groupBox6;
    private Button button4;
    private Button button3;
    private GroupBox groupBox5;
    private Button button1;
    private Button button2;
    private PictureBox pictureBox1;
    private Panel panel1;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private RadioButton radioButton3;
    private OpenFileDialog openFileDialog1;
    private SaveFileDialog saveFileDialog1;
    private Panel panel2;
    private Button button6;
    private Label label4;
    private Label label1;
    private TextBox textBox1;
    private GroupBox groupBox10;
    private Button button11;
    private Button button10;
    private Button button9;
    private Button button7;
    private Button button8;
    private Panel panel3;
    private RadioButton radioButton11;
    private RadioButton radioButton4;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem jxbcnbnmToolStripMenuItem;
    private Panel panel4;
    private RadioButton radioButton14;
    private RadioButton radioButton13;
    private RadioButton radioButton12;
    private Label label5;
    private CheckBox checkBox1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem справкаToolStripMenuItem;
    private Label label6;
    private Label label7;
    private TextBox textBox4;
    private TextBox textBox5;
    private TextBox textBox6;
    private Label label8;

    public string form_stck()
    {
      int num1 = 0;
      int num2 = 1;
      int result1;
      int.TryParse(this.textBox5.Text, out result1);
      int result2;
      int.TryParse(this.textBox4.Text, out result2);
      string str1 = "";
      string str2 = "";
      string str3 = "";
      string str4 = "<!DOCTYPE HTML>\r\n<html>\r\n <head>\r\n  <meta charset=\"utf-8\">\r\n  <title>наклейки</title>\r\n  <style>\r\n\t.t0\r\n\t{\r\n\t\tmargin-top: 0.1em; \r\n\t\tmargin-bottom: 0.1em; \t\t\r\n\t}\r\n\t.t1 \t\r\n\t{\t\r\n        transform: scale(-1);\t\t\r\n\t\tmargin-top: 0.1em; \r\n\t\tmargin-bottom: 1.5em; \r\n\t}\r\n\t.content \r\n\t{\r\n        width:1654px;\r\n        height:2339px;\r\n        margin:auto;\r\n        background-color:#FFFFFF;\r\n\t\t\r\n\t}\r\n\t\r\n\t.td1\r\n\t{\t\t\r\n\t\t\r\n\t\twidth:260px;\r\n\t\theight:" + this.textBox6.Text + "px;\r\n\t\tborder-bottom-style:dashed;\r\n\t\tborder-top-style:dashed;\r\n\t\tborder-left-style:dashed;\r\n\t\tborder-right-style:dashed;\r\n\t}\r\n\t\r\n\t.table1\r\n\t{\r\n\t\tborder-bottom-style:none;\r\n\t\tborder-top-style:none;\r\n\t\tborder-left-style:none;\r\n\t\tborder-right-style:none;\r\n\t}\r\n\t\r\n  </style>\r\n </head>\r\n \r\n <body class = \"content\">\r\n<table class=\"table1\" border=\"1\" cellspacing=\"0\" cellpadding=\"1\"><tr>";
      string str5 = " </body></html> ";
      if (this.radioButton5.Checked)
        num2 = 1;
      if (this.radioButton7.Checked)
        num2 = 2;
      if (this.radioButton6.Checked)
        num2 = 4;
      if (this.radioButton8.Checked)
        num2 = 3;
      int num3 = ((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() * num2;
      for (int index1 = 0; index1 <= ((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1; ++index1)
      {
        int num4 = 6;
        if (this.richTextBox1.Lines[index1].Length < 17)
          num4 = 6;
        if (this.richTextBox1.Lines[index1].Length > 16)
          num4 = 5;
        if (this.richTextBox1.Lines[index1].Length > 21)
          num4 = 4;
        if (this.richTextBox1.Lines[index1].Length > 28)
          num4 = 3;
        if (this.richTextBox1.Lines[index1].Length > 32)
          num4 = 2;
        string line1 = this.richTextBox1.Lines[index1];
        if (this.richTextBox1.Lines[index1] == "")
          --num3;
        if (line1 != null && line1.Length != 0)
        {
          if (line1[0] == '/' || line1[0] == '*')
          {
            if (num1 % result1 != 0)
            {
              while (num1 % result1 != 0)
              {
                if (this.radioButton12.Checked)
                  str3 = str3 + "<td class = \"td1\" valign=\"top\" align=\"center\">\r\n\t\t                                    <p class = \"t0\"> <font size = \"" + num4.ToString() + "\">+24</font> </p>\r\n                                            <p class = \"t1\"> <font size = \"" + num4.ToString() + "\">+24</font> </p> \r\n                                            </td>";
                if (this.radioButton13.Checked)
                {
                  if (num1 % 2 == 0)
                    str3 = str3 + " <td class = \"td1\" valign=\"top\" align=\"center\">\r\n\t\t                                    <p class = \"t0\"> <font size = \"" + num4.ToString() + "\">+24</font> </p>\r\n                                            <p class = \"t1\"> <font size = \"" + num4.ToString() + "\">+24</font> </p> \r\n                                            </td>";
                  else
                    str3 = str3 + " <td class = \"td1\" valign=\"top\" align=\"center\">\r\n\t\t                                    <p class = \"t0\"> <font size = \"" + num4.ToString() + "\">-24</font> </p>\r\n                                            <p class = \"t1\"> <font size = \"" + num4.ToString() + "\">-24</font> </p> \r\n                                            </td>";
                }
                if (this.radioButton14.Checked)
                  str3 = str3 + "<td class = \"td1\" valign=\"top\" align=\"center\">\r\n\t\t                                    <p class = \"t0\"> <font size = \"" + num4.ToString() + "\">N</font> </p>\r\n                                            <p class = \"t1\"> <font size = \"" + num4.ToString() + "\">N</font> </p> \r\n                                            </td>";
                ++num1;
                ++num3;
                if (num1 % (result1 * result2) == 0 || num1 == num3)
                {
                  int num5 = num1 % (result1 * result2) != 0 || num1 <= result1 * result2 ? num1 / (result1 * result2) + 1 : num1 / (result1 * result2);
                  str3 = str3 + "</table>" + "<p><font size = \"5\"> Страница:" + num5.ToString() + " Позиции:" + str1 + " </font></p>";
                  str1 = str2;
                  if (num1 != num3)
                    str3 += "<table class=\"table1\" border=\"1\" cellspacing=\"0\" cellpadding=\"1\"><tr>";
                }
              }
              str3 += "</tr>";
              if (num1 != num3 && num1 % (result1 * result2) != 0)
                str3 += "<tr>";
            }
            if (line1[0] == '/')
            {
              string line2 = this.richTextBox1.Lines[index1];
              str2 = line2.Substring(1, line2.Length - 1);
              str1 += str2;
              num3 -= num2;
            }
            if (line1[0] == '*')
            {
              str3 = str3 + "<td class = \"td1\" valign=\"top\" align=\"center\"  bgcolor = \"yellow\"> <p class = \"t0\" > <font size = \"" + num4.ToString() + "\">" + this.richTextBox1.Lines[index1] + "</font></p>";
              ++num1;
              num3 = num3 - num2 + 1;
            }
          }
          else
          {
            for (int index2 = 1; index2 <= num2; ++index2)
            {
              str3 = str3 + "<td class = \"td1\" valign=\"top\" align=\"center\">\r\n\t\t                                    <p class = \"t0\"> <font size = \"" + num4.ToString() + "\">" + this.richTextBox1.Lines[index1] + "</font> </p>\r\n                                            <p class = \"t1\"> <font size = \"" + num4.ToString() + "\">" + this.richTextBox1.Lines[index1] + "</font> </p> \r\n                                            </td>";
              ++num1;
              if (num1 % result1 == 0 && num1 % (result1 * result2) != 0 || num1 == num3)
              {
                str3 += "</tr>";
                if (num1 != num3 && num1 % (result1 * result2) != 0)
                  str3 += "<tr>";
              }
              if (num1 % (result1 * result2) == 0 || num1 == num3)
              {
                int num6 = num1 % (result1 * result2) != 0 || num1 <= result1 * result2 ? num1 / (result1 * result2) + 1 : num1 / (result1 * result2);
                if (num1 == num3 && !this.checkBox1.Checked)
                {
                  str3 = str3.Substring(0, str3.Length - 5);
                  while (num3 % (result1 * result2) != 0)
                  {
                    if (this.radioButton12.Checked)
                      str3 = str3 + "<td class = \"td1\" valign=\"top\" align=\"center\">\r\n\t\t                                    <p class = \"t0\"> <font size = \"" + num4.ToString() + "\">+24</font> </p>\r\n                                            <p class = \"t1\"> <font size = \"" + num4.ToString() + "\">+24</font> </p> \r\n                                            </td>";
                    if (this.radioButton13.Checked)
                      str3 = str3 + " <td class = \"td1\" valign=\"top\" align=\"center\">\r\n\t\t                                    <p class = \"t0\"> <font size = \"" + num4.ToString() + "\">-24</font></p>\r\n                                            <p class = \"t1\"> <font size = \"" + num4.ToString() + "\">-24</font></p> \r\n                                            </td>";
                    if (this.radioButton14.Checked)
                      str3 = str3 + "<td class = \"td1\" valign=\"top\" align=\"center\">\r\n\t\t                                    <p class = \"t0\"> <font size = \"" + num4.ToString() + "\">N</font></p>\r\n                                            <p class = \"t1\"> <font size = \"" + num4.ToString() + "\">N</font></p> \r\n                                            </td>";
                    ++num1;
                    ++num3;
                    if (num1 % result1 == 0 && num1 % (result1 * result2) != 0)
                    {
                      str3 += "</tr>";
                      if (num1 % (result1 * result2) != 0)
                        str3 += "<tr>";
                    }
                  }
                }
                str3 = str3 + "</table>" + "<p><font size = \"5\"> Страница:" + num6.ToString() + " Позиции:" + str1 + " </font></p>";
                str1 = str2;
                if (num1 != num3)
                  str3 += "<table class=\"table1\" border=\"1\" cellspacing=\"0\" cellpadding=\"1\"><tr>";
              }
            }
          }
        }
      }
      return str4 + str3 + str5;
    }

    public string form_stck2()
    {
      string str1 = "<!DOCTYPE HTML>\r\n<html>\r\n<head>\r\n<meta charset=\"utf - 8\">\r\n<title> наклейки </title>  \r\n<style>\r\n.content\r\n{\r\nwidth: 1654px;\r\nheight: 2339px;\r\nmargin: auto;\r\nbackground - color:#FFFFFF;\r\n}\r\ntable \r\n{\r\nborder - collapse: separate;\r\nborder:5px solid black;\r\n}\r\ntd \r\n{\r\nwidth:206px;\r\nheight:40px;\r\nborder:3px solid black;\r\n}\r\nfont \r\n{\r\nfont - size:43px;\r\n}\r\n</style >\r\n</head >\r\n<body class = \"content\">\r\n<table class = \"t\" cellspacing=\"5\">\t\r\n<tr>";
      string str2 = " </body></html> ";
      int num1 = 0;
      int num2 = 0;
      int num3 = 1;
      string str3 = "";
      string str4 = "";
      string str5 = "";
      string str6 = "";
      string str7 = "";
      if (this.radioButton5.Checked)
        num3 = 1;
      if (this.radioButton7.Checked)
        num3 = 2;
      if (this.radioButton6.Checked)
        num3 = 4;
      if (this.radioButton8.Checked)
        num3 = 6;
      int num4 = (((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1) * num3 % 344 == 0 || (((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1) * num3 <= 344 ? (((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1) * num3 / 344 : (((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1) * num3 / 344 + 1;
      int num5 = ((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() * num3;
      for (int index1 = 0; index1 <= ((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1; ++index1)
      {
        int num6 = 6;
        if (this.richTextBox1.Lines[index1].Length < 10)
          num6 = 6;
        if (this.richTextBox1.Lines[index1].Length > 10)
          num6 = 5;
        if (this.richTextBox1.Lines[index1].Length > 14)
          num6 = 4;
        string line = this.richTextBox1.Lines[index1];
        if (this.richTextBox1.Lines[index1] == "")
          --num5;
        if (line != null && line.Length != 0)
        {
          if (line[0] == '*')
          {
            if (num2 >= 8 && num2 % 8 != 0)
            {
              while (num2 % 8 != 0)
              {
                str7 += "<td align = \"center\"><font size =\"5\"><b>     </b></font></td>";
                ++num2;
                ++num5;
                if (num2 % 344 == 0 || num2 == num5)
                {
                  ++num1;
                  string str8 = str7 + "</table>";
                  if (num2 == num5)
                    num1 = num4;
                  str7 = str8 + "<p><font size = \"6\"> Страница:" + num1.ToString() + "</font></p>";
                  str4 = str6;
                  str3 = str5;
                  if (num2 != num5)
                    str7 += "<table class = \"t\" cellspacing=\"5\">";
                }
              }
              str7 += "</tr>";
              if (num2 != num5 && num2 % 344 != 0)
                str7 += "<tr>";
            }
            str7 = str7 + "<td align = \"center\" bgcolor = \"yellow\"><font size = " + num6.ToString() + "\"><b>" + this.richTextBox1.Lines[index1] + "</b></font></td>";
            ++num2;
          }
          else
          {
            for (int index2 = 1; index2 <= num3; ++index2)
            {
              str7 = str7 + "<td align = \"center\"><font size = " + num6.ToString() + "\"><b>" + this.richTextBox1.Lines[index1] + "</b></font></td>";
              ++num2;
              if (num2 % 8 == 0 && num2 % 344 != 0 || num2 == num5)
              {
                str7 += "</tr>";
                if (num2 != num5 && num2 % 344 != 0)
                  str7 += "<tr>";
              }
              if (num2 % 344 == 0 || num2 == num5)
              {
                ++num1;
                string str9 = str7 + "</table>";
                if (num2 == num5)
                  num1 = num4;
                str7 = str9 + "<p><font size = \"6\"> Страница:" + num1.ToString() + " Шкаф - " + str4 + " Наклейки:" + str3 + " </font></p>";
                str4 = str6;
                str3 = str5;
                if (num2 != num5)
                  str7 += "<table class = \"t\" cellspacing=\"5\">";
              }
            }
          }
        }
      }
      return str1 + str7 + str2;
    }

    public string form_stck3()
    {
      this.richTextBox1.AppendText("\n");
      string str1 = "<!DOCTYPE HTML>\r\n<html>\r\n<head>\r\n<meta charset=\"utf - 8\">\r\n<title> наклейки </title>  \r\n<style>\r\n.content\r\n{\r\nwidth: 1654px;\r\nheight: 2339px;\r\nmargin: auto;\r\nbackground - color:#FFFFFF;\r\n}\r\ntable \r\n{\r\nborder - collapse: separate;\r\nborder:5px solid black;\r\n}\r\ntd \r\n{\r\nwidth:103px;\r\nheight:35px;\r\nborder:3px solid black;\r\n}\r\nfont \r\n{\r\nfont - size:43px;\r\n}\r\n</style >\r\n</head >\r\n<body class = \"content\">\r\n<table class = \"t\" cellspacing=\"5\">\t\r\n<tr>";
      string str2 = " </body></html> ";
      int num1 = 0;
      int num2 = 0;
      int num3 = 1;
      string str3 = "";
      string str4 = "";
      string str5 = "";
      string str6 = "";
      string str7 = "";
      if (this.radioButton5.Checked)
        num3 = 1;
      if (this.radioButton7.Checked)
        num3 = 2;
      if (this.radioButton6.Checked)
        num3 = 4;
      if (this.radioButton8.Checked)
        num3 = 6;
      int num4 = (((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1) * num3 % 768 == 0 || (((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1) * num3 <= 768 ? (((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1) * num3 / 768 : (((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1) * num3 / 768 + 1;
      int num5 = ((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() * num3;
      for (int index1 = 0; index1 <= ((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1; ++index1)
      {
        int num6 = 3;
        if (this.richTextBox1.Lines[index1].Length < 11)
          num6 = 3;
        if (this.richTextBox1.Lines[index1].Length > 11)
          num6 = 2;
        if (this.richTextBox1.Lines[index1].Length > 15)
          num6 = 1;
        string line = this.richTextBox1.Lines[index1];
        if (this.richTextBox1.Lines[index1] == "")
          --num5;
        if (line != null && line.Length != 0)
        {
          if (line[0] == '*')
          {
            if (num2 >= 16 && num2 % 16 != 0)
            {
              while (num2 % 16 != 0)
              {
                str7 += "<td align = \"center\"><font size =\"5\"><b>     </b></font></td>";
                ++num2;
                ++num5;
                if (num2 % 768 == 0 || num2 == num5)
                {
                  ++num1;
                  string str8 = str7 + "</table>";
                  if (num2 == num5)
                    num1 = num4;
                  str7 = str8 + "<p><font size = \"6\"> Страница:" + num1.ToString() + "</font></p>";
                  str4 = str6;
                  str3 = str5;
                  if (num2 != num5)
                    str7 += "<table class = \"t\" cellspacing=\"5\">";
                }
              }
              str7 += "</tr>";
              if (num2 != num5 && num2 % 768 != 0)
                str7 += "<tr>";
            }
            str7 = str7 + "<td align = \"center\" bgcolor = \"yellow\"><font size = " + num6.ToString() + "\"><b>" + this.richTextBox1.Lines[index1] + "</b></font></td>";
            ++num2;
          }
          else
          {
            for (int index2 = 1; index2 <= num3; ++index2)
            {
              str7 = str7 + "\r\n<td align = \"center\"><font size = " + num6.ToString() + "\"><b>" + this.richTextBox1.Lines[index1] + "</b></font></td>";
              ++num2;
              if (num2 % 16 == 0 && num2 % 768 != 0 || num2 == num5)
              {
                str7 += "</tr>";
                if (num2 != num5 && num2 % 296 != 0)
                  str7 += "<tr>";
              }
              if (num2 % 768 == 0 || num2 == num5)
              {
                ++num1;
                string str9 = str7 + "</table>";
                if (num2 == num5)
                  num1 = num4;
                str7 = str9 + "<p><font size = \"6\"> Страница:" + num1.ToString() + " Шкаф - " + str4 + " Наклейки:" + str3 + " </font></p>";
                str4 = str6;
                str3 = str5;
                if (num2 != num5)
                  str7 += "<table class = \"t\" cellspacing=\"5\">";
              }
            }
          }
        }
      }
      return str1 + str7 + str2;
    }

    public Form1() => this.InitializeComponent();

    private void Form1_Load(object sender, EventArgs e)
    {
      GraphicsPath path = new GraphicsPath();
      foreach (Control control in (ArrangedElementCollection) this.panel1.Controls)
        path.AddRectangle(new Rectangle(control.Location, control.Size));
      this.panel1.Region = new Region(path);
      this.panel1.BackColor = Color.Transparent;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        if (this.openFileDialog1.FileName == null || this.openFileDialog1.FileName.Length == 0)
          return;
        this.richTextBox1.Clear();
        using (StreamReader streamReader = new StreamReader(this.openFileDialog1.FileName))
        {
          string str;
          while ((str = streamReader.ReadLine()) != null)
            this.richTextBox1.AppendText(str + "\n");
          streamReader.Close();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Файл не выбран", "Ошибка");
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.saveFileDialog1.Filter = "Текстовый файл наклеек(*.txt)|*.txt";
      if (this.saveFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      if (!File.Exists(this.saveFileDialog1.FileName))
      {
        using (StreamWriter streamWriter = new StreamWriter(this.saveFileDialog1.FileName, false, Encoding.UTF8))
        {
          for (int index = 0; index <= ((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1; ++index)
          {
            string line = this.richTextBox1.Lines[index];
            streamWriter.WriteLine(line);
          }
          streamWriter.Close();
        }
      }
      else if (MessageBox.Show("Файл уже существет! Дописать?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
      {
        using (StreamWriter streamWriter = new StreamWriter(this.saveFileDialog1.FileName, true, Encoding.UTF8))
        {
          for (int index = 0; index <= ((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1; ++index)
          {
            string line = this.richTextBox1.Lines[index];
            streamWriter.WriteLine(line);
          }
          streamWriter.Close();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Ошибка", "Для создания нового файла выберете уникальное имя");
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (this.richTextBox1.TextLength != 0)
      {
        while (this.richTextBox1.Lines[((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1] == "")
          this.richTextBox1.Text = this.richTextBox1.Text.Substring(0, this.richTextBox1.Text.Length - 1);
      }
      this.saveFileDialog1.Filter = "Файл наклеек(*.html)|*.html";
      if (this.richTextBox1.Text != null && ((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() != 0)
      {
        if (this.saveFileDialog1.ShowDialog() != DialogResult.OK)
          return;
        if (!File.Exists(this.saveFileDialog1.FileName))
        {
          using (StreamWriter streamWriter = new StreamWriter(this.saveFileDialog1.FileName, false, Encoding.UTF8))
          {
            if (this.radioButton1.Checked)
              streamWriter.Write(this.form_stck());
            if (this.radioButton2.Checked)
              streamWriter.Write(this.form_stck2());
            if (this.radioButton3.Checked)
              streamWriter.Write(this.form_stck3());
            streamWriter.Close();
          }
        }
        else if (MessageBox.Show("Файл уже существет! Перезаписать?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
        {
          File.Delete(this.saveFileDialog1.FileName);
          using (StreamWriter streamWriter = new StreamWriter(this.saveFileDialog1.FileName, true, Encoding.UTF8))
          {
            if (this.radioButton1.Checked)
              streamWriter.Write(this.form_stck());
            if (this.radioButton2.Checked)
              streamWriter.Write(this.form_stck2());
            if (this.radioButton3.Checked)
              streamWriter.Write(this.form_stck3());
            streamWriter.Close();
          }
        }
        else
        {
          int num = (int) MessageBox.Show("Ошибка", "Файл не перезаписан");
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Создане пустого файла невозможно", "Ошибка");
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      if (this.textBox3.Text == null || this.textBox3.Text == "" || this.textBox3.TextLength == 0)
      {
        if (this.textBox2.Text != this.buf)
          this.init = 0;
        if (this.richTextBox1.Find(this.textBox2.Text, this.init, RichTextBoxFinds.MatchCase) == -1)
        {
          if (MessageBox.Show("Ничего не найдено. Попробовать еще раз?", "Поиск", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
          {
            this.init = 0;
            this.richTextBox1.SelectionStart = this.richTextBox1.Find(this.textBox2.Text, this.init, RichTextBoxFinds.MatchCase);
            this.init = this.richTextBox1.Find(this.textBox2.Text, this.init, RichTextBoxFinds.MatchCase) + 1;
          }
          else
            this.init = 0;
        }
        else
        {
          this.richTextBox1.SelectionStart = this.richTextBox1.Find(this.textBox2.Text, this.init, RichTextBoxFinds.MatchCase);
          this.init = this.richTextBox1.Find(this.textBox2.Text, this.init, RichTextBoxFinds.MatchCase) + 1;
          this.buf = this.textBox2.Text;
        }
      }
      else
      {
        int num = 0;
        if (this.radioButton9.Checked)
        {
          this.radioButton10.Checked = false;
          num = this.richTextBox1.GetLineFromCharIndex(this.richTextBox1.SelectionStart);
        }
        if (this.radioButton10.Checked)
        {
          this.radioButton9.Checked = false;
          num = 0;
        }
        string text1 = this.textBox2.Text;
        string text2 = this.textBox3.Text;
        string[] lines = this.richTextBox1.Lines;
        for (int index = num; index <= ((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1; ++index)
        {
          string str1 = lines[index];
          if (str1.Contains(text1))
          {
            string str2 = str1.Replace(text1, text2);
            lines[index] = str2;
          }
        }
        this.richTextBox1.Lines = lines;
      }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (this.richTextBox1.TextLength != 0)
      {
        while (this.richTextBox1.Lines[((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1] == "")
          this.richTextBox1.Text = this.richTextBox1.Text.Substring(0, this.richTextBox1.Text.Length - 1);
      }
      File.Delete("buff.html");
      using (StreamWriter streamWriter = new StreamWriter("buff.html", true, Encoding.UTF8))
      {
        if (this.radioButton1.Checked)
          streamWriter.Write(this.form_stck());
        if (this.radioButton2.Checked)
          streamWriter.Write(this.form_stck2());
        if (this.radioButton3.Checked)
          streamWriter.Write(this.form_stck3());
        streamWriter.Close();
      }
      Process.Start("buff.html");
    }

    private void button6_Click(object sender, EventArgs e)
    {
      int num1 = 0;
      int num2 = 1;
      int num3 = 0;
      int num4 = 1;
      for (int index = 0; index <= ((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1; ++index)
      {
        string line = this.richTextBox1.Lines[index];
        if (line != null && line.Length != 0)
        {
          if (line[0] == '/' || line[0] == '*')
            ++num3;
          if (this.richTextBox1.Lines[index] == this.textBox1.Text)
          {
            num1 = index + 1 - num3;
            break;
          }
        }
        if (index == ((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1)
        {
          int num5 = (int) MessageBox.Show("Ничего не найдено", "Поиск");
        }
      }
      if (this.radioButton1.Checked)
        num2 = 96;
      if (this.radioButton2.Checked)
        num2 = 296;
      if (this.radioButton3.Checked)
        num2 = 768;
      if (this.radioButton5.Checked)
        num4 = 1;
      if (this.radioButton7.Checked)
        num4 = 2;
      if (this.radioButton6.Checked)
        num4 = 4;
      if (this.radioButton8.Checked)
        num4 = 6;
      int num6 = num1 * num4;
      int num7 = num6 >= num2 ? (num6 % num2 != 0 ? num6 / num2 + 1 : num6 / num2) : 1;
      this.label4.Text = " ";
      this.label4.Text = "Лист - " + num7.ToString();
    }

    private void button7_Click(object sender, EventArgs e)
    {
      if (this.radioButton11.Checked)
        this.richTextBox1.Clear();
      if (this.radioButton4.Checked && this.richTextBox1.TextLength != 0)
      {
        while (this.richTextBox1.Lines[((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1] == "")
          this.richTextBox1.Text = this.richTextBox1.Text.Substring(0, this.richTextBox1.Text.Length - 1);
        this.richTextBox1.Text += " \n";
      }
      for (int index = 1; index <= 32; ++index)
        this.richTextBox1.Text += "+24 \n";
      for (int index = 1; index <= 32; ++index)
        this.richTextBox1.Text += "-24 \n";
      for (int index = 1; index <= 32; ++index)
        this.richTextBox1.Text += "N \n";
    }

    private void button8_Click(object sender, EventArgs e)
    {
      if (this.radioButton11.Checked)
        this.richTextBox1.Clear();
      if (this.radioButton4.Checked && this.richTextBox1.TextLength != 0)
      {
        while (this.richTextBox1.Lines[((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1] == "")
          this.richTextBox1.Text = this.richTextBox1.Text.Substring(0, this.richTextBox1.Text.Length - 1);
        this.richTextBox1.Text += " \n";
      }
      for (int index = 1; index <= 48; ++index)
        this.richTextBox1.Text += "+24\n";
      for (int index = 1; index <= 48; ++index)
        this.richTextBox1.Text += "-24\n";
    }

    private void button9_Click(object sender, EventArgs e)
    {
      if (this.radioButton11.Checked)
        this.richTextBox1.Clear();
      if (this.radioButton4.Checked && this.richTextBox1.TextLength != 0)
      {
        while (this.richTextBox1.Lines[((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1] == "")
          this.richTextBox1.Text = this.richTextBox1.Text.Substring(0, this.richTextBox1.Text.Length - 1);
        this.richTextBox1.Text += " \n";
      }
      for (int index = 1; index <= 96; ++index)
        this.richTextBox1.Text += "+24\n";
    }

    private void button10_Click(object sender, EventArgs e)
    {
      if (this.radioButton11.Checked)
        this.richTextBox1.Clear();
      if (this.radioButton4.Checked && this.richTextBox1.TextLength != 0)
      {
        while (this.richTextBox1.Lines[((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1] == "")
          this.richTextBox1.Text = this.richTextBox1.Text.Substring(0, this.richTextBox1.Text.Length - 1);
        this.richTextBox1.Text += " \n";
      }
      for (int index = 1; index <= 96; ++index)
        this.richTextBox1.Text += "-24\n";
    }

    private void button11_Click(object sender, EventArgs e)
    {
      if (this.radioButton11.Checked)
        this.richTextBox1.Clear();
      if (this.radioButton4.Checked && this.richTextBox1.TextLength != 0)
      {
        while (this.richTextBox1.Lines[((IEnumerable<string>) this.richTextBox1.Lines).Count<string>() - 1] == "")
          this.richTextBox1.Text = this.richTextBox1.Text.Substring(0, this.richTextBox1.Text.Length - 1);
        this.richTextBox1.Text += " \n";
      }
      for (int index = 1; index <= 96; ++index)
        this.richTextBox1.Text += "N\n";
    }

    private void radioButton4_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void radioButton11_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void jxbcnbnmToolStripMenuItem_Click(object sender, EventArgs e) => this.richTextBox1.Clear();

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      this.radioButton5.Checked = true;
      this.radioButton7.Enabled = true;
      this.radioButton8.Enabled = true;
      this.radioButton6.Enabled = true;
      this.panel4.Enabled = true;
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
      this.radioButton5.Checked = true;
      this.radioButton7.Enabled = false;
      this.radioButton8.Enabled = false;
      this.radioButton6.Enabled = false;
      this.panel4.Enabled = false;
    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
      this.radioButton5.Checked = true;
      this.radioButton7.Enabled = false;
      this.radioButton8.Enabled = false;
      this.radioButton6.Enabled = false;
      this.panel4.Enabled = false;
    }

    private void справкаToolStripMenuItem_Click(object sender, EventArgs e) => Process.Start("ut.pdf");

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.groupBox1 = new GroupBox();
      this.radioButton1 = new RadioButton();
      this.radioButton2 = new RadioButton();
      this.radioButton3 = new RadioButton();
      this.groupBox2 = new GroupBox();
      this.groupBox7 = new GroupBox();
      this.groupBox10 = new GroupBox();
      this.groupBox9 = new GroupBox();
      this.groupBox8 = new GroupBox();
      this.label3 = new Label();
      this.label2 = new Label();
      this.groupBox4 = new GroupBox();
      this.groupBox6 = new GroupBox();
      this.groupBox5 = new GroupBox();
      this.groupBox3 = new GroupBox();
      this.button5 = new Button();
      this.textBox3 = new TextBox();
      this.textBox2 = new TextBox();
      this.radioButton10 = new RadioButton();
      this.radioButton9 = new RadioButton();
      this.richTextBox1 = new RichTextBox();
      this.contextMenuStrip1 = new ContextMenuStrip(this.components);
      this.jxbcnbnmToolStripMenuItem = new ToolStripMenuItem();
      this.button4 = new Button();
      this.button3 = new Button();
      this.button1 = new Button();
      this.button2 = new Button();
      this.radioButton8 = new RadioButton();
      this.radioButton7 = new RadioButton();
      this.radioButton6 = new RadioButton();
      this.radioButton5 = new RadioButton();
      this.pictureBox1 = new PictureBox();
      this.panel1 = new Panel();
      this.panel4 = new Panel();
      this.checkBox1 = new CheckBox();
      this.radioButton14 = new RadioButton();
      this.radioButton13 = new RadioButton();
      this.radioButton12 = new RadioButton();
      this.label5 = new Label();
      this.panel3 = new Panel();
      this.radioButton11 = new RadioButton();
      this.radioButton4 = new RadioButton();
      this.button11 = new Button();
      this.button10 = new Button();
      this.button9 = new Button();
      this.button7 = new Button();
      this.button8 = new Button();
      this.button6 = new Button();
      this.label4 = new Label();
      this.label1 = new Label();
      this.textBox1 = new TextBox();
      this.panel2 = new Panel();
      this.openFileDialog1 = new OpenFileDialog();
      this.saveFileDialog1 = new SaveFileDialog();
      this.menuStrip1 = new MenuStrip();
      this.справкаToolStripMenuItem = new ToolStripMenuItem();
      this.label6 = new Label();
      this.label7 = new Label();
      this.textBox4 = new TextBox();
      this.textBox5 = new TextBox();
      this.textBox6 = new TextBox();
      this.label8 = new Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.groupBox8.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.panel1.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.radioButton1);
      this.groupBox1.Controls.Add((Control) this.radioButton2);
      this.groupBox1.Controls.Add((Control) this.radioButton3);
      this.groupBox1.Font = new Font("Century Gothic", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.groupBox1.ForeColor = SystemColors.ControlLightLight;
      this.groupBox1.Location = new Point(16, 28);
      this.groupBox1.Margin = new Padding(4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new Padding(4);
      this.groupBox1.Size = new Size(240, 128);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Тип наклеек";
      this.radioButton1.AutoSize = true;
      this.radioButton1.Checked = true;
      this.radioButton1.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.radioButton1.ForeColor = SystemColors.ControlLightLight;
      this.radioButton1.Location = new Point(8, 32);
      this.radioButton1.Margin = new Padding(4);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new Size(97, 25);
      this.radioButton1.TabIndex = 0;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Провода";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new EventHandler(this.radioButton1_CheckedChanged);
      this.radioButton2.AutoSize = true;
      this.radioButton2.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.radioButton2.ForeColor = SystemColors.ControlLightLight;
      this.radioButton2.Location = new Point(8, 63);
      this.radioButton2.Margin = new Padding(4);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new Size(122, 25);
      this.radioButton2.TabIndex = 1;
      this.radioButton2.Text = "Агрегатные";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton2.CheckedChanged += new EventHandler(this.radioButton2_CheckedChanged);
      this.radioButton3.AutoSize = true;
      this.radioButton3.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.radioButton3.ForeColor = SystemColors.ControlLightLight;
      this.radioButton3.Location = new Point(8, 93);
      this.radioButton3.Margin = new Padding(4);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new Size(182, 25);
      this.radioButton3.TabIndex = 2;
      this.radioButton3.Text = "Малые Агрегатные";
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton3.CheckedChanged += new EventHandler(this.radioButton3_CheckedChanged);
      this.groupBox2.Controls.Add((Control) this.groupBox7);
      this.groupBox2.Controls.Add((Control) this.groupBox4);
      this.groupBox2.Controls.Add((Control) this.groupBox3);
      this.groupBox2.Font = new Font("Century Gothic", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.groupBox2.ForeColor = SystemColors.ControlLightLight;
      this.groupBox2.Location = new Point(272, 28);
      this.groupBox2.Margin = new Padding(4);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new Padding(4);
      this.groupBox2.Size = new Size(789, 729);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Рабочая область";
      this.groupBox7.Controls.Add((Control) this.groupBox10);
      this.groupBox7.Controls.Add((Control) this.groupBox9);
      this.groupBox7.Controls.Add((Control) this.groupBox8);
      this.groupBox7.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.groupBox7.ForeColor = SystemColors.ControlLightLight;
      this.groupBox7.Location = new Point(7, 196);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new Size(763, 526);
      this.groupBox7.TabIndex = 2;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Текстовый редактор";
      this.groupBox10.ForeColor = SystemColors.ControlLightLight;
      this.groupBox10.Location = new Point(451, 285);
      this.groupBox10.Name = "groupBox10";
      this.groupBox10.Size = new Size(306, 235);
      this.groupBox10.TabIndex = 3;
      this.groupBox10.TabStop = false;
      this.groupBox10.Text = "Создание фиксированной страницы";
      this.groupBox9.ForeColor = SystemColors.ControlLightLight;
      this.groupBox9.Location = new Point(451, 175);
      this.groupBox9.Name = "groupBox9";
      this.groupBox9.Size = new Size(303, 104);
      this.groupBox9.TabIndex = 2;
      this.groupBox9.TabStop = false;
      this.groupBox9.Text = "Поиск в списке";
      this.groupBox8.BackColor = SystemColors.HotTrack;
      this.groupBox8.Controls.Add((Control) this.label3);
      this.groupBox8.Controls.Add((Control) this.label2);
      this.groupBox8.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.groupBox8.ForeColor = SystemColors.ControlLightLight;
      this.groupBox8.Location = new Point(451, 26);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new Size(303, 143);
      this.groupBox8.TabIndex = 1;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = "Найти и заменить ";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.label3.Location = new Point(6, 57);
      this.label3.Name = "label3";
      this.label3.Size = new Size(75, 17);
      this.label3.TabIndex = 1;
      this.label3.Text = "Заменить:";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.label2.Location = new Point(30, 31);
      this.label2.Name = "label2";
      this.label2.Size = new Size(51, 17);
      this.label2.TabIndex = 0;
      this.label2.Text = "Найти:";
      this.groupBox4.Controls.Add((Control) this.groupBox6);
      this.groupBox4.Controls.Add((Control) this.groupBox5);
      this.groupBox4.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.groupBox4.ForeColor = SystemColors.ControlLightLight;
      this.groupBox4.Location = new Point(7, 90);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(763, 100);
      this.groupBox4.TabIndex = 1;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Работа с файлом";
      this.groupBox6.ForeColor = SystemColors.ControlLightLight;
      this.groupBox6.Location = new Point(336, 26);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.RightToLeft = RightToLeft.No;
      this.groupBox6.Size = new Size(418, 62);
      this.groupBox6.TabIndex = 5;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Файл наклеек";
      this.groupBox5.ForeColor = SystemColors.ControlLightLight;
      this.groupBox5.Location = new Point(7, 26);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(323, 62);
      this.groupBox5.TabIndex = 4;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Перечень наклеек";
      this.groupBox3.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.groupBox3.ForeColor = SystemColors.ControlLightLight;
      this.groupBox3.Location = new Point(7, 27);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(763, 57);
      this.groupBox3.TabIndex = 0;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Настройка количества наклеек";
      this.button5.BackColor = SystemColors.HotTrack;
      this.button5.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button5.ForeColor = SystemColors.ControlLightLight;
      this.button5.Location = new Point(554, 350);
      this.button5.Name = "button5";
      this.button5.Size = new Size(122, 24);
      this.button5.TabIndex = 8;
      this.button5.Text = "Заменить";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.textBox3.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.textBox3.Location = new Point(554, 291);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(206, 23);
      this.textBox3.TabIndex = 7;
      this.textBox2.Font = new Font("Century Gothic", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.textBox2.Location = new Point(554, 265);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(206, 22);
      this.textBox2.TabIndex = 6;
      this.radioButton10.AutoSize = true;
      this.radioButton10.Checked = true;
      this.radioButton10.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.radioButton10.Location = new Point(10, 0);
      this.radioButton10.Name = "radioButton10";
      this.radioButton10.Size = new Size(92, 21);
      this.radioButton10.TabIndex = 3;
      this.radioButton10.TabStop = true;
      this.radioButton10.Text = "Весь текст";
      this.radioButton10.UseVisualStyleBackColor = true;
      this.radioButton9.AutoSize = true;
      this.radioButton9.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.radioButton9.Location = new Point(108, 0);
      this.radioButton9.Name = "radioButton9";
      this.radioButton9.Size = new Size(175, 21);
      this.radioButton9.TabIndex = 2;
      this.radioButton9.Text = "От положения каретки";
      this.radioButton9.UseVisualStyleBackColor = true;
      this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
      this.richTextBox1.HideSelection = false;
      this.richTextBox1.Location = new Point(22, 291);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
      this.richTextBox1.ShowSelectionMargin = true;
      this.richTextBox1.Size = new Size(439, 441);
      this.richTextBox1.TabIndex = 0;
      this.richTextBox1.Text = "";
      this.richTextBox1.WordWrap = false;
      this.contextMenuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.jxbcnbnmToolStripMenuItem
      });
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.RenderMode = ToolStripRenderMode.System;
      this.contextMenuStrip1.Size = new Size((int) sbyte.MaxValue, 26);
      this.jxbcnbnmToolStripMenuItem.Name = "jxbcnbnmToolStripMenuItem";
      this.jxbcnbnmToolStripMenuItem.Size = new Size(126, 22);
      this.jxbcnbnmToolStripMenuItem.Text = "Очистить";
      this.jxbcnbnmToolStripMenuItem.Click += new EventHandler(this.jxbcnbnmToolStripMenuItem_Click);
      this.button4.BackColor = SystemColors.HotTrack;
      this.button4.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button4.Location = new Point(562, 157);
      this.button4.Name = "button4";
      this.button4.Size = new Size(198, 25);
      this.button4.TabIndex = 3;
      this.button4.Text = "Предпросмотр и печать";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button3.BackColor = SystemColors.HotTrack;
      this.button3.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button3.Location = new Point(358, 157);
      this.button3.Name = "button3";
      this.button3.Size = new Size(198, 25);
      this.button3.TabIndex = 2;
      this.button3.Text = "Сформировать файл";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button1.BackColor = SystemColors.HotTrack;
      this.button1.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button1.Location = new Point(29, 157);
      this.button1.Name = "button1";
      this.button1.Size = new Size(152, 25);
      this.button1.TabIndex = 0;
      this.button1.Text = "Открыть файл";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.BackColor = SystemColors.HotTrack;
      this.button2.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button2.ForeColor = SystemColors.ControlLightLight;
      this.button2.Location = new Point(187, 157);
      this.button2.Name = "button2";
      this.button2.Size = new Size(152, 25);
      this.button2.TabIndex = 1;
      this.button2.Text = "Сохранить файл";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.radioButton8.AutoSize = true;
      this.radioButton8.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.radioButton8.Location = new Point(333, 68);
      this.radioButton8.Name = "radioButton8";
      this.radioButton8.Size = new Size(98, 25);
      this.radioButton8.TabIndex = 3;
      this.radioButton8.Text = "Тройные";
      this.radioButton8.UseVisualStyleBackColor = true;
      this.radioButton7.AutoSize = true;
      this.radioButton7.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.radioButton7.Location = new Point(187, 68);
      this.radioButton7.Name = "radioButton7";
      this.radioButton7.Size = new Size(98, 25);
      this.radioButton7.TabIndex = 2;
      this.radioButton7.Text = "Двойные";
      this.radioButton7.UseVisualStyleBackColor = true;
      this.radioButton6.AutoSize = true;
      this.radioButton6.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.radioButton6.Location = new Point(500, 68);
      this.radioButton6.Name = "radioButton6";
      this.radioButton6.Size = new Size(108, 25);
      this.radioButton6.TabIndex = 1;
      this.radioButton6.Text = "По четыре";
      this.radioButton6.UseVisualStyleBackColor = true;
      this.radioButton5.AutoSize = true;
      this.radioButton5.Checked = true;
      this.radioButton5.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.radioButton5.Location = new Point(29, 68);
      this.radioButton5.Name = "radioButton5";
      this.radioButton5.Size = new Size(124, 25);
      this.radioButton5.TabIndex = 0;
      this.radioButton5.TabStop = true;
      this.radioButton5.Text = "Одинарные";
      this.radioButton5.UseVisualStyleBackColor = true;
      this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
      this.pictureBox1.Location = new Point(59, 513);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(147, 134);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      this.panel1.BackColor = SystemColors.GrayText;
      this.panel1.Controls.Add((Control) this.panel4);
      this.panel1.Controls.Add((Control) this.panel3);
      this.panel1.Controls.Add((Control) this.button11);
      this.panel1.Controls.Add((Control) this.button10);
      this.panel1.Controls.Add((Control) this.button9);
      this.panel1.Controls.Add((Control) this.button7);
      this.panel1.Controls.Add((Control) this.button8);
      this.panel1.Controls.Add((Control) this.button6);
      this.panel1.Controls.Add((Control) this.label4);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Controls.Add((Control) this.textBox1);
      this.panel1.Controls.Add((Control) this.panel2);
      this.panel1.Controls.Add((Control) this.button4);
      this.panel1.Controls.Add((Control) this.button5);
      this.panel1.Controls.Add((Control) this.textBox3);
      this.panel1.Controls.Add((Control) this.button2);
      this.panel1.Controls.Add((Control) this.textBox2);
      this.panel1.Controls.Add((Control) this.button3);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Controls.Add((Control) this.radioButton8);
      this.panel1.Controls.Add((Control) this.richTextBox1);
      this.panel1.Controls.Add((Control) this.radioButton6);
      this.panel1.Controls.Add((Control) this.radioButton7);
      this.panel1.Controls.Add((Control) this.radioButton5);
      this.panel1.Location = new Point(263, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(814, 753);
      this.panel1.TabIndex = 3;
      this.panel4.Controls.Add((Control) this.checkBox1);
      this.panel4.Controls.Add((Control) this.radioButton14);
      this.panel4.Controls.Add((Control) this.radioButton13);
      this.panel4.Controls.Add((Control) this.radioButton12);
      this.panel4.Controls.Add((Control) this.label5);
      this.panel4.Location = new Point(22, 238);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(439, 47);
      this.panel4.TabIndex = 21;
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new Point(11, 26);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(178, 21);
      this.checkBox1.TabIndex = 4;
      this.checkBox1.Text = "Не дописывать в конец";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.radioButton14.AutoSize = true;
      this.radioButton14.Location = new Point(265, 4);
      this.radioButton14.Name = "radioButton14";
      this.radioButton14.Size = new Size(36, 21);
      this.radioButton14.TabIndex = 3;
      this.radioButton14.TabStop = true;
      this.radioButton14.Text = "N";
      this.radioButton14.UseVisualStyleBackColor = true;
      this.radioButton13.AutoSize = true;
      this.radioButton13.Location = new Point(176, 4);
      this.radioButton13.Name = "radioButton13";
      this.radioButton13.Size = new Size(44, 21);
      this.radioButton13.TabIndex = 2;
      this.radioButton13.TabStop = true;
      this.radioButton13.Text = "-24";
      this.radioButton13.UseVisualStyleBackColor = true;
      this.radioButton12.AutoSize = true;
      this.radioButton12.Checked = true;
      this.radioButton12.Location = new Point(110, 4);
      this.radioButton12.Name = "radioButton12";
      this.radioButton12.Size = new Size(49, 21);
      this.radioButton12.TabIndex = 1;
      this.radioButton12.TabStop = true;
      this.radioButton12.Text = "+24";
      this.radioButton12.UseVisualStyleBackColor = true;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(8, 6);
      this.label5.Name = "label5";
      this.label5.Size = new Size(94, 17);
      this.label5.TabIndex = 0;
      this.label5.Text = "Дописывать: ";
      this.panel3.Controls.Add((Control) this.radioButton11);
      this.panel3.Controls.Add((Control) this.radioButton4);
      this.panel3.Location = new Point(483, 541);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(284, 23);
      this.panel3.TabIndex = 20;
      this.radioButton11.AutoSize = true;
      this.radioButton11.Location = new Point(159, 3);
      this.radioButton11.Name = "radioButton11";
      this.radioButton11.Size = new Size(67, 21);
      this.radioButton11.TabIndex = 1;
      this.radioButton11.Text = "Новый";
      this.radioButton11.UseVisualStyleBackColor = true;
      this.radioButton11.CheckedChanged += new EventHandler(this.radioButton11_CheckedChanged);
      this.radioButton4.AutoSize = true;
      this.radioButton4.Location = new Point(61, 3);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new Size(92, 21);
      this.radioButton4.TabIndex = 0;
      this.radioButton4.Text = "Добавить ";
      this.radioButton4.UseVisualStyleBackColor = true;
      this.radioButton4.CheckedChanged += new EventHandler(this.radioButton4_CheckedChanged);
      this.button11.BackColor = SystemColors.HotTrack;
      this.button11.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button11.Location = new Point(524, 695);
      this.button11.Name = "button11";
      this.button11.Size = new Size(205, 25);
      this.button11.TabIndex = 19;
      this.button11.Text = "N";
      this.button11.UseVisualStyleBackColor = false;
      this.button11.Click += new EventHandler(this.button11_Click);
      this.button10.BackColor = SystemColors.HotTrack;
      this.button10.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button10.Location = new Point(524, 664);
      this.button10.Name = "button10";
      this.button10.Size = new Size(205, 25);
      this.button10.TabIndex = 18;
      this.button10.Text = "-24";
      this.button10.UseVisualStyleBackColor = false;
      this.button10.Click += new EventHandler(this.button10_Click);
      this.button9.BackColor = SystemColors.HotTrack;
      this.button9.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button9.Location = new Point(524, 633);
      this.button9.Name = "button9";
      this.button9.Size = new Size(205, 25);
      this.button9.TabIndex = 17;
      this.button9.Text = "+24";
      this.button9.UseVisualStyleBackColor = false;
      this.button9.Click += new EventHandler(this.button9_Click);
      this.button7.BackColor = SystemColors.HotTrack;
      this.button7.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button7.ForeColor = SystemColors.ControlLightLight;
      this.button7.Location = new Point(524, 571);
      this.button7.Name = "button7";
      this.button7.Size = new Size(205, 25);
      this.button7.TabIndex = 15;
      this.button7.Text = "+24/-24/N";
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.button8.BackColor = SystemColors.HotTrack;
      this.button8.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button8.Location = new Point(524, 602);
      this.button8.Name = "button8";
      this.button8.Size = new Size(205, 25);
      this.button8.TabIndex = 16;
      this.button8.Text = "+24/-24";
      this.button8.UseVisualStyleBackColor = false;
      this.button8.Click += new EventHandler(this.button8_Click);
      this.button6.BackColor = SystemColors.HotTrack;
      this.button6.Location = new Point(554, 458);
      this.button6.Name = "button6";
      this.button6.Size = new Size(122, 24);
      this.button6.TabIndex = 14;
      this.button6.Text = "Найти";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.label4.Location = new Point(551, 438);
      this.label4.Name = "label4";
      this.label4.Size = new Size(213, 17);
      this.label4.TabIndex = 12;
      this.label4.Text = "Лист";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(480, 415);
      this.label1.Name = "label1";
      this.label1.Size = new Size(72, 17);
      this.label1.TabIndex = 11;
      this.label1.Text = "Наклейка";
      this.textBox1.Location = new Point(554, 412);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(206, 23);
      this.textBox1.TabIndex = 10;
      this.panel2.Controls.Add((Control) this.radioButton10);
      this.panel2.Controls.Add((Control) this.radioButton9);
      this.panel2.Location = new Point(473, 320);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(287, 24);
      this.panel2.TabIndex = 9;
      this.openFileDialog1.Filter = "Текстовые файлы наклеек (*.txt)|*.txt";
      this.saveFileDialog1.Filter = "Текстовый файл(*.txt)|*.txt";
      this.saveFileDialog1.OverwritePrompt = false;
      this.menuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.справкаToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(1072, 24);
      this.menuStrip1.TabIndex = 4;
      this.menuStrip1.Text = "menuStrip1";
      this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
      this.справкаToolStripMenuItem.Size = new Size(65, 20);
      this.справкаToolStripMenuItem.Text = "Справка";
      this.справкаToolStripMenuItem.Click += new EventHandler(this.справкаToolStripMenuItem_Click);
      this.label6.AutoSize = true;
      this.label6.Location = new Point(21, 176);
      this.label6.Name = "label6";
      this.label6.Size = new Size(57, 17);
      this.label6.TabIndex = 5;
      this.label6.Text = "Строки";
      this.label7.AutoSize = true;
      this.label7.Location = new Point(13, 206);
      this.label7.Name = "label7";
      this.label7.Size = new Size(66, 17);
      this.label7.TabIndex = 6;
      this.label7.Text = "Столбцы";
      this.textBox4.Location = new Point(85, 173);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(106, 23);
      this.textBox4.TabIndex = 7;
      this.textBox4.Text = "16";
      this.textBox5.Location = new Point(85, 203);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(106, 23);
      this.textBox5.TabIndex = 8;
      this.textBox5.Text = "7";
      this.textBox6.Location = new Point((int) sbyte.MaxValue, 237);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new Size(106, 23);
      this.textBox6.TabIndex = 9;
      this.textBox6.Text = "140";
      this.label8.Location = new Point(8, 240);
      this.label8.Name = "label8";
      this.label8.Size = new Size(113, 35);
      this.label8.TabIndex = 10;
      this.label8.Text = "Высота ячейки";
      this.AutoScaleDimensions = new SizeF(8f, 17f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.HotTrack;
      this.ClientSize = new Size(1072, 768);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.textBox6);
      this.Controls.Add((Control) this.textBox5);
      this.Controls.Add((Control) this.textBox4);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.menuStrip1);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.pictureBox1);
      this.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.ForeColor = SystemColors.ControlLightLight;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new Padding(4);
      this.Name = nameof (Form1);
      this.Text = "АСКО наклейки";
      this.Load += new EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox7.ResumeLayout(false);
      this.groupBox8.ResumeLayout(false);
      this.groupBox8.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.contextMenuStrip1.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
