using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConstructionLab5.Models
{
    public class Tariff
    {
        
            public int Id { get; set; }
            public string Title { get; set; }
            public string Descr { get; set; }
            public int PricePerMounth { get; set; }
      
    }
}