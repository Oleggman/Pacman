using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pacman.Models
{
    public class TextureInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public uint Id { get; set; }
        public uint Level { get; set; }
        public uint PosX { get; set; }
        public uint PosY { get; set; }
        public uint Width { get; set; }
        public uint Height { get; set; }
        public uint Type { get; set; }
    }
}
