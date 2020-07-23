namespace DailyMealPlan
{
    partial class CreateFoodForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.breakfastCheckBox = new System.Windows.Forms.CheckBox();
            this.lunchCheckBox = new System.Windows.Forms.CheckBox();
            this.dinnerCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.foodItemTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.caloriesTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.breakfastItemDataGridView = new System.Windows.Forms.DataGridView();
            this.lunchItemDataGridView = new System.Windows.Forms.DataGridView();
            this.dinnerItemDataGridView = new System.Windows.Forms.DataGridView();
            this.snackItemDataGridView = new System.Windows.Forms.DataGridView();
            this.snackCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.breakfastRemoveButton = new System.Windows.Forms.Button();
            this.lunchRemoveButton = new System.Windows.Forms.Button();
            this.dinnerRemoveButton = new System.Windows.Forms.Button();
            this.snackRemoveButton = new System.Windows.Forms.Button();
            this.BreakfastItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LunchItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DinnerItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SnackItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snackItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinnerItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunchItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakfastItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.breakfastItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snackItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snackItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New Food Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "What Meal Is This For?";
            // 
            // breakfastCheckBox
            // 
            this.breakfastCheckBox.AutoSize = true;
            this.breakfastCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakfastCheckBox.Location = new System.Drawing.Point(314, 147);
            this.breakfastCheckBox.Name = "breakfastCheckBox";
            this.breakfastCheckBox.Size = new System.Drawing.Size(84, 20);
            this.breakfastCheckBox.TabIndex = 2;
            this.breakfastCheckBox.Text = "Breakfast";
            this.breakfastCheckBox.UseVisualStyleBackColor = true;
            // 
            // lunchCheckBox
            // 
            this.lunchCheckBox.AutoSize = true;
            this.lunchCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchCheckBox.Location = new System.Drawing.Point(314, 173);
            this.lunchCheckBox.Name = "lunchCheckBox";
            this.lunchCheckBox.Size = new System.Drawing.Size(62, 20);
            this.lunchCheckBox.TabIndex = 3;
            this.lunchCheckBox.Text = "Lunch";
            this.lunchCheckBox.UseVisualStyleBackColor = true;
            // 
            // dinnerCheckBox
            // 
            this.dinnerCheckBox.AutoSize = true;
            this.dinnerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinnerCheckBox.Location = new System.Drawing.Point(314, 199);
            this.dinnerCheckBox.Name = "dinnerCheckBox";
            this.dinnerCheckBox.Size = new System.Drawing.Size(66, 20);
            this.dinnerCheckBox.TabIndex = 4;
            this.dinnerCheckBox.Text = "Dinner";
            this.dinnerCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Food Item ";
            // 
            // foodItemTextBox
            // 
            this.foodItemTextBox.Location = new System.Drawing.Point(550, 143);
            this.foodItemTextBox.Name = "foodItemTextBox";
            this.foodItemTextBox.Size = new System.Drawing.Size(123, 20);
            this.foodItemTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Item";
            // 
            // caloriesTextBox
            // 
            this.caloriesTextBox.Location = new System.Drawing.Point(573, 185);
            this.caloriesTextBox.Name = "caloriesTextBox";
            this.caloriesTextBox.Size = new System.Drawing.Size(100, 20);
            this.caloriesTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Calories";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(553, 225);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(120, 33);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // breakfastItemDataGridView
            // 
            this.breakfastItemDataGridView.AutoGenerateColumns = false;
            this.breakfastItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.breakfastItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BreakfastItemID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.breakfastItemDataGridView.DataSource = this.breakfastItemBindingSource;
            this.breakfastItemDataGridView.Location = new System.Drawing.Point(6, 315);
            this.breakfastItemDataGridView.Name = "breakfastItemDataGridView";
            this.breakfastItemDataGridView.Size = new System.Drawing.Size(244, 220);
            this.breakfastItemDataGridView.TabIndex = 12;
            // 
            // lunchItemDataGridView
            // 
            this.lunchItemDataGridView.AutoGenerateColumns = false;
            this.lunchItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lunchItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LunchItemID,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.lunchItemDataGridView.DataSource = this.lunchItemBindingSource;
            this.lunchItemDataGridView.Location = new System.Drawing.Point(256, 315);
            this.lunchItemDataGridView.Name = "lunchItemDataGridView";
            this.lunchItemDataGridView.Size = new System.Drawing.Size(244, 220);
            this.lunchItemDataGridView.TabIndex = 13;
            // 
            // dinnerItemDataGridView
            // 
            this.dinnerItemDataGridView.AutoGenerateColumns = false;
            this.dinnerItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dinnerItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DinnerItemID,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dinnerItemDataGridView.DataSource = this.dinnerItemBindingSource;
            this.dinnerItemDataGridView.Location = new System.Drawing.Point(506, 315);
            this.dinnerItemDataGridView.Name = "dinnerItemDataGridView";
            this.dinnerItemDataGridView.Size = new System.Drawing.Size(244, 220);
            this.dinnerItemDataGridView.TabIndex = 14;
            // 
            // snackItemDataGridView
            // 
            this.snackItemDataGridView.AutoGenerateColumns = false;
            this.snackItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.snackItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SnackItemID,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.snackItemDataGridView.DataSource = this.snackItemBindingSource;
            this.snackItemDataGridView.Location = new System.Drawing.Point(756, 315);
            this.snackItemDataGridView.Name = "snackItemDataGridView";
            this.snackItemDataGridView.Size = new System.Drawing.Size(243, 220);
            this.snackItemDataGridView.TabIndex = 15;
            // 
            // snackCheckBox
            // 
            this.snackCheckBox.AutoSize = true;
            this.snackCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snackCheckBox.Location = new System.Drawing.Point(314, 225);
            this.snackCheckBox.Name = "snackCheckBox";
            this.snackCheckBox.Size = new System.Drawing.Size(65, 20);
            this.snackCheckBox.TabIndex = 16;
            this.snackCheckBox.Text = "Snack";
            this.snackCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Breakfast Items";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Lunch Items";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(573, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Dinner Items";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(836, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Snack Items";
            // 
            // breakfastRemoveButton
            // 
            this.breakfastRemoveButton.Location = new System.Drawing.Point(6, 541);
            this.breakfastRemoveButton.Name = "breakfastRemoveButton";
            this.breakfastRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.breakfastRemoveButton.TabIndex = 21;
            this.breakfastRemoveButton.Text = "Remove";
            this.breakfastRemoveButton.UseVisualStyleBackColor = true;
            this.breakfastRemoveButton.Click += new System.EventHandler(this.breakfastRemoveButton_Click);
            // 
            // lunchRemoveButton
            // 
            this.lunchRemoveButton.Location = new System.Drawing.Point(256, 541);
            this.lunchRemoveButton.Name = "lunchRemoveButton";
            this.lunchRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.lunchRemoveButton.TabIndex = 22;
            this.lunchRemoveButton.Text = "Remove";
            this.lunchRemoveButton.UseVisualStyleBackColor = true;
            this.lunchRemoveButton.Click += new System.EventHandler(this.lunchRemoveButton_Click);
            // 
            // dinnerRemoveButton
            // 
            this.dinnerRemoveButton.Location = new System.Drawing.Point(506, 541);
            this.dinnerRemoveButton.Name = "dinnerRemoveButton";
            this.dinnerRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.dinnerRemoveButton.TabIndex = 23;
            this.dinnerRemoveButton.Text = "Remove";
            this.dinnerRemoveButton.UseVisualStyleBackColor = true;
            this.dinnerRemoveButton.Click += new System.EventHandler(this.dinnerRemoveButton_Click);
            // 
            // snackRemoveButton
            // 
            this.snackRemoveButton.Location = new System.Drawing.Point(756, 541);
            this.snackRemoveButton.Name = "snackRemoveButton";
            this.snackRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.snackRemoveButton.TabIndex = 24;
            this.snackRemoveButton.Text = "Remove";
            this.snackRemoveButton.UseVisualStyleBackColor = true;
            this.snackRemoveButton.Click += new System.EventHandler(this.snackRemoveButton_Click);
            // 
            // BreakfastItemID
            // 
            this.BreakfastItemID.DataPropertyName = "BreakfastItemID";
            this.BreakfastItemID.HeaderText = "BreakfastItemID";
            this.BreakfastItemID.Name = "BreakfastItemID";
            this.BreakfastItemID.Visible = false;
            // 
            // LunchItemID
            // 
            this.LunchItemID.DataPropertyName = "LunchItemID";
            this.LunchItemID.HeaderText = "LunchItemID";
            this.LunchItemID.Name = "LunchItemID";
            this.LunchItemID.Visible = false;
            // 
            // DinnerItemID
            // 
            this.DinnerItemID.DataPropertyName = "DinnerItemID";
            this.DinnerItemID.HeaderText = "DinnerItemID";
            this.DinnerItemID.Name = "DinnerItemID";
            this.DinnerItemID.Visible = false;
            // 
            // SnackItemID
            // 
            this.SnackItemID.DataPropertyName = "SnackItemID";
            this.SnackItemID.HeaderText = "SnackItemID";
            this.SnackItemID.Name = "SnackItemID";
            this.SnackItemID.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Calories";
            this.dataGridViewTextBoxColumn9.HeaderText = "Calories";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // snackItemBindingSource
            // 
            this.snackItemBindingSource.DataSource = typeof(DailyMealPlan.SnackItem);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Calories";
            this.dataGridViewTextBoxColumn7.HeaderText = "Calories";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dinnerItemBindingSource
            // 
            this.dinnerItemBindingSource.DataSource = typeof(DailyMealPlan.DinnerItem);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Calories";
            this.dataGridViewTextBoxColumn5.HeaderText = "Calories";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // lunchItemBindingSource
            // 
            this.lunchItemBindingSource.DataSource = typeof(DailyMealPlan.LunchItem);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Calories";
            this.dataGridViewTextBoxColumn3.HeaderText = "Calories";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // breakfastItemBindingSource
            // 
            this.breakfastItemBindingSource.DataSource = typeof(DailyMealPlan.BreakfastItem);
            // 
            // CreateFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 632);
            this.Controls.Add(this.snackRemoveButton);
            this.Controls.Add(this.dinnerRemoveButton);
            this.Controls.Add(this.lunchRemoveButton);
            this.Controls.Add(this.breakfastRemoveButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.snackCheckBox);
            this.Controls.Add(this.snackItemDataGridView);
            this.Controls.Add(this.dinnerItemDataGridView);
            this.Controls.Add(this.lunchItemDataGridView);
            this.Controls.Add(this.breakfastItemDataGridView);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.caloriesTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.foodItemTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dinnerCheckBox);
            this.Controls.Add(this.lunchCheckBox);
            this.Controls.Add(this.breakfastCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateFoodForm";
            this.Text = "Create Food Form";
            this.Load += new System.EventHandler(this.CreateFoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.breakfastItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snackItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snackItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox breakfastCheckBox;
        private System.Windows.Forms.CheckBox lunchCheckBox;
        private System.Windows.Forms.CheckBox dinnerCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox foodItemTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox caloriesTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.BindingSource breakfastItemBindingSource;
        private System.Windows.Forms.DataGridView breakfastItemDataGridView;
        private System.Windows.Forms.BindingSource lunchItemBindingSource;
        private System.Windows.Forms.DataGridView lunchItemDataGridView;
        private System.Windows.Forms.BindingSource dinnerItemBindingSource;
        private System.Windows.Forms.DataGridView dinnerItemDataGridView;
        private System.Windows.Forms.BindingSource snackItemBindingSource;
        private System.Windows.Forms.DataGridView snackItemDataGridView;
        private System.Windows.Forms.CheckBox snackCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button breakfastRemoveButton;
        private System.Windows.Forms.Button lunchRemoveButton;
        private System.Windows.Forms.Button dinnerRemoveButton;
        private System.Windows.Forms.Button snackRemoveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn BreakfastItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn LunchItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DinnerItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnackItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}