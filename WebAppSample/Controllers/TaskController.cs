using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAppSample.Helper.TaskHelper;
using WebAppSample.Models.TaskModels;

namespace WebAppSample.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {

        #region Get Methods
        //[AllowAnonymous]
        [Route("action")]
        [HttpGet("GetTaskDetails")]
        public ActionResult<List<TaskModel>> GetTaskDetails()
        {
            try
            {
                TaskData objTaskData = new TaskData();
                objTaskData.SampleTasks();
                return new ActionResult<List<TaskModel>>(Ok(TaskData.lsTaskModels));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet("GetTaskDetail/{TaskId:int}")]
        public ActionResult<TaskModel> GetTaskDetail(int TaskId)
        {
            try
            {
                TaskModel taskDetail = TaskData.lsTaskModels.Find(x => x.TaskID == TaskId);
                if (taskDetail != null)
                {
                    return Ok(taskDetail);

                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
                throw;
            }
        }

        #endregion

        #region Post Methods 

        [HttpPost("PostNewTask")]
        public ActionResult AddNewTask([FromBody] object data)
        {
            try
            {
                TaskModel newTask = Newtonsoft.Json.JsonConvert.DeserializeObject<TaskModel>(data.ToString());
                TaskModel taskModel = TaskData.lsTaskModels.Find(x => x.TaskID == newTask.TaskID);
                if (taskModel != null)
                {
                    return Conflict("A task with same task ID is identified");
                }
                else
                {
                    TaskData.lsTaskModels.Add(newTask);
                    return Created("", newTask);
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
                throw;
            }
        }

        [HttpPost("SamplePost")]
        public ActionResult SamplePost([FromBody] int id)
        {
            return Ok();
        }

        #endregion

    }
}
