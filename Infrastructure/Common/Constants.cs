
namespace Infrastructure.Common
{
    public class Constants
    {
        public const string DEFAULT_PASSWORD = "NeedReset%123";

        public const string STATUS_OPEN = "OPEN";
        public const string STATUS_NEW = "NEW";
        public const string STATUS_CLOSED = "CLOSED";


        public const string ROLE_ADMIN_ID = "14ccdd59-817a-48ff-b09d-15a3d8defa6a";
        public const string ROLE_USER_ID = "b3bd0df7-a483-49e2-9c5f-6a381ba150ec";
        public const string ROLE_ADMIN = "Admin";
        public const string ROLE_USER = "User";

        public static readonly Dictionary<string, string> UserRoles =
            new Dictionary<string, string>
        {
                {ROLE_ADMIN_ID, ROLE_ADMIN },
                {ROLE_USER_ID, ROLE_USER }
        };
    }
}
