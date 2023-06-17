using EventBoardDataAccess.DataBase.Repository;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            var yarik = new UnitOfWork();
            yarik.AddEventOrganizer(2);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}