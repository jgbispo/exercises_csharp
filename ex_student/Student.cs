namespace StudentNoteExercise
{
  class Student
  {
    // Properties
    private string name;
    private double[] notes = new double[3];
    private double leftover = 0;

    // Constructor
    public Student(string name, double[] notes)
    {
      this.name = name;
      this.notes = notes;
    }

    // Methods
    private double GetFinalGrade()
    {
      double sum = 0;
      for (int i = 0; i < notes.Length; i++)
      {
        sum += notes[i];
      }
      return sum;
    }

    public string GetResult()
    {
      if (GetFinalGrade() >= 60)
      {
        this.leftover = GetFinalGrade() - 60;
        return "Approved";
      }
      else
      {
        this.leftover = 60 - GetFinalGrade();
        return "Disapproved";
      }
    }

    // Getters and Setters
    public string GetName()
    {
      return name;
    }

    public void SetName(string name)
    {
      this.name = name;
    }

    public double[] GetNotes()
    {
      return notes;
    }

    public void SetNotes(double[] notes)
    {
      this.notes = notes;
    }

    // ToString
    public override string ToString()
    {
      string result;

      if (GetResult() == "Approved")
      {
        result = "Name: " + name + "\nFinal Grade: " + GetFinalGrade() + "\nResult: " + GetResult();

      }
      else
      {
        result = "Name: " + name + "\nFinal Grade: " + GetFinalGrade() + "\nResult: " + GetResult() + "\nLeftover: " + this.leftover;
      }
      return result;
    }

  }
}