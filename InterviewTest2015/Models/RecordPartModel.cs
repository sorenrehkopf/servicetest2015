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
    public class RecordPartModel
    {
        public string PartNo { get; set; }
        public int Qty { get; set; }
        public bool Hide { get; set; }
        public string ItemType { get; set; }
        public string ServiceType { get; set; }
        public string OrderNo { get; set; }
        public string OrderedOn { get; set; }
        public string OrderedBy { get; set; }
        public string Desc { get; set; }
        public bool Received { get; set; }
        public bool Esc { get; set; }
        public decimal? Price { get; set; }
        public decimal? Cost { get; set; }
        public decimal? ShippingCost { get; set; }
        public RecordReceivingInfo ReceivingInfo { get; set; }
        public RecordShippingInfo ShippingInfo { get; set; }

        public RecordPartModel() { }
    }
}