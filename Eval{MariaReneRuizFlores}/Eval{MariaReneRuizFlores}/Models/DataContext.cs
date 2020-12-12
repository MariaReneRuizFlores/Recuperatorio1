using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eval_MariaReneRuizFlores_.Models
{
    public class DataContext:DbContext //Heredamos el entityframework
    {
         public DataContext() : base("DefaultConnection") //Constructor
        { }
    }
}