using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Лабораторная работа 4. Перегрузка операций
 * Вариант 6
 * Класс vector
 * Поля – int (a, b, c). Перегрузить +, -, ++, --, * , * на число, / на число. 
 * Сравнить на == и !=. (d) если a=b=c=0, вектор = false. 
 * Преобразовать в число (модуль) и назад (ax) – в обоих случаях явно.
 */

namespace Project1
{
    class Vector
    {
        private int a;
        private int b;
        private int c;


        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }


        public Vector(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public int this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return A;
                }
                if (index == 1)
                {
                    return B;
                }
                if (index == 2)
                {
                    return C;
                }
                throw new Exception("Exception");
            }
            set
            {
                if (index == 0)
                {
                    A = value;
                }
                if (index == 1)
                {
                    B = value;
                }
                if (index == 2)
                {
                    C = value;
                }
            }
        }

        public double modul()
        {
            return Math.Sqrt((A * A) + (B * B) + (C * C));
        } 

        public static Vector operator +(Vector first, Vector second)
        {
            return new Vector(first.A + second.A, first.B + second.B, first.C + second.C);
        }

        public static Vector operator -(Vector first, Vector second)
        {
            return new Vector(first.A - second.A, first.B - second.B, first.C - second.C);
        }

        public static Vector operator ++(Vector vector)
        {
            return new Vector(vector.A++, vector.B++, vector.C++);
        }

        public static Vector operator --(Vector vector)
        {
            return new Vector(vector.A--, vector.B--, vector.C--);
        }

        public static Vector operator *(Vector first, Vector second)
        {
            return new Vector((first.B * second.C - first.C * second.B), (first.A * second.C - first.C * second.A), (first.A * second.B - first.B * second.A));
        }

        public static Vector operator *(Vector vector, int value)
        {
            return new Vector(vector.A * value, vector.B * value, vector.C * value);
        }

        public static Vector operator /(Vector vector, int value)
        {
            return new Vector(vector.A / value, vector.B / value, vector.C / value);
        }

        public static bool operator ==(Vector first, Vector second)
        {
            return first.A == second.A && first.B == second.B && first.C == second.C;
        }

        public static bool operator <(Vector first, Vector second)
        {
            return first.modul() < second.modul();
        }

        public static bool operator >(Vector first, Vector second)
        {
            return first.modul() > second.modul();
        }

        public static bool operator !=(Vector first, Vector second)
        {
            return first.A != second.A || first.B != second.B || first.C != second.C;
        }

        public static bool operator true(Vector vector)
        {
            return vector.A != 0 && vector.B != 0 && vector.C != 0;
        }

        public static bool operator false(Vector vector)
        {
            return vector.A == 0 && vector.B == 0 && vector.C == 0;
        }

        public static explicit operator double(Vector vector)
        {
            return Math.Sqrt((vector.A * vector.A) + (vector.B * vector.B) + (vector.C * vector.C));
        }

        public static explicit operator Vector(int a)
        {
            return new Vector(a, 0, 0);
        }

        public override string ToString()
        {
            return $"<x:{A}, y:{B}, z:{C}>";
        }
    }
}
