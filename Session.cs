public class Session
{
    public static Session? CurrentSession { get; private set; }

    public static void CreateNew(string email, int studentID)
    {
        CurrentSession = new Session(email, studentID);
    }   

    private Session(string email, int studentID)
    {
        Email = email;
        StudentID = studentID;
    }

    public string Email { get; set; }
    public int StudentID { get; set; }
}


