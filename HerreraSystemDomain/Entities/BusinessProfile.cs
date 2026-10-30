using System;
using System.Collections.Generic;
using System.Text;

namespace HerreraSystem.Domain.Entities
{
    public class BusinessProfile
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Ruc { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? LogoUrl { get; set; }
    }
}
