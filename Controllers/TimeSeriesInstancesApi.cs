using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Kukoo.Models;
using Kukoo.Attributes;

namespace Kukoo.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class TimeSeriesInstancesApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Executes a batch get, create, update, delete operation on multiple time series instances.</remarks>
        /// <param name="apiVersion">Version of the API to be used with the client request. Currently supported version is \&quot;2020-07-31\&quot;.</param>
        /// <param name="parameters">Time series instances suggest request body.</param>
        /// <param name="xMsClientRequestId">Optional client request ID. Service records this value. Allows the service to trace operation across services, and allows the customer to contact support regarding a particular request.</param>
        /// <param name="xMsClientSessionId">Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests.</param>
        /// <response code="200">Successful operation.</response>
        /// <response code="0">Unexpected error.</response>
        [HttpPost]
        [Route("/timeseries/instances/$batch")]
        [ValidateModelState]
        [SwaggerOperation("TimeSeriesInstancesExecuteBatch")]
        [SwaggerResponse(statusCode: 200, type: typeof(InstancesBatchResponse), description: "Successful operation.")]
        [SwaggerResponse(statusCode: 0, type: typeof(TsiError), description: "Unexpected error.")]
        public virtual IActionResult TimeSeriesInstancesExecuteBatch([FromQuery][Required()]string apiVersion, [FromBody]InstancesBatchRequest parameters, [FromHeader]string xMsClientRequestId, [FromHeader]string xMsClientSessionId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InstancesBatchResponse));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(TsiError));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InstancesBatchResponse>(exampleJson)
            : default(InstancesBatchResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Gets time series instances in pages.</remarks>
        /// <param name="apiVersion">Version of the API to be used with the client request. Currently supported version is \&quot;2020-07-31\&quot;.</param>
        /// <param name="xMsContinuation">Continuation token from previous page of results to retrieve the next page of the results in calls that support pagination. To get the first page results, specify null continuation token as parameter value. Returned continuation token is null if all results have been returned, and there is no next page of results.</param>
        /// <param name="xMsClientRequestId">Optional client request ID. Service records this value. Allows the service to trace operation across services, and allows the customer to contact support regarding a particular request.</param>
        /// <param name="xMsClientSessionId">Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests.</param>
        /// <response code="200">Successful operation.</response>
        /// <response code="0">Unexpected error.</response>
        [HttpGet]
        [Route("/timeseries/instances")]
        [ValidateModelState]
        [SwaggerOperation("TimeSeriesInstancesList")]
        [SwaggerResponse(statusCode: 200, type: typeof(GetInstancesPage), description: "Successful operation.")]
        [SwaggerResponse(statusCode: 0, type: typeof(TsiError), description: "Unexpected error.")]
        public virtual IActionResult TimeSeriesInstancesList([FromQuery][Required()]string apiVersion, [FromHeader]string xMsContinuation, [FromHeader]string xMsClientRequestId, [FromHeader]string xMsClientSessionId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GetInstancesPage));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(TsiError));

            string exampleJson = null;
            exampleJson = "{\n  \"bytes\": [],\n  \"empty\": true\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<GetInstancesPage>(exampleJson)
            : default(GetInstancesPage);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Partial list of hits on search for time series instances based on instance attributes.</remarks>
        /// <param name="apiVersion">Version of the API to be used with the client request. Currently supported version is \&quot;2020-07-31\&quot;.</param>
        /// <param name="parameters">Time series instances search request body.</param>
        /// <param name="xMsContinuation">Continuation token from previous page of results to retrieve the next page of the results in calls that support pagination. To get the first page results, specify null continuation token as parameter value. Returned continuation token is null if all results have been returned, and there is no next page of results.</param>
        /// <param name="xMsClientRequestId">Optional client request ID. Service records this value. Allows the service to trace operation across services, and allows the customer to contact support regarding a particular request.</param>
        /// <param name="xMsClientSessionId">Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests.</param>
        /// <response code="200">Successful search response.</response>
        /// <response code="0">Unexpected error.</response>
        [HttpPost]
        [Route("/timeseries/instances/search")]
        [ValidateModelState]
        [SwaggerOperation("TimeSeriesInstancesSearch")]
        [SwaggerResponse(statusCode: 200, type: typeof(SearchInstancesResponsePage), description: "Successful search response.")]
        [SwaggerResponse(statusCode: 0, type: typeof(TsiError), description: "Unexpected error.")]
        public virtual IActionResult TimeSeriesInstancesSearch([FromQuery][Required()]string apiVersion, [FromBody]SearchInstancesRequest parameters, [FromHeader]string xMsContinuation, [FromHeader]string xMsClientRequestId, [FromHeader]string xMsClientSessionId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SearchInstancesResponsePage));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(TsiError));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SearchInstancesResponsePage>(exampleJson)
            : default(SearchInstancesResponsePage);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Suggests keywords based on time series instance attributes to be later used in Search Instances.</remarks>
        /// <param name="apiVersion">Version of the API to be used with the client request. Currently supported version is \&quot;2020-07-31\&quot;.</param>
        /// <param name="parameters">Time series instances suggest request body.</param>
        /// <param name="xMsClientRequestId">Optional client request ID. Service records this value. Allows the service to trace operation across services, and allows the customer to contact support regarding a particular request.</param>
        /// <param name="xMsClientSessionId">Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests.</param>
        /// <response code="200">Successful operation.</response>
        /// <response code="0">Unexpected error.</response>
        [HttpPost]
        [Route("/timeseries/instances/suggest")]
        [ValidateModelState]
        [SwaggerOperation("TimeSeriesInstancesSuggest")]
        [SwaggerResponse(statusCode: 200, type: typeof(InstancesSuggestResponse), description: "Successful operation.")]
        [SwaggerResponse(statusCode: 0, type: typeof(TsiError), description: "Unexpected error.")]
        public virtual IActionResult TimeSeriesInstancesSuggest([FromQuery][Required()]string apiVersion, [FromBody]InstancesSuggestRequest parameters, [FromHeader]string xMsClientRequestId, [FromHeader]string xMsClientSessionId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InstancesSuggestResponse));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(TsiError));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InstancesSuggestResponse>(exampleJson)
            : default(InstancesSuggestResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
