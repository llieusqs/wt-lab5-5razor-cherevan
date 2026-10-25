using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_cherevan.Data;
using wt_lab5_5razor_cherevan.Models;

namespace wt_lab5_5razor_cherevan.Pages.Tasks;

public class EditModel : PageModel
{
    [BindProperty]
    public TaskItem Task { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        var existing = TaskStore.Tasks.FirstOrDefault(x => x.Id == id);
        if (existing == null) return NotFound();
        
        Task = existing;
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();

        var index = TaskStore.Tasks.FindIndex(x => x.Id == Task.Id);
        if (index == -1) return NotFound();

        TaskStore.Tasks[index] = Task; // Обновляем задачу в списке
        return RedirectToPage("./Index");
    }
}