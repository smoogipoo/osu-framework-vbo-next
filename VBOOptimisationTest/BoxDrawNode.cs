// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Numerics;

namespace VBOOptimisationTest
{
    public class BoxDrawNode : DrawNode
    {
        private IVertexBatch? batch;

        public override void Draw(IVertexAllocator vertexAllocator)
        {
            base.Draw(vertexAllocator);

            if (vertexAllocator.BeginBatch(ref batch, this, DrawType.Triangles, 6))
            {
                batch.Add(new Vector2(0, 1));
                batch.Add(new Vector2(0, 0));
                batch.Add(new Vector2(1, 0));

                batch.Add(new Vector2(0, 1));
                batch.Add(new Vector2(1, 0));
                batch.Add(new Vector2(1, 1));
            }
        }
    }
}
