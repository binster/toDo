﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.Web.Model.Domain;
using ToDoApp.Web.Model.Request;

namespace ToDoApp.Web.Services.Interfaces
{
    public interface IToDoService
    {
        List<ScheduleItem> GetAll();
        ScheduleItem GetTaskById(int id);
        int ScheduleNewTask(ScheduleTask model);
        void UpdateTask(ScheduleTaskWithId model);
        void DeleteTask(int id);
        Task<List<MotivationLink>> GetRedditPosts();
    }
}