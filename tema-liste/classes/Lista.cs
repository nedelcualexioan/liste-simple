using System;
using System.Collections.Generic;
using System.IO;
using tema_liste.Comparatori;

namespace tema_liste.classes
{
    public class Lista
    {
        private Node head = null;

        private Type type;

        public Type GetType
        {
            get => this.type;
        }

        public Lista(Type type)
        {
            this.type = type;
        }

        public void addStart(Object obj)
        {
            if (head == null)
            {
                head = new Node();
                head.Data = obj;
                head.Next = null;

            }
            else
            {
                Node node = new Node();
                node.Data = obj;
                node.Next = head;

                head = node;
            }


        }

        public void addSfarsit(Object obj)
        {
            if (head == null)
            {
                head = new Node();

                head.Data = obj;
                head.Next = null;
            }
            else
            {

                Node enumerator = this.head;

                while (enumerator.Next != null)
                {
                    enumerator = enumerator.Next;
                }

                enumerator.Next = new Node(obj, null);
            }
        }

        public void addPozitie(Object obj, int poz)
        {
            int i = 0;

            Node enumerator = head;

            while (enumerator != null)
            {
                if (i + 1 == poz)
                {
                    enumerator.Next = new Node(obj, enumerator.Next);


                    return;
                }

                enumerator = enumerator.Next;
                i++;
            }
        }

        public Node enumerator()
        {

            return head;
        }

        public void afisare()
        {
            Node enumerator = this.head;

            while (enumerator != null)
            {
                Console.WriteLine(enumerator.Data.ToString());

                enumerator = enumerator.Next;
            }
        }

        public void removeStart()
        {
            head = head.Next;
        }

        public void removeLast()
        {
            Node enumerator = head;

            while (enumerator.Next.Next != null)
            {
                enumerator = enumerator.Next;
            }

            enumerator.Next = null;
        }

        public void removePoz(int index)
        {
            int i = 0;

            Node enumerator = head;

            while (enumerator != null)
            {
                if (i + 1 == index)
                {
                    enumerator.Next = enumerator.Next.Next;

                    return;
                }

                enumerator = enumerator.Next;
                i++;
            }
        }

        public Node GetNode(int index)
        {
            Node enumerator = head;

            int i = 0;

            while (i != index)
            {
                enumerator = enumerator.Next;
                i++;
            }

            return enumerator;
        }

        public int GetSize()
        {
            int size = 0;

            Node enumerator = head;

            while (enumerator != null)
            {
                size++;

                enumerator = enumerator.Next;
            }

            return size;
        }

        public void setPoz(Object obj, int poz)
        {
            Node enumerator = head;
            int i = 0;

            while (enumerator != null)
            {
                if (i == poz)
                {
                    enumerator.Data = obj;

                    return;
                }

                enumerator = enumerator.Next;
                i++;
            }
        }

        public void sortCresc(Comparer<Elev> comparer)
        {
            int flag;

            do
            {
                flag = 0;

                for (int i = 0; i < this.GetSize() - 1; i++)
                {
                    if (comparer.Compare((Elev)GetNode(i).Data, (Elev)GetNode(i + 1).Data) > 0)
                    {

                        Elev m1 = GetNode(i).Data as Elev;
                        Elev m2 = GetNode(i + 1).Data as Elev;

                        setPoz(m1, i + 1);
                        setPoz(m2, i);

                        flag = 1;

                    }
                }
            } while (flag == 1);
        }

        public void SortCrescCompl(Comparer<Complex> comparer)
        {
            int flag;

            do
            {
                flag = 0;

                for (int i = 0; i < this.GetSize() - 1; i++)
                {
                    if (comparer.Compare((Complex)GetNode(i).Data, (Complex)GetNode(i + 1).Data) > 0)
                    {

                        Elev m1 = GetNode(i).Data as Elev;
                        Elev m2 = GetNode(i + 1).Data as Elev;

                        setPoz(m1, i + 1);
                        setPoz(m2, i);

                        flag = 1;

                    }
                }
            } while (flag == 1);
        }

        public void sortDescresc(Comparer<Elev> comparer)
        {
            int flag;

            do
            {
                flag = 0;

                for (int i = 0; i < this.GetSize() - 1; i++)
                {
                    if (comparer.Compare((Elev)GetNode(i).Data, (Elev)GetNode(i + 1).Data) < 0)
                    {

                        Elev m1 = GetNode(i).Data as Elev;
                        Elev m2 = GetNode(i + 1).Data as Elev;

                        setPoz(m1, i + 1);
                        setPoz(m2, i);

                        flag = 1;

                    }
                }
            } while (flag == 1);
        }
    }
}