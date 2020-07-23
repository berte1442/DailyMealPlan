using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyMealPlan
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void createFoodItemButton_Click(object sender, EventArgs e)
        {
            CreateFoodForm createFoodForm = new CreateFoodForm();
            createFoodForm.ShowDialog();
        }

        private void createMealButton_Click(object sender, EventArgs e)
        {
            CreateMealForm createMealForm = new CreateMealForm();
            createMealForm.ShowDialog();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void createMealPlanButton_Click(object sender, EventArgs e)
        {
            CreateMealPlanForm createMealPlanForm = new CreateMealPlanForm();
            createMealPlanForm.ShowDialog();
        }

        private void viewMealPlanButton_Click(object sender, EventArgs e)
        {
            ViewMealPlanForm viewMealPlanForm = new ViewMealPlanForm();
            viewMealPlanForm.ShowDialog();
        }

        private void logMealButton_Click(object sender, EventArgs e)
        {
            LogFoodForm logFoodForm = new LogFoodForm();
            logFoodForm.ShowDialog();
        }
    }
}
