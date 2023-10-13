using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Car : BaseEntity
    {
        public string Name { get; set; }
        protected internal string Name1 { get; set; }

        private protected string Name2 { get; set; }

    }

}
