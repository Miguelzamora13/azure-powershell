// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// AdminKeysOperations operations.
    /// </summary>
    public partial interface IAdminKeysOperations
    {
        /// <summary>
        /// Gets the primary and secondary admin API keys for the specified
        /// Azure Cognitive Search service.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchServiceName'>
        /// The name of the Azure Cognitive Search service associated with the
        /// specified resource group.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AdminKeyResult>> GetWithHttpMessagesAsync(string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Regenerates either the primary or secondary admin API key. You can
        /// only regenerate one key at a time.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchServiceName'>
        /// The name of the Azure Cognitive Search service associated with the
        /// specified resource group.
        /// </param>
        /// <param name='keyKind'>
        /// Specifies which key to regenerate. Valid values include 'primary'
        /// and 'secondary'. Possible values include: 'Primary', 'Secondary'
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AdminKeyResult>> RegenerateWithHttpMessagesAsync(string resourceGroupName, string searchServiceName, AdminKeyKind keyKind, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
