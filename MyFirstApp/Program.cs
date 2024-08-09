using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

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


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MDI());
        }
    }
}