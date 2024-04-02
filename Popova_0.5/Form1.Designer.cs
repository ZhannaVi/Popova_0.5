namespace Popova_0._5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpLevel = new System.Windows.Forms.GroupBox();
            this.AdvancedLevel = new System.Windows.Forms.RadioButton();
            this.IntermediateLevel = new System.Windows.Forms.RadioButton();
            this.beginnerLevel = new System.Windows.Forms.RadioButton();
            this.btnGame = new System.Windows.Forms.Button();
            this.grpLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(32, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 630);
            this.panel1.TabIndex = 0;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.LightCyan;
            this.btnCheck.Location = new System.Drawing.Point(690, 60);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(223, 82);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check input";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PowderBlue;
            this.btnClear.Location = new System.Drawing.Point(734, 148);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 49);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear Input";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpLevel
            // 
            this.grpLevel.BackColor = System.Drawing.Color.LightBlue;
            this.grpLevel.Controls.Add(this.AdvancedLevel);
            this.grpLevel.Controls.Add(this.IntermediateLevel);
            this.grpLevel.Controls.Add(this.beginnerLevel);
            this.grpLevel.Location = new System.Drawing.Point(734, 203);
            this.grpLevel.Name = "grpLevel";
            this.grpLevel.Size = new System.Drawing.Size(142, 188);
            this.grpLevel.TabIndex = 2;
            this.grpLevel.TabStop = false;
            this.grpLevel.Text = "Level";
            // 
            // AdvancedLevel
            // 
            this.AdvancedLevel.AutoSize = true;
            this.AdvancedLevel.Location = new System.Drawing.Point(7, 145);
            this.AdvancedLevel.Name = "AdvancedLevel";
            this.AdvancedLevel.Size = new System.Drawing.Size(105, 24);
            this.AdvancedLevel.TabIndex = 0;
            this.AdvancedLevel.TabStop = true;
            this.AdvancedLevel.Text = "Advanced";
            this.AdvancedLevel.UseVisualStyleBackColor = true;
            // 
            // IntermediateLevel
            // 
            this.IntermediateLevel.AutoSize = true;
            this.IntermediateLevel.Location = new System.Drawing.Point(7, 103);
            this.IntermediateLevel.Name = "IntermediateLevel";
            this.IntermediateLevel.Size = new System.Drawing.Size(124, 24);
            this.IntermediateLevel.TabIndex = 0;
            this.IntermediateLevel.TabStop = true;
            this.IntermediateLevel.Text = "Intermediate";
            this.IntermediateLevel.UseVisualStyleBackColor = true;
            // 
            // beginnerLevel
            // 
            this.beginnerLevel.AutoSize = true;
            this.beginnerLevel.Location = new System.Drawing.Point(7, 61);
            this.beginnerLevel.Name = "beginnerLevel";
            this.beginnerLevel.Size = new System.Drawing.Size(96, 24);
            this.beginnerLevel.TabIndex = 0;
            this.beginnerLevel.TabStop = true;
            this.beginnerLevel.Text = "beginner";
            this.beginnerLevel.UseVisualStyleBackColor = true;
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGame.Location = new System.Drawing.Point(734, 419);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(142, 49);
            this.btnGame.TabIndex = 1;
            this.btnGame.Text = "New game";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 795);
            this.Controls.Add(this.grpLevel);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "sudoku";
            this.grpLevel.ResumeLayout(false);
            this.grpLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpLevel;
        private System.Windows.Forms.RadioButton AdvancedLevel;
        private System.Windows.Forms.RadioButton IntermediateLevel;
        private System.Windows.Forms.RadioButton beginnerLevel;
        private System.Windows.Forms.Button btnGame;
    }
}

