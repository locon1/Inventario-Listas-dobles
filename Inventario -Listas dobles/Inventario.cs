using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario__Listas_dobles
{
    class Inventario
    {
        private Producto primero;
        private int _cont;
        public int cont { get { return _cont; } }

        public void agregar(Producto nuevo)
        {
            if (primero == null) {
                primero = nuevo;
                primero.anterior = null;
            }
            else {
                agregar(nuevo, primero);
            }
        }

        private void agregar(Producto nuevo, Producto ultimo)
        {
            if (ultimo.siguiente == null) 
            {
                ultimo.siguiente = nuevo;
                ultimo.siguiente.anterior = ultimo;
            }
            else 
            {
                agregar(nuevo, ultimo.siguiente);
            }
        }

        public Producto Buscar(string name)
        {
            Producto temp = primero;
            while (temp != null && temp.nombre != name) 
            {
                temp = temp.siguiente;
            }
            return temp;
        }

        public bool Eliminar(string name)
        {
            if (primero.nombre == name) 
            {
                primero = primero.siguiente;
                primero.anterior = null;
                return true;
            }
            else 
            {
                Producto temp = primero;
                while (temp.siguiente.nombre != name && temp.siguiente != null) 
                {
                    temp = temp.siguiente;
                }
                if (temp.siguiente == null) 
                {
                    return false;
                }
                else 
                {
                    temp.siguiente = temp.siguiente.siguiente;
                    temp.siguiente.anterior = temp.siguiente.anterior.anterior;
                    _cont--;
                    return true;
                }
            }
        }

        public string Reporte()
        {
            string salida = "Número de productos en el inventario: " + _cont + Environment.NewLine + Environment.NewLine + "Inventario: " + Environment.NewLine + Environment.NewLine;
            Producto temp = primero;
            while (temp != null) {
                salida += temp.ToString() + Environment.NewLine;
                salida += "---------------------------------------------------------------------------" + Environment.NewLine;
                temp = temp.siguiente;
            }
            return salida;
        }

        public string reporte_Inverso()
        {
            Producto temp = primero;
            string salida = "";
            if (primero == null) 
            {
                salida += "Número de productos en el inventario: " + 0 + Environment.NewLine + Environment.NewLine + " No hay nada en el inventario." + Environment.NewLine + Environment.NewLine;
                return salida;
            }
            else 
            {
                while (temp.siguiente != null) 
                {
                    salida += reporte_Inverso(temp);
                    temp = temp.siguiente;
                }
            }
            return salida;
        }

        private string reporte_Inverso(Producto ultimo)
        {
            string salida = "";
            if (ultimo.siguiente == null) {
                salida = "Número de productos en el inventario: " + _cont + Environment.NewLine + Environment.NewLine + "Inventario: " + Environment.NewLine + Environment.NewLine;
                salida += ultimo.ToString() + Environment.NewLine;
                salida += "---------------------------------------------------------------------------" + Environment.NewLine;
            }
            else {
                salida += reporte_Inverso(ultimo.siguiente) + ultimo.ToString();
            }
            return salida;
        }

        public void agregaralInicio(Producto nuevo)
        {
            if (primero == null) {
                primero = nuevo;
                primero.anterior = null;
                _cont++;
            }
            else {
                nuevo.siguiente = primero;
                primero = nuevo;
                primero.siguiente.anterior = primero;
                _cont++;
            }
        }

        public bool eliminar_Inicio()
        {
            if (primero != null) {
                primero = primero.siguiente;
                primero.anterior = null;
                _cont--;
                return true;
            }
            else {
                return false;
            }
        }

        public bool eliminar_Ultimo()
        {
            if (primero != null) {
                Producto temp = primero;
                while (temp.siguiente.siguiente != null) {
                    temp = temp.siguiente;
                }
                temp.siguiente.anterior = null;
                temp.siguiente = null;
                _cont--;
                return true;
            }
            else {
                return false;
            }
        }

        public bool Insertar(Producto nuevo, int posicion)
        {
            if (posicion <= _cont) {
                if (posicion == 1) {
                    nuevo.siguiente = primero;
                    primero = nuevo;
                    primero.anterior = null;
                }
                else {
                    Producto temp = primero;
                    int aux = 1;
                    while (aux < _cont) {
                        if (aux == posicion - 1) {
                            Producto x = temp.siguiente;
                            temp.siguiente = nuevo;
                            temp.siguiente.siguiente = x;
                            temp.siguiente.siguiente.anterior = temp.siguiente;
                            break;
                        }
                        else {
                            temp = temp.siguiente;
                        }
                        aux++;
                    }
                }
                _cont++;
                return true;
            }
            else {
                return false;
            }
        }
    }
}
