namespace Resume.Models
{
    public class ResumeData
    {        
        public string Summary { get; set; } = string.Empty; 

        public List<CertificationData> Certifications { get; set; } = new(); 

        public List<EducationData> Education { get; set; } = new();

        public List<TechnicalSkillData> Skills { get; set; } = new();

        public List<WorkHistoryData> WorkHistory { get; set; } = new();

    }
}
