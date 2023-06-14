using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ColorProject
{
    public class ColorCustomViewModel
    {
        public ObservableCollection<ColorInfo> Colours { get; set; }
        //public string Colorname { get; set; } = "First Color";
        //public Color RgCOLOR { get; set; }
        //public ICommand AddNew { get; set; }
        public ColorCustomViewModel()
        {

            Colours = new ObservableCollection<ColorInfo>();
            Colours.Add(new ColorInfo() { ColourId = 1, ColorName = "R", Coloring = Color.Red });
            Colours.Add(new ColorInfo() { ColourId = 2, ColorName = "G", Coloring = Color.Green });
            Colours.Add(new ColorInfo() { ColourId = 3, ColorName = "B", Coloring = Color.Blue });
            Colours.Add(new ColorInfo() { ColourId = 4, ColorName = "A", Coloring = Color.Aqua });

            MessagingCenter.Subscribe<AddorEditColor, ColorInfo>(this, "AddorEdit", (page, coloured) => {
                if (coloured.ColourId == 0)
                {
                    coloured.ColourId = Colours.Count + 1;
                    Colours.Add(coloured);
                }
               else if (coloured.ColourId > 0)
                {
                    coloured.ColourId = Colours.Count - 1;
                    Colours.Remove(coloured);
                }
                else
                {
                    ColorInfo colorInfoForEdit = Colours.Where(colr => colr.ColourId == coloured.ColourId).FirstOrDefault();
                    int newIndex = Colours.IndexOf(colorInfoForEdit);
                    Colours.Remove(colorInfoForEdit);
                    Colours.Add(coloured);
                    int oldIndex = Colours.IndexOf(coloured);
                    Colours.Move(oldIndex, newIndex);
                }

            });

            //Colours = new List<Color> { Color.R,}

        }
    }
}
