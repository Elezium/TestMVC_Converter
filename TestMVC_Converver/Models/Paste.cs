using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestMVC_Converver.Models
{
    public class Paste
    {

        public int PasteId { get; set; }

        public string Title {get;set;}

        [Required]

        [DataType(DataType.MultilineText)]
        public string Data {get;set;}        
        public int LanguageId { get; set; }        
        public List<Language> Languages {get;set;}      
          
        [Required]
        public bool Private {get;set;}
        public DateTime Expiry { get; set; }
    }
   
}
