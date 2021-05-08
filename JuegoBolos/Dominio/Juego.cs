using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoBolos.Dominio
{
    class Juego
    {
        private Jugador jugador1;
        private Jugador jugador2;
        private List<int[]> Lanzamientos = new List<int[]>();

        public Juego(String nombreJugador1, String nombreJugador2)
        {
            this.jugador1 = new Jugador(nombreJugador1);
            this.jugador2 = new Jugador(nombreJugador2);
        }

        public Jugador verJugador1()
        {
            return this.jugador1;
        }
        public Jugador verJugador2()
        {
            return this.jugador2;
        }
        public void Lanzar()
        {
            int turno = 1;
            while (!(turno > 10))
            {
                Random generador = new Random();
                int PinosTirados = generador.Next(0, 11);
                jugador1.agregarPunto(PinosTirados, generador.Next(0,11 - PinosTirados));
                PinosTirados = generador.Next(0, 11);
                jugador2.agregarPunto(PinosTirados, generador.Next(0,11 - PinosTirados));
                turno++;
            }

        }
        public int[] sumatoriaPuntos(Jugador jugador)
        {
            int[] puntaje = new int[10];
            int PuntajeActual = 0;
            for(int i = 0; i < jugador.obtenerLanzamientos().Count; i+=2)
            {
                if(i < 16 && jugador.obtenerLanzamientos()[i] == 10 && jugador.obtenerLanzamientos()[i+2] == 10)
                {
                    PuntajeActual = jugador.obtenerLanzamientos()[i] + jugador.obtenerLanzamientos()[i + 2] + jugador.obtenerLanzamientos()[i + 4];   
                }
                else if(i < 15 && jugador.obtenerLanzamientos()[i] == 10 && jugador.obtenerLanzamientos()[i+2] != 10) 
                {
                    PuntajeActual = jugador.obtenerLanzamientos()[i] + jugador.obtenerLanzamientos()[i + 2] + jugador.obtenerLanzamientos()[i + 3];
                }
                else if(i > 11&& i < 8 &&jugador.obtenerLanzamientos()[i] == 10 && jugador.obtenerNombre()[i+2] == 10)
                {
                    PuntajeActual = jugador.obtenerLanzamientos()[i] + jugador.obtenerLanzamientos()[i + 2];
                }
                else if (i > 15 && i < 19 && jugador.obtenerLanzamientos()[i] == 10)
                {
                    PuntajeActual = jugador.obtenerLanzamientos()[i];
                }
                else
                {
                    PuntajeActual = jugador.obtenerLanzamientos()[i] + jugador.obtenerLanzamientos()[i + 1];
                }
                puntaje[i/2] = PuntajeActual; 

            }
            return puntaje;
        }
    }
}
