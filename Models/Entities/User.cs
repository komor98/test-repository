﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestGit1.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
