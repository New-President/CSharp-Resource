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
    internal class Movie
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Classification { get; set; }
        public DateTime OpeningDate { get; set; }
        public List<string> GenreList { get; set; }
        public List<Screening> ScreeningList { get; set; } = new List<Screening>();
        public Movie() { }
        public Movie(string t, int d, string c, DateTime od, List<string> gl)
        {
            Title = t;
            Duration = d;
            Classification = c;
            OpeningDate = od;
            GenreList = gl;
        }
        public void AddGenre(String genre)
        {
            GenreList.Add(genre);
        }
        public void AddScreening(Screening screening)
        {
            ScreeningList.Add(screening);
        }
        public List<string> GetGenreList()
        {
            return GenreList;
        }
        //public List<Screening> GetScreeningList()
        //{
        //    return ScreeningList;
        //}
        public override string ToString()
        {
            return "Title: " + Title + "\tDuration: " + Duration + "\tClassification: " + Classification + "\tOpeningDate: " + OpeningDate;//Never display list
        }
    }
}
