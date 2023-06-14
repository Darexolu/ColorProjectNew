using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColorProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateorDelete : ContentPage
    {
        public UpdateorDelete(/*ColorInfo colorInfo=null*/)
        {
            InitializeComponent();
            //if (colorInfo != null)
            //{
            //    ((AddorEditViewModel)BindingContext).Coloured = colorInfo;

            //}

        }
        private void Update(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Delete(object sender, EventArgs e)
        {
            Navigation.PopAsync();

        }

    }
}