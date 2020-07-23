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
    public partial class CreateMealPlanForm : Form
    {
        DailyMealsEntities _context;
        int calories = 0;
        int breakfastCalories = 0;
        int lunchCalories = 0;
        int dinnerCalories = 0;
        int snackCalories = 0;
        int snackTotalCalories = 0;

        public CreateMealPlanForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new DailyMealsEntities();

            _context.Breakfasts.Load();
            this.breakfastsDataGridView.DataSource =
                _context.Breakfasts.Local.ToBindingList();

            _context.Lunches.Load();
            this.lunchesDataGridView.DataSource =
                _context.Lunches.Local.ToBindingList();

            _context.Dinners.Load();
            this.dinnersDataGridView.DataSource =
                _context.Dinners.Local.ToBindingList();

            _context.Snacks.Load();
            this.snacksDataGridView.DataSource =
                _context.Snacks.Local.ToBindingList();
        }
        private void CreateMealPlanForm_Load(object sender, EventArgs e)
        {

        }
        private void breakfastsDataGridView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (breakfastListBox.Items.Count < 1)
            {
                int selectedrowindex = breakfastsDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = breakfastsDataGridView.Rows[selectedrowindex];
                int totalCals = Convert.ToInt32(totalCaloriesLabel.Text);
                breakfastCalories = Convert.ToInt32(selectedRow.Cells["caloriesDataGridViewTextBoxColumn"].Value);
                var name = selectedRow.Cells["nameDataGridViewTextBoxColumn"].Value;

                if ((totalCals + breakfastCalories) > 2000)
                {
                    MessageBox.Show("Too many calories for today - figure it out fat stuff");
                }
                else
                {
                    try
                    {
                        breakfastListBox.Items.Add(name);
                        breakfastCalories = Convert.ToInt32(selectedRow.Cells["caloriesDataGridViewTextBoxColumn"].Value);

                        calories = calories + breakfastCalories;

                        totalCaloriesLabel.Text = calories.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid selection");
                    }
                }
            }
            else
            {
                MessageBox.Show("Only one Breakfast per day Fatty");
            }
        }
        private void lunchesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lunchListBox.Items.Count < 1)
            {
                int selectedrowindex = lunchesDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = lunchesDataGridView.Rows[selectedrowindex];
                int totalCals = Convert.ToInt32(totalCaloriesLabel.Text);
                lunchCalories = Convert.ToInt32(selectedRow.Cells["caloriesDataGridViewTextBoxColumn1"].Value);
                var name = selectedRow.Cells["nameDataGridViewTextBoxColumn1"].Value;

                if ((totalCals + lunchCalories) > 2000)
                {
                    MessageBox.Show("Too many calories for today - figure it out fat stuff");
                }
                else
                {
                    try
                    {
                        lunchListBox.Items.Add(name);
                        lunchCalories = Convert.ToInt32(selectedRow.Cells["caloriesDataGridViewTextBoxColumn1"].Value);

                        calories = calories + lunchCalories;

                        totalCaloriesLabel.Text = calories.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid selection");
                    }
                }
            }
            else
            {
                MessageBox.Show("Only one Lunch per day Fatty");
            }
        }
        private void dinnersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dinnerListBox.Items.Count < 1)
            {
                int selectedrowindex = dinnersDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dinnersDataGridView.Rows[selectedrowindex];
                int totalCals = Convert.ToInt32(totalCaloriesLabel.Text);
                dinnerCalories = Convert.ToInt32(selectedRow.Cells["caloriesDataGridViewTextBoxColumn2"].Value);
                var name = selectedRow.Cells["nameDataGridViewTextBoxColumn2"].Value;

                if ((totalCals + dinnerCalories) > 2000)
                {
                    MessageBox.Show("Too many calories for today - figure it out fat stuff");
                }
                else
                {
                    try
                    {
                        dinnerListBox.Items.Add(name);
                        dinnerCalories = Convert.ToInt32(selectedRow.Cells["caloriesDataGridViewTextBoxColumn2"].Value);

                        calories = calories + dinnerCalories;

                        totalCaloriesLabel.Text = calories.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid selection");
                    }
                }
            }
            else
            {
                MessageBox.Show("Only one Dinner per day Fatty");
            }
        }

        private void snacksDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = snacksDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = snacksDataGridView.Rows[selectedrowindex];
            int totalCals = Convert.ToInt32(totalCaloriesLabel.Text);
            snackCalories = Convert.ToInt32(selectedRow.Cells["caloriesDataGridViewTextBoxColumn3"].Value);
            var name = selectedRow.Cells["nameDataGridViewTextBoxColumn3"].Value;

            if ((totalCals + snackCalories) > 2000)
            {
                MessageBox.Show("Too many calories for today - figure it out fat stuff");
            }
            else
            {               
                try
                {
                    snackListBox.Items.Add(name);

                    calories = calories + snackCalories;

                    totalCaloriesLabel.Text = calories.ToString();

                    snackTotalCalories = snackTotalCalories + snackCalories;
                }
                catch
                {
                    MessageBox.Show("Invalid selection");
                }
            }
        }

        private void breakfastRemoveButton_Click(object sender, EventArgs e)
        {
            breakfastListBox.Items.Clear();
            calories = calories - breakfastCalories;
            totalCaloriesLabel.Text = calories.ToString();
        }

        private void lunchRemoveButton_Click(object sender, EventArgs e)
        {
            lunchListBox.Items.Clear();
            calories = calories - lunchCalories;
            totalCaloriesLabel.Text = calories.ToString();
        }

        private void dinnerRemoveButton_Click(object sender, EventArgs e)
        {
            dinnerListBox.Items.Clear();
            calories = calories - dinnerCalories;
            totalCaloriesLabel.Text = calories.ToString();
        }

        private void snackRemoveButton_Click(object sender, EventArgs e)
        {
            snackListBox.Items.Clear();
            calories = calories - snackTotalCalories;
            totalCaloriesLabel.Text = calories.ToString();
            snackTotalCalories = 0;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            bool dateAlreadyPlanned = false;
            var date = dateTimePicker.Value.ToShortDateString();
            foreach (var day in _context.DailyMeals)
            {
                if (day.Date.ToShortDateString() == date)
                {
                    dateAlreadyPlanned = true;
                }
            }
            if (dateAlreadyPlanned == false)
            {
                try
                {
                    DailyMeal dailyMeal = new DailyMeal();
                    dailyMeal.Date = dateTimePicker.Value;
                    dailyMeal.TotalCals = Convert.ToInt32(totalCaloriesLabel.Text);
                    var breakfastName = breakfastListBox.Items[0].ToString();
                    var lunchName = lunchListBox.Items[0].ToString();
                    var dinnerName = dinnerListBox.Items[0].ToString();

                    foreach (var item in _context.Breakfasts)
                    {
                        if (breakfastName == item.Name)
                        {
                            dailyMeal.BreakfastID = item.BreakfastID;
                            break;
                        }
                    }
                    foreach (var item in _context.Lunches)
                    {
                        if (lunchName == item.Name)
                        {
                            dailyMeal.LunchID = item.LunchID;
                            break;
                        }
                    }
                    foreach (var item in _context.Dinners)
                    {
                        if (dinnerName == item.Name)
                        {
                            dailyMeal.DinnerID = item.DinnerID;
                            break;
                        }
                    }
                    for (int i = 0; i < snackListBox.Items.Count; i++)
                    {
                        if (i == 0)
                        {
                            var snackName = snackListBox.Items[i].ToString();
                            foreach (var item in _context.Snacks)
                            {
                                if (snackName == item.Name)
                                {
                                    dailyMeal.SnackID = item.SnackID;
                                    break;
                                }
                            }
                        }
                        else if (i == 1)
                        {
                            var snackName = snackListBox.Items[i].ToString();
                            foreach (var item in _context.Snacks)
                            {
                                if (snackName == item.Name)
                                {
                                    dailyMeal.Snack2ID = item.SnackID;
                                    break;
                                }
                            }
                        }
                        else if (i == 2)
                        {
                            var snackName = snackListBox.Items[i].ToString();
                            foreach (var item in _context.Snacks)
                            {
                                if (snackName == item.Name)
                                {
                                    dailyMeal.Snack3ID = item.SnackID;
                                    break;
                                }
                            }
                        }
                        else if (i == 3)
                        {
                            var snackName = snackListBox.Items[i].ToString();
                            foreach (var item in _context.Snacks)
                            {
                                if (snackName == item.Name)
                                {
                                    dailyMeal.Snack4ID = item.SnackID;
                                    break;
                                }
                            }
                        }
                        else if (i == 4)
                        {
                            var snackName = snackListBox.Items[i].ToString();
                            foreach (var item in _context.Snacks)
                            {
                                if (snackName == item.Name)
                                {
                                    dailyMeal.Snack5ID = item.SnackID;
                                    break;
                                }
                            }
                        }
                        else if (i == 5)
                        {
                            var snackName = snackListBox.Items[i].ToString();
                            foreach (var item in _context.Snacks)
                            {
                                if (snackName == item.Name)
                                {
                                    dailyMeal.Snack6ID = item.SnackID;
                                    break;
                                }
                            }
                        }
                    }
                    _context.DailyMeals.Add(dailyMeal);                  
                    this._context.SaveChanges();

                    breakfastListBox.Items.Clear();
                    lunchListBox.Items.Clear();
                    dinnerListBox.Items.Clear();
                    snackListBox.Items.Clear();
                    calories = 0;
                    totalCaloriesLabel.Text = calories.ToString();
                    MessageBox.Show("Meal added successfully");

                }
                catch
                {
                    MessageBox.Show("Complete meal plan before submitting");
                }
            }
            else
            {
                MessageBox.Show("Meals already set for this date");
            }
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var date = dateTimePicker.Value.ToShortDateString();
            foreach(var item in _context.DailyMeals)
            {
                if(item.Date.ToShortDateString() == date)
                {
                    MessageBox.Show("Meals already set for this date");
                }
            }
        }
    }
}
