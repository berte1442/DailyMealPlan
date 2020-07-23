namespace DailyMealPlan
{
    partial class ViewMealPlanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.breakfastDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunchDataGridView = new System.Windows.Forms.DataGridView();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calories2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinnerDataGridView = new System.Windows.Forms.DataGridView();
            this.ID3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calories3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snackDataGridView = new System.Windows.Forms.DataGridView();
            this.ID4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calories4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalCalsLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.createMealPlanButton = new System.Windows.Forms.Button();
            this.mealOptionsButton = new System.Windows.Forms.Button();
            this.createFoodOptionsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snackDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(401, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Date to View Meal Plan";
            // 
            // breakfastDataGridView
            // 
            this.breakfastDataGridView.AllowUserToAddRows = false;
            this.breakfastDataGridView.AllowUserToDeleteRows = false;
            this.breakfastDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.breakfastDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Calories,
            this.Description});
            this.breakfastDataGridView.Location = new System.Drawing.Point(12, 201);
            this.breakfastDataGridView.Name = "breakfastDataGridView";
            this.breakfastDataGridView.ReadOnly = true;
            this.breakfastDataGridView.Size = new System.Drawing.Size(240, 150);
            this.breakfastDataGridView.TabIndex = 2;
            this.breakfastDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.breakfastDataGridView_CellContentDoubleClick);
            this.breakfastDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.breakfastDataGridView_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Calories
            // 
            this.Calories.HeaderText = "Calories";
            this.Calories.Name = "Calories";
            this.Calories.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // lunchDataGridView
            // 
            this.lunchDataGridView.AllowUserToAddRows = false;
            this.lunchDataGridView.AllowUserToDeleteRows = false;
            this.lunchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lunchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2,
            this.Name2,
            this.Calories2,
            this.Description2});
            this.lunchDataGridView.Location = new System.Drawing.Point(258, 201);
            this.lunchDataGridView.Name = "lunchDataGridView";
            this.lunchDataGridView.Size = new System.Drawing.Size(240, 150);
            this.lunchDataGridView.TabIndex = 3;
            this.lunchDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lunchDataGridView_CellDoubleClick);
            // 
            // ID2
            // 
            this.ID2.HeaderText = "ID";
            this.ID2.Name = "ID2";
            this.ID2.ReadOnly = true;
            this.ID2.Visible = false;
            // 
            // Name2
            // 
            this.Name2.HeaderText = "Name";
            this.Name2.Name = "Name2";
            this.Name2.ReadOnly = true;
            // 
            // Calories2
            // 
            this.Calories2.HeaderText = "Calories";
            this.Calories2.Name = "Calories2";
            this.Calories2.ReadOnly = true;
            // 
            // Description2
            // 
            this.Description2.HeaderText = "Description";
            this.Description2.Name = "Description2";
            this.Description2.ReadOnly = true;
            // 
            // dinnerDataGridView
            // 
            this.dinnerDataGridView.AllowUserToAddRows = false;
            this.dinnerDataGridView.AllowUserToDeleteRows = false;
            this.dinnerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dinnerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID3,
            this.Name3,
            this.Calories3,
            this.Description3});
            this.dinnerDataGridView.Location = new System.Drawing.Point(504, 201);
            this.dinnerDataGridView.Name = "dinnerDataGridView";
            this.dinnerDataGridView.Size = new System.Drawing.Size(240, 150);
            this.dinnerDataGridView.TabIndex = 4;
            this.dinnerDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dinnerDataGridView_CellDoubleClick);
            // 
            // ID3
            // 
            this.ID3.HeaderText = "ID";
            this.ID3.Name = "ID3";
            this.ID3.ReadOnly = true;
            this.ID3.Visible = false;
            // 
            // Name3
            // 
            this.Name3.HeaderText = "Name";
            this.Name3.Name = "Name3";
            this.Name3.ReadOnly = true;
            // 
            // Calories3
            // 
            this.Calories3.HeaderText = "Calories";
            this.Calories3.Name = "Calories3";
            this.Calories3.ReadOnly = true;
            // 
            // Description3
            // 
            this.Description3.HeaderText = "Description";
            this.Description3.Name = "Description3";
            this.Description3.ReadOnly = true;
            // 
            // snackDataGridView
            // 
            this.snackDataGridView.AllowUserToAddRows = false;
            this.snackDataGridView.AllowUserToDeleteRows = false;
            this.snackDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.snackDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID4,
            this.Name4,
            this.Calories4,
            this.Description4});
            this.snackDataGridView.Location = new System.Drawing.Point(750, 201);
            this.snackDataGridView.Name = "snackDataGridView";
            this.snackDataGridView.Size = new System.Drawing.Size(240, 150);
            this.snackDataGridView.TabIndex = 5;
            this.snackDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.snackDataGridView_CellDoubleClick);
            // 
            // ID4
            // 
            this.ID4.HeaderText = "ID";
            this.ID4.Name = "ID4";
            this.ID4.ReadOnly = true;
            this.ID4.Visible = false;
            // 
            // Name4
            // 
            this.Name4.HeaderText = "Name";
            this.Name4.Name = "Name4";
            this.Name4.ReadOnly = true;
            // 
            // Calories4
            // 
            this.Calories4.HeaderText = "Calories";
            this.Calories4.Name = "Calories4";
            this.Calories4.ReadOnly = true;
            // 
            // Description4
            // 
            this.Description4.HeaderText = "Description";
            this.Description4.Name = "Description4";
            this.Description4.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Breakfast";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lunch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dinner";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(746, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Snacks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Calories: ";
            // 
            // totalCalsLabel
            // 
            this.totalCalsLabel.AutoSize = true;
            this.totalCalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCalsLabel.Location = new System.Drawing.Point(131, 120);
            this.totalCalsLabel.Name = "totalCalsLabel";
            this.totalCalsLabel.Size = new System.Drawing.Size(18, 20);
            this.totalCalsLabel.TabIndex = 11;
            this.totalCalsLabel.Text = "0";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(750, 390);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(149, 86);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete This Daily Meal Plan";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // createMealPlanButton
            // 
            this.createMealPlanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMealPlanButton.Location = new System.Drawing.Point(504, 390);
            this.createMealPlanButton.Name = "createMealPlanButton";
            this.createMealPlanButton.Size = new System.Drawing.Size(149, 86);
            this.createMealPlanButton.TabIndex = 13;
            this.createMealPlanButton.Text = "Create New Meal Plan";
            this.createMealPlanButton.UseVisualStyleBackColor = true;
            this.createMealPlanButton.Click += new System.EventHandler(this.createMealPlanButton_Click);
            // 
            // mealOptionsButton
            // 
            this.mealOptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealOptionsButton.Location = new System.Drawing.Point(258, 390);
            this.mealOptionsButton.Name = "mealOptionsButton";
            this.mealOptionsButton.Size = new System.Drawing.Size(149, 86);
            this.mealOptionsButton.TabIndex = 14;
            this.mealOptionsButton.Text = "Create New Meal Options";
            this.mealOptionsButton.UseVisualStyleBackColor = true;
            this.mealOptionsButton.Click += new System.EventHandler(this.mealOptionsButton_Click);
            // 
            // createFoodOptionsButton
            // 
            this.createFoodOptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFoodOptionsButton.Location = new System.Drawing.Point(12, 390);
            this.createFoodOptionsButton.Name = "createFoodOptionsButton";
            this.createFoodOptionsButton.Size = new System.Drawing.Size(149, 86);
            this.createFoodOptionsButton.TabIndex = 15;
            this.createFoodOptionsButton.Text = "Create New Food Options";
            this.createFoodOptionsButton.UseVisualStyleBackColor = true;
            this.createFoodOptionsButton.Click += new System.EventHandler(this.createFoodOptionsButton_Click);
            // 
            // ViewMealPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 507);
            this.Controls.Add(this.createFoodOptionsButton);
            this.Controls.Add(this.mealOptionsButton);
            this.Controls.Add(this.createMealPlanButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.totalCalsLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.snackDataGridView);
            this.Controls.Add(this.dinnerDataGridView);
            this.Controls.Add(this.lunchDataGridView);
            this.Controls.Add(this.breakfastDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            //this.Name = "ViewMealPlanForm";
            this.Text = "View Meal Plan";
            this.Load += new System.EventHandler(this.ViewMealPlanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.breakfastDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snackDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView breakfastDataGridView;
        private System.Windows.Forms.DataGridView lunchDataGridView;
        private System.Windows.Forms.DataGridView dinnerDataGridView;
        private System.Windows.Forms.DataGridView snackDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calories2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calories3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calories4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalCalsLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button createMealPlanButton;
        private System.Windows.Forms.Button mealOptionsButton;
        private System.Windows.Forms.Button createFoodOptionsButton;
    }
}