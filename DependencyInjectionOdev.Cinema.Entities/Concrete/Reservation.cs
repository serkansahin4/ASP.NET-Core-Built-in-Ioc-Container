using DependencyInjectionOdev.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DependencyInjectionOdev.Cinema.Entities.Concrete
{
    public class Reservation : EntityBase 
    {
        public int MovieId { get; set; }
        public string UserId { get; set; }

        public virtual Movie Movie { get; set; }
        public IdentityUser User { get; set; }
    }
}
