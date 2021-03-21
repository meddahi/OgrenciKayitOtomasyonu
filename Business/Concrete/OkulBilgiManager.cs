using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OkulBilgiManager : IOkulBilgiService
    {
        IOkulBilgiDal _okulBilgiDal;
        public OkulBilgiManager(IOkulBilgiDal okulBilgiDal)
        {
            _okulBilgiDal = okulBilgiDal;
        }
        public List<OkulBilgi> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
