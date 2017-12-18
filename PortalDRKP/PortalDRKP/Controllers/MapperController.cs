using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortalDRKP.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace Portal3.Controllers
{
    public class MapperController : Controller
    {
        PrognozEDWEntities db = new PrognozEDWEntities();
        SalesEntities db2 = new SalesEntities();

        public ActionResult Index(string submitButton, string searchString, string RUfirstname, string RUlastame, string ENfirstname, string ENlastname, string domainname, string mail, string idsprav, string id1c, string idcrm, string staffcode, string empdate, string kickdate)
        {
            switch (submitButton)
            {
                case "Map":
                    {
                        if (RUfirstname != "" && RUlastame != "" && ENfirstname != "" && ENlastname != "" && domainname != "" && mail != "")
                        {
                            try
                            {
                                MapUser(RUfirstname, RUlastame, ENfirstname, ENlastname, domainname, mail,
                                    idsprav, id1c, idcrm, staffcode, empdate, kickdate);
                                ViewBag.Message = "Пользователь замапан!";
                            }
                            catch (Exception ex)
                            {
                                ViewBag.Message = ex.ToString();
                                return PartialView();
                            }
                        }
                        else
                        {
                            ViewBag.Message = "Введите данные в поля!";
                            if (searchString != null && searchString != "")
                                return PartialView(Search(searchString));
                            else
                                return PartialView();
                        }
                        return PartialView(Search(searchString));
                    };

                case "Search":
                    {
                        if (searchString != null && searchString != "")
                        {
                            return PartialView(Search(searchString));
                        }
                        else
                        {
                            ViewBag.Message = "Введите данные в поле поиска!";
                            return PartialView();
                        }
                    }
                default:
                    {
                        return PartialView();
                    }
            }
        }

        public CombinedUserList Search(string str)
        {
            CombinedUserList model = new CombinedUserList();
            List<string> mappedlist = MapperFuncs.MapRUEN(str);
            string request = ";";

            foreach (string mappedres in mappedlist)
                request += mappedres + ";";

            model.list1C = db.MapFind1C(str).ToList();
            model.listCRM = db.MapFindCRM1(request).ToList();
            model.listSpr = db2.MapFindSpr(str).ToList();
            return model;
        }

        public void MapUser(string RUfirstname, string RUlastame, string ENfirstname, string ENlastname, string domainname, string mail, string idsprav, string id1c, string idcrm, string staffcode, string empdate, string kickdate)
        {
            if (idsprav == "")
                idsprav = "-1";

            if (id1c == "")
                id1c = "-1";

            if (idcrm == "")
                idcrm = "-1";

            db2.MapUserUpd(RUfirstname, RUlastame, ENfirstname, ENlastname, domainname, mail, Convert.ToInt32(idsprav), Convert.ToInt32(id1c), idcrm, staffcode, empdate, kickdate);
        }


        //public ActionResult Map(CombinedUserList list)
        //{
        //    try
        //    {
        //        MapUser(list.absuser.RUfirstname, list.absuser.RUlastname, list.absuser.ENfirstname, list.absuser.ENlastname, list.absuser.domainname, list.absuser.mail,
        //                    list.absuser.idsprav, list.absuser.id1c, list.absuser.idcrm, list.absuser.staffcode, list.absuser.empdate, list.absuser.kickdate);
        //        ViewBag.Message = "РџРѕР»СЊР·РѕРІР°С‚РµР»СЊ Р·Р°РјР°РїР°РЅ!";
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Message = ex.ToString();
        //    }
        //    return PartialView();
        //}
    }
}