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
                Make = "HP",
                Model = "Pavilion",
                Year = 2012
            },
            new DeviceVM
            {
                DeviceVMId = 2,
                Make = "Apple",
                Model = "Mac Book Pro",
                Year = 2000
            },
            new DeviceVM
            {
                DeviceVMId = 3,
                Make = "Dell",
                Model = "Dell Machine 5000", 
                Year = 2015
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
    }
}