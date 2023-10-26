namespace EFECore;
class Program
{
    public static void Main(String[] args) { 
        ApplicationDbContext context = new ApplicationDbContext();
        // context.Employees.Add(new models.Employee { Name = "ahmed" });
        //context.Employees.Add(new models.Employee { Name = "Employee 1" });
        //context.Employees.Add(new models.Employee { Name = "admin emp" , Role="admin" });
        //context.Employees.Add(new models.Employee { Name = "manager", Role = "Manager" });

        //context.posts.Add(new models.Post { 
        //        Content = "Post Content" , 
        //        slug = "Post-1-title",
        //        title = "title" 
        //    }
        //);
         context.Employees.Add(new models.Employee { firstname="ahmed" , lastname="ali"});
        context.SaveChanges();

    }

}