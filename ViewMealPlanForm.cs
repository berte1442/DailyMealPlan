using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DailyMealPlan
{
    public partial class ViewMealPlanForm : Form
    {
        DailyMealsEntities _context;

        public ViewMealPlanForm()
        {
            InitializeComponent();
        }
        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    _context = new DailyMealsEntities();

        //    _context.Breakfasts.Load();
        //    this.breakfastDataGridView.DataSource =
        //        _context.Breakfasts.Local.ToBindingList();

        //    _context.Lunches.Load();
        //    this.lunchDataGridView.DataSource =
        //        _context.Lunches.Local.ToBindingList();

        //    _context.Dinners.Load();
        //    this.dinnerDataGridView.DataSource =
        //        _context.Dinners.Local.ToBindingList();

        //    _context.Snacks.Load();
        //    this.snackDataGridView.DataSource =
        //        _context.Snacks.Local.ToBindingList();
        //}

        private void ViewMealPlanForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            totalCalsLabel.Text = "0";            
            _context = new DailyMealsEntities();

            // clears datagridview prior to displaying new selected date
            breakfastDataGridView.DataSource = null;            
            lunchDataGridView.DataSource = null;
            dinnerDataGridView.DataSource = null;
            snackDataGridView.DataSource = null;
            breakfastDataGridView.Rows.Clear();
            breakfastDataGridView.Refresh();
            lunchDataGridView.Rows.Clear();
            lunchDataGridView.Refresh();
            dinnerDataGridView.Rows.Clear();
            dinnerDataGridView.Refresh();
            snackDataGridView.Rows.Clear();
            snackDataGridView.Refresh();
            ///////////////////////////////
            
            var date = dateTimePicker1.Value;
            var breakfastID = 0;
            var lunchID = 0;
            var dinnerID = 0;
            var snackID = 0;
            var snack2ID = 0;
            var snack3ID = 0;
            var snack4ID = 0;
            var snack5ID = 0;
            var snack6ID = 0;
            foreach(var item in _context.DailyMeals)
            {
                if(item.Date.ToShortDateString() == date.ToShortDateString())
                {
                    totalCalsLabel.Text = item.TotalCals.ToString();
                    breakfastID = Convert.ToInt32(item.BreakfastID);
                    lunchID = Convert.ToInt32(item.LunchID);
                    dinnerID = Convert.ToInt32(item.DinnerID);
                    snackID = Convert.ToInt32(item.SnackID);
                    snack2ID = Convert.ToInt32(item.Snack2ID);
                    snack3ID = Convert.ToInt32(item.Snack3ID);
                    snack4ID = Convert.ToInt32(item.Snack4ID);
                    snack5ID = Convert.ToInt32(item.Snack5ID);
                    snack6ID = Convert.ToInt32(item.Snack6ID);

                    foreach(var bfItem in _context.Breakfasts)
                    {
                        if(bfItem.BreakfastID == breakfastID)
                        {
                            breakfastDataGridView.Rows.Add(bfItem.BreakfastID, bfItem.Name, bfItem.Calories, bfItem.Description);
                        }
                    }
                    foreach (var lItem in _context.Lunches)
                    {
                        if (lItem.LunchID == lunchID)
                        {
                            lunchDataGridView.Rows.Add(lItem.LunchID, lItem.Name, lItem.Calories, lItem.Description);
                        }
                    }
                    foreach (var dItem in _context.Dinners)
                    {
                        if (dItem.DinnerID == dinnerID)
                        {
                            dinnerDataGridView.Rows.Add(dItem.DinnerID, dItem.Name, dItem.Calories, dItem.Description);
                        }
                    }
                    foreach (var sItem in _context.Snacks)
                    {
                        if (sItem.SnackID == snackID || 
                            sItem.SnackID == snack2ID || 
                            sItem.SnackID == snack3ID || 
                            sItem.SnackID == snack4ID || 
                            sItem.SnackID == snack5ID || 
                            sItem.SnackID == snack6ID)
                        {
                            snackDataGridView.Rows.Add(sItem.SnackID, sItem.Name, sItem.Calories, sItem.Description);
                        }
                    }
                }
            }
        }

        private void breakfastDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void breakfastDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = breakfastDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = breakfastDataGridView.Rows[selectedrowindex];
                var ID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                foreach (var item in _context.Breakfasts)
                {
                    if (ID == item.BreakfastID)
                    {
                        MessageBox.Show(item.Name + "\n\n" + item.Description + "\n\n" + item.Calories + " calories", "Breakfast");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid Selection");
            }
        }

        private void lunchDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = lunchDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = lunchDataGridView.Rows[selectedrowindex];
                var ID = Convert.ToInt32(selectedRow.Cells["ID2"].Value);
                foreach (var item in _context.Lunches)
                {
                    if (ID == item.LunchID)
                    {
                        MessageBox.Show(item.Name + "\n\n" + item.Description + "\n\n" + item.Calories + " calories", "Lunch");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid Selection");
            }
        }

        private void dinnerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = dinnerDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dinnerDataGridView.Rows[selectedrowindex];
                var ID = Convert.ToInt32(selectedRow.Cells["ID3"].Value);
                foreach (var item in _context.Dinners)
                {
                    if (ID == item.DinnerID)
                    {
                        MessageBox.Show(item.Name + "\n\n" + item.Description + "\n\n" + item.Calories + " calories", "Dinner");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid Selection");
            }
        }

        private void snackDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = snackDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = snackDataGridView.Rows[selectedrowindex];
                var ID = Convert.ToInt32(selectedRow.Cells["ID4"].Value);
                foreach (var item in _context.Snacks)
                {
                    if (ID == item.SnackID)
                    {
                        MessageBox.Show(item.Name + "\n\n" + item.Description + "\n\n" + item.Calories + " calories", "Snack");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid Selection");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this meal?", "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var date = dateTimePicker1.Value;
                    foreach (var item in _context.DailyMeals)
                    {
                        if (item.Date.ToShortDateString() == date.ToShortDateString())
                        {
                            _context.DailyMeals.Remove(item);
                            breakfastDataGridView.DataSource = null;
                            lunchDataGridView.DataSource = null;
                            dinnerDataGridView.DataSource = null;
                            snackDataGridView.DataSource = null;
                            breakfastDataGridView.Rows.Clear();
                            breakfastDataGridView.Refresh();
                            lunchDataGridView.Rows.Clear();
                            lunchDataGridView.Refresh();
                            dinnerDataGridView.Rows.Clear();
                            dinnerDataGridView.Refresh();
                            snackDataGridView.Rows.Clear();
                            snackDataGridView.Refresh();
                            totalCalsLabel.Text = "0";
                        }
                    }
                    _context.SaveChanges();
                    MessageBox.Show("Meal Plan Deleted");
                }
            }
            catch
            {
                MessageBox.Show("Could not complete action");
            }
        }

        private void createMealPlanButton_Click(object sender, EventArgs e)
        {
            CreateMealPlanForm createMealPlanForm = new CreateMealPlanForm();
            createMealPlanForm.ShowDialog();
            this.Refresh();
        }

        private void mealOptionsButton_Click(object sender, EventArgs e)
        {
            CreateMealForm createMealForm = new CreateMealForm();
            createMealForm.ShowDialog();
            this.Refresh();
        }

        private void createFoodOptionsButton_Click(object sender, EventArgs e)
        {
            CreateFoodForm createFood = new CreateFoodForm();
            createFood.ShowDialog();
            this.Refresh();
        }
    }
}
