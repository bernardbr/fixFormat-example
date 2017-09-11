using System;
using System.Collections.Generic;

namespace example
{
    public class Class1
    {
        /// <summary>
        /// My summary.
        /// </summary>
        /// <returns>The SQL Select.</returns>
        public static string GetSelectScript()
        {
            var tableName = "Table";
            var fields = new List<string>(3);
            fields.Add("first");
            fields.Add("second");
            fields.Add("last");

            var keyName = "key_name";
            var ids = new List<string>(1);
            ids.Add($"{keyName} = @{keyName}");

            return $@"
                SELECT {string.Join(", ", fields)}
                FROM {tableName}
                WHERE {string.Join(" AND ", ids)}
            ";
        }
    }
}