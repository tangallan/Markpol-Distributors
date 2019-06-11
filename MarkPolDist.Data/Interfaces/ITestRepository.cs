using MarkPolDist.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarkPolDist.Data.Interfaces
{
    public interface ITestRepository
    {
        Task<TestData> GetById(int id);

        Task<List<TestData>> GetAllTestDataAsync();
    }
}
