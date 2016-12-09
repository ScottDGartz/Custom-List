using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    class CustomList : IHomeworkList
    {
        private string[] data;
        private int count;

        public int Count { get;}

        public CustomList(int size)
        {
            data = new String[size];
        }

        public CustomList() : this(4)
        {

        }

        public void Add(String item)
        {
            if (count == data.Length)
            {
                String[] temp = new String[count * 2];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = data[i];
                }
                data = temp;
            }

                data[count] = item;
                count++;
            
        }

        public String GetData (int index)
        {
            if (index >=0 && index< count)
            {
                return data[index];
            }
            else
            {
                return null;
            }
        }

        public void SetData (int index, string item)
        {
            if (index >= 0 && index < count)
            {
                data[index] = item;
            }
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Data at index " + i + ": " + data[i]);
            }
        }

        public int IndexOf(string item)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i] == item)
                {
                    return i;
                } 
            }

            return -1;
        }

        public bool Contains(string item)
        {
            if (IndexOf(item) == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void RemoveAt(int index)
        {
            if(index>=0 && index< count)
            {
                for (int i = index; i < count; i++)
                {
                    data[i] = data[i + 1];
                }
                count--;
            }
        }

        public bool Remove(string item)
        {
            int tempInt = IndexOf(item);
            if (tempInt >= 0)
            {
                for (int i = tempInt; i < count-1; i++)
                {
                    data[i] = data[i + 1];
                }
                count--;
                return true;
                
            }
            return false;
        }

        public void Insert(int index, string item)
        {
            if (index >= 0)
            {
                if (index >= count)
                {
                    if (data[data.Length] != null)
                    {
                        String[] temp = new String[count * 2];
                        data = temp;
                    }
                    data[index] = item;
                }
                else
                {
                    for (int i = count; i > index; i--)
                    {
                        data[i] = data[i - 1];
                    }
                    data[index] = item;
                    count++;
                }
            }
        }
                    

        public void Clear()
        {
            count = 0;
        }
    }
}

