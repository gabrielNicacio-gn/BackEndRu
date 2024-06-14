
using BackEndRu.src.Infrastruct;
using BackEndRu.src.Models;
using BackEndRu.src.Models.DTOs;

namespace BackEndRu.src.UseCase
{
    public class GetAllUsers : IGetAllUsers
    {
        private readonly IUserRepository _userRepository;
        public GetAllUsers(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IEnumerable<ResponseUsers>? Get()
        {
            var response = _userRepository.GetUsers() ?? [];
            var list = response.Select(us => new ResponseUsers(us.Id, us.Name, us.Password));
            return list;
        }
    }
}