using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumeAPI.UI.Simple
{
    public interface IBindableListComponent<TModel>
        where TModel : new()
    {

        //Action<ModelHandler<TModel>> Added { get; set; }
        
        //Action<ModelHandler<TModel>> Removed { get; set; }

        //Action Cleared { get; set; }

        ListBinderAccess<TModel> GetBinderAccess();

        ModelHandler<TModel> Add();

        void Clear();

    }
}
