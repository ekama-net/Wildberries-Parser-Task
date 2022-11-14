namespace WildberriesParser
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Parse_button = new System.Windows.Forms.Button();
            this.New_txt_button = new System.Windows.Forms.Button();
            this.File_Data = new System.Windows.Forms.RichTextBox();
            this.File_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Parse_button
            // 
            this.Parse_button.Location = new System.Drawing.Point(34, 98);
            this.Parse_button.Margin = new System.Windows.Forms.Padding(2);
            this.Parse_button.Name = "Parse_button";
            this.Parse_button.Size = new System.Drawing.Size(150, 44);
            this.Parse_button.TabIndex = 0;
            this.Parse_button.Text = "Parse";
            this.Parse_button.UseVisualStyleBackColor = true;
            this.Parse_button.Click += new System.EventHandler(this.Parse_button_Click);
            // 
            // New_txt_button
            // 
            this.New_txt_button.Location = new System.Drawing.Point(34, 32);
            this.New_txt_button.Margin = new System.Windows.Forms.Padding(2);
            this.New_txt_button.Name = "New_txt_button";
            this.New_txt_button.Size = new System.Drawing.Size(150, 46);
            this.New_txt_button.TabIndex = 2;
            this.New_txt_button.Text = "New .txt";
            this.New_txt_button.UseVisualStyleBackColor = true;
            this.New_txt_button.Click += new System.EventHandler(this.New_txt_button_Click);
            // 
            // File_Data
            // 
            this.File_Data.Location = new System.Drawing.Point(234, 32);
            this.File_Data.Margin = new System.Windows.Forms.Padding(2);
            this.File_Data.Name = "File_Data";
            this.File_Data.ReadOnly = true;
            this.File_Data.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.File_Data.Size = new System.Drawing.Size(233, 110);
            this.File_Data.TabIndex = 3;
            this.File_Data.Text = "";
            // 
            // File_Name
            // 
            this.File_Name.AutoSize = true;
            this.File_Name.Location = new System.Drawing.Point(231, 9);
            this.File_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.File_Name.Name = "File_Name";
            this.File_Name.Size = new System.Drawing.Size(76, 20);
            this.File_Name.TabIndex = 4;
            this.File_Name.Text = "File Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 164);
            this.Controls.Add(this.File_Name);
            this.Controls.Add(this.File_Data);
            this.Controls.Add(this.New_txt_button);
            this.Controls.Add(this.Parse_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wildberries Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Parse_button;
        private System.Windows.Forms.Button New_txt_button;
        private System.Windows.Forms.RichTextBox File_Data;
        private System.Windows.Forms.Label File_Name;
    }
}
