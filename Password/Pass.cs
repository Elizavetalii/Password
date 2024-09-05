using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    public class Pass
    {
        private string password;

        public Pass(string password)
        {
            this.Password = password;
        }

        public string Password
        {
            get => password;
            private set
            {
                password = value;
            }
        }

        public int Score
        {
            get => CalculateScore();
        }

        private int CalculateScore()
        {
            int score = 0;

            // Проверка наличия цифр
            if (password.Any(char.IsDigit)) score++;

            // Проверка наличия строчных букв
            if (password.Any(char.IsLower)) score++;

            // Проверка наличия заглавных букв
            if (password.Any(char.IsUpper)) score++;

            // Проверка наличия специальных символов
            if (password.Any(ch => !char.IsLetterOrDigit(ch))) score++;

            // Проверка на минимальную длину в 10 символов
            if (password.Length > 10) score++;

            return score;
        }
    }
}

