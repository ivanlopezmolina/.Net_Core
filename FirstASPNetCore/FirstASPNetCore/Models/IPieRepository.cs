using System.Collections.Generic;

namespace FirstASPNetCore.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> Pies { get; }
        IEnumerable<Pie> PiesOfWeek { get; }

        Pie GetPieById(int pieId);
    }
}