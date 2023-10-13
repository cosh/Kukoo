using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Kukoo.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Kukoo.Models;
using Kukoo.Clients;
using Kukoo.Configs;
using Microsoft.Extensions.Configuration;

namespace Kukoo.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class QueryApiController : ControllerBase
    {
        private readonly ILogger _logger;
        private ADXClient _client;
        private SettingsTimeSeries _settings;

        public QueryApiController (IConfiguration configuration, ILogger<QueryApiController> logger, ADXClient client)
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
        /// <remarks>Executes Time Series Query in pages of results - Get Events, Get Series or Aggregate Series.</remarks>
        /// <param name="apiVersion">Version of the API to be used with the client request. Currently supported version is \&quot;2020-07-31\&quot;.</param>
        /// <param name="parameters">Time series query request body.</param>
        /// <param name="storeType">For the environments with warm store enabled, the query can be executed either on the &#39;WarmStore&#39; or &#39;ColdStore&#39;. This parameter in the query defines which store the query should be executed on. If not defined, the query will be executed on the cold store.</param>
        /// <param name="xMsContinuation">Continuation token from previous page of results to retrieve the next page of the results in calls that support pagination. To get the first page results, specify null continuation token as parameter value. Returned continuation token is null if all results have been returned, and there is no next page of results.</param>
        /// <param name="xMsClientRequestId">Optional client request ID. Service records this value. Allows the service to trace operation across services, and allows the customer to contact support regarding a particular request.</param>
        /// <param name="xMsClientSessionId">Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests.</param>
        /// <response code="200">Successful query.</response>
        /// <response code="0">Unexpected error.</response>
        [HttpPost]
        [Route("/timeseries/query")]
        [ValidateModelState]
        [SwaggerOperation("QueryExecute")]
        [SwaggerResponse(statusCode: 200, type: typeof(QueryResultPage), description: "Successful query.")]
        [SwaggerResponse(statusCode: 0, type: typeof(TsiError), description: "Unexpected error.")]
        public virtual IActionResult QueryExecute([FromQuery][Required()]string apiVersion, [FromBody]QueryRequest parameters, [FromQuery]string storeType, [FromHeader]string xMsContinuation, [FromHeader]string xMsClientRequestId, [FromHeader]string xMsClientSessionId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(QueryResultPage));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(TsiError));

            //just a test
            var result = _client.KustoClient.ExecuteQuery(_settings.DatabaseName, $"{_settings.TelemetryTable} | take 10", Helper.CreateClientRequestProperties());

            string exampleJson = null;
            exampleJson = "{\n  \"bytes\": [],\n  \"empty\": true\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<QueryResultPage>(exampleJson)
            : default(QueryResultPage);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Returns the time range and distribution of event count over the event timestamp ($ts). This API can be used to provide landing experience of navigating to the environment.</remarks>
        /// <param name="apiVersion">Version of the API to be used with the client request. Currently supported version is \&quot;2020-07-31\&quot;.</param>
        /// <param name="storeType">For the environments with warm store enabled, the query can be executed either on the &#39;WarmStore&#39; or &#39;ColdStore&#39;. This parameter in the query defines which store the query should be executed on. If not defined, the query will be executed on the cold store.</param>
        /// <param name="xMsClientRequestId">Optional client request ID. Service records this value. Allows the service to trace operation across services, and allows the customer to contact support regarding a particular request.</param>
        /// <param name="xMsClientSessionId">Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests.</param>
        /// <response code="200">Successful operation.</response>
        /// <response code="0">Unexpected error.</response>
        [HttpGet]
        [Route("/availability")]
        [ValidateModelState]
        [SwaggerOperation("QueryGetAvailability")]
        [SwaggerResponse(statusCode: 200, type: typeof(AvailabilityResponse), description: "Successful operation.")]
        [SwaggerResponse(statusCode: 0, type: typeof(TsiError), description: "Unexpected error.")]
        public virtual IActionResult QueryGetAvailability([FromQuery][Required()]string apiVersion, [FromQuery]string storeType, [FromHeader]string xMsClientRequestId, [FromHeader]string xMsClientSessionId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AvailabilityResponse));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(TsiError));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AvailabilityResponse>(exampleJson)
            : default(AvailabilityResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Returns environment event schema for a given search span. Event schema is a set of property definitions. Event schema may not be contain all persisted properties when there are too many properties.</remarks>
        /// <param name="apiVersion">Version of the API to be used with the client request. Currently supported version is \&quot;2020-07-31\&quot;.</param>
        /// <param name="parameters">Parameters to get event schema.</param>
        /// <param name="storeType">For the environments with warm store enabled, the query can be executed either on the &#39;WarmStore&#39; or &#39;ColdStore&#39;. This parameter in the query defines which store the query should be executed on. If not defined, the query will be executed on the cold store.</param>
        /// <param name="xMsClientRequestId">Optional client request ID. Service records this value. Allows the service to trace operation across services, and allows the customer to contact support regarding a particular request.</param>
        /// <param name="xMsClientSessionId">Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests.</param>
        /// <response code="200">Successful operation.</response>
        /// <response code="0">Unexpected error.</response>
        [HttpPost]
        [Route("/eventSchema")]
        [ValidateModelState]
        [SwaggerOperation("QueryGetEventSchema")]
        [SwaggerResponse(statusCode: 200, type: typeof(EventSchema), description: "Successful operation.")]
        [SwaggerResponse(statusCode: 0, type: typeof(TsiError), description: "Unexpected error.")]
        public virtual IActionResult QueryGetEventSchema([FromQuery][Required()]string apiVersion, [FromBody]GetEventSchemaRequest parameters, [FromQuery]string storeType, [FromHeader]string xMsClientRequestId, [FromHeader]string xMsClientSessionId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(EventSchema));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(TsiError));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<EventSchema>(exampleJson)
            : default(EventSchema);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
