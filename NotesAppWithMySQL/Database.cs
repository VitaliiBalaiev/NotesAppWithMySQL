using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NotesAppWithMySQL
{
    class Database
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=notes");

        public void openConnection()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void closeConnection()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public MySqlConnection getConnection()
        {       
            return conn;
        }



        public List<Note> GetNotes()
        {
            List<Note> notes = new List<Note>();
            string query = "SELECT title, text, date FROM records";
            MySqlCommand cmd = new MySqlCommand(query, getConnection());
            openConnection();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    notes.Add(new Note
                    {
                        Title = reader["title"].ToString(),
                        Text = reader["text"].ToString(),
                        Date = reader.GetDateTime("date")
                    });
                }
            }
            closeConnection();
            return notes;
        }
    }

    public class Note
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}