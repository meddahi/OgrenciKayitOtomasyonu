using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class OgrenciBilgi:IEntity
    {
        public long Tc { get; set; }
        public string AdSoyad { get; set; }
        public string TelefonNo { get; set; }
        public DateTime DogumTarih { get; set; }

    }
}
