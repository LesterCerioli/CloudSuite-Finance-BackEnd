

using System.Text.Json;
using CloudSuite.BackBonne.Application.Services.Contracts;

namespace CloudSuite.BackBonne.Application.Services.Implementations
{
    public class JsonSerializerService<T> : ISerializerService<T>
    {
    
        public string Serialize(T obj)
        {
            return JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
        
            
        }
    }
}