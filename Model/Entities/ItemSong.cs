using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiMusicList.Model.Entities
{
    [Table("ItemSong")]
    public class ItemSong
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Singer { get; set; }

        public string Path { get; set; }

        public string Image { get; set; }
    }
}