using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NuevaWeb.App.Frontend.Page
{
    public class ListModel : PageModel
    {
        private string [] grupos = {"Grupos 1", "Grupos 2","Grupos 3","Grupos 4"};

        public List<string> GruposMision {get; set;}

        public void OnGet()
        {

            GruposMision = new List<string>();
            GruposMision.AddRange(grupos);
        }

    }
        
}
