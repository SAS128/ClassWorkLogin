using ClassWork_Login.Presenters.Results;

namespace ClassWork_Login.Presenters
{
    public interface IPresenter<T>
    {
        IResult GetResult();
        IResult GetResult(T requestData);
    }
}
