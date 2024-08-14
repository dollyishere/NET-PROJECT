using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Reflection;

namespace MyFirstApp
{
    internal static class Program
    {
        // 부모 클래스로 변수 만들어서 파생(자식) 클래스 담기
        // 전역 변수로서, 다른 파일에서도 사용 가능하도록 함
        // 참고로 property에 속함
        public static IConfiguration? Configuration { get; set; }
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // get config

            // make builder
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            // start build
            Configuration = builder.Build();

            bool createNew = false;
            Mutex mutex = new Mutex(true, Assembly.GetEntryAssembly().FullName, out createNew);
            if (createNew)
            {
                ApplicationConfiguration.Initialize();
                using (LoginForm login = new LoginForm())
                {
                    // Dialog는 사용자에게 강력하게 권장하는 것
                    // 무조건 로그인하도록 강요하는 느낌이라고 보면 될 듯?
                    login.ShowDialog();
                    if (login.isAuthenticated == true)
                    {
                        Application.Run(new MDI());
                    }
                }
            } else
            {
                MessageBox.Show("Another instance of the application is already running");
            }


/*            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Application.Run(new MDI());
            Application.Run(new LoginForm());*/
        }
    }
}