using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilderMVC.Domain.Entities
{
    public class Component
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public int Count { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
    }
}
