namespace RandomNamePicker
{
    partial class FRM_NamePicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NamePicker));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LAB_SelectCount = new System.Windows.Forms.Label();
            this.TXT_SelectCount = new System.Windows.Forms.TextBox();
            this.LAB_Selected = new System.Windows.Forms.Label();
            this.TXT_Entries = new System.Windows.Forms.TextBox();
            this.TXT_Selected = new System.Windows.Forms.TextBox();
            this.LAB_List = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LAB_Selected, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TXT_Entries, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TXT_Selected, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LAB_List, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(551, 567);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LAB_SelectCount);
            this.panel2.Controls.Add(this.TXT_SelectCount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 45);
            this.panel2.TabIndex = 5;
            // 
            // LAB_SelectCount
            // 
            this.LAB_SelectCount.AutoSize = true;
            this.LAB_SelectCount.Location = new System.Drawing.Point(4, 13);
            this.LAB_SelectCount.Name = "LAB_SelectCount";
            this.LAB_SelectCount.Size = new System.Drawing.Size(228, 20);
            this.LAB_SelectCount.TabIndex = 1;
            this.LAB_SelectCount.Text = "How many should be selected: ";
            // 
            // TXT_SelectCount
            // 
            this.TXT_SelectCount.Location = new System.Drawing.Point(238, 10);
            this.TXT_SelectCount.Name = "TXT_SelectCount";
            this.TXT_SelectCount.Size = new System.Drawing.Size(33, 26);
            this.TXT_SelectCount.TabIndex = 0;
            // 
            // LAB_Selected
            // 
            this.LAB_Selected.AutoSize = true;
            this.LAB_Selected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_Selected.Location = new System.Drawing.Point(279, 0);
            this.LAB_Selected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAB_Selected.Name = "LAB_Selected";
            this.LAB_Selected.Size = new System.Drawing.Size(268, 39);
            this.LAB_Selected.TabIndex = 3;
            this.LAB_Selected.Text = "Selected";
            this.LAB_Selected.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TXT_Entries
            // 
            this.TXT_Entries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_Entries.Location = new System.Drawing.Point(4, 44);
            this.TXT_Entries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_Entries.Multiline = true;
            this.TXT_Entries.Name = "TXT_Entries";
            this.TXT_Entries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_Entries.Size = new System.Drawing.Size(267, 473);
            this.TXT_Entries.TabIndex = 0;
            // 
            // TXT_Selected
            // 
            this.TXT_Selected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_Selected.Location = new System.Drawing.Point(279, 44);
            this.TXT_Selected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_Selected.Multiline = true;
            this.TXT_Selected.Name = "TXT_Selected";
            this.TXT_Selected.ReadOnly = true;
            this.TXT_Selected.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_Selected.Size = new System.Drawing.Size(268, 473);
            this.TXT_Selected.TabIndex = 1;
            // 
            // LAB_List
            // 
            this.LAB_List.AutoSize = true;
            this.LAB_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_List.Location = new System.Drawing.Point(4, 0);
            this.LAB_List.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAB_List.Name = "LAB_List";
            this.LAB_List.Size = new System.Drawing.Size(267, 39);
            this.LAB_List.TabIndex = 2;
            this.LAB_List.Text = "Entries";
            this.LAB_List.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(275, 522);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 45);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_NamePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 567);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRM_NamePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ramdom Name Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TXT_Entries;
        private System.Windows.Forms.TextBox TXT_Selected;
        private System.Windows.Forms.Label LAB_List;
        private System.Windows.Forms.Label LAB_Selected;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LAB_SelectCount;
        private System.Windows.Forms.TextBox TXT_SelectCount;
    }
}

