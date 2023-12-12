using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace PCBuilderMVC.Domain.Entities
{
    public class PC
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        /*public int CreatorId { get; set; }
        public string CreatorName { get; set; }
        public string CreatorLink { get; set; }*/
        public int Cost { get; set; }

        public string _Images { get; set; }

        [NotMapped]
        public byte[][] Images
        {
            get { return _Images == null ? null : JsonSerializer.Deserialize<byte[][]>(_Images); }
            set { _Images = JsonSerializer.Serialize(value); }
        }

        public string _CPU { get; set; }

        [NotMapped]
        public Component CPU
        {
            get { return _CPU == null ? null : JsonSerializer.Deserialize<Component>(_CPU); }
            set { _CPU = JsonSerializer.Serialize(value); }
        }

        public string _GPU { get; set; }

        [NotMapped]
        public Component GPU
        {
            get { return _GPU == null ? null : JsonSerializer.Deserialize<Component>(_GPU); }
            set { _GPU = JsonSerializer.Serialize(value); }
        }

        public string _MotherBoard { get; set; }

        [NotMapped]
        public Component MotherBoard
        {
            get { return _MotherBoard == null ? null : JsonSerializer.Deserialize<Component>(_MotherBoard); }
            set { _MotherBoard = JsonSerializer.Serialize(value); }
        }

        public string _DRAM { get; set; }

        [NotMapped]
        public Component DRAM
        {
            get { return _DRAM == null ? null : JsonSerializer.Deserialize<Component>(_DRAM); }
            set { _DRAM = JsonSerializer.Serialize(value); }
        }

        public string _PowerSupply { get; set; }

        [NotMapped]
        public Component PowerSupply
        {
            get { return _PowerSupply == null ? null : JsonSerializer.Deserialize<Component>(_PowerSupply); }
            set { _PowerSupply = JsonSerializer.Serialize(value); }
        }

        public string _Case { get; set; }

        [NotMapped]
        public Component Case
        {
            get { return _Case == null ? null : JsonSerializer.Deserialize<Component>(_Case); }
            set { _Case = JsonSerializer.Serialize(value); }
        }

        public string _PCColling { get; set; }

        [NotMapped]
        public Component PCColling
        {
            get { return _PCColling == null ? null : JsonSerializer.Deserialize<Component>(_PCColling); }
            set { _PCColling = JsonSerializer.Serialize(value); }
        }

        public string _Storages { get; set; }

        [NotMapped]
        public Component Storages
        {
            get { return _Storages == null ? null : JsonSerializer.Deserialize<Component>(_Storages); }
            set { _Storages = JsonSerializer.Serialize(value); }
        }

        public string _Fans { get; set; }

        [NotMapped]
        public Component Fans
        {
            get { return _Fans == null ? null : JsonSerializer.Deserialize<Component>(_Fans); }
            set { _Fans = JsonSerializer.Serialize(value); }
        }
    }
}
