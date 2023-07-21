using System.Security.Policy;

namespace AspNetMvcBlog.Models
{
    public class NavbarViewModel
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

        public int CategoryId { get; set; }

       

        public static List<NavbarViewModel> NavList()
        {
            List<NavbarViewModel> navbarViewModels = new List<NavbarViewModel>();

            navbarViewModels.Add(new NavbarViewModel { Id = 1, Name = "HOME",CategoryId=2 });
            navbarViewModels.Add(new NavbarViewModel { Id = 2, Name = "BLOG POST", CategoryId = 1 });
            navbarViewModels.Add(new NavbarViewModel { Id = 3, Name = "ABOUT", CategoryId = 1 });
            navbarViewModels.Add(new NavbarViewModel { Id = 4, Name = "CATEGORY", CategoryId = 2 });
            navbarViewModels.Add(new NavbarViewModel { Id = 5, Name = "POST FORMAT", CategoryId = 1 });
            navbarViewModels.Add(new NavbarViewModel { Id = 6, Name = "CONTACT\"", CategoryId = 1 });

            return navbarViewModels;
        }
    }

    
}
