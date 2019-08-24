namespace ServiceStack.OrmLite.Extension
{
    public class DataBaseContextOption
    {
        public string DbConnectionString { get; set; }
        
        public IOrmLiteDialectProvider Provider { get; set; }
    }
}