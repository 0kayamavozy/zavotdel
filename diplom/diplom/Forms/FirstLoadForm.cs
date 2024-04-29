using diplom.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom.Forms
{
    public partial class FirstLoadForm : Form
    {
        public FirstLoadForm()
        {
            InitializeComponent();

            string headertext = $"Автоматизированная информационная система \r\n\"Завотделением\". {GlobalHelper.CorpusName} корпус";

            if (GlobalHelper.CorpusName == "Главный")
            {
                label1.Text = headertext;
                picturebox.Image = Properties.Resources.AMT1foto;
            }
            else if (GlobalHelper.CorpusName == "Первый")
            {
                label1.Text = headertext;
                picturebox.Image = Properties.Resources.user_464_gallery_fdec147347e98d8d315836a816ed9ba0_0_0;
            }
            else if (GlobalHelper.CorpusName == "Второй")
            {
                label1.Text = headertext;
                picturebox.Image = Properties.Resources._134379396_86582212;
            }

        }

        private void FirstLoadForm_Load(object sender, EventArgs e)
        {
            StudentsHelperClasscs.CountStudents(StudentsCount);
            StudentsHelperClasscs.SelectFree(BudF);
            StudentsHelperClasscs.SelectMoney(KomF);

            StudentsHelperClasscs.SelectO(oTB);
            StudentsHelperClasscs.SelectZ(zTB);
        }
    }
}
