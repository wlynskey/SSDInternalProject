using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSDInternalProject.ViewModels;

namespace SSDInternalProject.Repositories
{
    public class StatusRepo
    {
        private StatusVM[] statusList = {
            new StatusVM {
                StatusVMId = 1,
                Status = "evaluation"
            },
            new StatusVM {
                StatusVMId = 2,
                Status = "in queue"
            },
            new StatusVM {
                StatusVMId = 3,
                Status = "in repair"
            },
            new StatusVM {
                StatusVMId = 4,
                Status = "repaired"
            },
            new StatusVM {
                StatusVMId = 5,
                Status = "complete"
            }
        };
        public List<StatusVM> GetStatusList()
        {
            List<StatusVM> list = new List<StatusVM>();
            foreach(StatusVM item in statusList)
            {
                list.Add(item);
            }
            return list;
        }
        public StatusVM GetStatus(int id)
        {
            List<StatusVM> list = GetStatusList();
            for (int i = 0; i < list.Count; i++) 
            {
                if (list[i].StatusVMId == id)
                {
                    return list[i];
                }
            }
            return null;
        }
    }
}