using AuditappNew.Data;
using AuditappNew.Services;
using Microsoft.Extensions.Logging;
using System.IO;

namespace AuditappNew
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp ( )
        {
            var builder = MauiApp.CreateBuilder ( );
            builder
                .UseMauiApp<App> ( )
                .ConfigureFonts ( fonts =>
                {
                    fonts.AddFont ( "OpenSans-Regular.ttf","OpenSansRegular" );
                    fonts.AddFont ( "OpenSans-Semibold.ttf","OpenSansSemibold" );
                } );

            string dbPath = Path.Combine ( FileSystem.AppDataDirectory,"auditapp.db" );
            builder.Services.AddSingleton<AppDbContext> ( s => new AppDbContext ( dbPath ) );
            builder.Services.AddTransient<UserService> ( );
            builder.Services.AddTransient<MainPage> ( );

#if DEBUG
            builder.Logging.AddDebug ( );
#endif

            return builder.Build ( );
        }
    }
}