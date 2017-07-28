namespace Gbfs.Net
{
    public abstract class BaseResponse<T>
        where T : new()
    {
        public long LastUpdated { get; set; }
        public long TimeToLive { get; set; }
        public T Data { get; set; } = new T();
    }
}
