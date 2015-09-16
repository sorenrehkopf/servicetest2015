using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MCS.Models
{
    public class TechNoteModel
    {
        public string Date { get; set; }
        public string DateModified { get; set; }
        public string Tech { get; set; }
        public string Note { get; set; }

    }
}