using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoBolos.Dominio
{
    class Jugador
    {
        private String nombreJugador;
        private List<int> lanzamientos;

        public Jugador(String nombre)
        {
            this.nombreJugador = nombre;
            lanzamientos = new List<int>();
        }

        public String obtenerNombre()
        {
            return this.nombreJugador;
        }
        public void agregarPunto(int primerLanzamiento, int segundoLanzamiento)
        {
            if (primerLanzamiento == 10)
            {
                lanzamientos.Add(primerLanzamiento);
                lanzamientos.Add(0);
            }
            else
            {
                lanzamientos.Add(primerLanzamiento);
                lanzamientos.Add(segundoLanzamiento);
            }
        }
        public List<int> obtenerLanzamientos()
        {
            return this.lanzamientos;
        }
    }
}
