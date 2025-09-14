namespace CodeFirstRelation_Week12.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }


        // Relational Property
        //Bir kullanıcı birden çok posta sahip olabilir (1 -> N ilişkisi)
        public List<PostEntity> Posts { get; set; }
    }
}
