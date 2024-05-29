using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat0529
{
    class Ember : INotifyPropertyChanged
    {
        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                CicaMica();
            }
        }

        private string nev;

        public string Nev
        {
            get { return nev; }
            set { nev = value; CicaMica(); }
        }

        private string varos;

        public string Varos
        {
            get { return varos; }
            set { varos = value; CicaMica(); }
        }

        private string munka;

        public string Munka
        {
            get { return munka; }
            set { munka = value; CicaMica(); }
        }

        private string erdeklodes;

        public string Erdeklodes
        {
            get { return erdeklodes; }
            set { erdeklodes = value; CicaMica(); }
        }

        private int kor;

        public int Kor
        {
            get { return kor; }
            set { Kor = value; CicaMica(); }
        }

        public Ember(string nev,int kor, string varos, string munka, string erdeklodes)
        {
            Nev = nev;
            Kor = kor;
            Varos = varos;
            Munka = munka;
            Erdeklodes = erdeklodes;
        }
        public Ember()
        {
        }

        public override string? ToString()
        {
            return Nev != null ? $"{Nev} - {Kor} - {Varos} - {Munka} - {Erdeklodes}" : "";
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void CicaMica([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}