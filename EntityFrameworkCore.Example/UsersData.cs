using EntityFrameworkCore.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCore.Example
{
    public class UsersData
    {
        [CompositeKey]    
        public Guid UserId{ get; set; }

        [CompositeKey]
        [Required]
        public string DataId { get; set; }
    }
}