using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2001 && gamer.FirstName == "Muhammed Batuhan"
                && gamer.LastName == "GÜLTEKİN" && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else { return false; }
        }
    }
}
