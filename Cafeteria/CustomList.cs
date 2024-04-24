using System;
using System.Collections;
using System.Linq;


namespace Cafeteria
{
    /// <summary>
    /// class CustomList is for creating customized list
    /// </summary>
    /// <typeparam name="Type">to make the class generic</typeparam>
    public class CustomList<Type>:IEnumerable,IEnumerator
    {
        /// <summary>
        /// Static field _count used to auto increment the count of the list of the instance of <see cref="UserDetails"/>
        /// </summary>
        private int _count;
        /// <summary>
        /// Static field _capacity used to auto increment the capacity of the list of the instance of <see cref="UserDetails"/>
        /// </summary>
        private int _capacity;
        /// <summary>
        /// Property Count is for returning the count to the user
        /// </summary>
        public int Count { get{return _count;}  }
        /// <summary>
        /// Property Capacity is for returning the Capacity of the list to the user
        /// </summary>
        public int Capacity { get{return _capacity;} }
        /// <summary>
        /// static _array is for the storing the elements given by the user
        /// </summary> 
        private Type[] _array;

        public Type this[int index]
        {
            get{
                return _array[index];
            }
            set{
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

        /// <summary>
        /// Add method for adding the element of the specified datatype
        /// </summary>
        public void Add(Type element)
        {
            if(Count==_capacity)
            {
                GrowSize();
            }
            _array[_count]=element;
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
        /// <summary>
        /// AddRange method for adding multiple elements to the list at the same time
        /// </summary>
        /// <param name="list"></param>
        public void AddRange(CustomList<Type> list)
        {
            _capacity=_count+list.Count+4;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            int k=0;
            for (int j=_count;j<_count+list.Count;j++)
            {
                temp[j]=list[k];
                k++;
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
        public object Current{get {return _array[position];}  }
    }
}