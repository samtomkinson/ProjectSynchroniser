namespace Webatang.ProjectSynchroniser.Domain
{
    public class Difference
    {
        public string FileNameAndPath { get; set; }

        public DifferenceLocation DifferenceLocation { get; set; }

        public DifferenceType DifferenceType { get; set; }
    }
}
