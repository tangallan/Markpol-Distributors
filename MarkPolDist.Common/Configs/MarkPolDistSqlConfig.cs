using System;
using System.Collections.Generic;
using System.Text;

namespace MarkPolDist.Common.Configs
{
    public class MarkPolDistSqlConfig
    {
        public MarkPolDistSqlConfig(string connString)
        {
            this.ConnectionString = connString;
        }

        public string ConnectionString { get; }
    }
}
