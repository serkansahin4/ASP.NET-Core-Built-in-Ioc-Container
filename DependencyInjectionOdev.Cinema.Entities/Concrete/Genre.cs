using DependencyInjectionOdev.Cinema.Entities.ComplexType;
using DependencyInjectionOdev.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Cinema.Entities.Concrete
{
    public class Genre:EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<MovieGenre> MovieGenres { get; set; }

    }
}
