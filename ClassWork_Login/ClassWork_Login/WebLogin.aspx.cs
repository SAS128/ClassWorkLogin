using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassWork_Login
{
    public partial class WebLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GuestResponse rsvp = new GuestResponse();
                if (TryUpdateModel(rsvp, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    ResponseRepository.GetRepository().AddResponse(rsvp);
                  
                }
            }
        }
    }
}