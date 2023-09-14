using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Programowaniewizualne5
{
    public partial class Form2 : Form
    {
        string projectPath = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//SAVE
        {
            projectPath = System.IO.Path.GetDirectoryName(projectPath);
            string filePath = System.IO.Path.Combine(projectPath, "data1.xml");
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("MyData");
            doc.AppendChild(root);

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    XmlElement textBoxElement = doc.CreateElement("TextBoxData");
                    textBoxElement.SetAttribute("name", control.Name);
                    textBoxElement.InnerText = ((TextBox)control).Text;
                    root.AppendChild(textBoxElement);
                }
            }

            doc.Save(filePath);
        }

        private void button2_Click(object sender, EventArgs e)//LOAD
        {
            projectPath = System.IO.Path.GetDirectoryName(projectPath);
            string filePath = System.IO.Path.Combine(projectPath, "data1.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    XmlNode textBoxNode = doc.SelectSingleNode($"//MyData/TextBoxData[@name='{control.Name}']");
                    if (textBoxNode != null)
                    {
                        ((TextBox)control).Text = textBoxNode.InnerText;
                    }
                }
            }
        }
    }
}
