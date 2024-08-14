using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Reflection;

namespace MyFirstApp
{
    internal static class Program
    {
        // �θ� Ŭ������ ���� ���� �Ļ�(�ڽ�) Ŭ���� ���
        // ���� �����μ�, �ٸ� ���Ͽ����� ��� �����ϵ��� ��
        // ����� property�� ����
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
                    // Dialog�� ����ڿ��� �����ϰ� �����ϴ� ��
                    // ������ �α����ϵ��� �����ϴ� �����̶�� ���� �� ��?
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