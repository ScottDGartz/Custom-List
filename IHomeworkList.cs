using System;

namespace Homework_8
{
	/// <summary>
	/// Contains the properties and methods necessary for the
	/// CustomList homework assignment
	/// </summary>
	interface IHomeworkList
	{
		/// <summary>
		/// Gets the count of valid data in the list.  
		/// This is NOT the same as the length of the internal array.
		/// </summary>
		int Count { get; }

		/// <summary>
		/// Adds a string to the list after all existing data.  If the array is full,
		/// this method must perform the following steps:
		///  - Make a new array that is double the size of the existing array
		///  - Copy all data from the old array to the new one
		///  - Overwrite the old array field with the new array
		///  - Add the new item and update the count of valid data
		/// </summary>
		/// <param name="item">The new data to add</param>
		void Add(String item);

		/// <summary>
		/// Gets an element from the list as long as the index is valid
		/// </summary>
		/// <param name="index">The index of the element to retrieve</param>
		/// <returns>The specified data, or null if the index is less than 0 or >= count</returns>
		String GetData(int index);

		/// <summary>
		/// Overwrites existing data in the list, if the index is valid.  
		/// Valid indices are >= 0 and less than the count.
		/// Indices outside that range will cause this method to do nothing.
		/// </summary>
		/// <param name="index">The index of the element to overwrite</param>
		/// <param name="item">The new data to store in the list</param>
		void SetData(int index, String item);

		/// <summary>
		/// Determines the index of an existing piece of data in the list.
		/// This requires a loop to search through the array, looking for the
		/// first element that matches the specified item.
		/// </summary>
		/// <param name="item">The string to search for</param>
		/// <returns>The index of the element, or -1 if the element isn't found</returns>
		int IndexOf(String item);

		/// <summary>
		/// Determines if a particular piece of data exists in the list.
		/// You can use another method you've written to do most of this work.
		/// Depending on the result of that other method, either return true or false here.
		/// </summary>
		/// <param name="item">The string to search for</param>
		/// <returns>True if the string is in the list, false otherwise</returns>
		bool Contains(String item);

		/// <summary>
		/// Removes a piece of data at the specified index (if the index is valid).
		/// Valid indices are >= 0 and less than the count.
		/// To remove a piece of data, overwrite it with the data next to it.  
		/// This should continue from the specified index to the end of the data, as to not leave a gap.
		/// 
		/// Example data before and after removal:
		/// Indices          0,1,2,3,4,5
		/// Initial data     A,B,C,D,E,F
		/// Remove at 2      A,B,D,E,F,null
		/// </summary>
		/// <param name="index">The index of the data to remove</param>
		void RemoveAt(int index);

		/// <summary>
		/// Removes the first occurance of the specified data from the list, if it exists.
		/// This method should work much like RemoveAt(), shifting data and not leaving a gap.
		/// You should be able to use several other methods you've written to simplify this one.
		/// </summary>
		/// <param name="item">The data to remove</param>
		/// <returns>True if the data was found an removed, false otherwise</returns>
		bool Remove(String item);

		/// <summary>
		/// Inserts a new piece of data at the specified index in the list.
		/// If the index is less than zero, this method should do nothing.
		/// If the index is >= the count, simply add the data like the Add() method would.
		/// Otherwise, you'll need to shift elements over to make room for the new data.
		/// If the internal array is already full, you'll need to resize the array 
		/// similar to what you did in the Add() method.
		/// </summary>
		/// <param name="index">Where to insert the new data</param>
		/// <param name="item">The data to insert</param>
		void Insert(int index, String item);

		/// <summary>
		/// Clears the list by simply setting the count to zero.  Since valid data
		/// is always between zero and the count, setting the count to zero essentially
		/// means the user can't access any existing data.  Future Add() and Insert() calls
		/// will simply overwrite the old data anyway.
		/// </summary>
		void Clear();

		/// <summary>
		/// Loops through all of the data in the list and 
		/// prints each string on a separate line
		/// </summary>
		void Print();
	}
}
