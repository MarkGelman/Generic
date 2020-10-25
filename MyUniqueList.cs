using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    class MyUniqueList
    {
        List<int> list = new List<int>();

        public MyUniqueList()
        {

        }

        public bool Add(int item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                return true;
            }

            throw new ItemAlreadyExistException();
        }

        public bool Remove(int item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                return true;
            }

            throw new ItemNotFoundException();
        }

        public int Peek(int index)
        {
            if (list.Count >= index)
                throw new IndexOutOfRangeException();
            if (list.Contains(list[index]))
                return list[index];
            throw new ItemNotFoundException();
        }

        public int this[int index]
        {
            get
            {
                if (list.Count >= index)
                    throw new IndexOutOfRangeException();
                if (this.list.Contains(list[index]))
                    return this.list[index];
                throw new ItemNotFoundException();
            }
            set
            {
                if (list.Count >= index)
                    throw new IndexOutOfRangeException();
                if (list.Contains(value))
                    throw new ItemAlreadyExistException();
                list[index] = value;
            }
        }
    }
}
