using Solid.Core.Entities;

namespace Library.Entities
{
    public class LendPostModel
    {
        public int CustomerId { get; set; }
        
        public DateTime date { get; set; }

        public int Count_Book { get; set; }
    }
}
