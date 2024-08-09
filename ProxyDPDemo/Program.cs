using ProxyDPDemo.Global_Interface;
using ProxyDPDemo.Model;

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("SubhashishMahapatra", "123456", "Ceo");
        Employee employee2 = new Employee("SubhashishMahapatra", "123456", "Developer");
        Employee employee3 = new Employee("SubhashishMahapatra", "123456", "Client");


        Console.WriteLine("CEO Accessing");
        SharedFolderProxy folderProxy = new SharedFolderProxy(employee1);
        folderProxy.ReadWriteOperation();
        Console.WriteLine();


        Console.WriteLine("Developer Accessing");
        SharedFolderProxy folderProxy2 = new SharedFolderProxy(employee2);
        Console.WriteLine(employee2.Role.ToUpper());
        folderProxy2.ReadWriteOperation();
        Console.WriteLine();


        Console.WriteLine("Client Accessing");
        SharedFolderProxy folderProxy3 = new SharedFolderProxy(employee2);
        folderProxy3.ReadWriteOperation();


    }
}