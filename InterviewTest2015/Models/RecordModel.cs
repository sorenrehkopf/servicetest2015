using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Threading.Tasks;

namespace MCS.Models
{
    public class RecordModel
    {
        const string COLLECTION_NAME = "records_miker";
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

        public static async Task<RecordModel> FindById(int id)
        {
            RecordModel retval;
            try
            {
                var db = new MongoClient(ConfigurationManager.AppSettings["Mongo"]).GetDatabase("interview").GetCollection<RecordModel>("records_miker");
                retval = await db.Find(m => m.Id == id).SingleOrDefaultAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Something went wrong: {0}", ex.Message));
            }
            return retval;
        }

        public static async Task<IEnumerable<RecordModel>> WaitingForParts()
        {
            List<RecordModel> retval = new List<RecordModel>();
            try
            {
                var db = new MongoClient(ConfigurationManager.AppSettings["Mongo"]).GetDatabase("interview").GetCollection<RecordModel>("records_miker");
                retval = await db.Find(m => m.Id != 0).ToListAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Something went wrong: {0}", ex.Message));
            }

            return retval;
        }

        public static async Task<Boolean> Update(RecordModel model)
        {
            try
            {
                var db = new MongoClient(ConfigurationManager.AppSettings["Mongo"]).GetDatabase("interview").GetCollection<RecordModel>("records_miker");
                await db.ReplaceOneAsync(m => m.Id == model.Id, model);

            }
            catch
            {
                return false;
            }
            return true;
        }

    }
}
