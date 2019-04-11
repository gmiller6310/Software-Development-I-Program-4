//Grading ID: B9073
// Program #: 4
// Due Date: December 6, 2016 11:59 P.M.
// Course Number: CIS199-75
// Brief Decsription: Allows user to input the Title, Author, Publisher, Copyright Year, and Call Number. 
// When entered, the book is added to a list. The user can then select any book entered and request details, check out the book,
// or return the book to the shelf.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    public partial class LibraryForm : Form
    {
        private LibraryBook book = new LibraryBook("", "", "", 0, ""); // Creates new book object with basic input for the parameters
        List<LibraryBook> libraryBookList = new List<LibraryBook>(); // Creates new list named libraryBookList

        public LibraryForm()
        {
            InitializeComponent();
        }

        string title; // Creates variable title of type string
        string author; // Creates variable author of type string
        string publisher; // Creates variable publisher of type string
        int copyrightYear; // Creates variable copyrightyear of type int
        string callNumber; // Creates variable callnumber of type string

        private void addLibraryBookButton_Click(object sender, EventArgs e) // Creates click event for Add Library Book button
        {
            title = titleTextBox.Text; // Sets title equal to input from titleTextBox
            book.Title = title; // Sets property Title of object book equal to title

            author = authorTextBox.Text; // Sets author equal to input from authorTextBox
            book.Author = author; // Sets property Author of object book equal to author

            publisher = publisherTextBox.Text; // Sets publisher equal to input from publisherTextBox
            book.Publisher = publisher; // Sets property Publisher of object book equal to publisher

            callNumber = callNumberTextBox.Text; // Sets callNumber equal to input from callNumberTextBox
            book.CallNumber = callNumber; // Sets property CallNumber of object book equal to callNumber

            if (int.TryParse(copyrightYearTextBox.Text, out copyrightYear)) // Parses data from copyrightYearTextBox into copyrightYear
            {
                book.CopyrightYear = copyrightYear; // Sets property CopyrightYear of object book equal to copyrightYear
            }
            else // If parse unsuccessful...
            {
                MessageBox.Show("Please enter a valid Copyright Year."); // ... Display selected message
            }

            if (title == "") 
            {
                MessageBox.Show("Please enter a Title."); // If title is left blank, display given message
            }

            if (author == "")
            {
                MessageBox.Show("Please enter an Author."); // If author is left blank, display given message
            }

            if (publisher == "")
            {
                MessageBox.Show("Please enter a Publisher."); // If publisher is left blank, display given message
            }

            if (callNumber == "")
            {
                MessageBox.Show("Please enter a Call Number."); // If callNumber is left blank, display given message
            }

            libraryBookListBox.Items.Add(book.Title); // Add object book's Title property to list box libraryBookListBox
            libraryBookList.Add(book); // Add all information of object book to libraryBookList

            if (libraryBookListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Library Book."); // If no item in the list box is selected, display message
            }
        }

        private void detailsButton_Click(object sender, EventArgs e) // Creates click event for detailsButton
        {
            int index = libraryBookListBox.SelectedIndex; // Sets index equal to the value of the selected item in the list box

            MessageBox.Show(libraryBookList[index].ToString()); // Show all details of the book selected in the list using ToString method
        }

        private void checkOutButton_Click(object sender, EventArgs e) // Creates click event for checkOutButton
        {
            int index = libraryBookListBox.SelectedIndex; // Sets index equal to the value of the selected item in the list box

            book.CheckOut(); // Sets the checkedoutstatus of object book to true

            MessageBox.Show(book.Title + " has now been checked out."); // Shows message saying selected book is now checked out
        }

        private void returnButton_Click(object sender, EventArgs e) // Creates click event for returnButton
        {
            int index = libraryBookListBox.SelectedIndex; // Sets index equal to the value of the selected item in the list box

            book.ReturnToShelf(); // Sets the checkedout status of object book to false

            MessageBox.Show(book.Title + " has now been returned to the shelf."); // Shows message saying selected book has now been returned to the shelf
        }

    }
}
