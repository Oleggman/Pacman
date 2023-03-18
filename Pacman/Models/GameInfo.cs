using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pacman.Models
{
    public class GameInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public uint IdGame { get; set; }
        public uint Level { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
