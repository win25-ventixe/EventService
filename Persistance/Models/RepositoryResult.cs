namespace Persistance.Models;


//Nedan är en metod för att skicka med färdiga felmeddelanden

//public enum ResponseStatus
//{
//    Success,
//    NotFound,
//    Found,
//    Invalid,
//    Failed
//}
public class RepositoryResult
{
    public bool Success { get; set; }

    //public ResponseStatus? Status { get; set; }
    public string? Error { get; set; }
}

public class RepositoryResult<T> : RepositoryResult
{
    public T? Result { get; set; }

}