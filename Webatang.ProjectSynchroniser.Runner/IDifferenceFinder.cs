namespace Webatang.ProjectSynchroniser.Runner
{
    using System.Collections.Generic;

    using Webatang.ProjectSynchroniser.Domain;

    public interface IDifferenceFinder
    {
        IEnumerable<Difference> ProcessDifferences(Project leftProject, Project rightProject); 
    }
}
