using SidkenuWF.Formularios.Base.Controles;
using SidkenuWF.Formularios.Base.Controles.Foto;

namespace SidkenuWF.Formularios.Base
{
    public partial class FormularioBase : Form
    {
        public FormularioBase()
        {
            InitializeComponent();
        }

        public void PoblarComboBox(ComboBox cmb, object data)
        {
            cmb.DataSource = data;
        }

        public void PoblarComboBox(ComboBox cmb, object data, string displayMember, string valueMember)
        {
            cmb.DataSource = data;
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
        }

        public void ActivarControles(object obj, bool estado)
        {
            if (obj is Form)
            {
                foreach (var ctrol in ((Form)obj).Controls)
                {
                    if (ctrol is TextBox)
                    {
                        ((TextBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is RichTextBox)
                    {
                        ((RichTextBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is NumericUpDown)
                    {
                        ((NumericUpDown)ctrol).Enabled = estado;
                    }
                    else if (ctrol is DateTimePicker)
                    {
                        ((DateTimePicker)ctrol).Enabled = estado;
                    }

                    else if (ctrol is Button)
                    {
                        if (((Button)ctrol).Name != "btnSalir")
                        {
                            ((Button)ctrol).Enabled = estado;
                        }
                    }
                    else if (ctrol is ComboBox)
                    {
                        ((ComboBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is Panel)
                    {
                        ActivarControles(ctrol, estado);
                    }
                    else if (ctrol is UserControl)
                    {
                        ActivarControles(ctrol, estado);
                    }
                    // Controles Sidkenu
                    else if (ctrol is SidkenuTextBox)
                    {
                        ((SidkenuTextBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuDatePicker)
                    {
                        ((SidkenuDatePicker)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuComboBox)
                    {
                        ((SidkenuComboBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuButton)
                    {
                        if (((SidkenuButton)ctrol).Name != "btnSalir")
                        {
                            ((SidkenuButton)ctrol).Enabled = estado;
                        }
                    }
                    else if (ctrol is SidkenuCircularPictureBox)
                    {
                        ((SidkenuCircularPictureBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuFoto)
                    {
                        ((SidkenuFoto)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuRadioButton)
                    {
                        ((SidkenuRadioButton)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuToggleButton)
                    {
                        ((SidkenuToggleButton)ctrol).Enabled = estado;
                    }
                }
            }
            else if (obj is Panel)
            {
                foreach (var ctrol in ((Panel)obj).Controls)
                {
                    if (ctrol is TextBox)
                    {
                        ((TextBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is RichTextBox)
                    {
                        ((RichTextBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is NumericUpDown)
                    {
                        ((NumericUpDown)ctrol).Enabled = estado;
                    }
                    else if (ctrol is DateTimePicker)
                    {
                        ((DateTimePicker)ctrol).Enabled = estado;
                    }
                    else if (ctrol is Button)
                    {
                        if (((Button)ctrol).Name != "btnSalir")
                        {
                            ((Button)ctrol).Enabled = estado;
                        }
                    }
                    else if (ctrol is ComboBox)
                    {
                        ((ComboBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is Panel)
                    {
                        ActivarControles(ctrol, estado);
                    }
                    else if (ctrol is UserControl)
                    {
                        ActivarControles(ctrol, estado);
                    }
                    // Controles Sidkenu
                    else if (ctrol is SidkenuTextBox)
                    {
                        ((SidkenuTextBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuDatePicker)
                    {
                        ((SidkenuDatePicker)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuComboBox)
                    {
                        ((SidkenuComboBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuButton)
                    {
                        if (((SidkenuButton)ctrol).Name != "btnSalir")
                        {
                            ((SidkenuButton)ctrol).Enabled = estado;
                        }
                    }
                    else if (ctrol is SidkenuCircularPictureBox)
                    {
                        ((SidkenuCircularPictureBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuFoto)
                    {
                        ((SidkenuFoto)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuRadioButton)
                    {
                        ((SidkenuRadioButton)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuToggleButton)
                    {
                        ((SidkenuToggleButton)ctrol).Enabled = estado;
                    }
                }
            }
            else if (obj is UserControl)
            {
                foreach (var ctrol in ((UserControl)obj).Controls)
                {
                    if (ctrol is TextBox)
                    {
                        ((TextBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is RichTextBox)
                    {
                        ((RichTextBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is NumericUpDown)
                    {
                        ((NumericUpDown)ctrol).Enabled = estado;
                    }
                    else if (ctrol is DateTimePicker)
                    {
                        ((DateTimePicker)ctrol).Enabled = estado;
                    }
                    else if (ctrol is Button)
                    {
                        if (((Button)ctrol).Name != "btnSalir")
                        {
                            ((Button)ctrol).Enabled = estado;
                        }
                    }
                    else if (ctrol is ComboBox)
                    {
                        ((ComboBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is Panel)
                    {
                        ActivarControles(ctrol, estado);
                    }
                    else if (ctrol is UserControl)
                    {
                        ActivarControles(ctrol, estado);
                    }
                    // Controles Sidkenu
                    else if (ctrol is SidkenuTextBox)
                    {
                        ((SidkenuTextBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuDatePicker)
                    {
                        ((SidkenuDatePicker)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuComboBox)
                    {
                        ((SidkenuComboBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuButton)
                    {
                        if (((SidkenuButton)ctrol).Name != "btnSalir")
                        {
                            ((SidkenuButton)ctrol).Enabled = estado;
                        }
                    }
                    else if (ctrol is SidkenuCircularPictureBox)
                    {
                        ((SidkenuCircularPictureBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuFoto)
                    {
                        ((SidkenuFoto)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuRadioButton)
                    {
                        ((SidkenuRadioButton)ctrol).Enabled = estado;
                    }
                    else if (ctrol is SidkenuToggleButton)
                    {
                        ((SidkenuToggleButton)ctrol).Enabled = estado;
                    }
                }
            }
        }

        public void LimpiarControles(object obj)
        {
            if (obj is Form)
            {
                foreach (var ctrol in ((Form)obj).Controls)
                {
                    if (ctrol is TextBox)
                    {
                        ((TextBox)ctrol).Clear();
                    }
                    else if (ctrol is RichTextBox)
                    {
                        ((RichTextBox)ctrol).Clear();
                    }
                    else if (ctrol is NumericUpDown)
                    {
                        ((NumericUpDown)ctrol).Value = ((NumericUpDown)ctrol).Minimum;
                    }
                    else if (ctrol is DateTimePicker)
                    {
                        ((DateTimePicker)ctrol).Value = DateTime.Now;
                    }
                    else if (ctrol is Panel)
                    {
                        LimpiarControles(ctrol);
                    }
                    // Sidkenu
                    else if (ctrol is SidkenuTextBox)
                    {
                        ((SidkenuTextBox)ctrol).Texts = string.Empty;
                    }
                    else if (ctrol is SidkenuDatePicker)
                    {
                        ((SidkenuDatePicker)ctrol).Value = DateTime.Now;
                    }
                    else if (ctrol is Panel)
                    {
                        LimpiarControles(ctrol);
                    }
                    else if (ctrol is TabControl)
                    {
                        LimpiarControles(ctrol);
                    }
                }
            }
            else if (obj is Panel)
            {
                foreach (var ctrol in ((Panel)obj).Controls)
                {
                    if (ctrol is TextBox)
                    {
                        ((TextBox)ctrol).Clear();
                    }
                    else if (ctrol is RichTextBox)
                    {
                        ((RichTextBox)ctrol).Clear();
                    }
                    else if (ctrol is NumericUpDown)
                    {
                        ((NumericUpDown)ctrol).Value = ((NumericUpDown)ctrol).Minimum;
                    }
                    else if (ctrol is DateTimePicker)
                    {
                        ((DateTimePicker)ctrol).Value = DateTime.Now;
                    }
                    else if (ctrol is Panel)
                    {
                        LimpiarControles(ctrol);
                    }
                    // Sidkenu
                    else if (ctrol is SidkenuTextBox)
                    {
                        ((SidkenuTextBox)ctrol).Texts = string.Empty;
                    }
                    else if (ctrol is SidkenuDatePicker)
                    {
                        ((SidkenuDatePicker)ctrol).Value = DateTime.Now;
                    }
                    else if (ctrol is Panel)
                    {
                        LimpiarControles(ctrol);
                    }
                    else if (ctrol is TabControl)
                    {
                        LimpiarControles(ctrol);
                    }
                }
            }
            else if (obj is TabControl)
            {
                foreach (var ctrol in ((TabControl)obj).TabPages)
                {
                    foreach (var page in ((TabPage)ctrol).Controls)

                        if (page is TextBox)
                        {
                            ((TextBox)page).Clear();
                        }
                        else if (page is RichTextBox)
                        {
                            ((RichTextBox)page).Clear();
                        }
                        else if (page is NumericUpDown)
                        {
                            ((NumericUpDown)page).Value = ((NumericUpDown)page).Minimum;
                        }
                        else if (page is DateTimePicker)
                        {
                            ((DateTimePicker)page).Value = DateTime.Now;
                        }
                        // Sidkenu
                        else if (page is SidkenuTextBox)
                        {
                            ((SidkenuTextBox)page).Texts = string.Empty;
                        }
                        else if (page is SidkenuDatePicker)
                        {
                            ((SidkenuDatePicker)page).Value = DateTime.Now;
                        }
                        else if (page is Panel)
                        {
                            LimpiarControles(page);
                        }
                        else if (page is TabControl)
                        {
                            LimpiarControles(page);
                        }
                }
            }
        }
    }
}
