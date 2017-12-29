using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Epidemic.Assets;

namespace Epidemic.Runtime
{
    public partial class Console : UserControl
    {
        [Browsable(false)]
        public List<string> Information = new List<string> { };
        [Browsable(false)]
        public List<string> Warnings = new List<string> { };
        [Browsable(false)]
        public List<string> Errors = new List<string> { };

        [Category("Epidemic"), Description("Interface with full text of console.")]
        public string Text { get => consoleTextBox.Text; set => consoleTextBox.Text = value; }

        public Console()
        {
            InitializeComponent();
        }

        public void add(string text, ConsoleType type = ConsoleType.Information)
        {
            if (type == ConsoleType.Information)
            {
                Information.Add(text);
                consoleTextBox.Text += $"{Environment.NewLine}{text}";
                informationLabel.Text = (Convert.ToInt32(informationLabel.Text) + 1).ToString();
            }
            else if (type == ConsoleType.Warning)
            {
                Warnings.Add(text);
                consoleTextBox.Text += $"{Environment.NewLine}{text}";
                warningLabel.Text = (Convert.ToInt32(warningLabel.Text) + 1).ToString();
            }
            else if (type == ConsoleType.Error)
            {
                Errors.Add(text);
                consoleTextBox.Text += $"{Environment.NewLine}{text}";
                errorLabel.Text = (Convert.ToInt32(errorLabel.Text) + 1).ToString();
            }
        }
    }
}
