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
    public partial class CreateMealForm : Form
    {
        DailyMealsEntities _context;
        int calories = 0;
        public CreateMealForm()
        {
            InitializeComponent();
            this.optionsDataGridView.ReadOnly = true;
        }

        private void breakfastRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mealNameLabel.Text = "Meal Name -";
            mealNameTextBox.Clear();
            mealListBox.Items.Clear();
            calories = 0;
            totalCaloriesLabel.Text = calories.ToString();
            DailyMealsEntities _context;

            if (breakfastRadioButton.Checked == true)
            {
                _context = new DailyMealsEntities();

                _context.BreakfastItems.Load();
                this.optionsDataGridView.DataSource =
                    _context.BreakfastItems.Local.ToBindingList();

                this.optionsDataGridView.Columns["BreakfastItemID"].Visible = false;

                dgvLabel.Text = "Breakfast Items";
            }
        }

        private void lunchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mealNameLabel.Text = "Meal Name -";
            mealNameTextBox.Clear();
            mealListBox.Items.Clear();
            calories = 0;
            totalCaloriesLabel.Text = calories.ToString();
            DailyMealsEntities _context;

            if (lunchRadioButton.Checked == true)
            {
                _context = new DailyMealsEntities();

                _context.LunchItems.Load();
                this.optionsDataGridView.DataSource =
                    _context.LunchItems.Local.ToBindingList();

                this.optionsDataGridView.Columns["LunchItemID"].Visible = false;
                dgvLabel.Text = "Lunch Items";

            }
        }

        private void dinnerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mealNameLabel.Text = "Meal Name -";
            mealNameTextBox.Clear();
            mealListBox.Items.Clear();
            calories = 0;
            totalCaloriesLabel.Text = calories.ToString();
            DailyMealsEntities _context;

            if (dinnerRadioButton.Checked == true)
            {
                _context = new DailyMealsEntities();

                _context.DinnerItems.Load();
                this.optionsDataGridView.DataSource =
                    _context.DinnerItems.Local.ToBindingList();

                this.optionsDataGridView.Columns["DinnerItemID"].Visible = false;
                dgvLabel.Text = "Dinner Items";

            }
        }

        private void snackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mealNameLabel.Text = "Snack Name -";
            mealNameTextBox.Clear();
            mealListBox.Items.Clear();
            calories = 0;
            totalCaloriesLabel.Text = calories.ToString();
            DailyMealsEntities _context;

            if (snackRadioButton.Checked == true)
            {
                _context = new DailyMealsEntities();

                _context.SnackItems.Load();
                this.optionsDataGridView.DataSource =
                    _context.SnackItems.Local.ToBindingList();

                this.optionsDataGridView.Columns["SnackItemID"].Visible = false;
                dgvLabel.Text = "Snack Items";

            }
        }

        private void optionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void optionsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = optionsDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = optionsDataGridView.Rows[selectedrowindex];
            var name = selectedRow.Cells["Name"].Value;
            try
            {
                mealListBox.Items.Add(name);
            }
            catch
            {
                MessageBox.Show("Invalid selection");
            }

            int addCalories = Convert.ToInt32(selectedRow.Cells["Calories"].Value);

            calories = calories + addCalories;

            totalCaloriesLabel.Text = calories.ToString();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var name = "";
            int subtractCalories = 0;
            try
            {
                name = mealListBox.SelectedItem.ToString();
                mealListBox.Items.Remove(name);

                foreach (DataGridViewRow row in optionsDataGridView.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(name))
                    {
                        subtractCalories = Convert.ToInt32(row.Cells[2].Value);
                        break;
                    }
                }
                calories = calories - subtractCalories;
                totalCaloriesLabel.Text = calories.ToString();
            }
            catch
            {
                MessageBox.Show("Item not selected");
            }

            //calories = calories - subtractCalories;

            //totalCaloriesLabel.Text = calories.ToString();
            //mealNameTextBox.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            mealNameTextBox.Clear();
            mealListBox.Items.Clear();
            calories = 0;
            totalCaloriesLabel.Text = calories.ToString();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (mealNameTextBox.Text == "")
            {
                MessageBox.Show("Give your meal a name");
            }
            else if(mealListBox.Items.Count == 0)
            {
                MessageBox.Show("Add some items to create meal");
            }
            else
            {
                _context = new DailyMealsEntities();

                string description = "";
                int i = 0;
                foreach (var item in mealListBox.Items)
                {
                    if (i == 0)
                    {
                        description = item.ToString();
                    }
                    else
                    {
                        description = description + ", " + item;
                    }
                    i++;
                }
                if (breakfastRadioButton.Checked == true)
                {
                    Breakfast breakfast = new Breakfast();
                    breakfast.Description = description;
                    breakfast.Calories = Convert.ToInt32(totalCaloriesLabel.Text);
                    breakfast.Name = mealNameTextBox.Text;
                    _context.Breakfasts.Add(breakfast);
                    this._context.SaveChanges();
                    MessageBox.Show("New Breakfast Option Created\n\n" + breakfast.Name + 
                        "\n\n" + breakfast.Description + "\n\n" + breakfast.Calories + " calories");
                }
                else if (lunchRadioButton.Checked == true)
                {
                    Lunch lunch = new Lunch();
                    lunch.Description = description;
                    lunch.Calories = Convert.ToInt32(totalCaloriesLabel.Text);
                    lunch.Name = mealNameTextBox.Text;
                    _context.Lunches.Add(lunch);
                    this._context.SaveChanges();
                    MessageBox.Show("New Lunch Option Created\n\n" + lunch.Name + 
                        "\n\n" + lunch.Description + "\n\n" + lunch.Calories + " calories");
                }
                else if (dinnerRadioButton.Checked == true)
                {
                    Dinner dinner = new Dinner();
                    dinner.Description = description;
                    dinner.Calories = Convert.ToInt32(totalCaloriesLabel.Text);
                    dinner.Name = mealNameTextBox.Text;
                    _context.Dinners.Add(dinner);
                    this._context.SaveChanges();
                    MessageBox.Show("New Dinner Option Created\n\n" + dinner.Name + 
                        "\n\n" + dinner.Description + "\n\n" + dinner.Calories + " calories");
                }
                else if (snackRadioButton.Checked == true)
                {
                    Snack snack = new Snack();
                    snack.Description = description;
                    snack.Calories = Convert.ToInt32(totalCaloriesLabel.Text);
                    snack.Name = mealNameTextBox.Text;
                    _context.Snacks.Add(snack);
                    this._context.SaveChanges();
                    MessageBox.Show("New Snack Option Created\n\n" + snack.Name + 
                        "\n\n" + snack.Description + "\n\n" + snack.Calories + " calories");
                }

                mealNameTextBox.Clear();
                mealListBox.Items.Clear();
                calories = 0;
                totalCaloriesLabel.Text = calories.ToString();
            }
        }
    }
}
