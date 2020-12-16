using System;
using System.Collections.Generic;
using System.Collections;

namespace Stos
{
    public class StosWTablicy<T> : IStos<T>
    {
        private T[] tab;
        private int szczyt = -1;

        public StosWTablicy(int size = 10)
        {
            tab = new T[size];
            szczyt = -1;
        }

        public T Peek => IsEmpty ? throw new StosEmptyException() : tab[szczyt];

        public int Count => szczyt + 1;

        public bool IsEmpty => szczyt == -1;

        public void Clear() => szczyt = -1;

        public T this[int index] => tab[index];

        public T Pop()
        {
            if (IsEmpty)
                throw new StosEmptyException();

            szczyt--;
            return tab[szczyt + 1];
        }

        public void Push(T value)
        {
            if (szczyt == tab.Length - 1)
            {
                Array.Resize(ref tab, tab.Length * 2);
            }

            szczyt++;
            tab[szczyt] = value;
        }

        public T[] ToArray()
        {
            //return tab;  //bardzo źle - reguły hermetyzacji

            //poprawnie:
            T[] temp = new T[szczyt + 1];
            for (int i = 0; i < temp.Length; i++)
                temp[i] = tab[i];
            return temp;
        }

        public void TrimExcess()
        {
            if (IsEmpty)
                throw new StosEmptyException();
            int actualSize = Count;
            int newSize = actualSize + Convert.ToInt32((1d / 10d) * actualSize);
            if (newSize <= 5)
                newSize++;
            Array.Resize(ref tab, newSize);
        }

        public int GetActualTabLength()
        {
            return tab.Length;
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<T> ToArrayReadOnly() => Array.AsReadOnly(tab);


        public IEnumerable<T> Order
        {
            get
            {
                int counter = Count - 1;
                while (counter >= 0)
                {
                    yield return this[counter];
                    counter--;
                }

            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new EnumeratorStosu(this);
        }

        private class EnumeratorStosu : IEnumerator<T>
        {
            private readonly StosWTablicy<T> stos;
            private int index = -1;
            internal EnumeratorStosu(StosWTablicy<T> stos)
            {
                this.stos = stos;
            }
            public T Current
            {
                get
                {
                    return stos.tab[index];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public void Dispose() { }

            public override bool Equals(object obj)
            {
                return obj is EnumeratorStosu stosu &&
                       EqualityComparer<T>.Default.Equals(Current, stosu.Current);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Current);
            }

            public bool MoveNext()
            {
                if (index > stos.Count - 1)
                    return false;
                else
                {
                    index++;
                    return true;
                }

            }
            public void Reset() => index = -1;

            //Bez podpunktu 7 "implementacji interfejsu IStos<T> w klasiie StosWLiscie<T>". Za późno się za to wziąłem ale zawsze jakiś punkt wpadnie. Miłego oceniania :)
        }

    }
}
