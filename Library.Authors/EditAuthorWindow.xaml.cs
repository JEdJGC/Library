using System.Windows;
using Library.Models;

namespace Library.Authors
{

    public partial class EditAuthorWindow : Window
    {
        public Author Author { get; set; }
        public EditAuthorWindow(Author author)
        {
            InitializeComponent();
            Author = author;
            DataContext = Author;
            FirstNameTextBox.Focus();
            FirstNameTextBox.SelectAll();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
