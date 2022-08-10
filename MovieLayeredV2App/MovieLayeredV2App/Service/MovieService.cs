using MovieLayeredV2App.Model;
using System.Configuration;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace MovieLayeredV2App.Service
{
    public class MovieService
    {
        private static int storeSize = Convert.ToInt32(ConfigurationSettings.AppSettings["MAX_STORE_SIZE"]);
        private Movie[] _moviArr = new Movie[storeSize];
        private string csvFilePath = ConfigurationSettings.AppSettings["EXPORT_CSV_PATH"];
        public MovieService()
        {
            populateStore();
        }
        private void populateStore()
        {
            string filePath = "AddMovies.txt";
            if (File.Exists(filePath))
            {
                Stream stream = new FileStream("AddMovies.txt", FileMode.Open, FileAccess.Read);
                IFormatter formatter = new BinaryFormatter();
                this._moviArr = (Movie[])formatter.Deserialize(stream);
                stream.Close();
            }  
        }

        public void Add(Movie newMovie)
        {
            _moviArr[GetCount()] = newMovie;
            SaveStore();
            Console.WriteLine("Movie Added Successfully !!");
        }

        public Movie[] Get()
        {
            return _moviArr;
        }
        public void ClearAll()
        {
            this._moviArr = new Movie[5];
            SaveStore();
        }

        private void SaveStore()
        {
            Stream stream = new FileStream("AddMovies.txt", FileMode.Create, FileAccess.Write);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, _moviArr);
            stream.Close();
        }

        public int GetCount()
        {
            int pos = 0;
            for (int i = 0; i < _moviArr.Length; i++)
            {
                if (_moviArr[i] == null)
                {
                    break;
                }
                pos = i + 1;
            }

            return pos;
        }
        public void ExportStoreMovieFile()
        {
            Stream stream = new FileStream(csvFilePath, FileMode.Create, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(stream))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("ID,NAME,GENRE,YEAR");
                for (int i = 0; i < GetCount(); i++)
                {
                    sb.AppendLine(string.Format("{0},{1},{2},{3}", _moviArr[i].Id, _moviArr[i].Name, _moviArr[i].Genre, _moviArr[i].Year));
                }
                sw.WriteLine(sb.ToString());
            }
        }
        public void Search(string srch)
        {
            for (int i = 0; i < GetCount(); i++)
            {
                if (_moviArr[i].Name.Contains(srch))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("-----------------------------\n"
                        +_moviArr[i].Id + "|" + _moviArr[i].Name + "|" + _moviArr[i].Genre + "|" + _moviArr[i].Year+ 
                        "\n-----------------------------");
                    if (_moviArr[i].Name.Equals(srch))
                    {
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine(_moviArr[i].Id + "|" + _moviArr[i].Name + "|" + _moviArr[i].Genre + "|" + _moviArr[i].Year);
                        Console.WriteLine("-----------------------------\n");
                        return;
                    }
                    Console.WriteLine(sb);
                }
            }
        }
    }
}
