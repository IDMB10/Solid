using SingleResponsability;
public static class Program
{
    private static void Main()
    {
        StudentRepository studentRepository = new();
        ExportHelper exportHelper = new();
        exportHelper.ExportStudents(studentRepository.GetAll());
        Console.WriteLine("Proceso Completado");
    }
}