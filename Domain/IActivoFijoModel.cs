using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IActivoFijoModel<T>
    {
        void create(T t);
        T[] FIndAll(T t);
        void add(T t);
    }
}
