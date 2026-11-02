# Collections Concepts Answers

### 1. What is `IReadOnlyDictionary<TKey, TValue>`?
It is an interface in .NET that provides a read-only view of a dictionary collection. 
It allows accessing elements by key, checking key existence, and iterating over key-value pairs,
 but strictly disables adding, updating, or removing elements.

### 2. Difference between `IReadOnlyDictionary` and `Dictionary`, and why return it?
- **Difference:** `Dictionary` is a mutable concrete implementation class,
allowing full CRUD operations. `IReadOnlyDictionary` is an abstraction/interface that restricts modification.
- **Why Return It from Public Methods:**
  - **Encapsulation & Protection:** To expose internal data safely without allowing external callers 
	to modify the underlying dictionary state.
  - **Contract Integrity:** It explicitly communicates the intent that the returned collection should not be altered.

### 3. How is `SortedDictionary` different from `Dictionary` in Ordering and Lookup Speed?
- **Ordering:**
  - `Dictionary`: Has no guaranteed order; elements are stored based on hash codes in a Hash Table.
  - `SortedDictionary`: Automatically keeps elements sorted by their keys at all times using a Red-Black Tree.
- **Lookup Speed (Time Complexity):**
  - `Dictionary`: Average $\mathcal{O}(1)$ time complexity for lookup, insert, and delete operations.
  - `SortedDictionary`: $\mathcal{O}(\log N)$ time complexity for lookup, insert, and delete operations due to tree traversal.

### 4. When would you choose `SortedDictionary`?
Choose `SortedDictionary` when:
- You continuously need the key-value pairs to remain sorted automatically upon insertion.



### Task 2.2
*S1* : use the HashSet because i need search for value the time complextiy to this collection O(1).
*S2* : Use HashSet because prevent dublcate item and provide look up o(1) speed check if tag exist.
*S3* : List to add grades and allow diblcate items.
*S4* : IReadOnlylist because proivide interface work with items without any modification .
*S5* : SortedDictionary because need order and < Tkey,Tvalue > to sesseion andd time.
*S6* : Use IEnumerable evenif use Yield Keyword because pause and return value in evrey itraion.

