namespace dars1;

public class MyList : IMyList
{
    private int[] _nums;
    private int arrIndex = 0;
    public int Capacity
    {
        get { return _nums.Length; }
    }
    public MyList(int capacticy = 4)
    {
        _nums = new int[capacticy];
    }
    public bool Add(int num)
    {
        if (arrIndex >= Capacity)
        {
            DoubleCapacity();
        }

        _nums[arrIndex] = num;
        arrIndex++;

        return true;
    }
    private void DoubleCapacity()
    {
        int[] newArr = new int[Capacity * 2];
        for (int i = 0; i < Capacity; i++)
        {
            newArr[i] = _nums[i];
        }
        _nums = newArr;
    }

    public bool Contains(int num)
    {
        foreach (var i in _nums)
        {
            if (i == num)
            {
                return true;
            }
        }
        return false;
    }

    public void DisplayElements()
    {
        foreach (var i in _nums)
        {
            Console.Write(i + " ");
        }
    }

    public int GetById(int index)
    {
        return _nums[index];
    }

    public int IndexOf(int num)
    {
        for (int i = 0; i < Capacity; i++)
        {
            if (_nums[i] == num)
            {
                return i;
            }
        }
        return -1;
    }

    public bool Remove(int num)
    {
        for (int i = 0; i < Capacity; i++)
        {
            if (_nums[i] == num)
            {
                for (var j = i; j < Capacity - 1; j++)
                {
                    _nums[j] = _nums[j + 1];
                }
                --arrIndex;
                return true;
            }
        }
        return false;
    }

    public bool RemoveAll(int num)
    {
        var counter = 0;
        while (true)
        {
            var res = Remove(num);
            if (res == false)
            {
                break;
            }
            ++counter;
        }
        return counter != 0;
    }

    public bool RemoveAt(int index)
    {
        if (index < 0 || index > Capacity)
        {
            return false;
        }
        for (int i = 0; i < Capacity - 1; i++)
        {
            _nums[i] = _nums[i + 1];
        }
        --arrIndex;
        return true;
        //return Remove(_nums[index]);
    }
}
