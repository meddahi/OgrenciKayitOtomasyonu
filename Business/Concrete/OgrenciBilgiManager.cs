using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OgrenciBilgiManager : IOgrenciBilgiService
    {
        IOgrenciBilgiDal _ogrenciBilgiDal;
        public OgrenciBilgiManager(IOgrenciBilgiDal ogrenciBilgiDal)
        {
            _ogrenciBilgiDal = ogrenciBilgiDal;
        }
        public List<OgrenciBilgi> GetAll()
        {
            //İş kodları
            throw new NotImplementedException();
        }
    }
}
