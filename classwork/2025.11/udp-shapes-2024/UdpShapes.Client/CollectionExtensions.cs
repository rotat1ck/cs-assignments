namespace UdpShapes.Client;

public static class CollectionExtensions {
    public static IReadOnlyDictionary<K, V> ToSortedList<T, K, V> (
        this IEnumerable<T> items, Func<T, K> toKey, Func<T, V> toValue
    ) where K : notnull {
        SortedList<K, V> result = new SortedList<K, V> ();
        foreach (T item in items)
            result.Add (toKey (item), toValue (item));
        return result;
    }
}
