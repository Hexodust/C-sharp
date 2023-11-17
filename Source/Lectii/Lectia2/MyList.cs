using System.Collections;

namespace Lectia2;

public class MyList<T> : IEnumerable<T>
{
    private List<T> _list = new();

    public IEnumerator<T> GetEnumerator()
    {
        return _list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(T item)
    {
        if (item is int number && number % 2 != 0)
            return;
        _list.Add(item);
    }
}
