using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAppSample.Helper.TaskHelper;
using WebAppSample.Models.TaskModels;

namespace WebAppSample.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [Route("api/[controller]")]
    [Route("api/v2/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {

        #region Get Methods
        [Route("action")]
        [Authorize(Policy = "Admin")] // Policy based 
        [Authorize(Roles = "Admin")] // Role based
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

        [Authorize(Policy = "RequireAdministratorRole")]
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

        [Authorize(Roles = "Admin")]
        [HttpPost("SamplePost")]
        public ActionResult SamplePost([FromBody] int id)
        {
            return Ok();
        }

        #endregion

        #region PUT 
        [HttpPut("UpdateTask/{TaskId:int}")]
        public ActionResult UpdateTask(int TaskId, [FromBody] TaskModel updatedTask)
        {
            try
            {
                TaskModel existingTask = TaskData.lsTaskModels.Find(x => x.TaskID == TaskId);
                if (existingTask != null)
                {
                    // Update the existing task
                    existingTask.TaskName = updatedTask.TaskName;

                    return Ok(existingTask);
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

        #region DELETE
        //[Authorize(Policy = "RequireAdministratorRole")]
        [HttpDelete("DeleteTask/{TaskId:int}")]
        public ActionResult DeleteTask(int TaskId)
        {
            try
            {
                TaskModel taskToDelete = TaskData.lsTaskModels.Find(x => x.TaskID == TaskId);
                if (taskToDelete != null)
                {
                    TaskData.lsTaskModels.Remove(taskToDelete);
                    return Ok();
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
    }
}
