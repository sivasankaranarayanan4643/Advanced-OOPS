using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// Custom list class making the customized list to store and retrieve objects as our wish of the instance of s<see cref="CustomList"/>
    /// </summary>
    /// <typeparam name="Type">data type of the storing data</typeparam>
    public class CustomList<Type>:IEnumerable,IEnumerator
    {
        /// <summary>
        /// private property for the count of the elements in the list of the instance of <see cref="CustomList"/>
        /// </summary>
        private int _count;
        /// <summary>
        /// private property for the capacity of the list of the instance of <see cref="CustomList"/>
        /// </summary>
        private int _capacity;
        /// <summary>
        /// Read only property for getting the count of the elements in the list of the instance of <see cref="CustomList"/>
        /// </summary>
        public int Count { get{return _count;}}
        /// <summary>
        /// Read only property for gettiing the capacity of the list of the instance of <see cref="CustomList"/>
        /// </summary>
        /// <value></value>
        public int Capacity { get{return _capacity;}}
        /// <summary>
        /// private array for storing the elements of the instance of <see cref="CustomList"/> 
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
        /// <summary>
        /// for initializing the array, count and capacity of the instance of <see cref="CustomList"/>
        /// </summary>
        public CustomList()
        {
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }
        /// <summary>
        /// for initializing the array, count and capacity mentioned by the user of the instance of <see cref="CustomList"/>
        /// </summary>
        public CustomList(int size)
        {
            _count=0;
            _capacity=size;
            _array=new Type[_capacity];
        }
        /// <summary>
        /// Add method for adding a single element in the array of instance of <see cref="CustomList"/>
        /// </summary>
        /// <param name="element"></param>
        public void Add(Type element)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            _array[_count]=element;
            _count++;
        }
        /// <summary>
        /// Grow Size for growing the capacity if it exits the element count
        /// </summary>
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
        /// AddRange method for adding a list of objects or elements to the array
        /// </summary>
        /// <param name="list"></param>
        public void AddRange(CustomList<Type> list)
        {
            _capacity=_count+list.Count+2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            int k=0;
            for(int j=_count;j<_count+list.Count;j++)
            {
                temp[j]=list[k];
                k++;
            }
            _array=temp;
            _count=_count+list.Count;
        }
        int position;
        /// <summary>
        /// For changing the list to IEnumerator type
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            position=-1;
            return (IEnumerator)this;
        }
        
        /// <summary>
        /// For moving next position in the array
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// for reseting the position back to default value at the end othe iteration
        /// </summary>
        public void Reset()
        {
            position=-1;
        }

        /// <summary>
        /// for getting the elements in specified position
        /// </summary>
        public object Current{get {return _array[position];}}

    }
}