using System;
using System.Threading;

namespace fabricantevendedor
{
    public class Fabricante
    {
        private Almacen _a;
        private Thread _t;
        //private Random _rnd = new Random();
        private int ms_fabricar;
        private int cantidad;
        public Fabricante(Almacen a, int ms_fabricar, int cantidad)
        {
            this._a = a;
            this.ms_fabricar = ms_fabricar
            this.cantidad = cantidad
        }

        public void Fabrica()
        {
            this._t = new Thread(() => this._Accion());
            this._t.Start();
        }

        public void Termina()
        {
            _t.Join();
        }

        private void _Accion()
        {
            for (int i = 0; i < cantidad; i++)
            {
                Thread.Sleep(ms_fabricar);
                _a.Guardar();
            }
            // int ms;
            // for (int i = 0; i < 10; i++)
            // {
            //     ms = _rnd.Next(1000, 2000);
            //     Thread.Sleep(ms);
            //     _a.Guardar();
            // }
        }
    }

}