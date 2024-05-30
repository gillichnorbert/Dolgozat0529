using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged();
            }
        }

        private string city;
        public string City
        {
            get { return city; }
            set
            {
                city = value;
                OnPropertyChanged();
            }
        }

        private string job;
        public string Job
        {
            get { return job; }
            set
            {
                job = value;
                OnPropertyChanged();
            }
        }

        private string interest;
        public string Interest
        {
            get { return interest; }
            set
            {
                interest = value;
                OnPropertyChanged();
            }
        }

        public Person() { }

        public Person(string sor)
        {
            var a = sor.Split(",");
            Name = a[0];
            Age = Convert.ToInt32(a[1]);
            City = a[2];
            Job = a[3];
            Interest = a[4];
        }

        public override string ToString()
        {
            return $"{Name} - {Age} - {City} - {Job} - {Interest}";
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
