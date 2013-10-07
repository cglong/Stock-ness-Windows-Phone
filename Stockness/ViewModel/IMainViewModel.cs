using Stockness.Model;
using System.Collections.Generic;

namespace Stockness.ViewModel
{
    public interface IMainViewModel
    {
        string ApplicationTitle { get; }
        string UserName { get; }
        string UserBalance { get; }
        string UserNetChange { get; }

        IList<Position> Positions { get; }
    }
}
