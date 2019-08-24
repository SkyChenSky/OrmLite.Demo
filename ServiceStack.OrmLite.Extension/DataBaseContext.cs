using System;
using System.Data;

namespace ServiceStack.OrmLite.Extension
{
    public abstract class DataBaseContext:IDisposable
    {
        private readonly IDbConnection _db;
        private static string _dbConnectionString;
        private static IOrmLiteDialectProvider _provider;

        protected DataBaseContext()
        {
            if(string.IsNullOrEmpty(_dbConnectionString) || _provider == null)
                throw new OrmLiteExtensionException("please init first");
            
            var dbFactory = new OrmLiteConnectionFactory(_dbConnectionString,_provider);
            _db = dbFactory.Open();
        }

        public static void Init(DataBaseContextOption option)
        {
            _dbConnectionString = option.DbConnectionString;
            _provider = option.Provider;
        }
        
        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}