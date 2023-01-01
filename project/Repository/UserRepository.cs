using project.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
namespace project.Repository
{
    public interface IUserRepository
    {
        int UserRegi(UserAccount models);

    }
    public class UserRepository : IUserRepository
    {
        WorldContext _WorldContext;

        public UserRepository(WorldContext WorldContext)
        {
            _WorldContext = WorldContext;

        }
        public int UserRegi(UserAccount models)
        {
            UserAccount obj = new UserAccount();
            obj.FullName = models.FullName;
            obj.LastName= models.LastName;
            obj.Gender= models.Gender;
            obj.Graduction= models.Graduction;
            obj.Dateofbirth=models.Dateofbirth;
            obj.Hobbies= models.Hobbies;
            obj.EmailId= models.EmailId;
            obj.UploadDoc= models.UploadDoc;
            _WorldContext.UserAccounts.Add(obj);
            var resVal = _WorldContext.SaveChanges();
            if (resVal > 0)
            {
                return resVal;
            }
            return 0;
        }
    }
}
