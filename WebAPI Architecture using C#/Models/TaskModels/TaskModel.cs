using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using WebAppSample.Helper.TaskHelper;

namespace WebAppSample.Models.TaskModels
{
    public class TaskModel
    {
        public uint TaskID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public TaskStatusEnum TaskStatus { get; set; }
        public DateTime TaskCreationDate { get; set; }
        public string TaskOwner { get; set; }
        public string TaskAssignee { get; set; }
        public TaskTimeStampDetail TaskTimeStamp { get; set; }

        public TaskModel(uint taskID, string taskName, string taskDesc, TaskStatusEnum taskStatusEnum
            , DateTime taskCreationDate, string taskOwner, string taskAssignee, TaskTimeStampDetail taskTimeStampDetail)
        {
            TaskID = taskID;
            TaskName = taskName;
            TaskDescription = taskDesc;
            TaskStatus = taskStatusEnum;
            TaskCreationDate = taskCreationDate;
            TaskOwner = taskOwner;
            TaskAssignee = taskAssignee;
            TaskTimeStamp = taskTimeStampDetail;
        }
    }

    public class TaskTimeStampDetail
    {
        public DateTime TaskStartData { get; set; }
        public DateTime TaskEndData { get; set; }

        public TaskTimeStampDetail(DateTime taskStDate, DateTime taskSpFDate)
        {
            TaskStartData = taskStDate;
            TaskEndData = taskSpFDate;
        }
    }
}
