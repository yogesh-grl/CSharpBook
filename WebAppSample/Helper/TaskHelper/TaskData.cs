using WebAppSample.Models.TaskModels;

namespace WebAppSample.Helper.TaskHelper
{
    public class TaskData
    {
        public static List<TaskModel> lsTaskModels = new List<TaskModel>();
        public TaskData()
        {

        }

        public void SampleTasks()
        {
            try
            {
                lsTaskModels.Add(new TaskModel(1, "WakeUp", "Get up from the bed",
                    TaskStatusEnum.Closed, DateTime.Now, "Yogesh", "Nature",
                    new TaskTimeStampDetail(DateTime.Today, DateTime.Today)));


                lsTaskModels.Add(new TaskModel(2, "Brush", "Brush the Teeth",
                TaskStatusEnum.Closed, DateTime.Now, "Yogesh", "Yogesh",
                new TaskTimeStampDetail(DateTime.Today, DateTime.Today)));


                lsTaskModels.Add(new TaskModel(3, "Bath", "Task Bath in cold shower",
                TaskStatusEnum.InProgress, DateTime.Now, "Yogesh", "Yogesh",
                new TaskTimeStampDetail(DateTime.Today, DateTime.Today)));


                lsTaskModels.Add(new TaskModel(4, "Coffee", "Prepare Coffee",
                TaskStatusEnum.Hold, DateTime.Now, "Yogesh", "Yogesh",
                new TaskTimeStampDetail(DateTime.Today, DateTime.Today)));


                lsTaskModels.Add(new TaskModel(5, "Breakfast", "Preapre Breakfast",
                TaskStatusEnum.Hold, DateTime.Now, "Yogesh", "Yogesh",
                new TaskTimeStampDetail(DateTime.Today, DateTime.Today)));

            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
