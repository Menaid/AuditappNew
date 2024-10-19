using AuditappNew.Models;
using AuditappNew.Services;

namespace AuditappNew
{
    public partial class MainPage:ContentPage
    {
        private readonly UserService _userService;

        public MainPage ( UserService userService )
        {
            InitializeComponent ( );
            _userService = userService;
            LoadUsers ( );
        }

        private async void OnAddUserClicked ( object sender,EventArgs e )
        {
            if ( string.IsNullOrWhiteSpace ( UsernameEntry.Text ) ||
                string.IsNullOrWhiteSpace ( EmailEntry.Text ) ||
                string.IsNullOrWhiteSpace ( PasswordEntry.Text ) )
            {
                await DisplayAlert ( "Error","Please fill in all fields","OK" );
                return;
            }

            var user = new User
            {
                Username = UsernameEntry.Text,
                Email = EmailEntry.Text,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword ( PasswordEntry.Text ),
                CreatedAt = DateTime.UtcNow
            };

            await _userService.CreateUserAsync ( user );
            await LoadUsers ( );

            // Clear entries
            UsernameEntry.Text = EmailEntry.Text = PasswordEntry.Text = string.Empty;

            await DisplayAlert ( "Success","User added successfully","OK" );
        }

        private async Task LoadUsers ( )
        {
            var users = await _userService.GetAllUsersAsync ( );
            UserList.ItemsSource = users;
        }
    }
}