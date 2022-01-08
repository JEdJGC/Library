using System.ComponentModel;

namespace Library.Models
{
    public class Author : INotifyPropertyChanged
    {
        private int authorId;
        private string firstName;
        private string lastName;

        public event PropertyChangedEventHandler PropertyChanged;
        public int AuthorId
        {
            get => authorId;
            set
            {
                if (authorId != value)
                {
                    authorId = value;
                    OnNotifyPropertyChanged("AuthorId");
                }
            }
        }
        public string FirstName
        {
            get => firstName;
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    OnNotifyPropertyChanged("FirstName");
                }
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    OnNotifyPropertyChanged("LastName");
                }
            }
        }
        public string FullName
        {
            get => $"{FirstName}, {LastName}";
        }
        public Author()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
           
        private void OnNotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

