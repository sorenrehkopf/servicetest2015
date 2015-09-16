using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MCS.Models
{
    public class ContactModel
    {
        public string Id { get; set; }
        public Int32 OldId { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public String NameFirst { get; set; }
        public string NameLast { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone1Type { get; set; }
        public string Phone2 { get; set; }
        public string Phone2Type { get; set; }
        public string Type { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }
        public string Password { get; set; }

        public ContactModel()
        {
            
        }

    }
}