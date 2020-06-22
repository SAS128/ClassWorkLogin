using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassWork_Login
{
    public partial class WebTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected string GetPageData()
        {
            var yesData = ResponseRepository.GetRepository().GetAllResponses().Where(r => r.WillAttend.Value);
            StringBuilder htmlStr = new StringBuilder();
            foreach (var item in yesData)
            {
                htmlStr.Append(String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td></tr>", item.Name, item.Login, item.Password, item.Phone, item.Email,item.CarNumber,item.CarTable));
                Response.Write(htmlStr);
            }
            return htmlStr.ToString();
        }
    }
}