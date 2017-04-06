using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Emzi0767
{
    /// <summary>
    /// Represents a list, which supports Python-like operator operations.
    /// </summary>
    /// <typeparam name="T">Type of contained items.</typeparam>
    public class OperatorList<T> : IEnumerable<T>, ICollection<T>, IList<T>
    {
        /// <summary>
        /// Internal list, actual data holder
        /// </summary>
        internal List<T> InternalList { get; set; }

        /// <summary>
        /// Gets this <see cref="OperatorList{T}"/>'s item count.
        /// </summary>
        public int Count { get { return this.InternalList.Count; } }

        /// <summary>
        /// Gets whether this <see cref="OperatorList{T}"/> is read-only/
        /// </summary>
        public bool IsReadOnly { get { return false; } }

        /// <summary>
        /// Creates a new empty <see cref="OperatorList{T}"/>.
        /// </summary>
        public OperatorList()
        {
            this.InternalList = new List<T>();
        }

        /// <summary>
        /// Creates a new empty <see cref="OperatorList{T}"/> with specified starting capacity.
        /// </summary>
        /// <param name="capacity">Starting capacity of this <see cref="OperatorList{T}"/>.</param>
        public OperatorList(int capacity)
        {
            this.InternalList = new List<T>(capacity);
        }

        /// <summary>
        /// Creates a new <see cref="OperatorList{T}"/>, initially populated with items from specified <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <param name="items"><see cref="IEnumerable{T}"/> of items to initially populate the items with.</param>
        public OperatorList(IEnumerable<T> items)
        {
            this.InternalList = new List<T>(items);
        }

        /// <summary>
        /// Adds an item to this list.
        /// </summary>
        /// <param name="item">Item to add.</param>
        public void Add(T item)
        {
            this.InternalList.Add(item);
        }

        /// <summary>
        /// Adds several items to this list.
        /// </summary>
        /// <param name="items">Items to add.</param>
        public void AddRange(IEnumerable<T> items)
        {
            this.InternalList.AddRange(items);
        }

        /// <summary>
        /// Removes all items from this list.
        /// </summary>
        public void Clear()
        {
            this.InternalList.Clear();
        }

        /// <summary>
        /// Checks whether this list contains the specified item.
        /// </summary>
        /// <param name="item">Item to check for.</param>
        /// <returns>Whether this list contains the item.</returns>
        public bool Contains(T item)
        {
            return this.InternalList.Contains(item);
        }

        /// <summary>
        /// Copies the contents of this <see cref="OperatorList{T}"/> to an array.
        /// </summary>
        /// <param name="array">Array to copy to.</param>
        /// <param name="arrayIndex">Starting index to copy to.</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            this.InternalList.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Gets the enumerator for this <see cref="OperatorList{T}"/>.
        /// </summary>
        /// <returns>Enumerator for this <see cref="OperatorList{T}"/>.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return this.InternalList.GetEnumerator();
        }

        /// <summary>
        /// Returns the index of specified item in this <see cref="OperatorList{T}"/>.
        /// </summary>
        /// <param name="item">Item to search for.</param>
        /// <returns>Index of specified item, or -1 if not found.</returns>
        public int IndexOf(T item)
        {
            return this.InternalList.IndexOf(item);
        }

        /// <summary>
        /// Inserts an item at a specified index in this <see cref="OperatorList{T}"/>.
        /// </summary>
        /// <param name="index">Index to insert at.</param>
        /// <param name="item">Item to insert.</param>
        public void Insert(int index, T item)
        {
            this.InternalList.Insert(index, item);
        }

        /// <summary>
        /// Inserts several items at a specified index in this <see cref="OperatorList{T}"/>.
        /// </summary>
        /// <param name="index">Index to insert at.</param>
        /// <param name="items">Enumerable of items to insert.</param>
        public void InsertRange(int index, IEnumerable<T> items)
        {
            this.InternalList.InsertRange(index, items);
        }

        /// <summary>
        /// Removes a specified item from this <see cref="OperatorList{T}"/>.
        /// </summary>
        /// <param name="item">Item to remove.</param>
        /// <returns>Whether the item was removed.</returns>
        public bool Remove(T item)
        {
            return this.InternalList.Remove(item);
        }

        /// <summary>
        /// Removes several items at specified indices in this <see cref="OperatorList{T}"/>.
        /// </summary>
        /// <param name="index">Starting index of items to remove.</param>
        /// <param name="count">Number of items to remove.</param>
        public void RemoveRange(int index, int count)
        {
            this.InternalList.RemoveRange(index, count);
        }

        /// <summary>
        /// Removes an item at specified index in this <see cref="OperatorList{T}"/>.
        /// </summary>
        /// <param name="index">Index of the item to remove.</param>
        public void RemoveAt(int index)
        {
            this.InternalList.RemoveAt(index);
        }

        /// <summary>
        /// Gets the enumerator for this <see cref="OperatorList{T}"/>.
        /// </summary>
        /// <returns>Enumerator for this <see cref="OperatorList{T}"/>.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.InternalList.GetEnumerator();
        }

        /// <summary>
        /// Gets an item from specified index of this list.
        /// </summary>
        /// <param name="index">Index to get from.</param>
        /// <returns>Requested item.</returns>
        public T this[int index]
        {
            get { return this.InternalList[index]; }
            set { this.InternalList[index] = value; }
        }

        /// <summary>
        /// Adds an item to the specified <see cref="OperatorList{T}"/>. This operator does not mutate the collection.
        /// </summary>
        /// <param name="target">List to add to.</param>
        /// <param name="item">Item to add.</param>
        /// <returns>New <see cref="OperatorList{T}"/> containing the added item.</returns>
        public static OperatorList<T> operator +(OperatorList<T> target, T item)
        {
            return new OperatorList<T>(target.Concat(new[] { item }));
        }

        /// <summary>
        /// Adds items to the specified <see cref="OperatorList{T}"/>. This operator does not mutate the collection.
        /// </summary>
        /// <param name="target">List to add to.</param>
        /// <param name="items">Items to add.</param>
        /// <returns>New <see cref="OperatorList{T}"/> containing the added items.</returns>
        public static OperatorList<T> operator +(OperatorList<T> target, IEnumerable<T> items)
        {
            return new OperatorList<T>(target.Concat(items));
        }

        /// <summary>
        /// Removes an item from the specified <see cref="OperatorList{T}"/>. This operator does not mutate the collection.
        /// </summary>
        /// <param name="target">List to remove from.</param>
        /// <param name="item">Item to remove.</param>
        /// <returns>New <see cref="OperatorList{T}"/> which does not contain the removed item.</returns>
        public static OperatorList<T> operator -(OperatorList<T> target, T item)
        {
            return new OperatorList<T>(target.Except(new[] { item }));
        }

        /// <summary>
        /// Removes items from the specified <see cref="OperatorList{T}"/>. This operator does not mutate the collection.
        /// </summary>
        /// <param name="target">List to remove from.</param>
        /// <param name="items">Items to remove.</param>
        /// <returns>New <see cref="OperatorList{T}"/> which does not contain the removed items.</returns>
        public static OperatorList<T> operator -(OperatorList<T> target, IEnumerable<T> items)
        {
            return new OperatorList<T>(target.Except(items));
        }

        /// <summary>
        /// Compares this <see cref="OperatorList{T}"/> against another <see cref="IEnumerable{T}"/>, and returns whether they are equal.
        /// </summary>
        /// <param name="list1"><see cref="OperatorList{T}"/> to compare.</param>
        /// <param name="list2"><see cref="IEnumerable{T}"/> to compare against.</param>
        /// <returns>Whether the 2 collections are equal.</returns>
        public static bool operator ==(OperatorList<T> list1, IEnumerable<T> list2)
        {
            var o1 = list1 as object;
            var o2 = list2 as object;
            if ((o1 == null && o2 != null) || (o1 != null && o2 == null))
                return false;
            if (o1 == null && o2 == null)
                return true;

            return list1.SequenceEqual(list2);
        }

        /// <summary>
        /// Compares this <see cref="OperatorList{T}"/> against another <see cref="IEnumerable{T}"/>, and returns whether they are not equal.
        /// </summary>
        /// <param name="list1"><see cref="OperatorList{T}"/> to compare.</param>
        /// <param name="list2"><see cref="IEnumerable{T}"/> to compare against.</param>
        /// <returns>Whether the 2 collections are not equal.</returns>
        public static bool operator !=(OperatorList<T> list1, IEnumerable<T> list2)
        {
            return !(list1 == list2);
        }

        /// <summary>
        /// Multiplies this <see cref="OperatorList{T}"/>, creating a list that is a repeated sequence of itself.
        /// </summary>
        /// <param name="target"><see cref="OperatorList{T}"/> to multiply.</param>
        /// <param name="times">Number of times to repeat.</param>
        /// <returns>The multiplied <see cref="OperatorList{T}"/>.</returns>
        public static OperatorList<T> operator *(OperatorList<T> target, int times)
        {
            if (times < 1)
                throw new ArgumentOutOfRangeException(nameof(times), "Times needs to be between 1 and maximum integer value.");

            var tgt = target.AsEnumerable();
            for (var i = 0; i < times - 1; i++)
                tgt = tgt.Concat(target);

            return new OperatorList<T>(tgt);
        }

        /// <summary>
        /// Returns whether this <see cref="OperatorList{T}"/> is not null and contains any items.
        /// </summary>
        /// <param name="target"><see cref="OperatorList{T}"/> to check for items.</param>
        /// <returns>Whether the <see cref="OperatorList{T}"/> contains any items.</returns>
        public static bool operator true(OperatorList<T> target)
        {
            return target != null && target.InternalList.Count > 0;
        }

        /// <summary>
        /// Returns whether this <see cref="OperatorList{T}"/> is null or does not contain any items.
        /// </summary>
        /// <param name="target"><see cref="OperatorList{T}"/> to check for lack of items.</param>
        /// <returns>Whether the <see cref="OperatorList{T}"/> contains no items.</returns>
        public static bool operator false(OperatorList<T> target)
        {
            return target == null || target.InternalList.Count <= 0;
        }

        /// <summary>
        /// Returns items present in both this <see cref="OperatorList{T}"/> and another <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <param name="target"><see cref="OperatorList{T}"/> to get items from.</param>
        /// <param name="list"><see cref="IEnumerable{T}"/> to get items from.</param>
        /// <returns>Intersection of both lists.</returns>
        public static OperatorList<T> operator &(OperatorList<T> target, IEnumerable<T> list)
        {
            return new OperatorList<T>(target.Intersect(list));
        }

        /// <summary>
        /// Returns specified item if the list contains it, returns default value for the type otherwise (null in most cases).
        /// </summary>
        /// <param name="target"><see cref="OperatorList{T}"/> to check.</param>
        /// <param name="item">Item to check for.</param>
        /// <returns>Specified item or default value if it's absent.</returns>
        public static T operator &(OperatorList<T> target, T item)
        {
            var eq = EqualityComparer<T>.Default;
            return target.Contains(item) ? target.FirstOrDefault(xt => eq.Equals(xt, item)) : default(T);
        }

        /// <summary>
        /// Returns a list of distinct items from this <see cref="OperatorList{T}"/> and another <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <param name="target"><see cref="OperatorList{T}"/> to get items from.</param>
        /// <param name="list"><see cref="IEnumerable{T}"/> to get items from.</param>
        /// <returns><see cref="OperatorList{T}"/> of distinct items from sum of both lists.</returns>
        public static OperatorList<T> operator |(OperatorList<T> target, IEnumerable<T> list)
        {
            return new OperatorList<T>(target.Concat(list).Distinct());
        }

        /// <summary>
        /// Returns a <see cref="OperatorList{T}"/> with specified item if it did not contain it, otherwise returns the same list.
        /// </summary>
        /// <param name="target">Target <see cref="OperatorList{T}"/>.</param>
        /// <param name="item">Item to add.</param>
        /// <returns><see cref="OperatorList{T}"/> with specified item.</returns>
        public static OperatorList<T> operator |(OperatorList<T> target, T item)
        {
            return target.Contains(item) ? target : new OperatorList<T>(target.Concat(new[] { item }));
        }

        /// <summary>
        /// Returns a <see cref="OperatorList{T}"/> of items present in either of the lists, but not both.
        /// </summary>
        /// <param name="target"><see cref="OperatorList{T}"/> to get items from.</param>
        /// <param name="list"><see cref="IEnumerable{T}"/> to get items from.</param>
        /// <returns><see cref="OperatorList{T}"/> of items present in either list, but not both at once.</returns>
        public static OperatorList<T> operator ^(OperatorList<T> target, IEnumerable<T> list)
        {
            var l1 = target.Intersect(list);
            return new OperatorList<T>(target.Except(l1).Concat(list.Except(l1)));
        }

        /// <summary>
        /// Returns a <see cref="OperatorList{T}"/> excluding specified item if it contains it, or including it if it does not.
        /// </summary>
        /// <param name="target">Target <see cref="OperatorList{T}"/>.</param>
        /// <param name="item">Item to check for.</param>
        /// <returns><see cref="OperatorList{T}"/> with or without specified item.</returns>
        public static OperatorList<T> operator ^(OperatorList<T> target, T item)
        {
            return target.Contains(item) ? new OperatorList<T>(target.Except(new[] { item })) : new OperatorList<T>(target.Concat(new[] { item }));
        }

        /// <summary>
        /// Returns whether this <see cref="OperatorList{T}"/> has more items than the specified <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <param name="target"><see cref="OperatorList{T}"/> to check.</param>
        /// <param name="list"><see cref="IEnumerable{T}"/> to compare against.</param>
        /// <returns>Whether the <see cref="OperatorList{T}"/> contains more items than the enumerable.</returns>
        public static bool operator >(OperatorList<T> target, IEnumerable<T> list)
        {
            return target.Count > list.Count();
        }

        /// <summary>
        /// Returns whether this <see cref="OperatorList{T}"/> has less items than the specified <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <param name="target"><see cref="OperatorList{T}"/> to check.</param>
        /// <param name="list"><see cref="IEnumerable{T}"/> to compare against.</param>
        /// <returns>Whether the <see cref="OperatorList{T}"/> contains less items than the enumerable.</returns>
        public static bool operator <(OperatorList<T> target, IEnumerable<T> list)
        {
            return target.Count < list.Count();
        }

        /// <summary>
        /// Returns whether this <see cref="OperatorList{T}"/> has a smaller or same item count as the specified <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <param name="target"><see cref="OperatorList{T}"/> to check.</param>
        /// <param name="list"><see cref="IEnumerable{T}"/> to compare against.</param>
        /// <returns>Whether the <see cref="OperatorList{T}"/> contains a smaller or equal number of items than the enumerable.</returns>
        public static bool operator <=(OperatorList<T> target, IEnumerable<T> list)
        {
            return target.Count <= list.Count();
        }

        /// <summary>
        /// Returns whether this <see cref="OperatorList{T}"/> has a larger or same item count as the specified <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <param name="target"><see cref="OperatorList{T}"/> to check.</param>
        /// <param name="list"><see cref="IEnumerable{T}"/> to compare against.</param>
        /// <returns>Whether the <see cref="OperatorList{T}"/> contains a larger or equal number of items than the enumerable.</returns>
        public static bool operator >=(OperatorList<T> target, IEnumerable<T> list)
        {
            return target.Count >= list.Count();
        }

        /// <summary>
        /// Returns whether this <see cref="OperatorList{T}"/> is equal to another object.
        /// </summary>
        /// <param name="obj">Object to compare against.</param>
        /// <returns>Whether this <see cref="OperatorList{T}"/> is equal to specified object.</returns>
        public override bool Equals(object obj)
        {
            var lst = obj as OperatorList<T>;
            if (lst == null)
                return false;

            return this == lst;
        }

        /// <summary>
        /// Returns this <see cref="OperatorList{T}"/>'s hash code.
        /// </summary>
        /// <returns>This <see cref="OperatorList{T}"/>'s hash code.</returns>
        public override int GetHashCode()
        {
            return this.InternalList.GetHashCode();
        }

        /// <summary>
        /// Returns a string representation of this <see cref="OperatorList{T}"/>.
        /// </summary>
        /// <returns>String representation of this <see cref="OperatorList{T}"/>.</returns>
        public override string ToString()
        {
            return string.Concat("{ OperatorList of ", typeof(T).ToString() , " (", this.Count.ToString("#,##0") , " items) }");
        }
    }
}
