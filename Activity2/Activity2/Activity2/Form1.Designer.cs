namespace Activity2
{
    partial class Form1
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
            this.WishList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FillBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CountBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectionOutputBox = new System.Windows.Forms.TextBox();
            this.CountOutputBox = new System.Windows.Forms.TextBox();
            this.SortBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WishList
            // 
            this.WishList.FormattingEnabled = true;
            this.WishList.Location = new System.Drawing.Point(36, 41);
            this.WishList.Name = "WishList";
            this.WishList.Size = new System.Drawing.Size(209, 238);
            this.WishList.TabIndex = 0;
            this.WishList.SelectedIndexChanged += new System.EventHandler(this.WishList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wish List";
            // 
            // FillBtn
            // 
            this.FillBtn.Location = new System.Drawing.Point(279, 41);
            this.FillBtn.Name = "FillBtn";
            this.FillBtn.Size = new System.Drawing.Size(75, 23);
            this.FillBtn.TabIndex = 2;
            this.FillBtn.Text = "Fill";
            this.FillBtn.UseVisualStyleBackColor = true;
            this.FillBtn.Click += new System.EventHandler(this.FillBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(279, 147);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CountBtn
            // 
            this.CountBtn.Location = new System.Drawing.Point(279, 203);
            this.CountBtn.Name = "CountBtn";
            this.CountBtn.Size = new System.Drawing.Size(75, 23);
            this.CountBtn.TabIndex = 4;
            this.CountBtn.Text = "Count";
            this.CountBtn.UseVisualStyleBackColor = true;
            this.CountBtn.Click += new System.EventHandler(this.CountBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selection";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Count: ";
            // 
            // SelectionOutputBox
            // 
            this.SelectionOutputBox.Location = new System.Drawing.Point(90, 322);
            this.SelectionOutputBox.Name = "SelectionOutputBox";
            this.SelectionOutputBox.Size = new System.Drawing.Size(155, 20);
            this.SelectionOutputBox.TabIndex = 7;
            // 
            // CountOutputBox
            // 
            this.CountOutputBox.Location = new System.Drawing.Point(90, 362);
            this.CountOutputBox.Name = "CountOutputBox";
            this.CountOutputBox.Size = new System.Drawing.Size(155, 20);
            this.CountOutputBox.TabIndex = 8;
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(279, 94);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(75, 23);
            this.SortBtn.TabIndex = 9;
            this.SortBtn.Text = "Sort";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(279, 256);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 10;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 471);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.CountOutputBox);
            this.Controls.Add(this.SelectionOutputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.FillBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WishList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WishList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FillBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CountBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SelectionOutputBox;
        private System.Windows.Forms.TextBox CountOutputBox;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}

