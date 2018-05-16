using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsCoockiesSessions
{
    public partial class Default : System.Web.UI.Page
    {
        public string language = "";
        public List<String> users = new List<string>() { "Vasia", "Petia" };
        public String currentUserName = "No user";
        protected void Page_Load(object sender, EventArgs e)
        {
            // Создать объект cookie-набора.
            //читаем куки, если они пришли с клиента
            HttpCookie cookie = Request.Cookies["Preferences"];

            if (cookie != null)
            {
                language = cookie["Language"];
            }
            else {

                cookie = new HttpCookie("Preferences");
                // Установить значение в нем.
                cookie["Language"] = "English";
                language = "English";
                // Добавить в него еще одно значение.
                cookie["Country"] = "US";
                //Хранить 1 год
                cookie.Expires = DateTime.Now.AddYears(1);
                // Добавить cookie-набор к текущему веб-ответу.
                Response.Cookies.Add(cookie);
            }

            if (Session["currentUserName"] != null)
            {
                currentUserName = Session["currentUserName"] as String;
            }
        }

        protected void RU_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Preferences");
            cookie["Language"] = "Russian";
            Response.Cookies.Add(cookie);
            // Добавить в него еще одно значение.
            cookie["Country"] = "US";
            //Хранить 1 год
            cookie.Expires = DateTime.Now.AddYears(1);
            Response.Redirect(@"/Default.aspx");
        }

        protected void Default_Click(object sender, EventArgs e)
        {
            //удаляем куки, обнуляя время хранения
            HttpCookie cookie = new HttpCookie("Preferences");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            Response.Redirect(@"/Default.aspx");
        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            if (users.Contains(login.Text))
            {
                Session["currentUserName"] = login.Text;
                currentUserName = login.Text;
            }
        }
    }
}