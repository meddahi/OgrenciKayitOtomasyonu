using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class OkulBilgi: IEntity
    {
        public int BolumId { get; set; }
        public string Bolum { get; set; }
        public string Sinif { get; set; }
        public string Açiklama { get; set; }
    }
}
