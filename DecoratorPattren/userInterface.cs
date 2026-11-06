using Sytem;
using System.Collections.Generic;

//1.Component Interface

public interface IuserRepository
{
    Task<string> GetUserNameAsync(int Id);
}
