namespace PatikaCodeFirstDb.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        //bir kullanıcının birden fazla postu olabilir
        public List<Post> Posts { get; set; }
    }
}
