using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace NotesAppWithMySQL
{
    public partial class MainForm : Form
    {

        private Database db = new Database();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateNotesForPanel();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            string titleText = titleTextBox.Text;
            string noteText = noteTextBox.Text;

            // Check if the note already exists
            string checkQuery = "SELECT COUNT(*) FROM `records` WHERE title = @titleText";
            MySqlCommand checkCommand = new MySqlCommand(checkQuery, db.getConnection());
            checkCommand.Parameters.AddWithValue("@titleText", titleText);

            db.openConnection();

            int count = Convert.ToInt32(checkCommand.ExecuteScalar());
            if (count > 0)
            {
                // if note exists, update it
                string updateQuery = "UPDATE `records` SET text = @noteText WHERE title = @titleText";
                MySqlCommand updateCommand = new MySqlCommand(updateQuery, db.getConnection());
                updateCommand.Parameters.AddWithValue("@titleText", titleText);
                updateCommand.Parameters.AddWithValue("@noteText", noteText);

                if (updateCommand.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Failed to update note!");
                }
            }
            else if (!string.IsNullOrEmpty(titleText))
            {
                // if note does not exist, insert it
                string insertQuery = "INSERT INTO `records` (title, text) VALUES (@titleText, @noteText)";
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, db.getConnection());
                insertCommand.Parameters.AddWithValue("@titleText", titleText);
                insertCommand.Parameters.AddWithValue("@noteText", noteText);

                if (insertCommand.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Failed to add note!");
                }
            }

            titleTextBox.Clear();
            noteTextBox.Clear();

            GenerateNotesForPanel();

            db.closeConnection();

        }
        private void GenerateNotesForPanel()
        {
            List<Note> notes = db.GetNotes();

            flowLayoutPanelNotes.Controls.Clear();

            foreach (var note in notes)
            {
                Button noteButton = new Button();

                // Format the button text to include title, a preview of the text, and timestamp
                string previewText = note.Text.Length > 50 ? note.Text.Substring(0, 47) + "..." : note.Text;
                string buttonText = $"{note.Title}\n{previewText}\n{note.Date.ToString("g", CultureInfo.InvariantCulture)}";
                noteButton.Text = buttonText;

                
                noteButton.Tag = note;

                // Button styling
                noteButton.Width = flowLayoutPanelNotes.Width - 5;
                noteButton.Height = 100;
                noteButton.Margin = new Padding(3);
                noteButton.Font = new Font("Montserrat", 10);
                noteButton.BackColor = Color.White;

                noteButton.Click += NoteButton_Click;

                flowLayoutPanelNotes.Controls.Add(noteButton);

            }
        }

        private void NoteButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                Note note = clickedButton.Tag as Note;
                if (note != null)
                {
                    titleTextBox.Text = note.Title;
                    noteTextBox.Text = note.Text;
                }
            }
        }

        private void NewNoteBtn_Click(object sender, EventArgs e)
        {
            titleTextBox.Clear();
            noteTextBox.Clear();
        }

        private void DeleteNoteBtn_Click(object sender, EventArgs e)
        {
            string titleText = titleTextBox.Text;
            string noteText = noteTextBox.Text;

            db.openConnection();

            string deleteQuery = "DELETE FROM `records` WHERE `title` = @titleText";
            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, db.getConnection());
            deleteCommand.Parameters.AddWithValue("@titleText", titleText);
            if (deleteCommand.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("Failed to delete");
            }

            GenerateNotesForPanel();
            titleTextBox.Clear();
            noteTextBox.Clear();

            db.closeConnection();
        }
    }
}