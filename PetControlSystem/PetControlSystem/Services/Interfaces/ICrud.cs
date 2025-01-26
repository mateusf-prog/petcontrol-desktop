namespace PetControlSystem.Services.Interfaces
{
    public interface ICrud
    {
        void Delete(string id);
        Object Update(string id, Object obj);
        Object Create(Object obj);
        Object Read(string id);
        List<Object> ReadAll();
    }
}
