using wt_lab5_5razor_cherevan.Models;

namespace wt_lab5_5razor_cherevan.Data;

public static class TaskStore
{
    // Общий список задач для всех страниц
    public static List<TaskItem> Tasks { get; } = new()
    {
        new TaskItem { Id = 1, Title = "Настроить CI/CD", Project = "CRM", Assignee = "Иванов", EstimateHours = 8, Status = "In Progress" },
        new TaskItem { Id = 2, Title = "Спроектировать API", Project = "CRM", Assignee = "Петров", EstimateHours = 16, Status = "To Do" },
        new TaskItem { Id = 3, Title = "Написать тесты", Project = "CRM", Assignee = "Сидоров", EstimateHours = 12, Status = "To Do" },
        new TaskItem { Id = 4, Title = "Обновить документацию", Project = "Internal", Assignee = "Иванов", EstimateHours = 4, Status = "Done" },
        new TaskItem { Id = 5, Title = "Провести код-ревью", Project = "Internal", Assignee = "Петров", EstimateHours = 2, Status = "Done" }
    };
}