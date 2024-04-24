using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class CustomList<Type>:IEnumerable,IEnumerator
    {
        private int _count;
        private int _capacity;
        public int Count{get {return _count;}}
        public int Capacity{get {return _capacity;}} 
        private Type[] _array;
        public Type this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index]=value;
            }
        }
        public CustomList()
        {
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }
        public CustomList(int size)
        {
            _count=0;
            _capacity=size;
            _array=new Type[_capacity];
        }
        public void Add(Type element)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            for(int i=_count;i>0;i--)
            {
                _array[i]=_array[i-1];
            }
            _array[0]=element;
            _count++;
        }
        public void GrowSize()
        {
            _capacity*=2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;

        }
        public void AddRange(CustomList<Type> list)
        {
            _capacity=_count+list.Count+4;
            Type[]temp=new Type[_capacity];
            int start=_count;
            for(int i=_count+list.Count-1;i>list.Count-1;i--)
            {
                temp[i]=_array[start];
                start--;
            }
            int k=list.Count-1;
            for(int j=list.Count-1;j>=0;j--)
            {
                temp[j]=list[k];
                k--;
            }
            _array=temp;
            _count=_count+list.Count;
        }
        int position;
        public IEnumerator GetEnumerator()
        {
            position=-1;
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            if(position<_count-1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            position=-1;
        }
        public object Current{get {return _array[position];}}
    }
}