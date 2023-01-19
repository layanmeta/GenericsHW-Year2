using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericHW
{
    internal class Deck<T> where T : struct, IComparable<T>
    {
        readonly List<T> _startingList;
        readonly List<T> _backupList;

        public List<T> StartingList
        {
            get { return _startingList; }
        }

        public List<T> BackupList
        {
            get { return _startingList; }
        }

        protected int size;
        protected int Remaining => _startingList.Count + _backupList.Count;

        public Deck(int size)
        {
            this.size = size;
            _startingList = new List<T>();
            _backupList = new List<T>();
        }

        public void Add(T cards)
        {
            if (Remaining < size)
            {
                _startingList.Add(cards);
            }
        }

        public void Shuffle()
        {
            List<T> shuffleList = new();
            Random r = new Random();
            int currentNum;
            for (int i = 0; i < _startingList.Count; i++)
            {
                currentNum = r.Next(0, _startingList.Count);
                shuffleList.Add(_startingList[currentNum]);
                _startingList.RemoveAt(currentNum);
            }

            for (int i = 0; i < shuffleList.Count; i++)
            {
                _startingList.Add(shuffleList[i]);
            }
        }

        public void Reshuffle()
        {
            foreach (var item in _backupList)
            {
                _startingList.Add(item);
            }
            _backupList.Clear();
            Shuffle();
        }

        public bool TryDraw(T card)
        {
            if (_startingList.Count > 0 && _startingList.Contains(card))
            {
                _startingList.Remove(card);
                _backupList.Add(card);
                return true;
            }
            return false;
        }

        public T Peek()
        {
            if (_startingList.Count > 0)
            {
                return _startingList[0];
            }
            return default(T);
        }
    }
}
