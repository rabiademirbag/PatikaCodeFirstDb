﻿namespace PatikaCodeFirstDb.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }

        //navigation property
        public User User { get; set; }
    }
}
