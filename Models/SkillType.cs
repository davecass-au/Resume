using System.ComponentModel;

namespace Resume.Models
{
    public enum SkillType
    {
        Unknown = 0,
        
        [Description("Programming Languages")]
        ProgrammingLanguages = 1,

        [Description("Scientific Languages")]
        ScientificLanguages = 2,

        [Description("Frameworks")]
        Frameworks = 3,

        [Description("Databases")]
        Databases = 4,

        [Description("Cloud Platforms")]
        CloudPlatforms = 5,

        [Description("Data Visualisation")]
        DataVisualisations = 6,

        [Description("Web Services")]
        WebServices = 7,

        [Description("Containerisation")]
        Containerisation = 8,

        [Description("Other Tools")]
        Tools = 9,

        [Description("Agile and Collaboration Tools")]
        CollaborationTools = 10,

    }
}
