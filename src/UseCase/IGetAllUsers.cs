using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndRu.src.Models.DTOs;

namespace BackEndRu.src.UseCase
{
    public interface IGetAllUsers
    {
        IEnumerable<ResponseUsers>? Get();
    }
}