﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace ImagePaster
{
    public partial class MainForm : Form
    {
        public static short imgWidth = 0;
        public static short imgHeight = 0;
        public static byte borderWidth = 0;

        bool blockChange = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void sourceTextBox_TextChanged(object sender, EventArgs e)
        {
            string uri = sourceTextBox.Text.ToLower();
            if (uri == "")
            {
                resultTextBox.Clear();
                return;
            }
            if (!uri.Contains("http://www.")
                && (uri.IndexOf('.') == uri.LastIndexOf('.'))
                && (!uri.Contains(".jpg")
                || !uri.Contains(".png")
                || !uri.Contains(".gif")))
            {
                resultTextBox.Clear();
                return;
            }
            // Подбираем обтекание
            string floatType;
            if (leftRB.Checked) floatType = "right";
            else if (rightRB.Checked) floatType = "left";
            else floatType = "none";
            // Подбираем обтекание
            string alignType;
            if (radioButtonAlignLeft.Checked) alignType = "left";
            else if (radioButtonAlignRight.Checked) alignType = "right";
            else alignType = "center";
            // Указываем надпись при наводке на картинку
            string alt = "";
            if (textBoxAlt.Text != "") alt = string.Format("alt=\"{0}\"", textBoxAlt.Text);
            resultTextBox.Text = string.Format(
                "<div style=\"text-align:{6}\"><a href=\"{0}\"><img src=\"{0}\" style=\"float:{1};\"height=\"{2}px\" width=\"{3}px\" border=\"{4}\" {5}></a></div>", 
                sourceTextBox.Text, floatType, textBoxHeight.Text, textBoxWidth.Text, borderWidth, alt, alignType);
        }

        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (blockChange) return;
            if (imgHeight == 0 || imgWidth == 0) return;
            if (((TextBox)sender).Text == "")
            {
                textBoxWidth.Text = "0";
                return;
            }
            int newWidth = int.Parse(((TextBox)sender).Text);
            int newHeight = 0;

            newHeight = (imgHeight * newWidth) / imgWidth;

            blockChange = true;
            textBoxHeight.Text = newHeight.ToString();
            blockChange = false;
            sourceTextBox_TextChanged(null, null);
        }

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (blockChange) return;
            if (imgHeight == 0 || imgWidth == 0) return;
            if (((TextBox)sender).Text == "")
            {
                textBoxHeight.Text = "0";
                return;
            } 
            int newHeight = int.Parse(((TextBox)sender).Text);
            int newWidth = 0;

            newWidth = (imgWidth * newHeight) / imgHeight;

            blockChange = true;
            textBoxWidth.Text = newWidth.ToString();
            blockChange = false;
            sourceTextBox_TextChanged(null, null);
        }

        private void buttonDownloadImg_Click(object sender, EventArgs e)
        {
            string uri = sourceTextBox.Text.ToLower();
            if (uri == "") return;
            if (!uri.Contains("http://www.")
                && (uri.IndexOf('.') == uri.LastIndexOf('.'))
                && (!uri.Contains(".jpg")
                || !uri.Contains(".png")
                || !uri.Contains(".gif")))
            {
                return;
            }
            try
            {
                DownloadImg();
                long div = CommDiv(imgHeight, imgWidth);
                textBoxRatio.Text = string.Format("{0}/{1}", imgHeight / div, imgWidth / div);
                sourceTextBox_TextChanged(null, null);
            }
            catch (Exception ex)
            {
                ShowMsg(ex);
            }
        }

        [Conditional("DEBUG")]
        private void ShowMsg(Exception ex)
        {
            MessageBox.Show(string.Format("Исключение: {0}\r\nТекст: {1}", ex.GetType().Name, ex.Message), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DownloadImg()
        {
            WebResponse resp;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(sourceTextBox.Text);

            req.UserAgent = @"Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.1.5) Gecko/20091102 Firefox/3.5.5";
            req.AllowAutoRedirect = true;
            req.MaximumAutomaticRedirections = 300;
            resp = req.GetResponse();
            if (!resp.ContentType.Contains("image"))
            {
                labelError.Text = "Ссылка указывает не картинку";
                return;
            }

            Stream stream = resp.GetResponseStream();
            Image img = Image.FromStream(stream);
            stream.Close();

            textBoxWidth.Invoke(new Action(() => textBoxWidth.Text = img.Width.ToString()));
            imgWidth = (short)img.Width;
            textBoxHeight.Invoke(new Action(() => textBoxHeight.Text = img.Height.ToString()));
            imgHeight = (short)img.Height;
        }

        /// <summary>
        /// Find the Greatest Common Divisor
        /// </summary>
        /// <param name="a">Number a</param>
        /// <param name="b">Number b</param>
        /// <returns>The greatest common Divisor</returns>
        public static long CommDiv(long a, long b)
        {
            while (b != 0)
            {
                long tmp = b;
                b = a % b;
                a = tmp;
            }

            return a;
        }

        private void buttonFromClipboard_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText()) sourceTextBox.Text = Clipboard.GetText();
        }

        private void comboBoxBorder_SelectedIndexChanged(object sender, EventArgs e)
        {
            borderWidth = (byte)comboBoxBorder.SelectedIndex;
            sourceTextBox_TextChanged(null, null);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sourceTextBox.Text = "http://i.imgur.com/Wk5l8Mo.jpg";
            DownloadImg();
            textBoxHeight.Text = "400";
            textBoxRatio.Text = "4/3";
            comboBoxBorder.SelectedIndex = 1;
            textBoxAlt.Text = "My day off. I'm in bed. Boss calls to see if I can come in.";
            sourceTextBox_TextChanged(null, null);
        }
    }
}
