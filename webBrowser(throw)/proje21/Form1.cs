using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
            timer1.Enabled = true;
            notifyIcon1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoBack)
            {
                if (tabControl1.SelectedTab == tabPage1)
                {
                    if (webBrowser1.CanGoBack)
                    {
                        webBrowser1.GoBack();
                    }
                }
                else if(tabControl1.SelectedTab==tp)
                {
                    if (browser.CanGoBack)
                    {
                     browser.GoBack();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                if (webBrowser1.CanGoForward)
                {
                    webBrowser1.GoForward();
                }
            }
            else if (tabControl1.SelectedTab == tp)
            {
                if (browser.CanGoForward)
                {
                    browser.GoForward();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                webBrowser1.Refresh();
            }
            else if (tabControl1.SelectedTab == tp)
            {
                browser.Refresh();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {

                webBrowser1.GoHome();
                comboBox1.Text = " ";
            }
            else if (tabControl1.SelectedTab == tp)
            {
                browser.GoHome();
                comboBox1.Text = " ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                webBrowser1.Navigate(comboBox1.Text);
            }
            else if(tabControl1.SelectedTab==tp)
            {
                browser.Navigate(comboBox1.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            yeni();
        }
        TabPage tp = new TabPage();//global olarak tanımladık
        WebBrowser browser = new WebBrowser();//global olarak tanımladık
        public void yeni()
        {
               tp = new TabPage();//tekrar takrar oluşturduk
               tp.Text = "yeni sekme";
               tabControl1.TabPages.Add(tp);

               browser = new WebBrowser();
               browser.ScriptErrorsSuppressed = true;
               browser.Dock = DockStyle.Fill;
               browser.Navigate("www.google.com");
               tp.Controls.Add(browser);
               tabControl1.SelectedTab = tp;
               comboBox1.Text = " ";
            
        }
        
        private void yeniSekmeyiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage seçilen = new TabPage();
            seçilen = tabControl1.SelectedTab;
            tabControl1.TabPages.Remove(seçilen);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (!(comboBox1.Items.Contains(webBrowser1.Url)))
            {
                comboBox1.Items.Add((webBrowser1.Url));
                comboBox1.AutoCompleteCustomSource.Add(webBrowser1.Url.ToString());
            }
        }

        private void tarayıcıyıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                webBrowser1.Navigate("https://www.google.com/search?q=" + textBox1.Text);
            }
            else if (tabControl1.SelectedTab == tp)
            {
                browser.Navigate("https://www.google.com/search?q=" + textBox1.Text);
            }
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void programıGizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pogramıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                webBrowser1.Navigate("https://www.google.com/search?q=" + textBox1.Text);
            }
            else if (tabControl1.SelectedTab == tp)
            {
                browser.Navigate("https://www.google.com/search?q=" + textBox1.Text);
            }
        }

       
    }
}
