using ImplementationBase;
namespace ImplementationTwo;
public class TaskTwo : ITask
{
    public string Id
    {
        get;
    } = "Two";
    public string Description
    {
        get;
    } = "Second Implementation plugin";
    public int Run()
    {
        return 2;
    }
}