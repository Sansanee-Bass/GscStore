using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace GscStore.Models
{

    public class Review
    {

        public virtual IdentityUser User { get; set; }
        public string Comment { get; set; }
        //public string User { get; set; }


        //public virtual ReviewEntry ReviewEntry { get; set; }



    }

}