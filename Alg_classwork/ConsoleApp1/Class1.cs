public class CustomDictionary<TKey, TValue>
{
    private List<TKey> keys = new List<TKey>();
    private List<TValue> values = new List<TValue>();

    public void Add(TKey key, TValue value)
    {
        if (!keys.Contains(key))
        {
            keys.Add(key);
            values.Add(value);
        }
        else
        {
            throw new ArgumentException("Key already exists.");
        }
    }


    public TValue Get(TKey key)
    {
        int index = keys.IndexOf(key);
        if (index != -1)
        {
            return values[index];
        }
        throw new KeyNotFoundException("Key not found.");
    }


    public void Remove(TKey key)
    {
        int index = keys.IndexOf(key);
        if (index != -1)
        {
            keys.RemoveAt(index);
            values.RemoveAt(index);
        }
        else
        {
            throw new KeyNotFoundException("Key not found.");
        }
    }

    public void Display()
    {
        for (int i = 0; i < keys.Count; i++)
        {
            Console.WriteLine($"{keys[i]}: {values[i]}");
        }
    }
}