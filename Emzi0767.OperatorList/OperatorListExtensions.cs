using System;
using System.Collections.Generic;
using System.Text;

namespace Emzi0767.OperatorList
{
    public static class OperatorListExtensions
    {
        /// <summary>
        /// Converts this <see cref="OperatorList{T}"/> into a <see cref="List{T}"/>.
        /// </summary>
        /// <typeparam name="TItem">Type of items in the list.</typeparam>
        /// <param name="target"><see cref="OperatorList{T}"/> to convert.</param>
        /// <returns>Resulting <see cref="List{T}"/>.</returns>
        public static List<TItem> ToList<TItem>(this OperatorList<TItem> target)
        {
            return target.InternalList;
        }
    }
}
