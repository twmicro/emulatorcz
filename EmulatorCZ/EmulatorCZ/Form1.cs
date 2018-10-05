using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmulatorCZ
{
    public partial class MainForm : Form
    {
        private Dictionary<string, string> Marks;
        private int Zero = 0;
        private int Cross = 0;
        private bool Invert = true;
        public MainForm()
        {
            InitializeComponent();
            InitializeMarks(out Marks);
        }
        public void InitializeMarks(out Dictionary<string, string> marks)
        {
            marks = new Dictionary<string, string>();
            string[] Names = { "lu", "lc", "ld", "cu", "cc", "cd", "ru", "rc", "rd"};
            foreach (string Name in Names) marks.Add(Name, "empty");
        }

        public void Display()
        {
            score.Text = Zero + ":" + Cross;
        }

        public void BlockButtons(bool state)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = state;
            button2.Enabled = state;
            button3.Enabled = state;
            button4.Enabled = state;
            button5.Enabled = state;
            button6.Enabled = state;
            button7.Enabled = state;
            button8.Enabled = state;
            button9.Enabled = state;
        }
        public void Over(string winner)
        {
            if (winner == "zero") score.Text = "Zero Win!";
            else if (winner == "cross") score.Text = "Cross Win!";
            else score.Text = "Rang! NW";
        }
        public string NameOfButton(Button b)
        {
            string Name = b.Name;
            string LastSymbol = "";
            LastSymbol += Name[Name.Length - 1];
            int Index = Convert.ToInt32(LastSymbol) - 1;
            return Marks.Keys.ToArray()[Index];
        }
        public void ClickMark(object sender, EventArgs e)
        {
            Button mb = (Button)sender;
            mb.Font = new Font(new FontFamily("Arial"), 55);
            string Name = Invert ? "cross" : "zero";
            string ContentText = Name == "cross" ? "X" : "O";
            mb.Text = ContentText;
            Marks[NameOfButton(mb)] = Name;
            mb.Enabled = false;
            string state = State();
            if (!(Marks.ContainsValue("empty")) && state == "no winner") { score.Text = "NW. " + score.Text; }
            else
            {
                if (state == "zero") Zero++;
                if (state == "cross") Cross++;
                if (state != "no winner") Display();
            }
            Invert = !Invert;
        }

        public string State()
        {
            string state;
            string lu = Marks["lu"];
            string lc = Marks["lc"];
            string ld = Marks["ld"];
            string cu = Marks["cu"];
            string cc = Marks["cc"];
            string cd = Marks["cd"];
            string ru = Marks["ru"];
            string rc = Marks["rc"];
            string rd = Marks["rd"];
            if (lu == lc && lu == ld && lu != "empty") state = lu;
            else if (cu == cc && cu == cd && cu != "empty") state = cu;
            else if (ru == rc && ru == rd && ru != "empty") state = ru;
            else if (lu == cu && lu == ru && lu != "empty") state = lu;
            else if (lc == cc && lc == rc && lc != "empty") state = cu;
            else if (ld == cd && ld == rd && ld != "empty") state = ru;
            else if (lu == cc && lu == rd && lu != "empty") state = lu;
            else if (ru == cc && ru == ld && ru != "empty") state = ru;
            else state = "no winner";
            return state;
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            BlockButtons(true);
            InitializeMarks(out Marks);
            Invert = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            Over(Zero > Cross ? "zero" : "cross");
        }
    }
}
