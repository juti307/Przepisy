using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt3.Models
{
    public class Recipe
    {
        
        public int Id { get; set; }
       [Required(ErrorMessage ="Pole jest obowiązkowe")]
        [Display(Name = "Nazwa: ")]
        public string Name { get; set; }
        [MaxLength(300)]
        [Display(Name = "Składniki:")]
        public string Ingredients { get; set; }
        [MaxLength(1000)]
        [Display(Name = "Opis: ")]
        public string Description { get; set; }
        [Display(Name ="Data: ")]
        public DateTime Date { get; set; }
        [Display(Name="Użytkownik: ")]
        public string User { get; set; }
        [Range(0, 2)]
  
        public int Like { get; set; }
        [Display(Name = "Polubienia: ")]
        public int Votes { get; set; }
        [Range(0, 2)]
        public int VoteAdded { get; set; }

    }
}
