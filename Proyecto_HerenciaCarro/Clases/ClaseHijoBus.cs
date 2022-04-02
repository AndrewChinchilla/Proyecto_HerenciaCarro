using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_HerenciaCarro.Clases
{
    internal class ClaseHijoBus : ClasePadreCarro
    {
        public int CapacidadPasajeros { get; }
        public string TipodeRuta { get; set; }
        public ClaseHijoBus(string _marca, int _modelo, string _color, int _MAXVEL, int _CapPasajeros, String _TipodeRuta) : base(_marca, _modelo, _color, _MAXVEL)
        {
            CapacidadPasajeros = _CapPasajeros;
            TipodeRuta = _TipodeRuta;
        }
        public string Paradasuben()
        {
            Console.WriteLine("SUBEN SUBEN PASAJEROS!!!...");
            return "";
        }

        public string paradabajan()
        {
            Console.WriteLine("BAJAN BAJAN PASAJEROS!!!...");
            return "";
        }

        public string DameinformacionBus()
        {
            return $" MARCA DEL CARRO: {Marca}  MODELO DEL CARRO: {Modelo}  COLOR DEL CARRO: {Color} CAPACIDAD DE PASAJEROS: {CapacidadPasajeros} TIPO DE RUTA: {TipodeRuta}";
        }

        }
    }
