using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pacman.Models
{
    public class PlayerInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public uint IdGame { get; set; }
        public int Hp { get; set; }
        public uint Score { get; set; }
        public uint PosX { get; set; }
        public uint PosY { get; set; }
        public int WeaponType { get; set; }
    }
}
