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
    public partial class ColorCustomView : ContentView
    {
        public ColorCustomView()
        {
            InitializeComponent();
            //BindingContext = new ColorCustomViewModel();
        }
    }
}