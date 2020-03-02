using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieFan.Models
{
    public partial class Users
    {

        [NotMapped]
        public bool IsAdministrator
        {
            get => Convert.ToBoolean(this.IsAdmin);
        }
    }
}
