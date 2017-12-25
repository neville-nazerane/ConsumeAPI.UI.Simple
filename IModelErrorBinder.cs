using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumeAPI.UI.Simple
{
    public interface IModelErrorBinder<TView>
    {

        TView View { get; set; }

        void Add(string error);

        void Clear();

    }
    
}
