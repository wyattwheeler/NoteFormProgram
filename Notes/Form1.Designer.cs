namespace Notes
{
    partial class Form1
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
            this.Title = new System.Windows.Forms.Label();
            this.LTitle = new System.Windows.Forms.Label();
            this.LNote = new System.Windows.Forms.Label();
            this.TextTitle = new System.Windows.Forms.TextBox();
            this.TextMessage = new System.Windows.Forms.TextBox();
            this.DGVNoteList = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNoteList)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 23);
            this.Title.TabIndex = 6;
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Location = new System.Drawing.Point(12, 9);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(29, 15);
            this.LTitle.TabIndex = 1;
            this.LTitle.Text = "Title";
            // 
            // LNote
            // 
            this.LNote.AutoSize = true;
            this.LNote.Location = new System.Drawing.Point(12, 66);
            this.LNote.Name = "LNote";
            this.LNote.Size = new System.Drawing.Size(33, 15);
            this.LNote.TabIndex = 2;
            this.LNote.Text = "Note";
            // 
            // TextTitle
            // 
            this.TextTitle.Location = new System.Drawing.Point(12, 27);
            this.TextTitle.Name = "TextTitle";
            this.TextTitle.Size = new System.Drawing.Size(240, 23);
            this.TextTitle.TabIndex = 3;
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(12, 84);
            this.TextMessage.Multiline = true;
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(240, 354);
            this.TextMessage.TabIndex = 3;
            // 
            // DGVNoteList
            // 
            this.DGVNoteList.AllowUserToAddRows = false;
            this.DGVNoteList.AllowUserToDeleteRows = false;
            this.DGVNoteList.AllowUserToResizeColumns = false;
            this.DGVNoteList.AllowUserToResizeRows = false;
            this.DGVNoteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNoteList.Location = new System.Drawing.Point(616, 130);
            this.DGVNoteList.Name = "DGVNoteList";
            this.DGVNoteList.ReadOnly = true;
            this.DGVNoteList.RowTemplate.Height = 25;
            this.DGVNoteList.Size = new System.Drawing.Size(172, 308);
            this.DGVNoteList.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(616, 66);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(713, 66);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(616, 22);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 5;
            this.NewButton.Text = "Reset";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(713, 22);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DGVNoteList);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.TextTitle);
            this.Controls.Add(this.LNote);
            this.Controls.Add(this.LTitle);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNoteList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Label LTitle;
        private Label LNote;
        private TextBox TextTitle;
        private TextBox TextMessage;
        private DataGridView DGVNoteList;
        private Button SaveButton;
        private Button LoadButton;
        private Button NewButton;
        private Button DeleteButton;
    }
}