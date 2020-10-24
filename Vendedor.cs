using System;
using System.Threading;

namespace fabricantevendedor
{
    public class Vendedor
    {
        private Almacen _a;
        private Thread _t;
        //private Random _rnd = new Random();
        private int ms_vender;
        private int cantidad;
        public Vendedor(Almacen a, int ms_vender, int cantidad)
        {
            this._a = a;
            this.ms_vender = ms_vender
            this.cantidad = cantidad
        }

        public void Vende()
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
                Thread.Sleep(ms_vender);
                _a.Sacar();
            }
            // int ms;
            // for (int i = 0; i < 10; i++)
            // {
            //     ms = _rnd.Next(1000, 1500);
            //     Thread.Sleep(ms);
            //     _a.Sacar();
            // }
        }
    }
}