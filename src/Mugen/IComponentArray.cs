﻿namespace Mugen
{
    public interface IComponentArray<T> where T : struct, IComponent
    {
        ref T this[int index] { get; }
    }
}