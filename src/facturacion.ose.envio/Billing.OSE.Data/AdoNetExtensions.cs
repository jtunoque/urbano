using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.OSE.Data
{
    public static class AdoNetExtensions
    {
        public static string GetString(this IDataReader reader,string fieldName)
        {
            var ordinal = reader.GetOrdinal(fieldName);
            return reader.IsDBNull(ordinal) ? null:reader.GetString(ordinal);
        }

        public static DateTime GetDateTime(this IDataReader reader, string fieldName)
        {
            var ordinal = reader.GetOrdinal(fieldName);
            return reader.GetDateTime(ordinal);
        }

        public static DateTime? GetDateTimeNull(this IDataReader reader, string fieldName)
        {
            var ordinal = reader.GetOrdinal(fieldName);
            return reader.IsDBNull(ordinal) ? new Nullable<DateTime>() : reader.GetDateTime(ordinal);
        }

        public static Int32 GetInt32(this IDataReader reader, string fieldName)
        {
            var ordinal = reader.GetOrdinal(fieldName);
            return reader.GetInt32(ordinal);
        }

        public static Int32? GetInt32Null(this IDataReader reader, string fieldName)
        {
            var ordinal = reader.GetOrdinal(fieldName);
            return reader.IsDBNull(ordinal) ? new Nullable<Int32>() : reader.GetInt32(ordinal);
        }
    }
}
