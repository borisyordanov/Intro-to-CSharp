using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class GenericList<T>
{
    private int capacity;
    private int indexForNextAdd;

    T[] genericList;

    public GenericList(int capacity = 2)
    {
        this.capacity = capacity;
        this.genericList = new T[capacity];
        this.indexForNextAdd = 0;
    }


    public void Add(T elemToAdd)
    {
        if (indexForNextAdd == genericList.Length)
        {
            T[] newList = new T[this.capacity * 2];
            genericList.CopyTo(newList, 0);
            genericList = newList;

            this.capacity = this.capacity * 2;

        }
        
        genericList[indexForNextAdd] = elemToAdd;

        indexForNextAdd++;
    }


    public T this[int indx]
    {
        get
        {
            return genericList[indx];
        }
    }

    public void RemoveAt(int position)
    {
        if (position >= indexForNextAdd)
        {
            throw new ArgumentOutOfRangeException();
        }

        T[] resultList;

        if (indexForNextAdd - 1 == this.genericList.Length / 2)
        {
            resultList = new T[this.capacity / 2];

            this.capacity = this.capacity / 2;
        }
        else
        {
            resultList = new T[this.capacity];
        }
        
        

        int elemLeft = this.indexForNextAdd - position - 1;

        Array.Copy(genericList, 0, resultList, 0, position);
        Array.Copy(genericList, position + 1, resultList, position, elemLeft);

        indexForNextAdd--;

        genericList = resultList;
    }

    public void AddAt(int position, T value)
    {
        if (position >= indexForNextAdd)
        {
            throw new ArgumentOutOfRangeException();
        }
        
        T[] newList;

        int elemLeft = this.indexForNextAdd - position;

        if (indexForNextAdd == genericList.Length)
        {
            newList = new T[this.capacity * 2];

            this.capacity = this.capacity * 2;
        }
        else
        {
            newList = new T[this.capacity];
        }

        Array.Copy(genericList, 0, newList, 0, position);
        newList[position] = value;
        Array.Copy(genericList, position, newList, position + 1, elemLeft);

        indexForNextAdd++;

        genericList = newList;

    }

    public void Clear()
    {
        genericList = null;
        this.indexForNextAdd = 0;
    }

    public int Find(T searcedValue, int start = 0)
    {
        int indexFound = -1;
        
        for (int i = start; i < this.genericList.Length; i++)
	    {
            if (this.genericList[i].Equals(searcedValue))
            {
                indexFound = i;
                break;
            }
        }

        return indexFound;


    }

    public override string ToString()
    {

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < indexForNextAdd; i++)
		{
            result.Append(String.Format("{0} ", genericList[i]));
        }

        if (indexForNextAdd == 0)
        {
            result.Append("No elements");
        }
        
        return result.ToString();
    }
}

