// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Numerics;

namespace VBOOptimisationTest
{
    public interface IVertexBatch
    {
        void Add(Vector2 vertex);
    }
}
