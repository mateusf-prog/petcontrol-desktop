namespace PetControlSystem.Services.Interfaces
{
    public interface ICrud<T>
    {
        void Delete(string id);
        T Update(string id, T obj);
        T Create(T obj);
        T Read(string id);
        List<T> ReadAll();
    }
}

