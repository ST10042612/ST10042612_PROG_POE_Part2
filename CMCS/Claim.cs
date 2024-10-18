using Azure;
using Azure.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCS
{
    class Claim : ITableEntity //This class will be used to programatically represent a row or multiple rows from the entries in an Azure table
    {
        public string PartitionKey { get; set; } = "Claims";
        public string RowKey { get; set; } = Guid.NewGuid().ToString();
        public ETag ETag { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public int Claim_ID { get; set; }
        public int Lecturer_ID { get; set; }
        public int Hours_Worked { get; set; }
        public int Hourly_Rate { get; set; }
        public string Claim_Status { get; set; }
    }
}
