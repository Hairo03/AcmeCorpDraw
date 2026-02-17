using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeCorpDraw.Domain.Interfaces
{
    public interface ISerialNumberRepository
    {
        Task<bool> IsValidAsync(string serialNumber);
    }
}
