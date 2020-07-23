namespace DailyMealPlan
{
    partial class CreateMealForm
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
            this.breakfastRadioButton = new System.Windows.Forms.RadioButton();
            this.lunchRadioButton = new System.Windows.Forms.RadioButton();
            this.dinnerRadioButton = new System.Windows.Forms.RadioButton();
            this.snackRadioButton = new System.Windows.Forms.RadioButton();
            this.optionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dgvLabel = new System.Windows.Forms.Label();
            this.mealListBox = new System.Windows.Forms.ListBox();
            this.createButton = new System.Windows.Forms.Button();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.totalCaloriesLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.mealNameTextBox = new System.Windows.Forms.TextBox();
            this.mealNameLabel = new System.Windows.Forms.Label();
            this.breakfastItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.optionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Create New Meal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "What Meal Is This For?";
            // 
            // breakfastRadioButton
            // 
            this.breakfastRadioButton.AutoSize = true;
            this.breakfastRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakfastRadioButton.Location = new System.Drawing.Point(97, 130);
            this.breakfastRadioButton.Name = "breakfastRadioButton";
            this.breakfastRadioButton.Size = new System.Drawing.Size(83, 20);
            this.breakfastRadioButton.TabIndex = 23;
            this.breakfastRadioButton.TabStop = true;
            this.breakfastRadioButton.Text = "Breakfast";
            this.breakfastRadioButton.UseVisualStyleBackColor = true;
            this.breakfastRadioButton.CheckedChanged += new System.EventHandler(this.breakfastRadioButton_CheckedChanged);
            // 
            // lunchRadioButton
            // 
            this.lunchRadioButton.AutoSize = true;
            this.lunchRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchRadioButton.Location = new System.Drawing.Point(97, 168);
            this.lunchRadioButton.Name = "lunchRadioButton";
            this.lunchRadioButton.Size = new System.Drawing.Size(61, 20);
            this.lunchRadioButton.TabIndex = 24;
            this.lunchRadioButton.TabStop = true;
            this.lunchRadioButton.Text = "Lunch";
            this.lunchRadioButton.UseVisualStyleBackColor = true;
            this.lunchRadioButton.CheckedChanged += new System.EventHandler(this.lunchRadioButton_CheckedChanged);
            // 
            // dinnerRadioButton
            // 
            this.dinnerRadioButton.AutoSize = true;
            this.dinnerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinnerRadioButton.Location = new System.Drawing.Point(97, 207);
            this.dinnerRadioButton.Name = "dinnerRadioButton";
            this.dinnerRadioButton.Size = new System.Drawing.Size(65, 20);
            this.dinnerRadioButton.TabIndex = 25;
            this.dinnerRadioButton.TabStop = true;
            this.dinnerRadioButton.Text = "Dinner";
            this.dinnerRadioButton.UseVisualStyleBackColor = true;
            this.dinnerRadioButton.CheckedChanged += new System.EventHandler(this.dinnerRadioButton_CheckedChanged);
            // 
            // snackRadioButton
            // 
            this.snackRadioButton.AutoSize = true;
            this.snackRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snackRadioButton.Location = new System.Drawing.Point(97, 246);
            this.snackRadioButton.Name = "snackRadioButton";
            this.snackRadioButton.Size = new System.Drawing.Size(64, 20);
            this.snackRadioButton.TabIndex = 26;
            this.snackRadioButton.TabStop = true;
            this.snackRadioButton.Text = "Snack";
            this.snackRadioButton.UseVisualStyleBackColor = true;
            this.snackRadioButton.CheckedChanged += new System.EventHandler(this.snackRadioButton_CheckedChanged);
            // 
            // optionsDataGridView
            // 
            this.optionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.optionsDataGridView.Location = new System.Drawing.Point(278, 130);
            this.optionsDataGridView.Name = "optionsDataGridView";
            this.optionsDataGridView.Size = new System.Drawing.Size(240, 150);
            this.optionsDataGridView.TabIndex = 28;
            this.optionsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.optionsDataGridView_CellContentClick);
            this.optionsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.optionsDataGridView_CellDoubleClick);
            // 
            // dgvLabel
            // 
            this.dgvLabel.AutoSize = true;
            this.dgvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLabel.Location = new System.Drawing.Point(275, 111);
            this.dgvLabel.Name = "dgvLabel";
            this.dgvLabel.Size = new System.Drawing.Size(45, 16);
            this.dgvLabel.TabIndex = 29;
            this.dgvLabel.Text = "label3";
            // 
            // mealListBox
            // 
            this.mealListBox.FormattingEnabled = true;
            this.mealListBox.Location = new System.Drawing.Point(278, 343);
            this.mealListBox.Name = "mealListBox";
            this.mealListBox.Size = new System.Drawing.Size(240, 95);
            this.mealListBox.TabIndex = 30;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(524, 349);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 32;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesLabel.Location = new System.Drawing.Point(45, 343);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(101, 16);
            this.caloriesLabel.TabIndex = 33;
            this.caloriesLabel.Text = "Total Calories : ";
            // 
            // totalCaloriesLabel
            // 
            this.totalCaloriesLabel.AutoSize = true;
            this.totalCaloriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCaloriesLabel.Location = new System.Drawing.Point(152, 346);
            this.totalCaloriesLabel.Name = "totalCaloriesLabel";
            this.totalCaloriesLabel.Size = new System.Drawing.Size(15, 16);
            this.totalCaloriesLabel.TabIndex = 34;
            this.totalCaloriesLabel.Text = "0";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(524, 378);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 35;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(524, 407);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 36;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // mealNameTextBox
            // 
            this.mealNameTextBox.Location = new System.Drawing.Point(355, 317);
            this.mealNameTextBox.Name = "mealNameTextBox";
            this.mealNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.mealNameTextBox.TabIndex = 37;
            // 
            // mealNameLabel
            // 
            this.mealNameLabel.AutoSize = true;
            this.mealNameLabel.Location = new System.Drawing.Point(275, 320);
            this.mealNameLabel.Name = "mealNameLabel";
            this.mealNameLabel.Size = new System.Drawing.Size(70, 13);
            this.mealNameLabel.TabIndex = 38;
            this.mealNameLabel.Text = "Meal Name  -";
            // 
            // breakfastItemBindingSource
            // 
            this.breakfastItemBindingSource.DataSource = typeof(DailyMealPlan.BreakfastItem);
            // 
            // CreateMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mealNameLabel);
            this.Controls.Add(this.mealNameTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.totalCaloriesLabel);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.mealListBox);
            this.Controls.Add(this.dgvLabel);
            this.Controls.Add(this.optionsDataGridView);
            this.Controls.Add(this.snackRadioButton);
            this.Controls.Add(this.dinnerRadioButton);
            this.Controls.Add(this.lunchRadioButton);
            this.Controls.Add(this.breakfastRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "CreateMealForm";
            this.Text = "Create Meal";
            ((System.ComponentModel.ISupportInitialize)(this.optionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton breakfastRadioButton;
        private System.Windows.Forms.RadioButton lunchRadioButton;
        private System.Windows.Forms.RadioButton dinnerRadioButton;
        private System.Windows.Forms.RadioButton snackRadioButton;
        private System.Windows.Forms.BindingSource breakfastItemBindingSource;
        private System.Windows.Forms.DataGridView optionsDataGridView;
        private System.Windows.Forms.Label dgvLabel;
        private System.Windows.Forms.ListBox mealListBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Label totalCaloriesLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox mealNameTextBox;
        private System.Windows.Forms.Label mealNameLabel;
    }
}