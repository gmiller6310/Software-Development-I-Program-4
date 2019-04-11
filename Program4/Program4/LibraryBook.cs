//Grading ID: B9073
// Program #: 4
// Due Date: December 6, 2016 11:59 P.M.
// Course Number: CIS199-75
// Brief Decsription: Allows user to input the Title, Author, Publisher, Copyright Year, and Call Number. 
// When entered, the book is added to a list. The user can then select any book entered and request details, check out the book,
// or return the book to the shelf.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class LibraryBook
    {
        private string _title; // Creates backing field for title
        private string _author; // Creates backing field for author
        private string _publisher; // Creates backing field for publisher
        private int _copyrightyear; // Creates backing field for copyright year
        private string _callnumber; // Creates backing field for call number
        private bool _checkedoutstatus; // Creates backing field for checked out status

        public LibraryBook(string t, string a, string p, int y, string n) // Creates a 5 parameter constructor named LibraryBook
        {
            Title = t; // Sets property Title equal to t
            Author = a; // Sets property Author equal to a
            Publisher = p; // Sets property Publisher equal to p
            CopyrightYear = y; // Sets property CopyrightYear to y
            CallNumber = n; // Sets property CallNumber equal to n
        }

        public string Title // Creates Title property
        {
            // Precondition:  None
            // Postcondition: The title has been returned
            get
            {
                return _title; // Return backing field 
            }

            // Precondition:  None
            // Postcondition: The title has been set to the specified 
            set
            {
                _title = value; // Sets title backing field equal to value
            }
        }

        public string Author // Creates Author property
        {
            // Precondition:  None
            // Postcondition: The author has been returned
            get
            {
                return _author; // Return backing field 
            }

            // Precondition:  None
            // Postcondition: The author has been set to the specified value
            set
            {
                _author = value; // Sets author backing field equal to value
            }
        }

        public string Publisher // Creates Title property
        {
            // Precondition:  None
            // Postcondition: The publisher has been returned
            get
            {
                return _publisher; // Return backing field 
            }

            // Precondition:  None
            // Postcondition: The publisher has been set to the specified value
            set
            {
                _publisher = value; // Sets publisher backing field equal to value
            }
        }

        public int CopyrightYear // Creates CopyrightYear property
        {
            // Precondition:  None
            // Postcondition: The Copyright Year has been returned
            get
            {
                return _copyrightyear; // Return backing field 
            }

            // Precondition:  value >= 0
            // Postcondition: The Copyright Year has been set to the specified value
            set
            {
                if (value >= 0)
                    _copyrightyear = value; // If input follows requirements, set the backing field equal to the value
                else
                    _copyrightyear = 2016; // When invalid, set to 2016 instead
            }
        }

        public string CallNumber // Creates CallNumber property
        {
            // Precondition:  None
            // Postcondition: The call number has been returned
            get
            {
                return _callnumber; // Return backing field 
            }

            // Precondition:  None
            // Postcondition: The call number has been set to the specified value
            set
            {
                _callnumber = value; // Sets the Call Number backing field equal to value
            }
        }

        // Precondition: None
        // Postcondition: The checked out status has been set to true
        public void CheckOut()
        {
            _checkedoutstatus = true; // Changes checked out status to true
        }

        // Precondition: None
        // PostCondition: The checked out status has been set to false
        public void ReturnToShelf()
        {
            _checkedoutstatus = false; // Changes checked out status to false
        }

        // Precondition: None
        // Postcondition: Returns the current status of whether the book is checked out or not
        public bool IsCheckedOut()
        {
            return _checkedoutstatus; // Return checkedoutstatus backing field
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the Library Book
        public override string ToString() // Creates Method ToString
        {
            string result; // Builds result in steps

            result = "Title: " + Title.ToString() + Environment.NewLine + "Author: " + Author.ToString() +
                Environment.NewLine + "Publisher: " + Publisher.ToString() + Environment.NewLine + "Copyright Year: " +
                CopyrightYear.ToString() + Environment.NewLine + "Call Number: " + CallNumber.ToString() +
                Environment.NewLine + "Checked Out Status: " + _checkedoutstatus.ToString(); // Takes all information and displays it in the correct format 

            return result; // ToString when called, gives this value
        }

    }
}
