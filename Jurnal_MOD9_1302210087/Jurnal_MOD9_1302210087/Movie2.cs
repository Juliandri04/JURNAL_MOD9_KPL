
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;


namespace Jurnal_MOD9_1302210087
{
    public class Movie2
    {
        public string Title {get; private set;}
        public string Director {get; private set;}

        public List<string> Stars { get; private set;}

        public string Description { get; private set;}

        public Movie2(string Title, string Director, List<string> Stars, string Description) { this.Title = Title; this.Director = Director; this.Stars = Stars; this.Description = Description; }
    }
}