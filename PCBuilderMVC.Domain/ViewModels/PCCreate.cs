using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using PCBuilderMVC.Domain.Entities;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilderMVC.Domain.ViewModels
{
    public class PCCreate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public IFormFile Images;
        public int Cost { get; set; }
        public Component CPU { get; set; }
        public Component GPU { get; set; }
        public Component MotherBoard { get; set; }
        public Component DRAM { get; set; }
        public Component PowerSupply { get; set; }
        public Component Case { get; set; }
        public Component PCColling { get; set; }
        public Component Storages { get; set; }
        public Component Fans { get; set; }
    }
}
