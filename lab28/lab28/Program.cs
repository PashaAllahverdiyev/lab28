using lab28;

internal class Program
{
    static void Main()
    {
        List<Exam> exams = new List<Exam>();
        Exam exam = new Exam();
        exams.Add(exam.CreateExam(exam));
        foreach (var item in exams)
        {
            item.GetExam(exams);
        }
    }
}