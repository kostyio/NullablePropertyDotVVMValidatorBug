using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotVVM.Framework.Hosting;
using DotVVM.Framework.ViewModel;
using Microsoft.Extensions.Logging;
using NullablePropertyDotVVMValidatorBug.Model;

namespace NullablePropertyDotVVMValidatorBug.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {

        public string Title { get; set; } = "Hello from DotVVM!";

        public ModelWithValidation Model { get; set; }
        public ICollection<RandomEnum?> RandomEnumValues { get; set; } =
        Enum.GetValues<RandomEnum>().Cast<RandomEnum?>().Prepend(null).ToList();

        public async Task Save()
        {

            Title = Model.Name;
        }

        public override Task PreRender()
        {
            if (!Context.IsPostBack)
            {
                Model = new ModelWithValidation()
                {
                    Name = Title
                };
            }

            return base.PreRender();
        }

        public void SelectionChanged()
        {
            Title = Model.Enum.ToString();
        }

    }


}
