using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRepository
{
    public class UserRepository
    {
        ProjectDbContext context = new ProjectDbContext();
        public int Insert(User user)
        {
            context.Users.Add(user);
            return context.SaveChanges();

        }
        public int LogIn(string Email,string Password)
        {
        
            User user = context.Users.SingleOrDefault(u => u.Email == Email && u.Password== Password);
            try
            {
                if (user.Equals(null))
                {
                    return 0;

                }
                else
                    return user.UserId;

            }
            catch (Exception e1)
            {
                return 0;
            }

            //if (user.Equals(null))
            //{
            //    return 0;

            //}
            //else 
            //return user.UserId;
        }

        public User Get(int id)
        {

            return context.Users.SingleOrDefault(u => u.UserId == id);
        }
        public int Edit(UserEdit us)
        {
            User userToUpdate = context.Users.SingleOrDefault(u => u.UserId == us.UserId);
            userToUpdate.UserName = us.UserName;
            userToUpdate.Phone = us.Phone;
            userToUpdate.Password = us.Password;
            return context.SaveChanges();
        }
    }
}
