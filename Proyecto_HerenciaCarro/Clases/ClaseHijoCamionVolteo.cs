using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_HerenciaCarro.Clases
{
    internal class ClaseHijoCamionVolteo : ClasePadreCarro
    {
        public int EspacioCarga { get;  }
        public int FuerzaHidraulica { get; }
        public ClaseHijoCamionVolteo(string _marca, int _modelo, string _color, int _MAXVEL, int _EspacioCarga, int _FuerzaHidraulica) : base(_marca, _modelo, _color, _MAXVEL)

        {
            EspacioCarga = _EspacioCarga;
            FuerzaHidraulica = _FuerzaHidraulica;

        }
        
        public string LevantarVolteoHidraulico()
        {
            Console.WriteLine( "El volteo hidraulico está levantado");
            return "";
        } 

        public string DameinformacionCVolteo()
        {
            return $" MARCA DEL CARRO: {Marca}  MODELO DEL CARRO: {Modelo}  COLOR DEL CARRO: {Color} ESPACIO DE CARGA: {EspacioCarga} FUERZA HIDRAULICA: {FuerzaHidraulica}";

        }

    }
}
