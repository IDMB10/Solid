using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleResponsability
{
    public class ExportHelperGeneric
    {
        public static void ExportCSV<T>(IEnumerable<T> items) where T : class
        {

            StringBuilder sb = new StringBuilder();
            string csvHeader = String.Join(";", typeof(T).GetProperties().Select(x => x.Name.ToString()));
            sb.AppendLine(csvHeader);

            foreach (var item in items)
            {
                string csvData = String.Join(";", typeof(T).GetProperties().Select(x =>
                {
                    object? valueProperty = x.GetValue(item);
                    if (valueProperty is null) return string.Empty;
                    else if (valueProperty is not String && valueProperty is IEnumerable valuesListProperty)
                    {
                        string line = string.Empty;
                        var valores = valuesListProperty.Cast<object>().ToList().Select(x => x);
                        line += string.Join("|", valores);
                        return line;
                    }
                    else return valueProperty;
                }));

                sb.AppendLine(csvData);
            }
            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{typeof(T).Name}.csv"), sb.ToString(), Encoding.Unicode);

        }
    }
}