using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;

namespace EntityFrameworkCore.Attributes
{
    public static class CompositeKeyExtension
    {
        public static void BindCompositeKey(this ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType e in modelBuilder.Model.GetEntityTypes())
            {
                IEnumerable<IMutableProperty> cpkProps =
                    e.GetProperties()
                    .Where(p => p.PropertyInfo
                    .GetCustomAttribute<CompositeKeyAttribute>() != null);

                if (cpkProps.Any())
                {
                    ReadOnlyCollection<IMutableProperty> readOnlyList =
                        new ReadOnlyCollection<IMutableProperty>(cpkProps.ToList());

                    e.SetPrimaryKey(readOnlyList);
                }
            }
        }
    }
}