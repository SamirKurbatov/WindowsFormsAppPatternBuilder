using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPatternBuilder.BuilderBurger;
using WindowsFormsAppPatternBuilder.DBCon;

namespace WindowsFormsAppPatternBuilder
{
    public partial class Form1 : Form
    {
        Model1 model = new Model1();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var burgerBuilder = new BurgerBuilder();
            var burgerDirector = new BurgerDirector(burgerBuilder);

            if (comboBoxBurger.SelectedItem.ToString() == "Бургер стандартный")
            {
                burgerDirector.BuildDefault();
            }
            else
            {
                burgerDirector.BuildWithBacon();
            }

            try
            {
                model.Burgers.Add(burgerBuilder.GetBurger());
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            comboBoxBurger.SelectedIndex = 0;
            dataGridView1.DataSource = model.Burgers.ToList();
        }
    }
}
