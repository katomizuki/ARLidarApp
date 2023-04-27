using System.Collections.Generic;
using UnityEngine;

namespace Scenes
{
    public struct ARDensePointCloudsChangedEventArgs
    {
        public IReadOnlyList<ARDensePointCloud> added { get; }
        public IReadOnlyList<ARDensePointCloud> updated { get; }
        public IReadOnlyList<ARDensePointCloud> removed { get; }
        
        public ARDensePointCloudsChangedEventArgs(IReadOnlyList<ARDensePointCloud> added, IReadOnlyList<ARDensePointCloud> updated, IReadOnlyList<ARDensePointCloud> removed)
        {
            this.added = added;
            this.updated = updated;
            this.removed = removed;
        }
    }
}