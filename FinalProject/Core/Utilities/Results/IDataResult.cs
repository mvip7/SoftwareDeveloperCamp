using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // interface'ler kendi aralarında implemen edildiğinde kısıtlanma koymak uygun değildir
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
