namespace GroupDataUnPackager
{
    partial class SettingsForm_GroupDataUnPackager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm_GroupDataUnPackager));
            this.OKButton = new System.Windows.Forms.Button();
            this.AggregateTextRadioButton = new System.Windows.Forms.RadioButton();
            this.SeparateTurnsRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(74, 121);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(118, 40);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AggregateTextRadioButton
            // 
            this.AggregateTextRadioButton.AutoSize = true;
            this.AggregateTextRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AggregateTextRadioButton.Location = new System.Drawing.Point(22, 27);
            this.AggregateTextRadioButton.Name = "AggregateTextRadioButton";
            this.AggregateTextRadioButton.Size = new System.Drawing.Size(183, 20);
            this.AggregateTextRadioButton.TabIndex = 7;
            this.AggregateTextRadioButton.TabStop = true;
            this.AggregateTextRadioButton.Text = "Aggregate Text by Person";
            this.AggregateTextRadioButton.UseVisualStyleBackColor = true;
            // 
            // SeparateTurnsRadioButton
            // 
            this.SeparateTurnsRadioButton.AutoSize = true;
            this.SeparateTurnsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeparateTurnsRadioButton.Location = new System.Drawing.Point(22, 64);
            this.SeparateTurnsRadioButton.Name = "SeparateTurnsRadioButton";
            this.SeparateTurnsRadioButton.Size = new System.Drawing.Size(216, 20);
            this.SeparateTurnsRadioButton.TabIndex = 8;
            this.SeparateTurnsRadioButton.TabStop = true;
            this.SeparateTurnsRadioButton.Text = "Keep Turns as Separate Entries";
            this.SeparateTurnsRadioButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm_GroupDataUnPackager
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 173);
            this.Controls.Add(this.SeparateTurnsRadioButton);
            this.Controls.Add(this.AggregateTextRadioButton);
            this.Controls.Add(this.OKButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm_GroupDataUnPackager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plugin Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.RadioButton AggregateTextRadioButton;
        private System.Windows.Forms.RadioButton SeparateTurnsRadioButton;
    }
}