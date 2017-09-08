using BestOil.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil.Repository
{
    public static class FuelRepository
    {
        public static List<FuellInfo> GetFuels()
        {
            return new List<FuellInfo>()
            {
                new FuellInfo(){Name="АИ-92", Price=1.320m},
                new FuellInfo(){Name="АИ-95", Price=1.44m},
                new FuellInfo(){Name="АИ-98", Price=1.56m},
            };
        }
    }
}
