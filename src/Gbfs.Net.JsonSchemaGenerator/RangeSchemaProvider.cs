using System.ComponentModel.DataAnnotations;
using System.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

namespace Gbfs.Net.JsonSchemaGenerator
{
    public class RangeSchemaProvider : JSchemaGenerationProvider
    {
        public override JSchema GetSchema(JSchemaTypeGenerationContext context)
        {
            var rangeAttribute = context.MemberProperty?.AttributeProvider.GetAttributes(typeof(RangeAttribute), true)
                .Cast<RangeAttribute>()
                .FirstOrDefault();
            if (rangeAttribute == null) return null;

            if (!(rangeAttribute.Minimum is double minumum) || !(rangeAttribute.Maximum is double maximum)) return null;
            var isMinInfinity = double.IsInfinity(minumum);
            var isMaxInfinity = double.IsInfinity(maximum);

            if (!isMinInfinity && !isMaxInfinity) return null;

            var isFloatingPointNumber = context.ObjectType == typeof(float) || context.ObjectType == typeof(double);
            return new JSchema
            {
                Title = context.SchemaTitle,
                Description = context.SchemaDescription,
                Type = isFloatingPointNumber ? JSchemaType.Number : JSchemaType.Integer,
                Minimum = isMinInfinity ? null : (double?)minumum,
                Maximum = isMaxInfinity ? null : (double?)maximum,
            };
        }
    }
}