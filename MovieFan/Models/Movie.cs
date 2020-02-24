using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFan.Models
{
    public class Movie
    {
        private int id;
        private string title;
        private string description;

        public Movie(int id, string title, string description)
        {
            this.id = id;
            this.title = title;
            this.description = description;
        }

        public int Id { get => this.id; }
        public string Title { get => this.title; }
        public string Description { get => this.description; }
    }
}
