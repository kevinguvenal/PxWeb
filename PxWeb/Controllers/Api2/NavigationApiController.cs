/*
 * PxApi
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

using PxWeb.Models.Api2;
using PxWeb.Attributes.Api2;
using Px.Abstractions.DataSource;
using Px.Abstractions.Interfaces;

namespace PxWeb.Controllers.Api2
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class NavigationApiController : ControllerBase
    {
        private readonly IDataSource _dataSource;

        public NavigationApiController(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        /// <summary>
        /// Gets navigation item with the given id.
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="lang">The language if the default is not what you want.</param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/v2/navigation/{id}")]
        [ValidateModelState]
        [SwaggerOperation("GetNavigationById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Folder), description: "Success")]
        public virtual IActionResult GetNavigationById([FromRoute][Required] string id, [FromQuery] string lang)
        {

            
            _dataSource.CreateMenu(id, lang);

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Folder));
            string exampleJson = null;
            exampleJson = "{\n  \"description\" : \"description\",\n  \"folderContents\" : [ {\n    \"description\" : \"description\",\n    \"id\" : \"id\",\n    \"label\" : \"label\",\n    \"objectType\" : \"objectType\"\n  }, {\n    \"description\" : \"description\",\n    \"id\" : \"id\",\n    \"label\" : \"label\",\n    \"objectType\" : \"objectType\"\n  } ],\n  \"links\" : [ {\n    \"rel\" : \"rel\",\n    \"href\" : \"href\"\n  }, {\n    \"rel\" : \"rel\",\n    \"href\" : \"href\"\n  } ],\n  \"id\" : \"id\",\n  \"label\" : \"label\",\n  \"objectType\" : \"objectType\",\n  \"tags\" : [ \"tags\", \"tags\" ]\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Folder>(exampleJson)
            : default(Folder);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Browse the database structure
        /// </summary>
        /// <param name="lang">The language if the default is not what you want.</param>
        /// <response code="200">Success</response>
        /// <response code="429">Error respsone for 429</response>
        [HttpGet]
        [Route("/v2/navigation")]
        [ValidateModelState]
        [SwaggerOperation("GetNavigationRoot")]
        [SwaggerResponse(statusCode: 200, type: typeof(Folder), description: "Success")]
        [SwaggerResponse(statusCode: 429, type: typeof(Problem), description: "Error respsone for 429")]
        public virtual IActionResult GetNavigationRoot([FromQuery] string lang)
        {
            _dataSource.CreateMenu("", lang);
            
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Folder));

            //TODO: Uncomment the next line to return response 429 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(429, default(Problem));
            string exampleJson = null;
            exampleJson = "{\n  \"description\" : \"description\",\n  \"folderContents\" : [ {\n    \"description\" : \"description\",\n    \"id\" : \"id\",\n    \"label\" : \"label\",\n    \"objectType\" : \"objectType\"\n  }, {\n    \"description\" : \"description\",\n    \"id\" : \"id\",\n    \"label\" : \"label\",\n    \"objectType\" : \"objectType\"\n  } ],\n  \"links\" : [ {\n    \"rel\" : \"rel\",\n    \"href\" : \"href\"\n  }, {\n    \"rel\" : \"rel\",\n    \"href\" : \"href\"\n  } ],\n  \"id\" : \"id\",\n  \"label\" : \"label\",\n  \"objectType\" : \"objectType\",\n  \"tags\" : [ \"tags\", \"tags\" ]\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Folder>(exampleJson)
            : default(Folder);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
