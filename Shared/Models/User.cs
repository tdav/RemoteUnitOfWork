using MessagePack;

namespace Shared.Models
{
    [MessagePackObject]
    public class User
    {
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string Name { get; set; }
        [Key(2)]
        public int Age { get; set; }

        [Key(3)]
        public int CompanyId { get; set; }
        [Key(4)]
        public Company Company { get; set; }
    }
}
