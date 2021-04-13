using System.Collections.Generic;
using System.Reflection;

namespace KR_1
{
    public class SetOfStacks<T>
    {
        private List<Stack<T>> _sets;
        private int _limitation;
        private int _current;
        private int count;

        public SetOfStacks(int limitation)
        {
            this._limitation = limitation;
            _sets = new List<Stack<T>>();
            _sets.Add(new Stack<T>(_limitation));
            _current = 0;
            count = 0;
        }

        public void Push(T item)
        {
            if (_sets[_current].Count == _limitation)
            {
                _current++;
                _sets.Add(new Stack<T>());
            }
            _sets[_current].Push(item);
            count++;
        }

        public T Pop()
        {
            if (count <= 0)
                return default;
            T temp = _sets[_current].Pop();
            count--;
            if (_sets[_current].Count == 0 && _current != 0)
            {
                _sets.RemoveAt(_current);
                _current--;
            }
            return temp;
        }

        public T PopAt(int index)
        {
            if ((uint) index >= _limitation)
            {
                return default;
            }

            return _sets[index].Pop();
        }
    }
}