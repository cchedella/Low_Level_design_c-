using system;
using System.Collections.Generic;

//2. Concrete Component

public class SqlUserRepository : IuserRepository
{
    public async Task<string>  GetUserNameAsync(int Id)
    {
        //Simulating the database call
        await Task.Delay(1000);
        return $"User_{Id} from Database";
    }
}