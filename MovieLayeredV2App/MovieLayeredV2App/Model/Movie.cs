using System;
namespace MovieLayeredV2App.Model
{
    [Serializable]
    public class Movie
    {
        private int _id;
        private string _name;
        private string _genre;
        private string _year;

        public Movie(int id ,string name, string genre, string year)
        {
            _id = id;
            _name = name;
            _genre = genre;
            _year = year;
        }
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public string Genre { get { return _genre; } }
        public string Year { get { return _year; } }
    }
}
