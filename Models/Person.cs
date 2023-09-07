using System.ComponentModel.DataAnnotations;

namespace Aug31_Ver1_WebAp.Models
{
    public class Person
    {
        public Person()
        {

        }

        [Key]
        public int id { get; set; }

        public string? firstname { get; set; }

        public string? lastname { get; set; }

        public int? age { get; set; }

        public string? gender { get; set; }
    }
}

