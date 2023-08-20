using Resume.Models;

namespace Resume.Services
{
    public class MenuItems
    {
        public List<MenuItem> Items { get; private set; } 

        public MenuItems()
        {
            Items = new List<MenuItem>(){
                new MenuItem {
                    Title = "Summary",
                    Href = "",
                    IconClass = "oi oi-person"
                },
                new MenuItem {
                    Title = "Technical Skills",
                    Href = "technicalskills",
                    IconClass = "oi oi-wrench"
                },
                new MenuItem {
                    Title = "Certifications",
                    Href = "certifications",
                    IconClass = "oi oi-badge"
                },
                new MenuItem {
                    Title = "Education",
                    Href = "education",
                    IconClass = "oi oi-monitor"
                },
                new MenuItem {
                    Title = "Work History",
                    Href = "workhistory",
                    IconClass = "oi oi-briefcase"
                }
            };
        } 
    }
}
