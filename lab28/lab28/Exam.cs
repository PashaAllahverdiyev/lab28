using System.Globalization;

namespace lab28
{
    internal class Exam
    {
        public Student Student { get; set; }
        public int Point { get; set; }
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        List<Exam> exams;
        public Exam CreateExam(Exam exams)
        {
            Student student = new Student();
            Console.WriteLine("Imtahan sayi");
            int exam = int.Parse(Console.ReadLine());
            for(int i = 0; i < exam; i++)
            {
                Console.WriteLine("Adiniz");
                student.Name = Console.ReadLine();
                Console.WriteLine("Qiymetiniz");
                exams.Point = int.Parse(Console.ReadLine());
                Console.WriteLine("Imtahan adi");
                exams.Subject = Console.ReadLine();
                Console.WriteLine("Tarix (GG/AA/YYYY formatinda):");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine("Baslamaa saati (HH:mm formatinda):");
                DateTime time;
                if (DateTime.TryParseExact(Console.ReadLine(), "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out time))
                {
                    DateTime startDate = date.Date + time.TimeOfDay;
                    exams.StartDate = startDate;
                }
                Console.WriteLine("Bitme saati (HH:mm formatinda):");
                DateTime endtime;
                if (DateTime.TryParseExact(Console.ReadLine(), "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out endtime))
                {
                    DateTime endDate = date.Date + endtime.TimeOfDay;
                    exams.EndDate = endDate;
                }
                exams.Student = student;

            }
            return exams;
        }
        public void GetExam(List<Exam> exams)
        {
            foreach (Exam exam in exams)
            {
                TimeSpan duration = exam.EndDate - exam.StartDate;
                if (exam.Point > 50 && duration.TotalHours > 1)
                {
                    Console.WriteLine($"Name: {exam.Student.Name},Fenn: {exam.Subject},Point: {exam.Point} ,Startdate: {exam.StartDate},Enddate: {exam.EndDate}");
                }
            }
        }
    }
}
