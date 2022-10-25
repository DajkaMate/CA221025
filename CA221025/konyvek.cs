using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA221025
{
    internal class konyvek
    {   
        private string _author;
        private string _title;
        private int _date;
        private int _price;
        private string _genre;

        public string Author 
        {
            get => _author;
            set 
            {
                if (value.Length < 3)
                {
                    throw new Exception("A szerző neve minimum 3 karakter");
                }
                if (value.Length > 50)
                {
                    throw new Exception("A szerző neve maximum 50 karakter");
                }
                _author = value;
            }           
        }
        public string Title
        {
            get => _title;
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("A könyv címe minimum 3 karakter");
                }
                if (value.Length > 50)
                {
                    throw new Exception("A könyv címe maximum 50 karakter");
                }
                _title = value;
            }
        }
        private int Date
        {
            get => _date;
            set 
            { 
                if (value < 1910)
                { 
                    throw new Exception("A könyv éve minimum 1930 karakter");
                }
                DateTime myDateTime = DateTime.Now;
                int currentYear = myDateTime.Year;
                if (value > currentYear)
                {
                    throw new Exception("A könyv éve max idei év");
                }
                _date = value;
            }
        }
        public int Price
        {
            get => _price;
            set
            {
                if (value > 15000)
                {
                    throw new Exception("A könyv ára maximum 15 ezer ft");
                }
                if (value %5 != 0)
                {
                    throw new Exception("A könyv ára nem oszthatü 5-tel");
                }
                _price = value;

            }
        }
        enum Genre
        {

        }
        public konyvek(string author, string title, int date, int price)
        {
            Author = author;
            Title = title;
            Date = date;
            Price = price;
        }



    }
}
