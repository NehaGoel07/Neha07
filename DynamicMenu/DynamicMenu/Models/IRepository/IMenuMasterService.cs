using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicMenu.Models
{
    public interface IMenuMasterService
    {
        IEnumerable<MenuMaster> GetMenuMaster();
        IEnumerable<MenuMaster> GetMenuMaster(string UserRole,string userId);
        int Add(MenuMaster menu);
        MenuMaster GetMenuMaster(int id);
        int UpdateMenu(MenuMaster menuMaster);
        int DeleteMenu(int id);
        IEnumerable<MenuMaster> GetMenuMasterRole(string role);
    }
}
