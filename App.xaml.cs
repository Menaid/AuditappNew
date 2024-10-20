using AuditappNew.Services;

namespace AuditappNew
{
    public partial class App:Application
    {
        public static UserService UserService { get; private set; }

        public App ( UserService userService )
        {
            InitializeComponent ( );
            UserService = userService;
            MainPage = new AppShell ( );
        }
    }
}