using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Matriz
    {
        private int[,] matriz;

        public Matriz(int size)
        {
            matriz = new int[size, size];
        }

        public void llenarXRenglón()
        {
            int x = 1;
            for (int r = 0; r < matriz.GetLength(0); r++)
                for (int c = 0; c < matriz.GetLength(1); c++)
                    matriz[r, c] = x++;
        }

        public void llenarXColumna()
        {
            int x = 1;
            for (int r = 0; r < matriz.GetLength(1); r++)
                for (int c = 0; c < matriz.GetLength(0); c++)
                    matriz[c, r] = x++;
        }

        public void llenarXRenglónInverso()
        {
            int x = 1;
            for (int r = matriz.GetLength(0) - 1; r >= 0; r--)
                for (int c = matriz.GetLength(1) - 1; c >= 0; c--)
                    matriz[r, c] = x++;
        }

        public void llenarXColumnaInverso()
        {
            int x = 1;
            for (int r = matriz.GetLength(0) - 1; r >= 0; r--)
                for (int c = matriz.GetLength(1) - 1; c >= 0; c--)
                    matriz[c, r] = x++;
        }

        public string mostrarXRenglón()
        {
            string resultado = "";
            for (int r = 0; r < matriz.GetLength(0); r++)
                for (int c = 0; c < matriz.GetLength(1); c++)
                    resultado += "[" + r.ToString() + "," + c.ToString() + "] = " + matriz[r, c].ToString() + Environment.NewLine;
            return resultado;
        }

        public string mostrarXColumna()
        {
            string resultado = "";
            for (int r = 0; r < matriz.GetLength(0); r++)
                for (int c = 0; c < matriz.GetLength(1); c++)
                    resultado += "[" + c.ToString() + "," + r.ToString() + "] = " + matriz[c, r].ToString() + Environment.NewLine;
            return resultado;
        }

        public string mostrarDiagonalPrincipal()
        {
            string resultado = "";
            for (int i = 0; i < matriz.GetLength(0); i++)
                resultado += "[" + i.ToString() + "," + i.ToString() + "] = " + matriz[i, i].ToString() + Environment.NewLine;
            return resultado;
        }

        public string mostrarDiagonalSecundaria()
        {
            string resultado = "";
            int c = 0;
            for (int r = matriz.GetLength(0) - 1; r >= 0; r--)
                resultado += "[" + r.ToString() + "," + c.ToString() + "] = " + matriz[r, c++].ToString() + Environment.NewLine;
            return resultado;
        }

        public string mostrarArribaDiagonalPrincipal()
        {
            string resultado = "";
            for (int r = 0; r < matriz.GetLength(0) - 1; r++)
                for (int c = r + 1; c < matriz.GetLength(1); c++)
                    resultado += "[" + r.ToString() + "," + c.ToString() + "] = " + matriz[r, c].ToString() + Environment.NewLine;        
            return resultado;
        }

        public string mostrarArribaDiagonalSecundaria()
        {
            string resultado = "";
            for (int r = 0; r < matriz.GetLength(0) - 1; r++)
                for (int c = 0; c < matriz.GetLength(1) - r - 1; c++)
                    resultado += "[" + r.ToString() + "," + c.ToString() + "] = " + matriz[r, c].ToString() + Environment.NewLine;
            return resultado;
        }

        public string mostrarDebajoDiagonalPrincipal()
        {
            string resultado = "";
            for (int r = 1; r < matriz.GetLength(0); r++)
                for (int c = 0; c < r; c++)
                    resultado += "[" + r.ToString() + "," + c.ToString() + "] = " + matriz[r, c].ToString() + Environment.NewLine;
            return resultado;
        }

        public string mostrarDebajoDiagonalSecundaria()
        {
            string resultado = "";
            for (int r = 1; r < matriz.GetLength(0); r++)
                for (int c = matriz.GetLength(0) - r; c < matriz.GetLength(0); c++)
                    resultado += "[" + r.ToString() + "," + c.ToString() + "] = " + matriz[r, c].ToString() + Environment.NewLine;
            return resultado;
        }

        public void rotarXDiagonalPrincipal()
        {
            int aux;
            for (int r = 0; r < matriz.GetLength(0); r++)
                for (int c = r + 1; c < matriz.GetLength(0); c++)
                {
                    aux = matriz[c, r];
                    matriz[c, r] = matriz[r, c];
                    matriz[r, c] = aux;
                }
        }

        public string mostrarPro()
        {
            string resultado = "";
            for (int r = 0; r < matriz.GetLength(0); r++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    resultado += matriz[r, c].ToString() + "\t";
                }
                resultado += Environment.NewLine;
            }
            return resultado;
        }
    }
}