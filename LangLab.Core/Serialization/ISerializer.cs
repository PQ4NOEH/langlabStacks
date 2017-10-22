namespace LangLab.Core.Serialization
{
    public interface ISerializer<T>
    {
        T Serialize(object obj);
        TResult Deserialize<TResult>(T obj);
    }

    public interface IBinarySerializer : ISerializer<byte[]> { }
    public interface IStringSerializer : ISerializer<string> { }
}
