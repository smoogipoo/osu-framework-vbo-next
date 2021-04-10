// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections;
using System.Collections.Generic;

namespace VBOOptimisationTest
{
    public class CompositeDrawNode : DrawNode, ICollection<DrawNode>
    {
        public readonly List<DrawNode> Children = new List<DrawNode>();

        public override void Draw(IVertexAllocator vertexAllocator)
        {
            base.Draw(vertexAllocator);

            foreach (var c in Children)
                c.Draw(vertexAllocator);
        }

        #region ICollection

        public IEnumerator<DrawNode> GetEnumerator() => Children.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Children).GetEnumerator();

        public void Add(DrawNode item)
        {
            Children.Add(item);
        }

        public void Clear()
        {
            Children.Clear();
        }

        public bool Contains(DrawNode item) => Children.Contains(item);

        public void CopyTo(DrawNode[] array, int arrayIndex)
        {
            Children.CopyTo(array, arrayIndex);
        }

        public bool Remove(DrawNode item) => Children.Remove(item);

        public int Count => Children.Count;

        public bool IsReadOnly => false;

        #endregion
    }
}
