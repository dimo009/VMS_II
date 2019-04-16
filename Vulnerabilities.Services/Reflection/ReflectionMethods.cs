using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Vulnerabilities.Services.Reflection
{
    public class ReflectionMethods
    {
        public List<TypeInfo> GetDBContextTypes()
        {
            var dbContextTypes = Assembly.GetExecutingAssembly()
                             .DefinedTypes.Where(t => typeof(DbContext).IsAssignableFrom(t))
                             .ToList();

            return dbContextTypes;
            
        }

        public List<TypeInfo> GetDbContextNames()
        {
            var ContextName = Assembly.GetExecutingAssembly()
            .DefinedTypes
            .Where(x => x.BaseType?.Name == "DbContext").ToList();

            return ContextName;
        }
        
    }
}
