namespace Webatang.ProjectSynchroniser.Runner
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;
    using System.Xml.XPath;

    using Webatang.ProjectSynchroniser.Domain;

    public class DefaultProjectSynchroniserRunner : IProjectSyncroniserRunner
    {
        public Project Process(string projectPath)
        {
            XDocument document = XDocument.Load(projectPath);

            var compileNodes = document.Descendants().Where(e => e.Name.LocalName.Equals("compile", StringComparison.InvariantCultureIgnoreCase));

            return new Project
            {
                FileCount = compileNodes.Count()
            };
        }
    }
}
