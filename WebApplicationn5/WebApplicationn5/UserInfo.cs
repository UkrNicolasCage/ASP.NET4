namespace WebApplicationn5
{
    public class UserInfo
    {
        public int IdUser { get; set; } = 0;
        public string NameUser { get; set; } = "";
        public string EmailUser { get; set; } = "";

        public override string ToString()
        {
            return $"ID: {IdUser};\nName: {NameUser};\nEmail: {EmailUser}.\n";
        }
    }
}
