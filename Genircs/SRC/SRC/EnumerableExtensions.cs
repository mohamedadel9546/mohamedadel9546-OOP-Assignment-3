

namespace SRC;

public static class EnumerableExtensions
{
    // R1: Page<T>
    public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
    {
        if (source is null) throw new ArgumentNullException(nameof(source));
        if (pageNumber < 1) throw new ArgumentOutOfRangeException(nameof(pageNumber), "Page number must be greater than or equal to 1.");
        if (pageSize < 1) throw new ArgumentOutOfRangeException(nameof(pageSize), "Page size must be greater than or equal to 1.");

        int skipCount = (pageNumber - 1) * pageSize;
        int currentItemIndex = 0;
        int yieldedCount = 0;

        foreach (var item in source)
        {
            if (currentItemIndex >= skipCount && yieldedCount < pageSize)
            {
                yield return item;
                yieldedCount++;
            }

            currentItemIndex++;

            if (yieldedCount == pageSize)
                yield break;
        }
    }

    // R2: FindById<T>
    public static T? FindById<T>(this IEnumerable<T> source, int id) where T : IEntity
    {
        if (source is null) throw new ArgumentNullException(nameof(source));

        foreach (var item in source)
        {
            if (item.ID == id)
            {
                return item;
            }
        }

        return default;
    }

    // R3: ToIdDictionary<T>
    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> source) where T : IEntity
    {
        if (source is null) throw new ArgumentNullException(nameof(source));

        var dictionary = new Dictionary<int, T>();

        foreach (var item in source)
        {
            dictionary.Add(item.ID, item);
        }

        return dictionary;
    }
}