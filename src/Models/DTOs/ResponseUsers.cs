using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndRu.src.Models.DTOs
{
    public record ResponseUsers(int Id, string Name, string Email);
}