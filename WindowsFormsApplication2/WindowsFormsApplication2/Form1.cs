using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication2
{
    
   
    public partial class Form1 : Form
    {
        //-------------------
        public Form1()
        {
            
            InitializeComponent();   
        }
        //-------------------

        //--
       // private CollectionType<Fighter> cl = new CollectionType<Fighter>(10);
        private List<Fighter> cl = new List<Fighter>(10);
        private delegate int Comparator(Fighter f1, Fighter f2);
        //--

        private void colsize_KeyPress(object sender, KeyPressEventArgs e)
        {
             
          if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        
        }

        private void b1_Click(object sender, EventArgs e)
        {
            int size = Int32.Parse(colsize.Text);

            //CollectionType<Fighter> cl = new CollectionType<Fighter>(size);
            //for (int i = 0; i < size; i++) {
            //    cl.Add(new Fighter());
            //    col.AppendText(i+1 + ") ");
            //    col.AppendText(cl[i].ToString() + "\r\n\r\n");
            //    System.Threading.Thread.Sleep(15);

            //}
            cl = new List<Fighter>(size);
            
            for (int i = 0; i < size; i++)
            {
                cl.Add(new Fighter());
                col.AppendText(i + 1 + ") ");
                col.AppendText(cl[i].ToString() + "\r\n\r\n");
                System.Threading.Thread.Sleep(15);

            }
        }

        private void minbut_Click(object sender, EventArgs e)
        {
            //var query = Ct.Where<CollectionType<Fighter>>(g => g.Count == 2).Select(g => g);
            //var query1 = from g in Ct where g.Count == 2 select g;
            //var query2 = Ct.Max<CollectionType<Fighter>>();
            //var query3 = from g in Ct where g.Count < 10 select g;
            //var quer = cl.Min<Fighter>();
            var quer1 = cl.Min<Fighter>();
            query.Text = quer1 + "\r\n";
            
        }

        private void maxbut_Click(object sender, EventArgs e)
        {
            var quer1 = cl.Max<Fighter>();
            query.Text = quer1 + "\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            col.Clear();
            cl.Sort(delegate(Fighter f1, Fighter f2)
            {
                return f1.CompareTo(f2);
            });

            for (int i = 0; i < cl.Count; i++)
            {
                col.AppendText(i + 1 + ") ");
                col.AppendText(cl[i].ToString() + "\r\n\r\n");
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            col.Clear();
            cl.Sort(delegate(Fighter f1, Fighter f2)
            {
                if (f1.Strength < f1.Strength)
                    return 1;
                if (f1.Strength > f2.Strength)
                    return -1;
                return 0;
            });

            for (int i = 0; i < cl.Count; i++)
            {
                col.AppendText(i + 1 + ") ");
                col.AppendText(cl[i].ToString() + "\r\n\r\n");
            }
        }

    }

    class Fighter : IEnumerable, IComparable                                       //Abstract Fighter
    {
        //статические переменные
        static string[] array;
        static short iterator;
        Random rd = new Random();
        static Fighter()
        {
            array = new string[20];
            iterator = 0;
        }
        //Constructor
        public Fighter(string name = "FaceLess", double str = 15, double agi = 15, double intil = 15, double arm = 0, int atck = 8, int spd = 100)
        {
            
            Name = name;
            Strength = str;
            Agility = agi;
            Intillegence = intil;
            Armor = arm;
            Attack = atck;
            Speed = spd;
            array[iterator++] = name;
            Console.WriteLine("Simple warrior, nothing special");
        }
        public Fighter()
        {
            Name = "NoName";
            Strength = rd.Next(20);
            Agility = rd.Next(20);
            Intillegence = rd.Next(20);
            Armor = rd.Next(20);
            Attack = rd.Next(20);
            Speed = rd.Next(20);
            array[iterator++] = "NoName";
        }

        //индексатор
        public string this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }

        public int CompareTo(Object obj)
        {
            #region exception
            try
            {
                if (!(obj is Fighter)) throw new ArgumentException();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.GetType());
                return -1;
            }
            #endregion
            if (Name == ((Fighter)obj).Name && Strength == ((Fighter)obj).Strength)
                return 0;
            else if (Strength > ((Fighter)obj).Strength)
                return 1;
            else return -1;

        }
        //Main characteristics
        protected string Name { get; set; }
        public double Strength { get; set; }
        protected double Agility { get; set; }
        protected double Intillegence { get; set; }
        protected double Armor { get; set; }
        protected int Attack { get; set; }
        protected int Speed { get; set; }
        //---------------------------------------------------------


        //Virtual writing to file 

        public override string ToString()
        {
            string s = string.Format("Name: {0}, Strength: {1}, Agility: {2}, Intillegence: {3}", Name, Strength,Agility,Intillegence);
            return s;
        }
    }


    class CollectionType<T> : IList<T>, IComparable where T : IComparable, new()
    {
        public T[] array;
        private int _count;
        private int iterator;
        private int contains;

        public CollectionType(int size)
        {
            array = new T[size];
            _count = 0;
            iterator = -1;
        }
        public CollectionType() : this(10) { }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<T>)(array.GetEnumerator());
        }
        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
        public int CompareTo(Object obj)
        {
            if (this.GetCount() == ((CollectionType<T>)obj).GetCount())
                return 0;
            else if (this.GetCount() > ((CollectionType<T>)obj).GetCount())
                return 1;
            else return -1;

        }

        //public Fighter Query(CollectionType<T>[] mass)
        //{
        //  var result = from g in mass where g==g select g;
        //}

        public bool Contains(T value)
        {
            if (IsEmpty() == true) return false;
            for (int i = 0; i < _count; i++)
                if (array[i].CompareTo(value) == 0)
                {
                    contains = i;
                    return true;
                }

            return false;
        }
        private bool IsEmpty()
        {
            return _count == 0;
        }
        public bool Remove(T item)
        {
            #region exception
            if (IsEmpty() == false) return false;
            try
            {
                if (item == null) throw new NullReferenceException("Null parameter");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
            }
            #endregion
            if (Contains(item))
            {
                RemoveAt(contains);
                return true;
            }


            return false;
        }
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }
        public bool WriteToFile()
        {
            if (System.IO.File.Exists(@"e:\4 семестр\c#\3\Collection.txt"))
                System.IO.File.Delete(@"e:\4 семестр\c#\3\Collection.txt");

            for (int g = 0; g < _count; g++)
            {
                System.IO.File.AppendAllText(@"e:\4 семестр\c#\3\Collection.txt", array[g].ToString());
                System.IO.File.AppendAllText(@"e:\4 семестр\c#\3\Collection.txt", "\r\n");
            }
            return true;
        }

        public override string ToString()
        {
            string str = "Collection type:\n";
            for (int g = 0; g < this._count; g++)
            {
                str += array[g].ToString();
                str += "\n";
            }
            return str;
        }
        public void Add(T value)
        {
            array[++iterator] = value;
            _count++;
        }
        public void Clear()
        {
            if (IsEmpty() == true) return;
            for (int i = 0; i < _count; i++)
                array[i] = default(T);

            _count = 0;
            iterator = 0;
        }
        public void CopyTo(T[] newArray, int indexFrom)
        {
            #region exception
            try
            {
                if (newArray == null) throw new ArgumentNullException("Null argument");

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);

            }
            #endregion
            for (int i = 0; i < _count; i++, indexFrom++)
                newArray[indexFrom] = array[i];
        }
        public void Insert(int index, T item)
        {
            #region exception
            try
            {
                if (index > _count || index < 0) throw new IndexOutOfRangeException("Index is out of range");

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);

            }
            #endregion
            array[index] = item;

        }
        public void RemoveAt(int index)
        {
            #region exception
            if (IsEmpty() == true) return;
            try
            {
                if (index > _count || index < 0) throw new IndexOutOfRangeException("Index is out of range");
                if (array[index] == null) throw new ArgumentNullException("Index is null");

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion
            for (int g = index; g < _count - 1; g++)
                array[g] = array[g + 1];

            _count--;
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }
        public int IndexOf(T item)
        {
            if (IsEmpty() == true) return -1;
            Contains(item);
            return contains;
        }
        public int GetCount()
        {
            return _count;
        }


        public T this[int index]
        {
            get
            {
                #region exception
                try
                {
                    if (array[index] == null) throw new ArgumentNullException("This index cotains null data");
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                }
                #endregion
                return array[index];
            }
            set
            {
                #region exception
                try
                {
                    if (index < 0 || index > 10) throw new ArgumentOutOfRangeException("Index is out of a range");
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                #endregion
                array[index] = value;
            }
        }


    }

   

}
