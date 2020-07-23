using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DailyMealPlan;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DailyMealPlan
{
    public partial class CreateFoodForm : Form
    {
        DailyMealsEntities _context;
        public CreateFoodForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new DailyMealsEntities();

            _context.BreakfastItems.Load();
            this.breakfastItemDataGridView.DataSource =
                _context.BreakfastItems.Local.ToBindingList();

            _context.LunchItems.Load();
            this.lunchItemDataGridView.DataSource =
                _context.LunchItems.Local.ToBindingList();

            _context.DinnerItems.Load();
            this.dinnerItemDataGridView.DataSource =
                _context.DinnerItems.Local.ToBindingList();

            _context.SnackItems.Load();
            this.snackItemDataGridView.DataSource =
                _context.SnackItems.Local.ToBindingList();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool itemAdded = false;
                _context = new DailyMealsEntities();

                if ((breakfastCheckBox.CheckState == 0 && lunchCheckBox.CheckState == 0 &&
                    dinnerCheckBox.CheckState == 0 && snackCheckBox.CheckState == 0) ||
                    (foodItemTextBox.Text == "" || caloriesTextBox.Text == ""))
                {
                    MessageBox.Show("Complete input to allow submission");
                }
                else
                {
                    if (breakfastCheckBox.CheckState != 0)
                    {
                        BreakfastItem breakfastItem = new BreakfastItem();
                        breakfastItem.Name = foodItemTextBox.Text;
                        breakfastItem.Calories = Convert.ToInt32(caloriesTextBox.Text);
                        _context.BreakfastItems.Add(breakfastItem);
                        this._context.SaveChanges();
                        _context.BreakfastItems.Load();
                        this.breakfastItemDataGridView.DataSource =
                            _context.BreakfastItems.Local.ToBindingList();
                        itemAdded = true;
                        MessageBox.Show("Breakfast Item Added");
                    }

                    if (lunchCheckBox.CheckState != 0)
                    {
                        LunchItem lunchItem = new LunchItem();
                        lunchItem.Name = foodItemTextBox.Text;
                        lunchItem.Calories = Convert.ToInt32(caloriesTextBox.Text);
                        _context.LunchItems.Add(lunchItem);
                        this._context.SaveChanges();
                        _context.LunchItems.Load();
                        this.lunchItemDataGridView.DataSource =
                            _context.LunchItems.Local.ToBindingList();
                        itemAdded = true;
                        MessageBox.Show("Lunch Item Added");
                    }

                    if (dinnerCheckBox.CheckState != 0)
                    {
                        DinnerItem dinnerItem = new DinnerItem();
                        dinnerItem.Name = foodItemTextBox.Text;
                        dinnerItem.Calories = Convert.ToInt32(caloriesTextBox.Text);
                        _context.DinnerItems.Add(dinnerItem);
                        this._context.SaveChanges();
                        _context.DinnerItems.Load();
                        this.dinnerItemDataGridView.DataSource =
                            _context.DinnerItems.Local.ToBindingList();
                        itemAdded = true;
                        MessageBox.Show("Dinner Item Added");
                    }

                    if (snackCheckBox.CheckState != 0)
                    {
                        SnackItem snackItem = new SnackItem();
                        snackItem.Name = foodItemTextBox.Text;
                        snackItem.Calories = Convert.ToInt32(caloriesTextBox.Text);
                        _context.SnackItems.Add(snackItem);
                        this._context.SaveChanges();
                        _context.SnackItems.Load();
                        this.snackItemDataGridView.DataSource =
                            _context.SnackItems.Local.ToBindingList();
                        itemAdded = true;
                        MessageBox.Show("Snack Item Added");
                    }
                }
                if (itemAdded == true)
                {
                    foodItemTextBox.Clear();
                    caloriesTextBox.Clear();
                    breakfastCheckBox.Checked = false;
                    lunchCheckBox.Checked = false;
                    dinnerCheckBox.Checked = false;
                    snackCheckBox.Checked = false;
                }
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void CreateFoodForm_Load(object sender, EventArgs e)
        {

        }

        private void breakfastRemoveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _context = new DailyMealsEntities();

                //get selected row id
                int selectedrowindex = breakfastItemDataGridView.SelectedCells[0].RowIndex;
                BreakfastItem breakfastItem = new BreakfastItem();
                breakfastItem.BreakfastItemID = Convert.ToInt64(breakfastItemDataGridView.Rows[selectedrowindex].Cells["BreakfastItemID"].Value);
                //parse db list for row id - remove accordingly
                try
                {
                    foreach (var item in _context.BreakfastItems)
                    {
                        if (item.BreakfastItemID == breakfastItem.BreakfastItemID)
                        {
                            _context.BreakfastItems.Remove(item);
                            break;
                        }
                    }
                    this._context.SaveChanges();
                    _context.BreakfastItems.Load();
                    this.breakfastItemDataGridView.DataSource =
                        _context.BreakfastItems.Local.ToBindingList();
                    MessageBox.Show("Item deleted");
                }
                catch
                {
                    MessageBox.Show("Item not selected");
                }
            }
        }

        private void lunchRemoveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _context = new DailyMealsEntities();

                //get selected row id
                int selectedrowindex = lunchItemDataGridView.SelectedCells[0].RowIndex;
                LunchItem lunchItem = new LunchItem();
                lunchItem.LunchItemID = Convert.ToInt64(lunchItemDataGridView.Rows[selectedrowindex].Cells["LunchItemID"].Value);
                //parse db list for row id - remove accordingly
                try
                {
                    foreach (var item in _context.LunchItems)
                    {
                        if (item.LunchItemID == lunchItem.LunchItemID)
                        {
                            _context.LunchItems.Remove(item);
                            break;
                        }
                    }
                    this._context.SaveChanges();
                    _context.LunchItems.Load();
                    this.lunchItemDataGridView.DataSource =
                        _context.LunchItems.Local.ToBindingList();
                    MessageBox.Show("Item deleted");
                }
                catch
                {
                    MessageBox.Show("Item not selected");
                }
            }
        }

        private void dinnerRemoveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _context = new DailyMealsEntities();

                //get selected row id
                int selectedrowindex = dinnerItemDataGridView.SelectedCells[0].RowIndex;
                DinnerItem dinnerItem = new DinnerItem();
                dinnerItem.DinnerItemID = Convert.ToInt64(dinnerItemDataGridView.Rows[selectedrowindex].Cells["DinnerItemID"].Value);
                //parse db list for row id - remove accordingly
                try
                {
                    foreach (var item in _context.DinnerItems)
                    {
                        if (item.DinnerItemID == dinnerItem.DinnerItemID)
                        {
                            _context.DinnerItems.Remove(item);
                            break;
                        }
                    }
                    this._context.SaveChanges();
                    _context.DinnerItems.Load();
                    this.dinnerItemDataGridView.DataSource =
                        _context.DinnerItems.Local.ToBindingList();
                    MessageBox.Show("Item deleted");
                }
                catch
                {
                    MessageBox.Show("Item not selected");
                }
            }
        }

        private void snackRemoveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _context = new DailyMealsEntities();

                //get selected row id
                int selectedrowindex = snackItemDataGridView.SelectedCells[0].RowIndex;
                SnackItem snackItem = new SnackItem();
                snackItem.SnackItemID = Convert.ToInt64(snackItemDataGridView.Rows[selectedrowindex].Cells["SnackItemID"].Value);
                //parse db list for row id - remove accordingly
                try
                {
                    foreach (var item in _context.SnackItems)
                    {
                        if (item.SnackItemID == snackItem.SnackItemID)
                        {
                            _context.SnackItems.Remove(item);
                            break;
                        }
                    }
                    this._context.SaveChanges();
                    _context.SnackItems.Load();
                    this.snackItemDataGridView.DataSource =
                        _context.SnackItems.Local.ToBindingList();
                    MessageBox.Show("Item deleted");
                }
                catch
                {
                    MessageBox.Show("Item not selected");
                }
            }
        }
    }
}
