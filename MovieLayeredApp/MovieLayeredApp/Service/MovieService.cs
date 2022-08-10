using MovieLayeredApp.Model;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MovieLayeredApp.Service
{
    public class MovieService
    {
        private Movie[] _moviArr = new Movie[5];
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
            Stream stream = new FileStream("AddMovies.txt", FileMode.Open, FileAccess.Write);
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
    }
}
