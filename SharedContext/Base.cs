using System;
using POO.NotificatioContext;

namespace POO.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); // SPOF (ponto unico de falha)
        }

        public Guid Id { get; set; }
    }
}