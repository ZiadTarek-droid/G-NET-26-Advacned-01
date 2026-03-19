using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //A generic class is a class that works with any data type using a type parameter(e.g., <T>).

            //Why use generics?

            //Code reusability

            //Type safety(no casting errors)

            //Better performance
            #endregion
            #region Q2
            //    class Container<T>
            //{
            //    private T item;

            //    public void Add(T value)
            //    {
            //        item = value;
            //    }

            //    public T Get()
            //    {
            //        return item;
            //    }
            //} 
            #endregion
            #region Q3
            //    class Pair<TKey, TValue>
            //{
            //    public TKey Key { get; set; }
            //    public TValue Value { get; set; }

            //    public Pair(TKey key, TValue value)
            //    {
            //        Key = key;
            //        Value = value;
            //    }
            //} 
            #endregion
            #region Q4
            //static void Swap<T>(ref T a, ref T b)
            //{
            //    T temp = a;
            //    a = b;
            //    b = temp;
            //} 
            #endregion
            #region Q5
            //static void Swap<T>(ref T a, ref T b)
            //{
            //    T temp = a;
            //    a = b;
            //    b = temp;
            //} 
            #endregion
            #region Q6
            //    interface IRepository<T>
            //{
            //    void Add(T item);
            //    T Get(int id);
            //    void Remove(int id);
            //} 
            #endregion
            #region Q7
            //    class Example<T> where T : struct
            //{
            //    public T Value;
            //} 
            #endregion
            #region Q8
            //    class Example<T> where T : class
            //{
            //    public T Data;
            //} 
            #endregion
        }
    }
}
