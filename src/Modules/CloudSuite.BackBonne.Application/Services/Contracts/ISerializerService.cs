namespace CloudSuite.BackBonne.Application.Services.Contracts
{
    public interface ISerializerService<T>
    {
         string Serialize(T obj);
        
    }
}