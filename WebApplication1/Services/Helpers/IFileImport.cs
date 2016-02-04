using System.Collections.Generic;

namespace Services.Helpers
{
    public interface IFileImport<T> where T : class
    {
        IEnumerable<T> ReadData();
    }
}