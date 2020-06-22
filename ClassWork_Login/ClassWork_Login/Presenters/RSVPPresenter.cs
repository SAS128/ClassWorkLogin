using System;
using System.Collections.Generic;
using ClassWork_Login.Models.Repository;
using ClassWork_Login.Presenters.Results;

namespace ClassWork_Login.Presenters
{
    public class RSVPPresenter :    IPresenter<GuestResponse>, IPresenter<IEnumerable<GuestResponse>>
    {
        [Ninject.Inject]
        public IRepository repository{ get; set; }

        IResult IPresenter<IEnumerable<GuestResponse>>.GetResult()
        {
            return new DataResult<IEnumerable<GuestResponse>>(repository.GetAllResponses());
        }

        IResult IPresenter<GuestResponse>.GetResult()
        {
            return new DataResult<GuestResponse>(new GuestResponse());
        }

        IResult IPresenter<GuestResponse>.GetResult(GuestResponse requestData)
        {
            repository.AddResponse(requestData);
            if (!requestData.WillAttend.HasValue)
                throw new ArgumentNullException("WillAttend не должно быть null");
            if (requestData.WillAttend.Value)
                return new RedirectResult(@"/Content/seeyou.html");
            else
                return new RedirectResult(@"/Content/sorry.html");
        }
        //[Not implemented]
        IResult IPresenter<IEnumerable<GuestResponse>>.GetResult(IEnumerable<GuestResponse> requestData)
        {
            throw new NotImplementedException();
        }
    }
}