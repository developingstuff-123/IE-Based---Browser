using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cird_Browser
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (metroTabControl.SelectedTab.Controls[0] is WebBrowser browser)
            {
                browser.Navigate(txtUrl.Text);
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            NewTab();
        }

        private void NewTab()
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            metroTabControl.Controls.Add(tab);
            metroTabControl.SelectTab(metroTabControl.TabCount - 1);
            WebBrowser browser = new WebBrowser() { ScriptErrorsSuppressed = true };
            browser.Parent = tab;
            browser.Dock = DockStyle.Fill;
            browser.Navigate("https://www.google.com");
            txtUrl.Text = "https://www.google.com";
            browser.DocumentCompleted += BrowserDocumentCompleted;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewTab();
        }

        private void BrowserDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (metroTabControl.SelectedTab.Controls[0] is WebBrowser browser)
            {
                metroTabControl.SelectedTab.Text = browser.DocumentTitle;
            }
        }

        private void InkBack_Click(object sender, EventArgs e)
        {
            if (metroTabControl.SelectedTab.Controls[0] is WebBrowser browser)
            {
                if (browser.CanGoBack)
                {
                    browser.GoBack();
                }
            }
        }

        private void InkForward_Click(object sender, EventArgs e)
        {
            if (metroTabControl.SelectedTab.Controls[0] is WebBrowser browser)
            {
                if (browser.CanGoForward)
                {
                    browser.GoForward();
                }
            }
        }
    }
}
