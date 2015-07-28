using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace mvcUrlShortning.Models
{
    public class urlDetails
    {

        public int Srno { get; set; }
        public string uniqueID { get; set; }

        [DataType(DataType.Url)]
        public string shortUrl { get; set; }

        [DataType(DataType.Url)]
        [Required(ErrorMessage="Please Enter a url")]
        [RegularExpression(@"^(http|ftp|https|www)://([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?$")]
        [StringLength(10)]
        public string longUrl { get; set; }

        public DateTime date { get; set; }
    }
}