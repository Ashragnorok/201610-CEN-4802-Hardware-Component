namespace Sark___Hardware_Component
{
    partial class UserInterface
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnGroundFloor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbxConsole = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblElevatorName = new System.Windows.Forms.Label();
            this.pbarTimeToComplete = new System.Windows.Forms.ProgressBar();
            this.cbxElevatorFloor = new System.Windows.Forms.ComboBox();
            this.btnElevatorFloor = new System.Windows.Forms.Button();
            this.lblActionProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Service Toggle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnGroundFloor
            // 
            this.btnGroundFloor.Location = new System.Drawing.Point(268, 74);
            this.btnGroundFloor.Name = "btnGroundFloor";
            this.btnGroundFloor.Size = new System.Drawing.Size(121, 42);
            this.btnGroundFloor.TabIndex = 1;
            this.btnGroundFloor.Text = "Go To Ground Floor";
            this.btnGroundFloor.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(535, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbxConsole
            // 
            this.tbxConsole.Location = new System.Drawing.Point(12, 44);
            this.tbxConsole.Multiline = true;
            this.tbxConsole.Name = "tbxConsole";
            this.tbxConsole.Size = new System.Drawing.Size(250, 150);
            this.tbxConsole.TabIndex = 3;
            this.tbxConsole.Text = "the Elevator class output should be \r\nprinted here for debugging";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblElevatorName
            // 
            this.lblElevatorName.AutoSize = true;
            this.lblElevatorName.Location = new System.Drawing.Point(12, 24);
            this.lblElevatorName.Name = "lblElevatorName";
            this.lblElevatorName.Size = new System.Drawing.Size(252, 17);
            this.lblElevatorName.TabIndex = 5;
            this.lblElevatorName.Text = "[placeholderinsert elevator name here]";
            // 
            // pbarTimeToComplete
            // 
            this.pbarTimeToComplete.Location = new System.Drawing.Point(268, 171);
            this.pbarTimeToComplete.Name = "pbarTimeToComplete";
            this.pbarTimeToComplete.Size = new System.Drawing.Size(121, 23);
            this.pbarTimeToComplete.TabIndex = 6;
            // 
            // cbxElevatorFloor
            // 
            this.cbxElevatorFloor.FormattingEnabled = true;
            this.cbxElevatorFloor.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cbxElevatorFloor.Location = new System.Drawing.Point(268, 44);
            this.cbxElevatorFloor.Name = "cbxElevatorFloor";
            this.cbxElevatorFloor.Size = new System.Drawing.Size(121, 24);
            this.cbxElevatorFloor.TabIndex = 7;
            // 
            // btnElevatorFloor
            // 
            this.btnElevatorFloor.Location = new System.Drawing.Point(405, 44);
            this.btnElevatorFloor.Name = "btnElevatorFloor";
            this.btnElevatorFloor.Size = new System.Drawing.Size(120, 23);
            this.btnElevatorFloor.TabIndex = 8;
            this.btnElevatorFloor.Text = "Go To Floor";
            this.btnElevatorFloor.UseVisualStyleBackColor = true;
            // 
            // lblActionProgress
            // 
            this.lblActionProgress.AutoSize = true;
            this.lblActionProgress.Location = new System.Drawing.Point(269, 148);
            this.lblActionProgress.Name = "lblActionProgress";
            this.lblActionProgress.Size = new System.Drawing.Size(108, 17);
            this.lblActionProgress.TabIndex = 9;
            this.lblActionProgress.Text = "Action Progress";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 273);
            this.Controls.Add(this.lblActionProgress);
            this.Controls.Add(this.btnElevatorFloor);
            this.Controls.Add(this.cbxElevatorFloor);
            this.Controls.Add(this.pbarTimeToComplete);
            this.Controls.Add(this.lblElevatorName);
            this.Controls.Add(this.tbxConsole);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGroundFloor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserInterface";
            this.Text = "Elevator Class Test";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGroundFloor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbxConsole;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblElevatorName;
        private System.Windows.Forms.ProgressBar pbarTimeToComplete;
        private System.Windows.Forms.ComboBox cbxElevatorFloor;
        private System.Windows.Forms.Button btnElevatorFloor;
        private System.Windows.Forms.Label lblActionProgress;
    }
}