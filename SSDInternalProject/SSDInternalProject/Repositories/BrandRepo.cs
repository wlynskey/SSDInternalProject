using SSDInternalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSDInternalProject.Repositories
{
    public class BrandRepo
    {
        private BrandVM[] brandsList =
        {
            new BrandVM
            {
                BrandVMId = 1,
                Brand = "HP"
            },
            new BrandVM
            {
                BrandVMId = 2,
                Brand = "Apple"
            },
            new BrandVM
            {
                BrandVMId = 3,
                Brand = "Dell"
            }
        };
        public List<BrandVM> GetBrandList()
        {
            List<BrandVM> list = new List<BrandVM>();
            foreach (BrandVM item in brandsList)
            {
                list.Add(item);
            }
            return list;
        }
        public BrandVM GetBrand(int id)
        {
            List<BrandVM> list = GetBrandList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].BrandVMId == id)
                {
                    return list[i];
                }
            }
            return null;
        }
    }
}