using MarkPolDist.Common.Configs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MarkPolDist.Data.Repositories
{
    public class MarkPolDistBaseRepository
    {
        protected MarkPolDistSqlConfig Configuration { get; }

        protected IDbConnection Connection { get; }

        public MarkPolDistBaseRepository(MarkPolDistSqlConfig config)
        {
            this.Configuration = config;
            this.Connection = new SqlConnection(this.Configuration.ConnectionString);
        }
    }
}
