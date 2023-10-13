using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using Kukoo.Attributes;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Kukoo.Models;
using Swashbuckle.AspNetCore.Annotations;
using Kukoo.Clients;
using Kukoo.Configs;

namespace Kukoo.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ModelSettingsApiController : ControllerBase
    {

        private readonly ILogger _logger;
        private ADXClient _client;
        private SettingsTimeSeries _settings;

        public ModelSettingsApiController(IConfiguration configuration, ILogger<ModelSettingsApiController> logger, ADXClient client)
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
        /// <remarks>Returns the model settings which includes model display name, Time Series ID properties and default type ID. Every Gen2 environment has a model that is automatically created.</remarks>
        /// <param name="apiVersion">Version of the API to be used with the client request. Currently supported version is \&quot;2020-07-31\&quot;.</param>
        /// <param name="xMsClientRequestId">Optional client request ID. Service records this value. Allows the service to trace operation across services, and allows the customer to contact support regarding a particular request.</param>
        /// <param name="xMsClientSessionId">Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests.</param>
        /// <response code="200">Successful operation.</response>
        /// <response code="0">Unexpected error.</response>
        [HttpGet]
        [Route("/timeseries/modelSettings")]
        [ValidateModelState]
        [SwaggerOperation("ModelSettingsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelSettingsResponse), description: "Successful operation.")]
        [SwaggerResponse(statusCode: 0, type: typeof(TsiError), description: "Unexpected error.")]
        public virtual IActionResult ModelSettingsGet([FromQuery][Required()]string apiVersion, [FromHeader]string xMsClientRequestId, [FromHeader]string xMsClientSessionId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ModelSettingsResponse));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(TsiError));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ModelSettingsResponse>(exampleJson)
            : default(ModelSettingsResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Updates time series model settings - either the model name or default type ID.</remarks>
        /// <param name="apiVersion">Version of the API to be used with the client request. Currently supported version is \&quot;2020-07-31\&quot;.</param>
        /// <param name="parameters">Model settings update request body.</param>
        /// <param name="xMsClientRequestId">Optional client request ID. Service records this value. Allows the service to trace operation across services, and allows the customer to contact support regarding a particular request.</param>
        /// <param name="xMsClientSessionId">Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests.</param>
        /// <response code="200">Successful operation returns new full model settings.</response>
        /// <response code="0">Unexpected error.</response>
        [HttpPatch]
        [Route("/timeseries/modelSettings")]
        [ValidateModelState]
        [SwaggerOperation("ModelSettingsUpdate")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelSettingsResponse), description: "Successful operation returns new full model settings.")]
        [SwaggerResponse(statusCode: 0, type: typeof(TsiError), description: "Unexpected error.")]
        public virtual IActionResult ModelSettingsUpdate([FromQuery][Required()]string apiVersion, [FromBody]UpdateModelSettingsRequest parameters, [FromHeader]string xMsClientRequestId, [FromHeader]string xMsClientSessionId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ModelSettingsResponse));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(TsiError));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ModelSettingsResponse>(exampleJson)
            : default(ModelSettingsResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
