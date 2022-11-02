using System;

namespace StudentNoteExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notes = new double[3];
            Console.Write("Enter the student's name: ");
            string name = Console.ReadLine()!;
            for (int i = 0; i < notes.Length; i++)
            {
                Console.Write("Enter the note " + (i + 1) + ": ");
                notes[i] = double.Parse(Console.ReadLine()!);
            }
            Student student = new Student(name, notes);
            Console.WriteLine(student.ToString());
        }
    }
}