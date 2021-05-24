using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Gappstone.API.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void ApplySnakeCaseNamingConvention(this ModelBuilder builder)
        {
            foreach (var entity in builder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.GetTableName().ToSnakeCase());
                foreach (var property in entity.GetProperties())
                {
                    var tableIdentifier = StoreObjectIdentifier.Table(entity.GetTableName(), null);
                    property.SetColumnName(property.GetColumnName(tableIdentifier).ToSnakeCase());
                }

                foreach (var key in entity.GetKeys())
                {
                    if (key != null)
                        key.SetName(key.GetName().ToSnakeCase());
                }

                foreach (var foreingKey in entity.GetForeignKeys())
                {
                    if (foreingKey != null)
                        foreingKey.SetConstraintName(foreingKey.GetConstraintName().ToSnakeCase());
                }

                foreach (var index in entity.GetIndexes())
                {
                    if (index != null)
                        index.SetDatabaseName(index.GetDatabaseName().ToSnakeCase());
                }

            }
        }
    }
}
