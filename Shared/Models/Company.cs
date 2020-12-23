using MessagePack;
using System.Collections.Generic;

namespace Shared.Models
{
    [MessagePackObject]
    public class Company
    {
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string Name { get; set; }

        [Key(2)]
        public List<User> Users { get; set; } = new List<User>();
    }
}
