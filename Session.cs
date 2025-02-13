public class Session
{
    private static Session _instance;
    public static Session CurrentSession
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Session();
            }
            return _instance;
        }
    }

    private Session() { }

    public string Email { get; set; }
    public int StudentID { get; set; }
}
