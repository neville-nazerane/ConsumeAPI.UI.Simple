using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumeAPI.UI.Simple
{
    public class ListBinderAccess<TModel>
        where TModel : new()
    {

        internal Action<ModelHandler<TModel>> OnAdd;
        public void Add(ModelHandler<TModel> handler) => OnAdd(handler);

        internal Action<ModelHandler<TModel>> OnRemove;
        public void Remove(ModelHandler<TModel> handler) => OnRemove(handler);

        internal Action OnClear;
        public void Clear() => OnClear();



    }
}
