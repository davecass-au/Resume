using Resume.Models;

namespace Resume.Services
{
    public class UserOptions
    {
        public bool NavBarCollapsed { get; private set; }

        public event Action? OnNavBarStateChange;

        public void ToggleNavBar()
        {
            NavBarCollapsed = !NavBarCollapsed;
            NotifyNavBarStateChanged();
        }

        private void NotifyNavBarStateChanged() => OnNavBarStateChange?.Invoke();
    }
}
