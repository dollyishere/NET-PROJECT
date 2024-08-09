using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

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


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MDI());
        }
    }
}