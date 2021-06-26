using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Matthew_991524179_Midterm
{
    /// <summary>
    /// Interaction logic for Functionalities.xaml
    /// </summary>
    public partial class Functionalities : Window
    {
        public Functionalities()
        {
            InitializeComponent();
        }

        List<Book> books = new List<Book>() { new Book { ISBN = 111111, Title = "And then there were none", Price = 24.99, Genre = "Mystery"},
        new Book { ISBN = 2222222, Title = "Pride and Prejudice", Price = 27.99, Genre = "Romance"},
        new Book { ISBN = 3333333, Title = "Guns Germs and Steel", Price = 30.99, Genre = "History"} };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            string campus = null;
            if (rbtnMystery.IsChecked == true) campus = rbtnMystery.Content.ToString();
            else if (rbtnRomance.IsChecked == true) campus = rbtnRomance.Content.ToString();
            else campus = rbtnHistory.Content.ToString();

            Book s = new Book()
            {
                ISBN = Convert.ToInt32(txtISBN.Text),
                Title = txtTitle.Text,
                Price = Convert.ToDouble(txtPrice.Text)
            };
            books.Add(s);
            MessageBox.Show("New book " + s.ToString() + " added!", "Add Book");
            clearAddBookFields();
        }

        void clearAddBookFields()
        {
            txtISBN.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtPrice.Text = string.Empty;
            rbtnMystery.IsChecked = false;
            rbtnRomance.IsChecked = false;
            rbtnHistory.IsChecked = false;
        }

        private void dGridShowBooks_Loaded(object sender, RoutedEventArgs e)
        {
            dGridShowBooks.ItemsSource = books;
        }

        private void dGridShowStudents_Unloaded(object sender, RoutedEventArgs e)
        {
            dGridShowBooks.ItemsSource = null;
        }

        // Search by Genre
        private void btnFindByGenre_Click(object sender, RoutedEventArgs e)
        {
            List<Book> foundBooks = new List<Book>();
            CheckBox[] checkBoxes = { chkBoxHistory, chkBoxMystery, chkBoxRomance };

            if (checkBoxes.Length > 1)
            {
                foreach (var checkBox in checkBoxes)
                {
                    if (checkBox.IsChecked == true)
                    {
                        foreach (Book boo in books)
                            if (boo.Genre == checkBox.Content.ToString())
                            {
                                foundBooks.Add(boo);
                                MessageBox.Show("Book titled = " + foundBooks + " has been found.", "Find Genre");
                            }
                    }
                }
            }
            else MessageBox.Show("No Genre selected!", "Find by Genre");
            lstBoxFindBook.DataContext = foundBooks;
            clearFindBookFields();
        }

        void clearFindBookFields()
        {
            chkBoxHistory.IsChecked = false;
            chkBoxMystery.IsChecked = false;
            chkBoxRomance.IsChecked = false;

        }
    }
}
        
