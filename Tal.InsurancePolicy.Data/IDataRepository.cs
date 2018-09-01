using System;
using System.Collections.Generic;
using System.Text;
using Tal.InsurerPolicy.Domain;

namespace Tal.InsurancePolicy.Data
{
    public interface IDataRepository
    {
        List<ClientRecord> GetClientRecords();
    }
}
