// See https://aka.ms/new-console-template for more information
namespace S10219524_Question02
{
    internal class S10219524_Question02
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("loaninfo(2).csv");
            string[] header = lines[0].Split(",");
            Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,13} {5,13} {6,5}", header[0], header[1], header[2], header[3], "Days Loan", "Days Overdue", "Fine");
            File.WriteAllText("overdueinfo.csv", "Book ID,Borrower ID,Days Overdue,Fine Amount\n");
            for (int i = 1; i < lines.Length; i++)
            {
                string[] row = lines[i].Split(",");
                DateTime Bdate = Convert.ToDateTime(row[2]);
                DateTime Rdate = Convert.ToDateTime(row[3]);
                int LoanDay = Rdate.Subtract(Bdate).Days;
                string overdue, fine;
                if (LoanDay > 14)
                {
                    overdue = Convert.ToString(LoanDay - 14);
                    double calculation = Convert.ToDouble(overdue);
                    fine = Convert.ToString(calculation * 0.5);
                    Console.WriteLine("{0} {1,17} {2,13} {3,15}        {4,-10} {5,-13} {6,-5}", row[0], row[1], Bdate.ToString("dd/MM/yyyy"), Rdate.ToString("dd/MM/yyyy"), LoanDay, overdue, ("$" + fine + "0"));
                    File.AppendAllText("overdueinfo.csv", (row[0] + "," + row[1] + "," + overdue + "," + fine + "\n"));
                }
                else
                {
                    overdue = "";
                    fine = "";
                    Console.WriteLine("{0} {1,17} {2,13} {3,15}        {4,-10} {5,-13} {6,-5}", row[0], row[1], Bdate.ToString("dd/MM/yyyy"), Rdate.ToString("dd/MM/yyyy"), LoanDay, overdue, fine);
                }
            }
        }
    }
}
