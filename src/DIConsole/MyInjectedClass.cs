
namespace DIConsole;

public class MyInjectedClass{
    
    // public MyInjectedClass()
    // {
        
    // }

    public async Task Execute()
    {
        await Task.Run(() => {
            Thread.Sleep(1500);
            Console.WriteLine("MyInjectedClass :: Execute");
        });
    }
}