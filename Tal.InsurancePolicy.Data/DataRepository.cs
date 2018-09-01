using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Tal.InsurerPolicy.Data;
using Tal.InsurerPolicy.Domain;

namespace Tal.InsurancePolicy.Data
{
    public class DataRepository : DataRepositoryBase, IDataRepository
    {
        public DataRepository(string filePath) : base(filePath) { }

        public async Task<List<ClientRecord>> GetClientRecords()
        {
            var table = GetDataFromExcel();

            if (table == null) return null;
            var records = new List<ClientRecord>();
            
            foreach (DataRow dR in table.Rows)
            {
                records.Add(new ClientRecord
                {
                    CompanyCode = dR["CompanyCode"].ToString(),
                    Company = dR["Company"].ToString(),
                    PolicyNo = dR["PolicyNo"].ToString(),
                    FirstName = dR["FirstName"].ToString(),
                    LastName = dR["LastName"].ToString(),
                    DateOfBirth = DateTime.Parse(dR["DateOfBirth"].ToString()),
                    Gender = dR["Gender"].ToString(),
                    CoverType = dR["CoverType"].ToString(),
                    AmountInsured = 0M,
                    PremiumAmount = 0M,
                    Frequency = dR["Frequency"].ToString(),
                    AnnualPremium = 0M,
                    PolicyStatus = dR["PolicyStatus"].ToString(),
                    CoverActive = true,
                    CoverActiveType = CoverActiveType.Active,
                    CommencementDate = string.IsNullOrEmpty(dR["CommencementDate"].ToString()) ? null : (DateTime?)DateTime.Parse(dR[""].ToString()),
                    RenewalDate = string.IsNullOrEmpty(dR["RenewalDate"].ToString()) ? null : (DateTime?)DateTime.Parse(dR[""].ToString()),
                    CancellationDate = string.IsNullOrEmpty(dR["CancellationDate"].ToString()) ? null : (DateTime?)DateTime.Parse(dR[""].ToString()),
                    PremiumType = dR["PremiumType"].ToString(),
                    PolicyType = dR["PolicyType"].ToString(),
                    BenefitPeriod = dR["BenefitPeriod"].ToString(),
                    WaitPeriod = dR["WaitPeriod"].ToString()
                });
            }
           
            return records;
        }

        List<ClientRecord> IDataRepository.GetClientRecords()
        {
            throw new NotImplementedException();
        }
    }
}
