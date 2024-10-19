using AuditappNew.Services;

namespace AuditappNew
{
    public partial class App:Application
    {
        public App ( UserService userService )
        {
            InitializeComponent ( );
            MainPage = new NavigationPage ( new MainPage ( userService ) );
        }
    }
}