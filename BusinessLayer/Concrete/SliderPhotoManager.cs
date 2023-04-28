using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SliderPhotoManager : ISliderPhotoService
    {
        private readonly ISliderPhotoDal _sliderPhotoDal;

        public SliderPhotoManager(ISliderPhotoDal sliderPhotoDal)
        {
            _sliderPhotoDal = sliderPhotoDal;
        }

        public void TDelete(SliderPhoto t)
        {
            _sliderPhotoDal.Delete(t);
        }

        public SliderPhoto TGetByID(int id)
        {
            return _sliderPhotoDal.GetByID(id);
        }

        public List<SliderPhoto> TGetList()
        {
            return _sliderPhotoDal.GetListAll();
        }

        public void TInsert(SliderPhoto t)
        {
            _sliderPhotoDal.Insert(t);
        }

        public void TUpdate(SliderPhoto t)
        {
            _sliderPhotoDal.Update(t);
        }
    }
}
