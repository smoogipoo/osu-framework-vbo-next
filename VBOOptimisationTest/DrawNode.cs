// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace VBOOptimisationTest
{
    public abstract class DrawNode : IVertexOwner
    {
        public virtual void Draw(IVertexAllocator vertexAllocator)
        {
        }
    }
}
