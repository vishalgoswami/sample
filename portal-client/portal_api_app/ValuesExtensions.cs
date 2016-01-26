﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using PortalClient;

namespace PortalClient
{
    public static partial class ValuesExtensions
    {
        /// <param name='operations'>
        /// Reference to the PortalClient.IValues.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static object DeleteById(this IValues operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IValues)s).DeleteByIdAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the PortalClient.IValues.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> DeleteByIdAsync(this IValues operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.DeleteByIdWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the PortalClient.IValues.
        /// </param>
        public static IList<string> Get(this IValues operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IValues)s).GetAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the PortalClient.IValues.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<string>> GetAsync(this IValues operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<string>> result = await operations.GetWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the PortalClient.IValues.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static string GetById(this IValues operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IValues)s).GetByIdAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the PortalClient.IValues.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<string> GetByIdAsync(this IValues operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<string> result = await operations.GetByIdWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the PortalClient.IValues.
        /// </param>
        /// <param name='value'>
        /// Required.
        /// </param>
        public static object PostByValue(this IValues operations, string value)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IValues)s).PostByValueAsync(value);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the PortalClient.IValues.
        /// </param>
        /// <param name='value'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PostByValueAsync(this IValues operations, string value, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PostByValueWithOperationResponseAsync(value, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the PortalClient.IValues.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='value'>
        /// Required.
        /// </param>
        public static object PutByIdAndValue(this IValues operations, int id, string value)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IValues)s).PutByIdAndValueAsync(id, value);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the PortalClient.IValues.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='value'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PutByIdAndValueAsync(this IValues operations, int id, string value, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PutByIdAndValueWithOperationResponseAsync(id, value, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
