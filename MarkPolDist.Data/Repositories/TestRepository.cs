using Dapper;
using MarkPolDist.Common.Configs;
using MarkPolDist.Common.Models;
using MarkPolDist.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkPolDist.Data.Repositories
{
    public class TestRepository : MarkPolDistBaseRepository, ITestRepository
    {
        public TestRepository(MarkPolDistSqlConfig config) : base(config)
        {
        }

        public async Task<TestData> GetById(int id)
        {
            TestData result = null;

            using (var conn = base.Connection)
            {
                string sQuery = "SELECT [Id], [Name] FROM [TestData] WHERE [Id]=@id";

                conn.Open();

                result = await conn.QueryFirstOrDefaultAsync<TestData>(sQuery, new { id = id });
            }

            return result;
        }

        public async Task<List<TestData>> GetAllTestDataAsync()
        {
            List<TestData> result = new List<TestData>();

            using (var conn = base.Connection)
            {
                string sQuery = "SELECT [Id], [Name] FROM [TestData]";
                conn.Open();

                var resultIEnumerable = await conn.QueryAsync<TestData>(sQuery).ConfigureAwait(false);

                result = resultIEnumerable.ToList();
            }

            return result;
        }
    }
}
