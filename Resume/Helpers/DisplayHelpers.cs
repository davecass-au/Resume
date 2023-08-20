namespace Resume.Helpers
{
    public static class DisplayHelpers
    {
        public static string GetListForDisplay(List<string> list)
        {
            return string.Join(", ", list);
        }
    }
}
