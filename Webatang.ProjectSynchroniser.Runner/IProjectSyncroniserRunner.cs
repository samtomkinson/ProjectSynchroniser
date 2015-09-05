namespace Webatang.ProjectSynchroniser.Runner
{
    using Webatang.ProjectSynchroniser.Domain;

    public interface IProjectSyncroniserRunner
    {
        Project Process(string projectPath);
    }
}
