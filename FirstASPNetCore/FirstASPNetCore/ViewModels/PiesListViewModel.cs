using System;
using System.Collections.Generic;
using FirstASPNetCore.Models;

namespace FirstASPNetCore.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }

        public string CurrentCategory { get; set; }
    }
}
