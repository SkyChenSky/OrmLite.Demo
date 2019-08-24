using System;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceStack.OrmLite.Extension
{
    public static class Extension
    {
        public static void AddOrmLiteDataBaseContext<T>(this IServiceCollection serviceCollection,Action<DataBaseContextOption> option) where T : DataBaseContext
        {
            var dataBaseContextOption = new DataBaseContextOption();

            option?.Invoke(dataBaseContextOption);

            DataBaseContext.Init(dataBaseContextOption);
            
            serviceCollection.AddScoped<T>();
        }
    }
}