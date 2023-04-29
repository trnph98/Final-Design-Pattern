using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.DTO;

namespace Finals.Pattern
{
    class WordsCollection : IteratorAggregate
    {
        List<GoodDTO> _collection = new List<GoodDTO>();
        bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<GoodDTO> getItems()
        {
            return _collection;
        }

        public void AddItem(GoodDTO item)
        {
            this._collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}
