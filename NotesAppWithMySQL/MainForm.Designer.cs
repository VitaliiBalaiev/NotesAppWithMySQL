namespace NotesAppWithMySQL
{
    partial class MainForm
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanelNotes = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.NewNoteBtn = new System.Windows.Forms.Button();
            this.DeleteNoteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Montserrat", 10F);
            this.titleTextBox.Location = new System.Drawing.Point(908, 138);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(379, 32);
            this.titleTextBox.TabIndex = 1;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteTextBox.Location = new System.Drawing.Point(908, 220);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(379, 465);
            this.noteTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(991, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(907, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(907, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Note:";
            // 
            // flowLayoutPanelNotes
            // 
            this.flowLayoutPanelNotes.Location = new System.Drawing.Point(97, 100);
            this.flowLayoutPanelNotes.Name = "flowLayoutPanelNotes";
            this.flowLayoutPanelNotes.Size = new System.Drawing.Size(506, 659);
            this.flowLayoutPanelNotes.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(260, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 44);
            this.label5.TabIndex = 9;
            this.label5.Text = "Your notes";
            // 
            // NewNoteBtn
            // 
            this.NewNoteBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.NewNoteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewNoteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewNoteBtn.FlatAppearance.BorderSize = 0;
            this.NewNoteBtn.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewNoteBtn.Location = new System.Drawing.Point(908, 714);
            this.NewNoteBtn.Name = "NewNoteBtn";
            this.NewNoteBtn.Size = new System.Drawing.Size(109, 45);
            this.NewNoteBtn.TabIndex = 10;
            this.NewNoteBtn.Text = "New note";
            this.NewNoteBtn.UseVisualStyleBackColor = false;
            this.NewNoteBtn.Click += new System.EventHandler(this.NewNoteBtn_Click);
            // 
            // DeleteNoteBtn
            // 
            this.DeleteNoteBtn.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteNoteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteNoteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteNoteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteNoteBtn.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteNoteBtn.Location = new System.Drawing.Point(1178, 714);
            this.DeleteNoteBtn.Name = "DeleteNoteBtn";
            this.DeleteNoteBtn.Size = new System.Drawing.Size(109, 45);
            this.DeleteNoteBtn.TabIndex = 11;
            this.DeleteNoteBtn.Text = "Delete";
            this.DeleteNoteBtn.UseVisualStyleBackColor = false;
            this.DeleteNoteBtn.Click += new System.EventHandler(this.DeleteNoteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.LightGreen;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(1043, 714);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(109, 45);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1427, 790);
            this.Controls.Add(this.DeleteNoteBtn);
            this.Controls.Add(this.NewNoteBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flowLayoutPanelNotes);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.titleTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NewNoteBtn;
        private System.Windows.Forms.Button DeleteNoteBtn;
        
    }
}

