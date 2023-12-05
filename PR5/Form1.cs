using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PR5.BuilderBurger;
using PR5.DBCon;


namespace PR5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model1 model = new Model1();    

        private void button1_Click(object sender, EventArgs e)
        {
            BurgerBuilder burgerBuilder = new BurgerBuilder();
            BurgerDirector burgerDirector = new BurgerDirector(burgerBuilder);

            if (comboBoxBurger.SelectedItem.ToString() == "Бургер стандартный") 
                burgerDirector.BuildDefault();

            else 
                burgerDirector.BuildWithBacon();
            
            try
            {

                model.Burgers.Add(burgerBuilder.GetBurgers());
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
