using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MCS.Models
{
    public class RecordAssetModel
    {
        public string AssetTag { get; set; }
        public string SerialNo { get; set; }
        public string ModelName { get; set; }
        public string ModelNo { get; set; }
        public string Brand { get; set; }


        public RecordAssetModel() { }
    }
}