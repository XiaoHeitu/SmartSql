using SmartSql.DbSession;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Data;

namespace SmartSql.Bulk.Oracle
{
    public class BulkInsert : AbstractBulkInsert
    {
        public BulkInsert(IDbSession dbSession) : base(dbSession)
        {

        }

        public override void Insert()
        {
            DbSession.Open();
            InsertImpl();
        }

        private void InsertImpl()
        {
            
        }

        public override async Task InsertAsync()
        {
            await DbSession.OpenAsync();
            InsertImpl();
        }
    }
}
