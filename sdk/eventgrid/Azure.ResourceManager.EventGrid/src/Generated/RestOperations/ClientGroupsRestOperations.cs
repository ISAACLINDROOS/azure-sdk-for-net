// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid
{
    internal partial class ClientGroupsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ClientGroupsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ClientGroupsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-06-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string namespaceName, string clientGroupName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.EventGrid/namespaces/", false);
            uri.AppendPath(namespaceName, true);
            uri.AppendPath("/clientGroups/", false);
            uri.AppendPath(clientGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string namespaceName, string clientGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.EventGrid/namespaces/", false);
            uri.AppendPath(namespaceName, true);
            uri.AppendPath("/clientGroups/", false);
            uri.AppendPath(clientGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get properties of a client group. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. </param>
        /// <param name="namespaceName"> Name of the namespace. </param>
        /// <param name="clientGroupName"> Name of the client group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/> or <paramref name="clientGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/> or <paramref name="clientGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<EventGridNamespaceClientGroupData>> GetAsync(string subscriptionId, string resourceGroupName, string namespaceName, string clientGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(clientGroupName, nameof(clientGroupName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, namespaceName, clientGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventGridNamespaceClientGroupData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = EventGridNamespaceClientGroupData.DeserializeEventGridNamespaceClientGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((EventGridNamespaceClientGroupData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get properties of a client group. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. </param>
        /// <param name="namespaceName"> Name of the namespace. </param>
        /// <param name="clientGroupName"> Name of the client group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/> or <paramref name="clientGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/> or <paramref name="clientGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<EventGridNamespaceClientGroupData> Get(string subscriptionId, string resourceGroupName, string namespaceName, string clientGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(clientGroupName, nameof(clientGroupName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, namespaceName, clientGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventGridNamespaceClientGroupData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = EventGridNamespaceClientGroupData.DeserializeEventGridNamespaceClientGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((EventGridNamespaceClientGroupData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string subscriptionId, string resourceGroupName, string namespaceName, string clientGroupName, EventGridNamespaceClientGroupData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.EventGrid/namespaces/", false);
            uri.AppendPath(namespaceName, true);
            uri.AppendPath("/clientGroups/", false);
            uri.AppendPath(clientGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string namespaceName, string clientGroupName, EventGridNamespaceClientGroupData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.EventGrid/namespaces/", false);
            uri.AppendPath(namespaceName, true);
            uri.AppendPath("/clientGroups/", false);
            uri.AppendPath(clientGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create or update a client group with the specified parameters. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. </param>
        /// <param name="namespaceName"> Name of the namespace. </param>
        /// <param name="clientGroupName"> The client group name. </param>
        /// <param name="data"> Client group information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, <paramref name="clientGroupName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/> or <paramref name="clientGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string namespaceName, string clientGroupName, EventGridNamespaceClientGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(clientGroupName, nameof(clientGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, namespaceName, clientGroupName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update a client group with the specified parameters. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. </param>
        /// <param name="namespaceName"> Name of the namespace. </param>
        /// <param name="clientGroupName"> The client group name. </param>
        /// <param name="data"> Client group information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, <paramref name="clientGroupName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/> or <paramref name="clientGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string namespaceName, string clientGroupName, EventGridNamespaceClientGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(clientGroupName, nameof(clientGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, namespaceName, clientGroupName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string subscriptionId, string resourceGroupName, string namespaceName, string clientGroupName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.EventGrid/namespaces/", false);
            uri.AppendPath(namespaceName, true);
            uri.AppendPath("/clientGroups/", false);
            uri.AppendPath(clientGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string namespaceName, string clientGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.EventGrid/namespaces/", false);
            uri.AppendPath(namespaceName, true);
            uri.AppendPath("/clientGroups/", false);
            uri.AppendPath(clientGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete an existing client group. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. </param>
        /// <param name="namespaceName"> Name of the namespace. </param>
        /// <param name="clientGroupName"> Name of the client group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/> or <paramref name="clientGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/> or <paramref name="clientGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string namespaceName, string clientGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(clientGroupName, nameof(clientGroupName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, namespaceName, clientGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete an existing client group. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. </param>
        /// <param name="namespaceName"> Name of the namespace. </param>
        /// <param name="clientGroupName"> Name of the client group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/> or <paramref name="clientGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/> or <paramref name="clientGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string namespaceName, string clientGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(clientGroupName, nameof(clientGroupName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, namespaceName, clientGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByNamespaceRequestUri(string subscriptionId, string resourceGroupName, string namespaceName, string filter, int? top)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.EventGrid/namespaces/", false);
            uri.AppendPath(namespaceName, true);
            uri.AppendPath("/clientGroups", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            return uri;
        }

        internal HttpMessage CreateListByNamespaceRequest(string subscriptionId, string resourceGroupName, string namespaceName, string filter, int? top)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.EventGrid/namespaces/", false);
            uri.AppendPath(namespaceName, true);
            uri.AppendPath("/clientGroups", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get all the client groups under a namespace. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. </param>
        /// <param name="namespaceName"> Name of the namespace. </param>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="namespaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ClientGroupsListResult>> ListByNamespaceAsync(string subscriptionId, string resourceGroupName, string namespaceName, string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var message = CreateListByNamespaceRequest(subscriptionId, resourceGroupName, namespaceName, filter, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ClientGroupsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ClientGroupsListResult.DeserializeClientGroupsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get all the client groups under a namespace. </summary>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. </param>
        /// <param name="namespaceName"> Name of the namespace. </param>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="namespaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ClientGroupsListResult> ListByNamespace(string subscriptionId, string resourceGroupName, string namespaceName, string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var message = CreateListByNamespaceRequest(subscriptionId, resourceGroupName, namespaceName, filter, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ClientGroupsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ClientGroupsListResult.DeserializeClientGroupsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByNamespaceNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string namespaceName, string filter, int? top)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByNamespaceNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string namespaceName, string filter, int? top)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get all the client groups under a namespace. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. </param>
        /// <param name="namespaceName"> Name of the namespace. </param>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="namespaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ClientGroupsListResult>> ListByNamespaceNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string namespaceName, string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var message = CreateListByNamespaceNextPageRequest(nextLink, subscriptionId, resourceGroupName, namespaceName, filter, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ClientGroupsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ClientGroupsListResult.DeserializeClientGroupsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get all the client groups under a namespace. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. </param>
        /// <param name="namespaceName"> Name of the namespace. </param>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="namespaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ClientGroupsListResult> ListByNamespaceNextPage(string nextLink, string subscriptionId, string resourceGroupName, string namespaceName, string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var message = CreateListByNamespaceNextPageRequest(nextLink, subscriptionId, resourceGroupName, namespaceName, filter, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ClientGroupsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ClientGroupsListResult.DeserializeClientGroupsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
