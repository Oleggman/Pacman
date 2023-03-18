using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pacman.Models
{
    public class EnemyInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public uint Id { get; set; }
        public int Level { get; set; }
        public int MoveType { get; set; }
        public int Hp { get; set; }
        public bool IsInvunerable { get; set; } = false;
        public int Damage { get; set; }
        public int Speed { get; set; }
    }
}
