﻿namespace Use_Case_23.Models
{
    public class Credit
    {
        public int Id { get; set; }
        public int TitleId { get; set; }
        public string? RealName { get; set; }
        public string? CharacterName { get; set; }
        public Role? Role { get; set; }

    }
}
