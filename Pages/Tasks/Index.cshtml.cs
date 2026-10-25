using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_cherevan.Data;
using wt_lab5_5razor_cherevan.Models;

namespace wt_lab5_5razor_cherevan.Pages.Tasks;

public class IndexModel : PageModel
{
    public List<TaskItem> Tasks { get; set; } = new();

    public void OnGet()
    {
        Tasks = TaskStore.Tasks;
    }

    // Обработчик для удаления задачи (POST)
    public IActionResult OnPostDelete(int id)
    {
        var taskToRemove = TaskStore.Tasks.FirstOrDefault(x => x.Id == id);
        if (taskToRemove != null)
        {
            TaskStore.Tasks.Remove(taskToRemove);
        }
        return RedirectToPage("./Index");
    }
}