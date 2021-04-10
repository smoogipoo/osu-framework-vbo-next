// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Diagnostics.CodeAnalysis;

namespace VBOOptimisationTest
{
    public interface IVertexAllocator
    {
        /// <summary>
        /// Begins a new vertex batch.
        /// </summary>
        /// <param name="batch">An existing vertex batch. Can be null, in which case a new batch will be set.</param>
        /// <param name="owner">The owner for which the batch is being drawn.</param>
        /// <param name="type">The way in which to draw vertices from the batch.</param>
        /// <param name="count">The number of vertices to be added to the batch.</param>
        /// <returns>Whether the batch needs to have any vertices added to it.</returns>
        bool BeginBatch([NotNull] ref IVertexBatch? batch, IVertexOwner owner, DrawType type, int count);
    }
}
