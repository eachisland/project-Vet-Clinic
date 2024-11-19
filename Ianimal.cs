using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectVetClinic
{
    public interface Ianimal
    {
        string Name { get; }
        DateTime Birthday { get; }
        string Breed { get; }
        string MedicalHistory { get; }
        double Weight { get; }
        string Color { get; }
        string Image { get; set; }
        Status Status { get; set; }
    }
}
