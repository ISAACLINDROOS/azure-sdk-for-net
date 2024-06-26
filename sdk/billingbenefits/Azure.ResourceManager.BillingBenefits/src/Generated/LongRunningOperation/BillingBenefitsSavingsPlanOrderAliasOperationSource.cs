// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits
{
    internal class BillingBenefitsSavingsPlanOrderAliasOperationSource : IOperationSource<BillingBenefitsSavingsPlanOrderAliasResource>
    {
        private readonly ArmClient _client;

        internal BillingBenefitsSavingsPlanOrderAliasOperationSource(ArmClient client)
        {
            _client = client;
        }

        BillingBenefitsSavingsPlanOrderAliasResource IOperationSource<BillingBenefitsSavingsPlanOrderAliasResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = BillingBenefitsSavingsPlanOrderAliasData.DeserializeBillingBenefitsSavingsPlanOrderAliasData(document.RootElement);
            return new BillingBenefitsSavingsPlanOrderAliasResource(_client, data);
        }

        async ValueTask<BillingBenefitsSavingsPlanOrderAliasResource> IOperationSource<BillingBenefitsSavingsPlanOrderAliasResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = BillingBenefitsSavingsPlanOrderAliasData.DeserializeBillingBenefitsSavingsPlanOrderAliasData(document.RootElement);
            return new BillingBenefitsSavingsPlanOrderAliasResource(_client, data);
        }
    }
}
