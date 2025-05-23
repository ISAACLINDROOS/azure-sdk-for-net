// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary>
    /// A Class representing an AppConfigurationReplica along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AppConfigurationReplicaResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAppConfigurationReplicaResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppConfigurationStoreResource"/> using the GetAppConfigurationReplica method.
    /// </summary>
    public partial class AppConfigurationReplicaResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AppConfigurationReplicaResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="configStoreName"> The configStoreName. </param>
        /// <param name="replicaName"> The replicaName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string configStoreName, string replicaName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas/{replicaName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _appConfigurationReplicaReplicasClientDiagnostics;
        private readonly ReplicasRestOperations _appConfigurationReplicaReplicasRestClient;
        private readonly AppConfigurationReplicaData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppConfiguration/configurationStores/replicas";

        /// <summary> Initializes a new instance of the <see cref="AppConfigurationReplicaResource"/> class for mocking. </summary>
        protected AppConfigurationReplicaResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppConfigurationReplicaResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AppConfigurationReplicaResource(ArmClient client, AppConfigurationReplicaData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AppConfigurationReplicaResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AppConfigurationReplicaResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appConfigurationReplicaReplicasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string appConfigurationReplicaReplicasApiVersion);
            _appConfigurationReplicaReplicasRestClient = new ReplicasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appConfigurationReplicaReplicasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AppConfigurationReplicaData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the properties of the specified replica.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas/{replicaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppConfigurationReplicaResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _appConfigurationReplicaReplicasClientDiagnostics.CreateScope("AppConfigurationReplicaResource.Get");
            scope.Start();
            try
            {
                var response = await _appConfigurationReplicaReplicasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppConfigurationReplicaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified replica.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas/{replicaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppConfigurationReplicaResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _appConfigurationReplicaReplicasClientDiagnostics.CreateScope("AppConfigurationReplicaResource.Get");
            scope.Start();
            try
            {
                var response = _appConfigurationReplicaReplicasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppConfigurationReplicaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a replica.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas/{replicaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _appConfigurationReplicaReplicasClientDiagnostics.CreateScope("AppConfigurationReplicaResource.Delete");
            scope.Start();
            try
            {
                var response = await _appConfigurationReplicaReplicasRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppConfigurationArmOperation(_appConfigurationReplicaReplicasClientDiagnostics, Pipeline, _appConfigurationReplicaReplicasRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a replica.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas/{replicaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _appConfigurationReplicaReplicasClientDiagnostics.CreateScope("AppConfigurationReplicaResource.Delete");
            scope.Start();
            try
            {
                var response = _appConfigurationReplicaReplicasRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppConfigurationArmOperation(_appConfigurationReplicaReplicasClientDiagnostics, Pipeline, _appConfigurationReplicaReplicasRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a replica with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas/{replicaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The parameters for creating a replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppConfigurationReplicaResource>> UpdateAsync(WaitUntil waitUntil, AppConfigurationReplicaData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appConfigurationReplicaReplicasClientDiagnostics.CreateScope("AppConfigurationReplicaResource.Update");
            scope.Start();
            try
            {
                var response = await _appConfigurationReplicaReplicasRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppConfigurationArmOperation<AppConfigurationReplicaResource>(new AppConfigurationReplicaOperationSource(Client), _appConfigurationReplicaReplicasClientDiagnostics, Pipeline, _appConfigurationReplicaReplicasRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a replica with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas/{replicaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The parameters for creating a replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppConfigurationReplicaResource> Update(WaitUntil waitUntil, AppConfigurationReplicaData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appConfigurationReplicaReplicasClientDiagnostics.CreateScope("AppConfigurationReplicaResource.Update");
            scope.Start();
            try
            {
                var response = _appConfigurationReplicaReplicasRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new AppConfigurationArmOperation<AppConfigurationReplicaResource>(new AppConfigurationReplicaOperationSource(Client), _appConfigurationReplicaReplicasClientDiagnostics, Pipeline, _appConfigurationReplicaReplicasRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
