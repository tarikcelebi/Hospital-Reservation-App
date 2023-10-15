using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeReservationApp
{
    public class Patient
    {
        public string NameSurname { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string TC { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Policlinic { get; set; }

        public Patient(string nameSurname, DateTime date, string time, string tC, string phone, string gender, string policlinic)
        {
            NameSurname = nameSurname;
            Date = date;
            Time = time;
            TC = tC;
            Phone = phone;
            Gender = gender;
            Policlinic = policlinic;
        }

        
    }
}
