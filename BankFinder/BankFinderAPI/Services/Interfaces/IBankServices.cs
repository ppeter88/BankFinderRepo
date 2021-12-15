using BankFinderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankFinderAPI.Services.Interfaces
{
    public interface IBankServices
    {
        bool Create(InstitutionDto bankDto);
    }
}
