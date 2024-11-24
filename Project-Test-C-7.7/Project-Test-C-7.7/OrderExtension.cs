using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project_Test_C_7._7
{
    public static class OrderExtension
    {
        internal static async Task SaveToJsonOrderAsync<T>(this Order<T> order)
        {
            using (FileStream fs = new FileStream("order.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync(fs, order);
            }
        }
    }
}
