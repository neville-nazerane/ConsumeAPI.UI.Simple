using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumeAPI.UI.Simple
{

    public class ModelListBinder<TModel, TView>  : IModelItemBinder<TView, List<TModel>>
       where TModel : new()
       where TView : IBindableListComponent<TModel>

    {

        List<ModelHandler<TModel>> handlers;

        public ModelListBinder()
        {
            handlers = new List<ModelHandler<TModel>>();
        }

        protected TView Component;
        public TView View {
            get => Component;
            set
            {
                Component = value;
                var access = Component.GetBinderAccess();
                access.OnAdd = handler => handlers.Add(handler);
                access.OnRemove = handler => handlers.Remove(handler);
                access.OnClear = () => handlers.Clear();

                //Component.Added = handler => handlers.Add(handler);
                //Component.Removed = handler => handlers.Remove(handler);
                //Component.Cleared = () => handlers.Clear();
            }
        }


        public List<TModel> Value {
            get
            {
                var list = new List<TModel>();
                foreach (var handler in handlers)
                    list.Add(handler.Model);
                return list;
            }
            set
            {
                Component.Clear();
                foreach (var model in value)
                {
                    var handler = Component.Add();
                    handler.Model = model;
                    handlers.Add(handler);
                }
            }
        }

        public virtual void ClearError()
        {

        }

        public virtual void OnError()
        {

        }
        
    }
}
