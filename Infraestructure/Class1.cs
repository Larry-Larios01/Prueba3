using Domain;
using System;

namespace Infraestructure
{
    public class ActivoFijoModel : IActivoFijoModel<ActivoFijo>
    {
        public ActivoFijo[] ACt;
        public void add(ActivoFijo t)
        {
         
            
            ActivoFijo[] tmp = new ActivoFijo[ACt.Length + 1];
            Array.Copy(ACt, tmp, ACt.Length);
            tmp[tmp.Length - 1] = t;
            ACt = tmp;
        }

        public void Create(ActivoFijo p)
        {
            Add(p, ref ActivoFijo);
        }

        public void create(ActivoFijo t)
        {
            add
        }

        public ActivoFijo[] FIndAll(ActivoFijo t)
        {
            throw new NotImplementedException();
        }

        private void Add(ActivoFijo p, ref Producto[] pds)
        {
           
        }

        
    }
}
