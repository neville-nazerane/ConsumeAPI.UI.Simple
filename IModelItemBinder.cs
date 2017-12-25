using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace ConsumeAPI.UI.Simple
{
    public interface IModelItemBinder<TView, TData>
    {

        TView View { get; set; }

        TData Value { get; set; }

        void OnError();

        void ClearError();

    }
    
   

}
