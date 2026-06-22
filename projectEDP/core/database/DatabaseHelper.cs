using System;
using Npgsql;

namespace projectEDP.core.database
{
    public static class DatabaseHelper
    {
        private static readonly string _connectionString =
            "Host=aws-1-ap-northeast-1.pooler.supabase.com;Database=postgres;Username=postgres.cveiuqrnmdidjdjknnwe;Password=pEDPpasswwrd;SSL Mode=Require;Trust Server Certificate=true";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}