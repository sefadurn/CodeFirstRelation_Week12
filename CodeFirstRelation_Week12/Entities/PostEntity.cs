namespace CodeFirstRelation_Week12.Entities
{
    public class PostEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }  // Foreign Key


        // Relational Property

        public UserEntity User { get; set; }  // Post -> User ilişkisi (Her post bir kullanıcıya aittir)
    }
} 
