using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkV3.Entities;
using UnitOfWorkV3.Interfaces;

namespace UnitOfWorkV3.Services
{
    public class SaleService
    {
        private IUnitOfWork _unitOfWork;

        public SaleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateSale(Sale sale)
        {
            using (var context = _unitOfWork.Create())
            {
                try
                {
                    int saleId = context.Repositories.SaleRepository.Create(sale);

                    if (saleId != 0)
                    {
                        int saleDetailId = 1;
                        foreach (var detail in sale.Details)
                        {
                            detail.IdSale = saleId;
                            saleDetailId = context.Repositories.SaleDetailRepository.Create(detail);
                        }

                        if (saleDetailId == 0)
                        {
                            context.SaveChanges();
                        }
                        //else
                        //{
                        //    throw new Exception(); //No hay detalle para agregar, se hace rollback.
                        //}
                    }
                    return saleId;
                }
                catch (Exception)
                {
                    throw;
                }            
            }
        }
    }
}
