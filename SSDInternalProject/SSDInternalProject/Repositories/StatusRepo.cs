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
                Status = "evaluation"
            },
            new StatusVM {
                StatusVMId = 5,
                Status = "evaluation"
            }
        };
        public List<StatusVM> GetStatusList()
        {
            List<StatusVM> list = new List<StatusVM>();
            foreach(StatusVM item in statusList)
            {
                StatusVM status = new StatusVM();
                status.Status = item;
                list.Add(status);
            }
            return list;
        }
    }
}