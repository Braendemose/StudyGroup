﻿namespace Common.Models
{
    public class Episode
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Droid>? Droids { get; set; }
    }
}
