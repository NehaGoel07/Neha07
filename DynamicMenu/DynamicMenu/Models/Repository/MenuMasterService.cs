using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicMenu.Models
{
    public class MenuMasterService : IMenuMasterService
    {
        private readonly ApplicationContext applicationContext;

        public MenuMasterService(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        /// <summary>
        /// Return all the menu items
        /// </summary>
        /// <returns>IEnumerable</returns>
        public IEnumerable<MenuMaster> GetMenuMaster()
        {
            return applicationContext.MenuMaster.AsEnumerable();
        }

        /// <summary>
        /// Returns menu item based on id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>MenuMaster</returns>
        public MenuMaster GetMenuMaster(int id)
        {
            var data= applicationContext.MenuMaster.Where(x=>x.MenuIdentity==id).FirstOrDefault();
            return data;
        }

        /// <summary>
        /// Returns menu item based on UserRole and id
        /// </summary>
        /// <param name="UserRole"></param>
        /// <param name="userId"></param>
        /// <returns>IEnumerable</returns>
        public IEnumerable<MenuMaster> GetMenuMaster(string UserRole,string userId)
        {
            var result = applicationContext.MenuMaster.Where(m=>m.User_Roll == UserRole || m.User_Id==userId).ToList();
            return result;
        }

        public IEnumerable<MenuMaster> GetMenuMasterRole(string role)
        {
            var data = applicationContext.MenuMaster.Where(x => x.User_Roll == role).ToList();
            return data;
        }
        /// <summary>
        /// Delete menu from database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>int</returns>
        public int DeleteMenu(int id)
        {
            var menu = GetMenuMaster(id);
            var data = applicationContext.MenuMaster.Where(x => x.Parent_MenuID == menu.MenuID).ToList();
            foreach (var parent in data)
            {
                parent.Parent_MenuID = "*";
            }
            applicationContext.MenuMaster.Remove(menu);
            return applicationContext.SaveChanges();
        }

        /// <summary>
        /// Update existing menu item in database
        /// </summary>
        /// <param name="menuMaster"></param>
        /// <returns>int</returns>
        public int UpdateMenu(MenuMaster menuMaster)
        {
            var result = GetMenuMaster(menuMaster.MenuIdentity);
            var data = applicationContext.MenuMaster.Where(x => x.Parent_MenuID == result.MenuID).ToList();
            foreach(var parent in data)
            {
                parent.Parent_MenuID = menuMaster.MenuID;
            }
            result.IsParent = menuMaster.IsParent;
            result.MenuFileName = menuMaster.MenuFileName;
            result.MenuID = menuMaster.MenuID;
            result.MenuName = menuMaster.MenuName;
            result.MenuURL = menuMaster.MenuURL;
            result.Parent_MenuID = menuMaster.Parent_MenuID;
            result.User_Id = menuMaster.User_Id;
            result.User_Roll = menuMaster.User_Roll;
            result.USE_YN = menuMaster.USE_YN;
            result.CreatedDate = menuMaster.CreatedDate;

            return applicationContext.SaveChanges();
        }

        public int Add(MenuMaster menu)
        {
            _ = applicationContext.MenuMaster.Add(menu);
            return applicationContext.SaveChanges();
        }
    }
}
