

namespace DotNetFromScratch.Generics.GenericClasses
{
    public class ApiResponse<TData>
    {
        public bool IsSuccessful { get; private set; }
        public string ResultMessage { get; private set; }
        public TData? Data { get; private set; }


        public ApiResponse(TData data, string message)
        {
            Data = data;
            ResultMessage = message;
            IsSuccessful = true;
        }

        public ApiResponse(string message)
        {
            ResultMessage = message;
            IsSuccessful = false;
        }

        /*
        public ApiResponse<TData> GetData(TData data, string message)
        {
            var result = new ApiResponse<TData>();
            result.IsSuccessful = true;
            result.ResultMessage = message;
            result.Data = data;
            return result;

        }
        */
    }

   
}
