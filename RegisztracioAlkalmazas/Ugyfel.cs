using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisztracioAlkalmazas
{
    class Ugyfel
    {
        private string nev;
        private int szuletesiEv;
        private string nem;
        private string kedvenchobbi;
        private List<string> hobbik;

        public Ugyfel(string nev, int szuletesiEv, string nem, string kedvenchobbi, List<string> hobbik)
        {
            this.nev = nev;
            this.szuletesiEv = szuletesiEv;
            this.nem = nem;
            this.kedvenchobbi = kedvenchobbi;
            this.hobbik = hobbik;
        }

        public Ugyfel(string ugyfel)
        {
            String[] str = ugyfel.Split(';');

            nev = str[0];
            szuletesiEv = Convert.ToInt32(str[1]);
            nem = str[2];
            kedvenchobbi = str[3];

            hobbik = new List<string>();
            foreach(string hobbi in str[4].Split(','))
            {
                hobbik.Add(hobbi);
            }
        }

        public string Nev { get => nev; set => nev = value; }
        public int SzuletesiEv { get => szuletesiEv; set => szuletesiEv = value; }
        public string Nem { get => nem; set => nem = value; }
        public string KedvencHobbi { get => kedvenchobbi; set => kedvenchobbi = value; }
        public List<string> Hobbik { get => hobbik; set => hobbik = value; }


        public override string ToString()
        {
            return string.Format($"{nev};{szuletesiEv};{nem};{kedvenchobbi};{formatHobbik()}");
        }

        private string formatHobbik()
        {
            string hobbikString = "";
            for (int i = 0; i < hobbik.Count; i++)
            {
                hobbikString += hobbik[i];
                if (i + 1 < hobbik.Count)
                {
                    hobbikString += ",";
                }
            }
            return hobbikString;
        }
    }
}
