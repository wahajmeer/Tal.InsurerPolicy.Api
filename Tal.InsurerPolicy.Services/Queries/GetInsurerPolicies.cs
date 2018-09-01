using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tal.InsurancePolicy.Data;
using Tal.InsurerPolicy.Domain;

namespace Tal.InsurerPolicy.Services.Queries
{
    public class GetInsurerPolicies : IRequest<List<LifeClient>>
    {

    }

    public class GetInsurerPoliciesHandler : IRequestHandler<GetInsurerPolicies, List<LifeClient>>
    {
        private readonly IDataRepository _dataRepository;

        public GetInsurerPoliciesHandler(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public async Task<List<LifeClient>> Handle(GetInsurerPolicies request, CancellationToken cancellationToken)
        {
            var clientDetails = _dataRepository.GetClientRecords();

            var lifeClients = new List<LifeClient>();
        
            if (clientDetails != null)
            {
                //Create a collection of life client
            }

            return await lifeClients;
        }
    }
}
