// Copyright (C) afuzzyllama. All rights reserved
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System.Collections;
using System.Collections.Generic;

namespace PixelsForGlory.Collections
{
    public class List3D<T> : IList<T>
    {
        private readonly IList<T> _list;

        public readonly Dimensions3D Dimensions;

        public List3D(Dimensions3D dimensions)
        {
            Dimensions = dimensions;
            _list = new List<T>(new T[Dimensions.X * Dimensions.Y * Dimensions.Z]);
        }

        public List3D(List3D<T> list3D)
        {
            Dimensions = list3D.Dimensions;
            _list = new List<T>(list3D._list);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return _list.Remove(item);
        }

        public int Count
        {
            get { return _list.Count; }
        }

        public bool IsReadOnly
        {
            get { return _list.IsReadOnly; }
        }
        public int IndexOf(T item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public T this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }
        }

        public T this[int indexX, int indexY, int indexZ]
        {
            get { return _list[indexX + indexY * Dimensions.X + indexZ * Dimensions.X * Dimensions.Y]; }
            set { _list[indexX + indexY * Dimensions.X + indexZ * Dimensions.X * Dimensions.Y] = value; }
        }
    }
}