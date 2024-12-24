using System.Collections;

namespace k3d.Common.Collections
{
    public class SyncList<T>: IList<T>
    {
        public int Count
        {
            get
            {
                lock (_syncObject)
                {
                    return _list.Count;
                }
            }
        }
        
        public bool IsReadOnly => false;
        
        public T this[int index]
        {
            get
            {
                lock (_syncObject)
                {
                    return _list[index];
                }
            }

            set
            {
                lock (_syncObject)
                {
                    _list[index] = value;
                }
            }
        }

        public SyncList(object syncObject)
        {
            _syncObject = syncObject;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            lock (_syncObject)
            {
                return _list.GetEnumerator();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            lock (_syncObject)
            {
                _list.Add(item);
            }
        }

        public void Clear()
        {
            lock (_syncObject)
            {
                _list.Clear();
            }
        }

        public bool Contains(T item)
        {
            lock (_syncObject)
            {
                return _list.Contains(item);
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            lock (_syncObject)
            {
                _list.CopyTo(array, arrayIndex);
            }
        }

        public bool Remove(T item)
        {
            lock (_syncObject)
            {
                return _list.Remove(item);
            }
        }
        
        public int IndexOf(T item)
        {
            lock (_syncObject)
            {
                return _list.IndexOf(item);
            }
        }

        public void Insert(int index, T item)
        {
            lock (_syncObject)
            {
                _list.Insert(index, item);
            }
        }

        public void RemoveAt(int index)
        {
            lock (_syncObject)
            {
                _list.RemoveAt(index);
            }
        }

        private readonly object _syncObject;
        private readonly List<T> _list = [];
    }
}