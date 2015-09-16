using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace MCS.Models
{
    public class RecordModel
    {
        const string COLLECTION_NAME = "";
        [BsonId]
        public int Id { get; set; }
        public int ParentId { get; set; }
        public bool Paid { get; set; }
        public string Type { get; set; }
        public bool IsComplete { get; set; }
        public string Requester { get; set; }
        public string WorkOrderNo { get; set; }
        public string ServicePlan { get; set; }
        public string Problem { get; set; }
        public string PO { get; set; }
        public string ClaimNo { get; set; }
        public string PaymentType { get; set; }
        public decimal TaxRate { get; set; }
        public bool Backup { get; set; }
        public string BackupText { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }
        public string ServicePlanExp { get; set; }
        public List<int> Children { get; set; }
        public ContactModel Contact { get; set; }
        public CompleteInfoModel CompleteInfo { get; set; }
        public List<RecordAssetModel> Assets { get; set; }
        public List<RecordPartModel> Parts { get; set; }
        public List<TechNoteModel> TechNotes { get; set; }

        public RecordModel() { }

        public RecordModel FindById(int id)
        {
            MongoServer server = new MongoClient(ConfigurationManager.AppSettings["Mongo"]).GetServer();
            MongoDatabase db = server.GetDatabase("microk12db");
            RecordModel retval = db.GetCollection<RecordModel>(COLLECTION_NAME).AsQueryable<RecordModel>().Where(m => m.Id == id).FirstOrDefault();
            return retval;
        }

    }
}
 