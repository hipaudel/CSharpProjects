namespace DependencyInjectionImplementation
{
    public interface IUser
    {
        
        int Id { get; set; }
        string Name { get; set; }
        IMessage Message { get; set; }
    }
}