/*

 This file is part of VoltDB.
 Copyright (C) 2008-2011 VoltDB Inc.

 Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
 documentation files (the "Software"), to deal in the Software without restriction, including without limitation the
 rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit
 persons to whom the Software is furnished to do so, subject to the following conditions:

 The above copyright notice and this permission notice shall be included in all copies or substantial portions of the
 Software.

 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS BE
 LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*/
using VoltDB.Data.Client.Properties;

namespace VoltDB.Data.Client
{
    /// <summary>
    /// Defines a table wrapper for a table with 21 columns.
    /// </summary>
    /// <typeparam name="T1">Type of column 1 of the underlying table.</typeparam>
    /// <typeparam name="T2">Type of column 2 of the underlying table.</typeparam>
    /// <typeparam name="T3">Type of column 3 of the underlying table.</typeparam>
    /// <typeparam name="T4">Type of column 4 of the underlying table.</typeparam>
    /// <typeparam name="T5">Type of column 5 of the underlying table.</typeparam>
    /// <typeparam name="T6">Type of column 6 of the underlying table.</typeparam>
    /// <typeparam name="T7">Type of column 7 of the underlying table.</typeparam>
    /// <typeparam name="T8">Type of column 8 of the underlying table.</typeparam>
    /// <typeparam name="T9">Type of column 9 of the underlying table.</typeparam>
    /// <typeparam name="T10">Type of column 10 of the underlying table.</typeparam>
    /// <typeparam name="T11">Type of column 11 of the underlying table.</typeparam>
    /// <typeparam name="T12">Type of column 12 of the underlying table.</typeparam>
    /// <typeparam name="T13">Type of column 13 of the underlying table.</typeparam>
    /// <typeparam name="T14">Type of column 14 of the underlying table.</typeparam>
    /// <typeparam name="T15">Type of column 15 of the underlying table.</typeparam>
    /// <typeparam name="T16">Type of column 16 of the underlying table.</typeparam>
    /// <typeparam name="T17">Type of column 17 of the underlying table.</typeparam>
    /// <typeparam name="T18">Type of column 18 of the underlying table.</typeparam>
    /// <typeparam name="T19">Type of column 19 of the underlying table.</typeparam>
    /// <typeparam name="T20">Type of column 20 of the underlying table.</typeparam>
    /// <typeparam name="T21">Type of column 21 of the underlying table.</typeparam>
    public class Table<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
    {
        /// <summary>
        /// Table from which the wrapper feeds.
        /// </summary>
        private Table RawTable;

        /// <summary>
        /// Internal storage for the Row collection.
        /// </summary>
        private readonly RowCollection<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> _Rows;

        /// <summary>
        /// Provides an enumerable collection of records on the table, allowing for full LINQ support.
        /// </summary>
        public RowCollection<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> Rows
        {
            get
            {
                return this._Rows;
            }
        }
        
        /// <summary>
        /// Number of records in the table.
        /// </summary>
        public int RowCount
        {
            get
            {
                return this.RawTable.RowCount;
            }
        }

        /// <summary>
        /// Convenience flag indicating the table actually has data (RowCount > 0).
        /// </summary>
        public bool HasData
        {
            get
            {
                return this.RawTable.RowCount > 0;
            }
        }

        /// <summary>
        /// Instantiate a strongly-typed Table Wrapper around the given generic Table.
        /// </summary>
        /// <param name="table">The table to build the wrapper for.</param>
        internal Table(Table table)
        {
            // Validate column count.
            if (table.ColumnCount != 21)
                throw new VoltInvalidDataException(Resources.InvalidColumnCount, table.ColumnCount);

            // Validate column data types.
            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(0)) == (typeof(T1))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(0)).ToString()
                                                  , typeof(T1).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(1)) == (typeof(T2))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(1)).ToString()
                                                  , typeof(T2).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(2)) == (typeof(T3))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(2)).ToString()
                                                  , typeof(T3).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(3)) == (typeof(T4))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(3)).ToString()
                                                  , typeof(T4).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(4)) == (typeof(T5))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(4)).ToString()
                                                  , typeof(T5).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(5)) == (typeof(T6))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(5)).ToString()
                                                  , typeof(T6).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(6)) == (typeof(T7))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(6)).ToString()
                                                  , typeof(T7).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(7)) == (typeof(T8))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(7)).ToString()
                                                  , typeof(T8).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(8)) == (typeof(T9))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(8)).ToString()
                                                  , typeof(T9).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(9)) == (typeof(T10))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(9)).ToString()
                                                  , typeof(T10).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(10)) == (typeof(T11))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(10)).ToString()
                                                  , typeof(T11).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(11)) == (typeof(T12))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(11)).ToString()
                                                  , typeof(T12).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(12)) == (typeof(T13))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(12)).ToString()
                                                  , typeof(T13).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(13)) == (typeof(T14))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(13)).ToString()
                                                  , typeof(T14).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(14)) == (typeof(T15))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(14)).ToString()
                                                  , typeof(T15).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(15)) == (typeof(T16))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(15)).ToString()
                                                  , typeof(T16).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(16)) == (typeof(T17))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(16)).ToString()
                                                  , typeof(T17).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(17)) == (typeof(T18))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(17)).ToString()
                                                  , typeof(T18).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(18)) == (typeof(T19))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(18)).ToString()
                                                  , typeof(T19).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(19)) == (typeof(T20))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(19)).ToString()
                                                  , typeof(T20).ToString()
                                                  );

            if (!(VoltType.ToDefaultNetType(table.GetColumnDBType(20)) == (typeof(T21))))
                throw new VoltInvalidCastException(
                                                    Resources.InvalidCastException
                                                  , VoltType.ToDefaultNetType(table.GetColumnDBType(20)).ToString()
                                                  , typeof(T21).ToString()
                                                  );

            // Validation complete, keep a reference to the raw table.
            this.RawTable = table;

            // Attach the enumerable row collection.
            this._Rows = new RowCollection<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(this);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T1[] Column1()
        {
            return this.RawTable.GetColumnData<T1>(0);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T1 Column1(int rowIndex)
        {
            return this.RawTable.GetValue<T1>(0, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T2[] Column2()
        {
            return this.RawTable.GetColumnData<T2>(1);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T2 Column2(int rowIndex)
        {
            return this.RawTable.GetValue<T2>(1, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T3[] Column3()
        {
            return this.RawTable.GetColumnData<T3>(2);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T3 Column3(int rowIndex)
        {
            return this.RawTable.GetValue<T3>(2, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T4[] Column4()
        {
            return this.RawTable.GetColumnData<T4>(3);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T4 Column4(int rowIndex)
        {
            return this.RawTable.GetValue<T4>(3, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T5[] Column5()
        {
            return this.RawTable.GetColumnData<T5>(4);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T5 Column5(int rowIndex)
        {
            return this.RawTable.GetValue<T5>(4, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T6[] Column6()
        {
            return this.RawTable.GetColumnData<T6>(5);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T6 Column6(int rowIndex)
        {
            return this.RawTable.GetValue<T6>(5, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T7[] Column7()
        {
            return this.RawTable.GetColumnData<T7>(6);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T7 Column7(int rowIndex)
        {
            return this.RawTable.GetValue<T7>(6, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T8[] Column8()
        {
            return this.RawTable.GetColumnData<T8>(7);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T8 Column8(int rowIndex)
        {
            return this.RawTable.GetValue<T8>(7, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T9[] Column9()
        {
            return this.RawTable.GetColumnData<T9>(8);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T9 Column9(int rowIndex)
        {
            return this.RawTable.GetValue<T9>(8, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T10[] Column10()
        {
            return this.RawTable.GetColumnData<T10>(9);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T10 Column10(int rowIndex)
        {
            return this.RawTable.GetValue<T10>(9, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T11[] Column11()
        {
            return this.RawTable.GetColumnData<T11>(10);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T11 Column11(int rowIndex)
        {
            return this.RawTable.GetValue<T11>(10, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T12[] Column12()
        {
            return this.RawTable.GetColumnData<T12>(11);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T12 Column12(int rowIndex)
        {
            return this.RawTable.GetValue<T12>(11, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T13[] Column13()
        {
            return this.RawTable.GetColumnData<T13>(12);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T13 Column13(int rowIndex)
        {
            return this.RawTable.GetValue<T13>(12, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T14[] Column14()
        {
            return this.RawTable.GetColumnData<T14>(13);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T14 Column14(int rowIndex)
        {
            return this.RawTable.GetValue<T14>(13, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T15[] Column15()
        {
            return this.RawTable.GetColumnData<T15>(14);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T15 Column15(int rowIndex)
        {
            return this.RawTable.GetValue<T15>(14, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T16[] Column16()
        {
            return this.RawTable.GetColumnData<T16>(15);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T16 Column16(int rowIndex)
        {
            return this.RawTable.GetValue<T16>(15, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T17[] Column17()
        {
            return this.RawTable.GetColumnData<T17>(16);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T17 Column17(int rowIndex)
        {
            return this.RawTable.GetValue<T17>(16, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T18[] Column18()
        {
            return this.RawTable.GetColumnData<T18>(17);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T18 Column18(int rowIndex)
        {
            return this.RawTable.GetValue<T18>(17, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T19[] Column19()
        {
            return this.RawTable.GetColumnData<T19>(18);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T19 Column19(int rowIndex)
        {
            return this.RawTable.GetValue<T19>(18, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T20[] Column20()
        {
            return this.RawTable.GetColumnData<T20>(19);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T20 Column20(int rowIndex)
        {
            return this.RawTable.GetValue<T20>(19, rowIndex);
        }
        /// <summary>
        /// Returns a strongly-typed raw data array for the column.
        /// </summary>
        /// <returns>Raw data array of the column content.</returns>
        public T21[] Column21()
        {
            return this.RawTable.GetColumnData<T21>(20);
        }

        /// <summary>
        /// Returns a specific element in the column, at the given row index.
        /// This method is provided for full-coverage, however, if you find yourself iterating through the column
        /// records this way, you are likely better off grabbing the raw data and iterating on a strongly-typed array.
        /// </summary>
        /// <param name="rowIndex">Row index of the element to retrieve.</param>
        /// <returns>The element (field) value.</returns>
        public T21 Column21(int rowIndex)
        {
            return this.RawTable.GetValue<T21>(20, rowIndex);
        }
    }
}
