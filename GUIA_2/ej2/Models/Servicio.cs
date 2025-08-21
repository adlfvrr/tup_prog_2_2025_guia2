using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1.Models
{
    internal class Servicio
    {
        int cantidadPersonas;
        Persona[] personas;
        public Servicio() { cantidadPersonas = 0; personas = new Persona[100]; }
        public bool AgregarPersona(int dni, string nombre)
        {
            bool agregar = false;
            if (VerPersonaPorDNI(dni) == null)
            {
                agregar = true;
                Persona persona = new Persona(dni, nombre);
                personas[cantidadPersonas] = persona;
                cantidadPersonas++;
            }
            return agregar;
        }
        public int VerCantidadPersonas()
        {
            return cantidadPersonas;
        }
        public Persona VerPersona(int n)
        {
            return personas[n];
        }
        public Persona VerPersonaPorDNI(int dni)
        {
            int idx = -1; int cont = 0;
            while(idx == -1 && cont < cantidadPersonas)
            {
                if (personas[cont].DNI == dni)
                {
                    idx = cont;
                }
                cont++;
            }
            if (idx == -1) { return null; }
            return personas[idx];
        }
        public void EliminarPersona(Persona persona)
        {
            int idx = -1; int cont = 0;
            while( idx == -1 && cont < cantidadPersonas)
            {
                if (personas[cont].DNI == persona.DNI)
                {
                    idx = cont;
                }
                cont++;
            }
            if (idx == -1)
            {
                return;
            }
            else
            {
                personas[idx] = personas[cantidadPersonas - 1];
                cantidadPersonas--;
            }
            /*for(int i = 0; i < cantidadPersonas - 1; i++)
            {
               /* for(int j = i + 1; j < cantidadPersonas; j++)
                {
                    if (personas[i].DNI < personas[j].DNI)
                    {
                        Persona aux = personas[i];
                        personas[i] = personas[j];
                        personas[j] = aux;
                    }
                }*/
            }
        }
    }

