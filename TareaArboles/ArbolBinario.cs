﻿using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Drawing; 
using System.Diagnostics; 
using System.Threading;

namespace TareaArboles
{
    class ArbolBinario
    {
        public NodoArbol Raiz;
        public NodoArbol aux;

        public ArbolBinario() 
        { 
            aux = new NodoArbol(); 
        }

        public ArbolBinario(NodoArbol nueva_raiz) 
        { 
            Raiz = nueva_raiz; 
        }
        
        // Función para agregar un nuevo nodo (valor) al Árbol Binario.   
        public void Insertar(int x)
        {
            if (Raiz == null)
            { 
                Raiz = new NodoArbol(x, null, null, null);
                Raiz.nivel = 0;
            }else 
                Raiz = Raiz.Insertar(x, Raiz, Raiz.nivel);
        }

        // Función para eliminar un nodo (valor) del Árbol Binario.   
        public void Eliminar(int x)
        {
            if(Raiz ==  null)
                Raiz =new NodoArbol(x,null,null,null);
            else 
                Raiz.Eliminar(x,ref Raiz);
        }
        
        public void Buscar(int x)
        {
            if(Raiz != null)
            {
                Raiz.buscar(x, Raiz);
            }
        }

        //Función para dibujar árbol binario
        public void DibujarArbol(Graphics grafo,Font fuente,Brush Relleno,Brush RellenoFuente,Pen Lapiz,Brush encuentro)
        {
            int x = 400; 
            // Posiciones de la raíz del árbol
            int y = 75;
            if(Raiz == null)
                return;
            Raiz.PosicionNodo( ref x, y); 
            //Posición de cada nodo
            Raiz.DibujarRamas(grafo, Lapiz);  //Dibuja los Enlaces entre nodos
            //Dibuja todos los Nodos
            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
        }

        public int x1 = 400;

        // Posiciones iniciales de la raíz del árbol
        public int y2 = 75;

        // Función para Colorear los nodos
        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, NodoArbol Raiz, bool post, bool inor, bool preor)
        {
            Brush entorno = Brushes.Red;
            if(inor == true)
            {
                if(Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000);
                    // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor,preor);
                }
            }else
            if(preor == true)
            {
                if(Raiz != null)
                {
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000);// pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post,inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post,inor, preor);
                }
            }else
            if(post ==true)
            {
                if(Raiz !=null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post,inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                }
            }
        }
    }
}
