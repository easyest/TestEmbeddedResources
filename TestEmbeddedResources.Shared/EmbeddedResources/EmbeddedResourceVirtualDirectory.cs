using System.Collections;
using System.Collections.Generic;
using System.Web.Hosting;
using Abp.Resources.Embedded;

namespace TestEmbeddedResources.Shared.EmbeddedResources
{
    public class ComponentsEmbeddedResourceVirtualDirectory : VirtualDirectory
    {
        private readonly List<EmbeddedResourceVirtualFile> _children = new List<EmbeddedResourceVirtualFile>();
        private readonly List<EmbeddedResourceVirtualFile> _files = new List<EmbeddedResourceVirtualFile>();
        //private IEnumerable<EmbeddedResourceItem> _resources;

        public ComponentsEmbeddedResourceVirtualDirectory(string virtualPath, IEnumerable<EmbeddedResourceItem> embeddedResourceItems) : base(virtualPath)
        {
            var virtualPathPart = string.Copy(virtualPath).TrimStart(new[] { '/', '~' }).Replace('/','.');
            var realPathPart = string.Copy(virtualPath).TrimStart(new[] {'/', '~'});

            foreach (var embeddedResourceItem in embeddedResourceItems)
            {
                var fileVirtualPath = embeddedResourceItem.FileName.Replace(virtualPathPart, string.Empty).TrimStart('.');

                var virtualFile = new EmbeddedResourceVirtualFile($"/{realPathPart}/{fileVirtualPath}", embeddedResourceItem);
                //var virtualFile = new ComponentsEmbeddedResourceVirtualFile($"/{embeddedResourceItem.FileName}", embeddedResourceItem);
                _files.Add(virtualFile);
                _children.Add(virtualFile);
            }
        }

        public override IEnumerable Directories => new List<VirtualDirectory>();

        public override IEnumerable Files => _files;
        public override IEnumerable Children => _children;
    }
}
