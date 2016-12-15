using SSDInternalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSDInternalProject.Repositories {
    public class RepairRepo {
        // Static data
        List<RepairVM> myRepairList = null;

        public RepairRepo() {
            myRepairList = new List<RepairVM>();
            RepairVM repair1 = new RepairVM();
            repair1.RepairVMId = 1;
            repair1.Name = "Monitor Repair";
            repair1.AvgHours = 2;
            repair1.AvgCost = 25;
            repair1.Description = "Screen is broken";
            myRepairList.Add(repair1);

            RepairVM repair2 = new RepairVM();
            repair2.RepairVMId = 2;
            repair2.Name = "Power Source Repair";
            repair2.AvgHours = 1;
            repair2.AvgCost = 30;
            repair2.Description = "Power is burned";
            myRepairList.Add(repair2);
        }

        // Create
        public void Create(string Name, string Password,
                string Phone, string Address) {
            // save change to DB in the future...
        }

        // Read
        public RepairVM GetRepair(int id) {
            List<RepairVM> list = GetRepairList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].RepairVMId == id)
                {
                    return list[i];
                }
            }
            return null;
        }
        
        public List<RepairVM> GetRepairList() {
            return myRepairList;
        }

        // Update
        public void Update(RepairVM repair) {
            // save change to DB in the future...
        }

        // Delete
        public void Delete(int repairId) {
            // save change to DB in the future...
        }
    }
}
