using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Kukoo.Models;
using Kukoo.Attributes;
using Kukoo.Clients;
using Kukoo.Configs;

namespace Kukoo.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class TimeSeriesHierarchiesApiController : ControllerBase
    {
        private readonly ILogger _logger;
        private ADXClient _client;
        private SettingsTimeSeries _settings;

        public TimeSeriesHierarchiesApiController(IConfiguration configuration, ILogger<TimeSeriesHierarchiesApiController> logger, ADXClient client)
        {
            _logger = logger;
            _client = client;
            _settings = new();
            configuration.GetSection(nameof(SettingsTimeSeries))
                .Bind(_settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Executes a batch get, create, update, delete operation on multiple time series hierarchy definitions.</remarks>
        /// <param name="apiVersion">Version of the API to be used with the client request. Currently supported version is \&quot;2020-07-31\&quot;.</param>
        /// <param name="parameters">Time series hierarchies batch request body.</param>
        /// <param name="xMsClientRequestId">Optional client request ID. Service records this value. Allows the service to trace operation across services, and allows the customer to contact support regarding a particular request.</param>
        /// <param name="xMsClientSessionId">Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests.</param>
        /// <response code="200">Successful operation.</response>
        /// <response code="0">Unexpected error.</response>
        [HttpPost]
        [Route("/timeseries/hierarchies/$batch")]
        [ValidateModelState]
        [SwaggerOperation("TimeSeriesHierarchiesExecuteBatch")]
        [SwaggerResponse(statusCode: 200, type: typeof(HierarchiesBatchResponse), description: "Successful operation.")]
        [SwaggerResponse(statusCode: 0, type: typeof(TsiError), description: "Unexpected error.")]
        public virtual IActionResult TimeSeriesHierarchiesExecuteBatch([FromQuery][Required()]string apiVersion, [FromBody]HierarchiesBatchRequest parameters, [FromHeader]string xMsClientRequestId, [FromHeader]string xMsClientSessionId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(HierarchiesBatchResponse));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(TsiError));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<HierarchiesBatchResponse>(exampleJson)
            : default(HierarchiesBatchResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Returns time series hierarchies definitions in pages.</remarks>
        /// <param name="apiVersion">Version of the API to be used with the client request. Currently supported version is \&quot;2020-07-31\&quot;.</param>
        /// <param name="xMsContinuation">Continuation token from previous page of results to retrieve the next page of the results in calls that support pagination. To get the first page results, specify null continuation token as parameter value. Returned continuation token is null if all results have been returned, and there is no next page of results.</param>
        /// <param name="xMsClientRequestId">Optional client request ID. Service records this value. Allows the service to trace operation across services, and allows the customer to contact support regarding a particular request.</param>
        /// <param name="xMsClientSessionId">Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests.</param>
        /// <response code="200">Successful operation.</response>
        /// <response code="0">Unexpected error.</response>
        [HttpGet]
        [Route("/timeseries/hierarchies")]
        [ValidateModelState]
        [SwaggerOperation("TimeSeriesHierarchiesList")]
        [SwaggerResponse(statusCode: 200, type: typeof(GetHierarchiesPage), description: "Successful operation.")]
        [SwaggerResponse(statusCode: 0, type: typeof(TsiError), description: "Unexpected error.")]
        public virtual IActionResult TimeSeriesHierarchiesList([FromQuery][Required()]string apiVersion, [FromHeader]string xMsContinuation, [FromHeader]string xMsClientRequestId, [FromHeader]string xMsClientSessionId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GetHierarchiesPage));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(TsiError));

            string exampleJson = null;
            exampleJson = "{\n  \"bytes\": [],\n  \"empty\": true\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<GetHierarchiesPage>(exampleJson)
            : default(GetHierarchiesPage);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
