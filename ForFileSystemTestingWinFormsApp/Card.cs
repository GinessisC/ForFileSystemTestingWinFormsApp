using ForFileSystemTestingWinFormsApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForFileSystemTestingWinFormsApp
{
    class Card
    {

        public static readonly Dictionary<string, string> cardNameDateKeyValuePair = new Dictionary<string, string>() { };
        static readonly Dictionary<string, string> keyValuePairsForDescription = new Dictionary<string, string>();
        private static string GetMainPath()
        {
            return KatalogInfo.GetPath(StartForm.folderBrowserDialog1);

        }
        public static List<string> pathesForImage = new List<string>()
        {
            $"{GetMainPath()}\\CardsTxtInfo\\крести (2).txt",
            $"{GetMainPath()}\\CardsTxtInfo\\пика.txt",
            $"{GetMainPath()}\\CardsTxtInfo\\бубны.txt",
            $"{GetMainPath()}\\CardsTxtInfo\\черви (2).txt"
        };
        public static List<string> pathesForDescription = new List<string>()
        {
            //"D:\\Projects\\ForFileSystemTestingWinFormsApp\\CardsTxtInfo\\бубны (2).txt\\крести (2).txt",
            //"D:\\Projects\\ForFileSystemTestingWinFormsApp\\CardsTxtInfo\\пика.txt",
            //"D:\\Projects\\ForFileSystemTestingWinFormsApp\\CardsTxtInfo\\бубны.txt",
            //"D:\\Projects\\ForFileSystemTestingWinFormsApp\\CardsTxtInfo\\черви (2).txt"


            $"{GetMainPath()}\\CardsTxtInfo\\черви.txt",
            $"{GetMainPath()}\\CardsTxtInfo\\пика (2).txt",
            $"{GetMainPath()}\\CardsTxtInfo\\крести.txt",
            $"{GetMainPath()}\\CardsTxtInfo\\бубны (2).txt"
        };

        private void DictionaryDataFromFileFillerForImage(string path)
        {
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(path))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var t = line.Split('-');
                    if (t.Length > 1)
                    {
                        cardNameDateKeyValuePair.Add(t[0], t[1]);
                        //Console.WriteLine(t[1]); //values
                    }
                }
            }
        }
        private void DictionaryDataFromFileFillerForDiscription(string path)
        {
            const Int32 BufferSize = 128;

            using (var fileStream = File.OpenRead(path))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    List<string> list = line.Split('-').ToList();

                    for (int i = 0; i < list.Count; i++)
                    {

                        if (i % 2 != 0)
                        {
                            list.Remove(list[i]);
                        }
                        else
                        {
                            if (line.Length > 1)
                            {
                                keyValuePairsForDescription.Add(list[i].Split('(')[0], list[i].Split('(')[1].Split(')')[0]);

                            }

                        }
                    }
                }
            }
        }
        private string ChangeCardNameToDisplay()
        {
            string cardNameToDisplay = CardName;

            if (CardName.Contains('Т'))
                cardNameToDisplay = CardName.Replace("Т", "Туз");
            if (CardName.Contains('К'))
            {
                cardNameToDisplay = CardName.Replace("К", "Кароль");
            }
            if (CardName.Contains('В'))
            {
                cardNameToDisplay = CardName.Replace("В", "Валет");
            }
            if (CardName.Contains('Д'))
            {
                cardNameToDisplay = CardName.Replace("Д", "Дама");
            }
            
            return cardNameToDisplay;

        }

        public string CardNameToDisplay { get { return ChangeCardNameToDisplay(); } set { } }
        public string CardName
        {
            get 
            {
                string result = "";
                foreach (var dictionary in cardNameDateKeyValuePair)
                {
                    if (Day < 9)
                    {
                        if (dictionary.Value.Contains($" {Day} {Month}"))
                        {
                            result = dictionary.Key;
                        }
                    }
                    else
                    {
                        if (dictionary.Value.Contains($"{Day} {Month}"))
                        {
                            result = dictionary.Key;
                        }
                    }
                    
                }
                return result;

            }
            set { }
        }
        public string Description
        {
            get
            {
                string description = "";
                foreach (var item in keyValuePairsForDescription)
                {
                    if (item.Key.Contains(CardName))
                    {
                        description = item.Value;
                    }
                }
                return description;
            }
            private set { }
        }
        public int Day { get; set; }
        public string Month { get; set; }
        public Card(int days, string month)
        {
            
            if (cardNameDateKeyValuePair.Count == 0)
            {
                for(int i = 0; i < pathesForImage.Count; i++)
                {
                    DictionaryDataFromFileFillerForImage(pathesForImage[i]);
                }
            }
            if (keyValuePairsForDescription.Count == 0)
            {
                for (int i = 0; i < pathesForDescription.Count; i++)
                {
                    DictionaryDataFromFileFillerForDiscription(pathesForDescription[i]);
                }
            }
            
            Day = days;
            ChangeMonthValue(month);
        }
        private void ChangeMonthValue(string customerMonth)
        {

            switch (customerMonth)
            {
                case "январь":
                    Month = "январ";
                    break;
                case "февраль":
                    Month = "феврал";
                    break;
                case "март":
                    Month = "март";
                    break;
                case "апрель":
                    Month = "апрел";
                    break;
                case "май":
                    Month = "мая";
                    break;
                case "июнь":
                    Month = "июн";
                    break;
                case "июль":
                    Month = "июл";
                    break;
                case "август":
                    Month = "авгус";
                    break;
                case "сентябрь":
                    Month = "сентябр";
                    break;
                case "октябрь":
                    Month = "октябр";
                    break;
                case "ноябрь":
                    Month = "ноябр";
                    break;
                case "декабрь":
                    Month = "декабр";
                    break;
                
                
            }
        }
    }
}
