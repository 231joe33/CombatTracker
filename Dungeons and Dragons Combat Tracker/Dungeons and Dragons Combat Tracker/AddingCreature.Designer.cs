namespace Dungeons_and_Dragons_Combat_Tracker
{
    partial class AddingCreature
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
            this.addButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.raceTextBox = new System.Windows.Forms.TextBox();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.healthOption1 = new System.Windows.Forms.RadioButton();
            this.healthOption2 = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.noClassCheckBox = new System.Windows.Forms.CheckBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.fixedHealthTextBox = new System.Windows.Forms.TextBox();
            this.fixedHealthLabel = new System.Windows.Forms.Label();
            this.diceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.diceAmountTextBox = new System.Windows.Forms.TextBox();
            this.bonusHPTextBox = new System.Windows.Forms.TextBox();
            this.diceAmountLabel = new System.Windows.Forms.Label();
            this.diceTypeLabel = new System.Windows.Forms.Label();
            this.bonusHealthLabel = new System.Windows.Forms.Label();
            this.warningforBonusHPLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(314, 444);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 48);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(80, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // raceTextBox
            // 
            this.raceTextBox.Location = new System.Drawing.Point(80, 103);
            this.raceTextBox.Name = "raceTextBox";
            this.raceTextBox.Size = new System.Drawing.Size(100, 20);
            this.raceTextBox.TabIndex = 3;
            // 
            // levelTextBox
            // 
            this.levelTextBox.Location = new System.Drawing.Point(80, 191);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(100, 20);
            this.levelTextBox.TabIndex = 4;
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(80, 149);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(100, 20);
            this.classTextBox.TabIndex = 5;
            // 
            // healthOption1
            // 
            this.healthOption1.AutoSize = true;
            this.healthOption1.Location = new System.Drawing.Point(80, 235);
            this.healthOption1.Name = "healthOption1";
            this.healthOption1.Size = new System.Drawing.Size(89, 17);
            this.healthOption1.TabIndex = 6;
            this.healthOption1.TabStop = true;
            this.healthOption1.Text = "Fixed Amount";
            this.healthOption1.UseVisualStyleBackColor = true;
            this.healthOption1.CheckedChanged += new System.EventHandler(this.healthOption1_CheckedChanged);
            // 
            // healthOption2
            // 
            this.healthOption2.AutoSize = true;
            this.healthOption2.Location = new System.Drawing.Point(80, 297);
            this.healthOption2.Name = "healthOption2";
            this.healthOption2.Size = new System.Drawing.Size(195, 17);
            this.healthOption2.TabIndex = 7;
            this.healthOption2.TabStop = true;
            this.healthOption2.Text = "Roll for Health (Usually for monsters)";
            this.healthOption2.UseVisualStyleBackColor = true;
            this.healthOption2.CheckedChanged += new System.EventHandler(this.healthOption2_CheckedChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(36, 57);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name:";
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Location = new System.Drawing.Point(36, 106);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(36, 13);
            this.raceLabel.TabIndex = 9;
            this.raceLabel.Text = "Race:";
            // 
            // noClassCheckBox
            // 
            this.noClassCheckBox.AutoSize = true;
            this.noClassCheckBox.Location = new System.Drawing.Point(186, 152);
            this.noClassCheckBox.Name = "noClassCheckBox";
            this.noClassCheckBox.Size = new System.Drawing.Size(153, 17);
            this.noClassCheckBox.TabIndex = 10;
            this.noClassCheckBox.Text = "Check if no particular class";
            this.noClassCheckBox.UseVisualStyleBackColor = true;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(39, 153);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(35, 13);
            this.classLabel.TabIndex = 11;
            this.classLabel.Text = "Class:";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(36, 198);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(36, 13);
            this.levelLabel.TabIndex = 12;
            this.levelLabel.Text = "Level:";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(38, 237);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(41, 13);
            this.healthLabel.TabIndex = 13;
            this.healthLabel.Text = "Health:";
            // 
            // fixedHealthTextBox
            // 
            this.fixedHealthTextBox.Location = new System.Drawing.Point(149, 258);
            this.fixedHealthTextBox.Name = "fixedHealthTextBox";
            this.fixedHealthTextBox.Size = new System.Drawing.Size(100, 20);
            this.fixedHealthTextBox.TabIndex = 14;
            this.fixedHealthTextBox.Visible = false;
            // 
            // fixedHealthLabel
            // 
            this.fixedHealthLabel.AutoSize = true;
            this.fixedHealthLabel.Location = new System.Drawing.Point(108, 261);
            this.fixedHealthLabel.Name = "fixedHealthLabel";
            this.fixedHealthLabel.Size = new System.Drawing.Size(41, 13);
            this.fixedHealthLabel.TabIndex = 15;
            this.fixedHealthLabel.Text = "Health:";
            this.fixedHealthLabel.Visible = false;
            // 
            // diceTypeComboBox
            // 
            this.diceTypeComboBox.FormattingEnabled = true;
            this.diceTypeComboBox.Items.AddRange(new object[] {
            "D4",
            "D6",
            "D8",
            "D10",
            "D12",
            "D20"});
            this.diceTypeComboBox.Location = new System.Drawing.Point(186, 357);
            this.diceTypeComboBox.Name = "diceTypeComboBox";
            this.diceTypeComboBox.Size = new System.Drawing.Size(63, 21);
            this.diceTypeComboBox.TabIndex = 16;
            this.diceTypeComboBox.Visible = false;
            this.diceTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.diceTypeComboBox_SelectedIndexChanged);
            // 
            // diceAmountTextBox
            // 
            this.diceAmountTextBox.Location = new System.Drawing.Point(186, 320);
            this.diceAmountTextBox.Name = "diceAmountTextBox";
            this.diceAmountTextBox.Size = new System.Drawing.Size(63, 20);
            this.diceAmountTextBox.TabIndex = 17;
            this.diceAmountTextBox.Visible = false;
            // 
            // bonusHPTextBox
            // 
            this.bonusHPTextBox.Location = new System.Drawing.Point(186, 394);
            this.bonusHPTextBox.Name = "bonusHPTextBox";
            this.bonusHPTextBox.Size = new System.Drawing.Size(63, 20);
            this.bonusHPTextBox.TabIndex = 18;
            this.bonusHPTextBox.Visible = false;
            // 
            // diceAmountLabel
            // 
            this.diceAmountLabel.AutoSize = true;
            this.diceAmountLabel.Location = new System.Drawing.Point(97, 323);
            this.diceAmountLabel.Name = "diceAmountLabel";
            this.diceAmountLabel.Size = new System.Drawing.Size(83, 13);
            this.diceAmountLabel.TabIndex = 19;
            this.diceAmountLabel.Text = "Amount of Dice:";
            this.diceAmountLabel.Visible = false;
            // 
            // diceTypeLabel
            // 
            this.diceTypeLabel.AutoSize = true;
            this.diceTypeLabel.Location = new System.Drawing.Point(121, 360);
            this.diceTypeLabel.Name = "diceTypeLabel";
            this.diceTypeLabel.Size = new System.Drawing.Size(59, 13);
            this.diceTypeLabel.TabIndex = 20;
            this.diceTypeLabel.Text = "Dice Type:";
            this.diceTypeLabel.Visible = false;
            // 
            // bonusHealthLabel
            // 
            this.bonusHealthLabel.AutoSize = true;
            this.bonusHealthLabel.Location = new System.Drawing.Point(101, 397);
            this.bonusHealthLabel.Name = "bonusHealthLabel";
            this.bonusHealthLabel.Size = new System.Drawing.Size(79, 13);
            this.bonusHealthLabel.TabIndex = 21;
            this.bonusHealthLabel.Text = "Any Bonus HP:";
            this.bonusHealthLabel.Visible = false;
            // 
            // warningforBonusHPLabel
            // 
            this.warningforBonusHPLabel.AutoSize = true;
            this.warningforBonusHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningforBonusHPLabel.Location = new System.Drawing.Point(255, 397);
            this.warningforBonusHPLabel.Name = "warningforBonusHPLabel";
            this.warningforBonusHPLabel.Size = new System.Drawing.Size(95, 16);
            this.warningforBonusHPLabel.TabIndex = 22;
            this.warningforBonusHPLabel.Text = "If none, put 0";
            this.warningforBonusHPLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Character Creation";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(447, 444);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(103, 48);
            this.submitButton.TabIndex = 24;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click_1);
            // 
            // AddingCreature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 504);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.warningforBonusHPLabel);
            this.Controls.Add(this.bonusHealthLabel);
            this.Controls.Add(this.diceTypeLabel);
            this.Controls.Add(this.diceAmountLabel);
            this.Controls.Add(this.bonusHPTextBox);
            this.Controls.Add(this.diceAmountTextBox);
            this.Controls.Add(this.diceTypeComboBox);
            this.Controls.Add(this.fixedHealthLabel);
            this.Controls.Add(this.fixedHealthTextBox);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.noClassCheckBox);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.healthOption2);
            this.Controls.Add(this.healthOption1);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.levelTextBox);
            this.Controls.Add(this.raceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addButton);
            this.Name = "AddingCreature";
            this.Text = "AddingCreature";
            this.Load += new System.EventHandler(this.AddingCreature_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox raceTextBox;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.RadioButton healthOption1;
        private System.Windows.Forms.RadioButton healthOption2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.CheckBox noClassCheckBox;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.TextBox fixedHealthTextBox;
        private System.Windows.Forms.Label fixedHealthLabel;
        private System.Windows.Forms.ComboBox diceTypeComboBox;
        private System.Windows.Forms.TextBox diceAmountTextBox;
        private System.Windows.Forms.TextBox bonusHPTextBox;
        private System.Windows.Forms.Label diceAmountLabel;
        private System.Windows.Forms.Label diceTypeLabel;
        private System.Windows.Forms.Label bonusHealthLabel;
        private System.Windows.Forms.Label warningforBonusHPLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
    }
}