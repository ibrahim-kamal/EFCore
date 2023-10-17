namespace EFECore;
class Program
{
    public static void Main(String[] args) { 
        ApplicationDbContext context = new ApplicationDbContext();
        context.Employees.Add(new models.Employee { Name = "ahmed" });
        context.Employees.Add(new models.Employee { Name = "adel" });
        context.SaveChanges();

    }

}