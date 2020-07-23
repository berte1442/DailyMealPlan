namespace DailyMealPlan
{
    partial class HomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.createFoodItemButton = new System.Windows.Forms.Button();
            this.createMealButton = new System.Windows.Forms.Button();
            this.logMealButton = new System.Windows.Forms.Button();
            this.viewMealPlanButton = new System.Windows.Forms.Button();
            this.createMealPlanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Action";
            // 
            // createFoodItemButton
            // 
            this.createFoodItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFoodItemButton.Location = new System.Drawing.Point(71, 75);
            this.createFoodItemButton.Name = "createFoodItemButton";
            this.createFoodItemButton.Size = new System.Drawing.Size(232, 52);
            this.createFoodItemButton.TabIndex = 1;
            this.createFoodItemButton.Text = "Create Food Item";
            this.createFoodItemButton.UseVisualStyleBackColor = true;
            this.createFoodItemButton.Click += new System.EventHandler(this.createFoodItemButton_Click);
            // 
            // createMealButton
            // 
            this.createMealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMealButton.Location = new System.Drawing.Point(71, 148);
            this.createMealButton.Name = "createMealButton";
            this.createMealButton.Size = new System.Drawing.Size(232, 52);
            this.createMealButton.TabIndex = 2;
            this.createMealButton.Text = "Create Meal Option";
            this.createMealButton.UseVisualStyleBackColor = true;
            this.createMealButton.Click += new System.EventHandler(this.createMealButton_Click);
            // 
            // logMealButton
            // 
            this.logMealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logMealButton.Location = new System.Drawing.Point(71, 373);
            this.logMealButton.Name = "logMealButton";
            this.logMealButton.Size = new System.Drawing.Size(232, 52);
            this.logMealButton.TabIndex = 4;
            this.logMealButton.Text = "Log Food ";
            this.logMealButton.UseVisualStyleBackColor = true;
            this.logMealButton.Click += new System.EventHandler(this.logMealButton_Click);
            // 
            // viewMealPlanButton
            // 
            this.viewMealPlanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMealPlanButton.Location = new System.Drawing.Point(71, 300);
            this.viewMealPlanButton.Name = "viewMealPlanButton";
            this.viewMealPlanButton.Size = new System.Drawing.Size(232, 52);
            this.viewMealPlanButton.TabIndex = 3;
            this.viewMealPlanButton.Text = "View Meal Plan";
            this.viewMealPlanButton.UseVisualStyleBackColor = true;
            this.viewMealPlanButton.Click += new System.EventHandler(this.viewMealPlanButton_Click);
            // 
            // createMealPlanButton
            // 
            this.createMealPlanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMealPlanButton.Location = new System.Drawing.Point(71, 224);
            this.createMealPlanButton.Name = "createMealPlanButton";
            this.createMealPlanButton.Size = new System.Drawing.Size(232, 52);
            this.createMealPlanButton.TabIndex = 5;
            this.createMealPlanButton.Text = "Create Meal Plan";
            this.createMealPlanButton.UseVisualStyleBackColor = true;
            this.createMealPlanButton.Click += new System.EventHandler(this.createMealPlanButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.createMealPlanButton);
            this.Controls.Add(this.logMealButton);
            this.Controls.Add(this.viewMealPlanButton);
            this.Controls.Add(this.createMealButton);
            this.Controls.Add(this.createFoodItemButton);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createFoodItemButton;
        private System.Windows.Forms.Button createMealButton;
        private System.Windows.Forms.Button logMealButton;
        private System.Windows.Forms.Button viewMealPlanButton;
        private System.Windows.Forms.Button createMealPlanButton;
    }
}