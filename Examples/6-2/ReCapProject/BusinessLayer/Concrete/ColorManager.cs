using Business.Constants;
using BusinessLayer.Abstract;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color color)
        {
            if (color.ColorName.Length < 2)
            {
                return new ErrorResult(Messages.ColorAddedError);
            }
            else
            {
                _colorDal.Add(color);
                return new SuccessResult(Messages.ColorAddedSuccess);
            }
        }
        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorListed);
        }

        public IDataResult<Color> GetByID(int Id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == Id));
        }

        public IResult Delete(Color color)
        {
            if (color == null)
            {
                return new ErrorResult(Messages.ColorDeletedError);
            }
            else
            {
                _colorDal.Delete(color);
                return new SuccessResult(Messages.ColorDeletedSuccess);
            }
        }
        public IResult Update(Color color)
        {
            if (color.ColorName.Length < 2)
            {
                return new ErrorResult(Messages.ColorUpdatedError);
            }
            else
            {
                _colorDal.Update(color);
                return new SuccessResult(Messages.ColorUpdatedSuccess);
            }
        }
    }
}
