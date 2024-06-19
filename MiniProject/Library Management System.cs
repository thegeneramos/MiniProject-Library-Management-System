using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Library_Management_System : Form
    {
        Queue<Book> books = new Queue<Book>();
        public Library_Management_System()
        {
            InitializeComponent();
            
        }

        private void Library_Management_System_Load(object sender, EventArgs e)
        {
            books.Enqueue(new Book() { Title= "The Lion, the Witch and the Wardrobe", Author="C.S. Lewis", Genre=Genre.Fantasy });
            books.Enqueue(new Book() { Title = "Prince Caspian", Author = "C.S. Lewis", Genre = Genre.Fantasy });
            books.Enqueue(new Book() { Title = "The Voyage Of The Dawn Treader", Author = "C.S. Lewis", Genre = Genre.Fantasy });
            books.Enqueue(new Book() { Title = "The Silver Chair", Author = "C.S. Lewis", Genre = Genre.Fantasy });
            books.Enqueue(new Book() { Title = "The Horse and His Boy", Author = "C.S. Lewis", Genre = Genre.Fantasy });
            books.Enqueue(new Book() { Title = "The Silver Chair", Author = "C.S. Lewis", Genre = Genre.Fantasy });
            books.Enqueue(new Book() { Title = "The Magician's Nephew", Author = "C.S. Lewis", Genre = Genre.Fantasy });
            books.Enqueue(new Book() { Title = "The Last Battle", Author = "C.S. Lewis", Genre = Genre.Fantasy });
            books.Enqueue(new Book() { Title = "1776", Author = "David McCullough", Genre = Genre.History });
            books.Enqueue(new Book() { Title = "History of the Peloponnesian War", Author = "Thucydidesh", Genre = Genre.History });
            books.Enqueue(new Book() { Title = "We Were the Lucky Ones", Author = "Georgia Hunter", Genre = Genre.Fiction });
            books.Enqueue(new Book() { Title = "The Only Thing to Fear", Author = "Tung Richmond", Genre = Genre.Fiction });
            books.Enqueue(new Book() { Title = "You", Author = "Carolina Kepnes", Genre = Genre.Fiction });
            books.Enqueue(new Book() { Title = "Hidden Bodies", Author = "Carolina Kepnes", Genre = Genre.Fiction });
            books.Enqueue(new Book() { Title = "You Love Me", Author = "Carolina Kepnes", Genre = Genre.Fiction });
            books.Enqueue(new Book() { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = Genre.Fiction });
            books.Enqueue(new Book() { Title = "In Cold Blood", Author = "F. Scott Fitzgerald", Genre = Genre.NonFiction });
            books.Enqueue(new Book() { Title = "The Good Soldiers", Author = "David Finkel", Genre = Genre.NonFiction });
            books.Enqueue(new Book() { Title = "Fifty Shades Of Grey", Author = "E.L. James", Genre = Genre.Romance });
            books.Enqueue(new Book() { Title = "Fifty Shades Darker", Author = "E.L. James", Genre = Genre.Romance });
            books.Enqueue(new Book() { Title = "The Population Bomb", Author = "Paul R. Ehrlich", Genre = Genre.Science });
            books.Enqueue(new Book() { Title = "Solaris", Author = "Stanislaw Lem", Genre = Genre.Science });
            books.Enqueue(new Book() { Title = "Bad Science", Author = "Ben Goldacre", Genre = Genre.Science });
            books.Enqueue(new Book() { Title = "Elon Musk", Author = "Walter Isaacson", Genre = Genre.Biography });
            books.Enqueue(new Book() { Title = "Henry V", Author = "William Shakespeare", Genre = Genre.Biography });
            books.Enqueue(new Book() { Title = "Grant", Author = "Ron Chernow", Genre = Genre.Biography });
            books.Enqueue(new Book() { Title = "Dune", Author = "Frank Herbert", Genre = Genre.Fantasy });
            books.Enqueue(new Book() { Title = "Interview with the Vampire", Author = "Anne Rice", Genre = Genre.Fantasy });
            books.Enqueue(new Book() { Title = "The Phantom Tollbooth", Author = "Norton Juster", Genre = Genre.Fantasy });
            books.Enqueue(new Book() { Title = "The Stand", Author = "Stephen King", Genre = Genre.Fantasy });
            books.Enqueue(new Book() { Title = "The Godfather", Author = "Mario Puzo", Genre = Genre.Mystery });
            books.Enqueue(new Book() { Title = "Crooked House", Author = "Agatha Christie", Genre = Genre.Mystery });
            books.Enqueue(new Book() { Title = "A Study in Scarlet", Author = "Arthur Conan Doyle", Genre = Genre.Mystery });
            
            bookGrid.DataSource = books.ToList();
            comboGenre.DataSource = Enum.GetValues(typeof(Genre));
            grpBookDetails.Visible = true;
        }
        private void RefreshDate()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            comboGenre.SelectedIndex = 0;
            bookGrid.DataSource = books;
            
        }
    }

}
