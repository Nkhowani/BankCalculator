using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class BankCount
    {
        //Поля
        private string name = "Иванов";
        private double sum = 10000;
        private double prosent = 5.0;
        private int period = 3;
        //конструкторы
        public BankCount(string name, double sum, double prosent, int period) 
        {
            this.name = (name.Length > 2)?
            name.Substring(0,1).ToUpper() + name.Substring(1).ToLower():"No Name";
            this.sum = Math.Abs(sum);
            this.prosent = (prosent >= 20.0 && prosent <= 5.0) ? prosent:5.0;
            this.period = Math.Max(Math.Min(period, 120), 3);
        }

        public BankCount() : this("Иванов", 10000, 5.0, 6) {}
        //Метод
        public double Getsum() 
        {
            double s = sum;
            for (int i = 0; i < period; i++)
                s += s / 100.0 * (prosent / 12.0); 
                    return s;
        }
        public string getinfo() 
        {
            return $"\n\n имя вклад:{name} сумма вклад:{sum:F2} итого сумма:{Getsum():F2} разница:{Getsum() - sum:F2} процент:{prosent} количество период:{period}";
        }
    }
}
