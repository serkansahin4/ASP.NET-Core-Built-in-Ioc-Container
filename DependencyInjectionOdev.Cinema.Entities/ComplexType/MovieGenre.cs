using DependencyInjectionOdev.Cinema.Entities.Concrete;
using DependencyInjectionOdev.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Cinema.Entities.ComplexType
{
    public class MovieGenre:EntityBase
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
