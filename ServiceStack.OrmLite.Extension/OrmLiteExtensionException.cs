using System;

namespace ServiceStack.OrmLite.Extension
{
    public class OrmLiteExtensionException : ApplicationException
    {
        public OrmLiteExtensionException(string msg) : base(msg)
        {

        }
    }
}