using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_cherevan.Data;
using wt_lab5_5razor_cherevan.Models;

namespace wt_lab5_5razor_cherevan.Pages.Tasks;

public class DetailsModel : PageModel
{
    // Свойство для хранения найденной задачи
    public TaskItem? Task { get; set; }

    public IActionResult OnGet(int id)
    {
        // Ищем задачу по ID в нашем хранилище
        Task = TaskStore.Tasks.FirstOrDefault(x => x.Id == id);

        // Если задача с таким ID не найдена, возвращаем ошибку 404
        if (Task == null)
        {
            return NotFound();
        }

        // Если нашли - показываем страницу
        return Page();
    }
}