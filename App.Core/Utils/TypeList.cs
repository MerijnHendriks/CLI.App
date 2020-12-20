using System.Collections;
using System.Collections.Generic;

namespace App.Core.Utils
{
    public class TypeList<T1> : IEnumerable<T1>
    {
        private List<T1> list;

        public TypeList()
        {
            list = new List<T1>();
        }

        public IEnumerator<T1> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public T2 Get<T2>() where T2 : T1
        {
            foreach (var item in list)
            {
                if (item.GetType() == typeof(T2))
                {
                    return (T2)item;
                }
            }

            return default;
        }

        public void Add<T2>() where T2 : T1, new()
        {
            if (Get<T2>() != null)
            {
                return;
            }

            list.Add(new T2());
        }

        public void Remove<T2>() where T2 : T1
        {
            foreach (var item in list)
            {
                if (item.GetType() == typeof(T2))
                {
                    list.Remove(item);
                    return;
                }
            }
        }

        public int Count()
        {
            return list.Count;
        }

        public void Clear()
        {
            list.Clear();
        }
    }
}
