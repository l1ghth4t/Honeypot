using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Configuration;

namespace HackerTrap
{
    /// <summary>
    /// Форма, запрашивающая пароль, расшифровывающая конфигурационный файл и запускающая главную форму
    /// </summary>
    /// 
    public partial class Auth : Form
    {
        /// <summary>
        /// Конструктор формы. Если файл конфигурации не зашифрован, то загружаем главную форму
        /// </summary>
        /// 
        public Auth()
        {
            InitializeComponent();

            if (File.Exists(ConfigName))
                if (!IsConfigEncrypted())
                    Application.Run(new MainForm());

            else
                throw new Exception("Что-то пошло не так: отсутствует файл конфигурации. Программа закрывается аварийно.");
        }

        /// <summary>
        /// Как называется файл конфигурации сборки
        /// </summary>
        /// 
        private static string ConfigName = "HackerTrap.dll.config";

        /// <summary>
        /// Проверяет, зашифрован ли файл конфигурации
        /// </summary>
        /// <returns>Значение типа bool, определяющее, читаем ли файл конфигурации</returns>
        /// 
        private static bool IsConfigEncrypted()
        {
            if (ConfigurationManager.AppSettings["Encrypted"] == "No")
                return false;

            return true;
        }

        /// <summary>
        /// Метод, расшифровывающий файл конфигурации
        /// </summary>
        /// <param name="Pass">Пароль</param>
        /// 
        private static void ConfigDecrypting(string Password)
        {
            if (Password == null)
                throw new ArgumentNullException("Password");

            
        }

        /// <summary>
        /// Метод, вычисляющий значение хеш-функции SHA-512 от строки
        /// </summary>
        /// <param name="Input">Строка, для которой вычисляем хеш</param>
        /// <returns>Хеш</returns>
        /// 
        private static byte[] CalculateSHA512(string Input)
        {
            var encoding = new System.Text.ASCIIEncoding();

            byte[] InputBytes = encoding.GetBytes(Input);

            using (var sha512 = new SHA512Managed())
            {
                byte[] hash = sha512.ComputeHash(InputBytes);

                return hash;
            }
        }
    }
}
