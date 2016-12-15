using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSDInternalProject.ViewModels;

namespace SSDInternalProject.Repositories
{
    public class DeviceRepo
    {
        private DeviceVM[] devices = {
            new DeviceVM {
                DeviceVMId = 1,                
                Model = "Pavilion",
                Year = 2012,
                BrandVMId = 1                
            },
            new DeviceVM
            {
                DeviceVMId = 2,                
                Model = "Mac Book Pro",
                Year = 2000,
                BrandVMId = 2
            },
            new DeviceVM
            {
                DeviceVMId = 3,                
                Model = "Machine 5000", 
                Year = 2015,
                BrandVMId = 3
            }
        };

        public List<DeviceVM> GetDeviceList()
        {
            List<DeviceVM> list = new List<DeviceVM>();
            foreach(DeviceVM item in devices)
            {
                list.Add(item);
            }
            return list;
        }

        public DeviceVM GetDevice(int id)
        {
            List<DeviceVM> list = GetDeviceList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].DeviceVMId == id)
                {
                    return list[i];
                }
            }
            return null;
        }
    }
}