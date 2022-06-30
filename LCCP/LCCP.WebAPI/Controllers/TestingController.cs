using LCCP.Core.ApplicationFacade;
using LCCP.Dto;
using Microsoft.AspNetCore.Mvc;

namespace LCCP.WebAPI.Controllers
{
    /// <summary>
    /// Testing Controller class used for testing the Get, Post, Put, Delete Tesing API
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TestingController : ControllerBase
    {
        #region Private Memebers

        private ITestingAf _testingAf;

        #endregion

        #region Constructor

        public TestingController(ITestingAf testingAf)
        {
            _testingAf = testingAf;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get the Test Data List Object
        /// </summary>
        /// <returns>Returns the TestDataDtoList object</returns>
        [HttpGet("test")]
        public IActionResult GetTestDataList()
        {
            IActionResult actionResult;
            try
            {
                actionResult = Ok(_testingAf.GetTestDataList());
            }
            catch (Exception ex)
            {
                actionResult = StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

            return actionResult;
        }

        /// <summary>
        /// Get the Test Data Object By Id
        /// </summary>
        /// <param name="id">TestData Id</param>
        /// <returns>Returns the TestDataDto object</returns>
        [HttpGet("test/id")]
        public IActionResult GetTestDataById(int id)
        {
            IActionResult actionResult;
            try
            {
                actionResult = Ok(_testingAf.GetTestDataById(id));
            }
            catch (Exception ex)
            {
                actionResult = StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

            return actionResult;
        }

        /// <summary>
        /// Add the Test Data Object
        /// </summary>
        /// <param name="testDataDto">TestData object</param>
        /// <returns>Returns the BaseResultDto object</returns>
        [HttpPost("test")]
        public IActionResult AddTestData(TestDataDto testDataDto)
        {
            IActionResult actionResult;
            try
            {
                actionResult = Ok(_testingAf.AddTestData(testDataDto));
            }
            catch (Exception ex)
            {
                actionResult = StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

            return actionResult;
        }

        /// <summary>
        /// Update the Test Data Object
        /// </summary>
        /// <param name="testDataDto">TestData object</param>
        /// <returns>Returns the BaseResultDto object</returns>
        [HttpPut("test")]
        public IActionResult UpdateTestData(TestDataDto testDataDto)
        {
            IActionResult actionResult;
            try
            {
                actionResult = Ok(_testingAf.UpdateTestData(testDataDto));
            }
            catch (Exception ex)
            {
                actionResult = StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

            return actionResult;
        }

        /// <summary>
        /// Delete the Test Data Object
        /// </summary>
        /// <param name="id">TestData Id</param>
        /// <returns>Returns the BaseResultDto object</returns>
        [HttpDelete("test/id")]
        public IActionResult DeleteTestData(int id)
        {
            IActionResult actionResult;
            try
            {
                actionResult = Ok(_testingAf.DeleteTestData(id));
            }
            catch (Exception ex)
            {
                actionResult = StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

            return actionResult;
        }

        #endregion
    }
}