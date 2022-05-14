//============================================================
// Student Number : S1021954, S10222162
// Student Name : Yong Zi Ren, Lee Wee Kang
// Module Group : T08
//============================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_T08_Team8
{
    internal class Adult: Ticket
    {
        public bool PopcornOffer { get; set; }

        public Adult() { }

        public Adult(Screening s, bool po): base(s)
        {
            PopcornOffer = po;
        }

        public override double CalculatePrice()
        {
            DateTime dateBooked = Screening.ScreeningDateTime;

            string screeningType = Screening.ScreeningType;

            List<string> weekdays = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday" };
            List<string> weekends = new List<string>() { "Friday", "Saturday", "Sunday" };

            string day = dateBooked.ToString("dddd");


            if (screeningType == "3D")
            {


                foreach (string s in weekdays)
                {

                    if (day == s)
                    {
                        return 11.0;
                    }
                }
                foreach (string s in weekends)
                {

                    if (day == s)
                    {
                        return 14.0;
                    }
                }
            }

            else if (screeningType == "2D")
            {
                foreach (string s in weekdays)
                {

                    if (day == s)
                    {
                        return 8.5;
                    }
                }
                foreach (string s in weekends)
                {

                    if (day == s)
                    {
                        return 12.5;
                    }
                }
            }

            return 0;
        }

        public override string ToString()
        {
            return base.ToString() + "\tPopcornOffer: " + PopcornOffer;
        }
    }
}
