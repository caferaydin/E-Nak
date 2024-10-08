﻿namespace E_Nak.Domain.Common
{
    public class BaseEntity <Val>
    {
        public Val Id { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
