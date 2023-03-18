using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pacman.Models
{
    public class WeaponInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public uint Id { get; set; }
        public uint Damage { get; set; }
        public uint DamageRadius { get; set; }
        public uint Bullets { get; set; }
        public uint Timeout { get; set; }
        public string Name { get; set; }
        public uint DamageSpeedMsec { get; set; }
    }
}
