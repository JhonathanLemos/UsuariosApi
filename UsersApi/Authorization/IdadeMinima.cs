using Microsoft.AspNetCore.Authorization;

namespace UsersApi.Authorization
{
    public class IdadeMinima : IAuthorizationRequirement
    {
        public int Idade { get; set; }

        public IdadeMinima(int idade)
        {
            Idade = idade;
        }
    }
}
