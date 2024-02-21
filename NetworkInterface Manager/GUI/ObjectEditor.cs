using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;

namespace NetworkInterface_Manager.GUI
{
    class ObjectEditor<T> : Panel
    {

        public T ObjectToEdit { get; private set; }

        private int PaddingTitleX = 5;
        private int PaddingTitleY = 5;

        private int PaddingPropertyX = 10;
        private int PaddingPropertyY = 10;

        private int PaddingPropertyAndValueX = 10;

        private int PaddingPropertyToNextPropertyY = 10;

        private Font FontLabelTitle = new Font("Microsoft Sans Serif", 9, FontStyle.Bold, GraphicsUnit.Point);
        private Font FontLabelProperty = new Font("Microsoft Sans Serif", 8, FontStyle.Regular, GraphicsUnit.Point);

        private Dictionary<PropertyInfo, Control> PropertyInfoControlMapping = new Dictionary<PropertyInfo, Control>();

        private Dictionary<Control,PropertyInfo> ControlPropertyInfoMapping = new Dictionary<Control,PropertyInfo>();

        public ObjectEditor(T objectToEdit) {
            ObjectToEdit = objectToEdit;
            //Creating the label for the title
            Label title = new Label();
            title.AutoSize = true;
            title.Text = ReplaceUppercaseWithSpace(typeof(T).Name);
            title.Location = new System.Drawing.Point(PaddingTitleX, PaddingTitleY); //Applying Padding for the title
            title.Font = FontLabelTitle;
            this.Controls.Add(title);
            int gapPropertyAndValueX = 0; //The Minimum Gap we need inbetween all the property title labels and the actual property value
            int gapPropertyToNextPropertyY = 0; //The Minimum Gap we need inbetween all the properties on the Y Axis
            foreach (PropertyInfo property in typeof(T).GetProperties())
            {
                Size size = TextRenderer.MeasureText(ReplaceUppercaseWithSpace(property.Name) + ":", FontLabelProperty);
                if (gapPropertyAndValueX < size.Width) {
                    gapPropertyAndValueX = size.Width;
                }
                if (gapPropertyToNextPropertyY < size.Height)
                {
                    gapPropertyToNextPropertyY = size.Height;
                }
            }
            int gapTitleAndProperty = TextRenderer.MeasureText(title.Text, FontLabelTitle).Height;
            int propertyX = PaddingPropertyX;
            int propertyY = PaddingTitleY +  gapTitleAndProperty + PaddingPropertyY; //Starting off with the minimum gap and the padding
            foreach (PropertyInfo property in typeof(T).GetProperties()){
                Label propertyTitle = new Label();
                propertyTitle.AutoSize = true;
                propertyTitle.Text = ReplaceUppercaseWithSpace(property.Name) + ":";
                propertyTitle.Location = new System.Drawing.Point(propertyX, propertyY);
                propertyTitle.Name = "Title " + property.Name;
                propertyTitle.Font = FontLabelProperty;
                this.Controls.Add(propertyTitle);

                Control controlValue = null;

                if (property.PropertyType == typeof(String)) {
                    TextBox propertyTextbox = new TextBox();
                    propertyTextbox.Text = (String)property.GetValue(objectToEdit);
                    controlValue = propertyTextbox;
                }
                else if (property.PropertyType == typeof(Boolean))
                {
                    CheckBox propertyCheckBox = new CheckBox();
                    propertyCheckBox.Checked = (Boolean)property.GetValue(objectToEdit);
                    propertyCheckBox.CheckedChanged += PropertyCheckBox_CheckedChanged;
                    controlValue = propertyCheckBox;
                }

                if (controlValue == null)
                {
                    Label propertyNotSupported = new Label();
                    propertyNotSupported.Text = property.PropertyType.Name + " not supported!";
                    controlValue = propertyNotSupported;
                }

                controlValue.TextChanged += ControlValue_TextChanged;
               
                controlValue.Font = FontLabelProperty;
                controlValue.Location = new System.Drawing.Point(propertyX + gapPropertyAndValueX + PaddingPropertyAndValueX, propertyY);
                controlValue.Name = property.Name;
                controlValue.AutoSize = true;

                this.Controls.Add(controlValue);

                propertyY += gapPropertyToNextPropertyY + PaddingPropertyToNextPropertyY;

                PropertyInfoControlMapping.Add(property, controlValue);
                ControlPropertyInfoMapping.Add(controlValue, property);
            }
            OnPropertyValueChanged += ObjectEditor_OnPropertyValueChanged;
        }

        private void PropertyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox control = (CheckBox)sender;
            UpdateValue(control, control.Checked);
        }

        private void ObjectEditor_OnPropertyValueChanged(object source, PropertyValueChangedEventArgs e)
        {
            OnAnyPropertyValueChanged(source);
        }

        private void ControlValue_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            UpdateValue(control, control.Text);
        }

        private void UpdateValue(Control control, Object value) {
            String controlName = control.Name;
            PropertyInfo propertyInfo;
            if (ControlPropertyInfoMapping.TryGetValue(control, out propertyInfo)) {
                OnPropertyValueChanged(control, new PropertyValueChangedEventArgs(propertyInfo, value, propertyInfo.GetValue(ObjectToEdit)));
                propertyInfo.SetValue(ObjectToEdit, value);
            }          
        }

        //Taken from https://stackoverflow.com/a/272929
        public String ReplaceUppercaseWithSpace(String text,bool preserveAcronyms = true) {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;
            StringBuilder newText = new StringBuilder(text.Length * 2);
            newText.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                    if ((text[i - 1] != ' ' && !char.IsUpper(text[i - 1])) ||
                        (preserveAcronyms && char.IsUpper(text[i - 1]) &&
                         i < text.Length - 1 && !char.IsUpper(text[i + 1])))
                        newText.Append(' ');
                newText.Append(text[i]);
            }
            return newText.ToString();
        }

        public delegate void PropertyValueChanged(object source, PropertyValueChangedEventArgs e);
        public delegate void AnyPropertyValueChanged(object source);

        public event PropertyValueChanged OnPropertyValueChanged = delegate { };
        public event AnyPropertyValueChanged OnAnyPropertyValueChanged = delegate { };

        public class PropertyValueChangedEventArgs : EventArgs
        {
            public PropertyInfo AffectedProperty { get; private set; }
            public Object NewValue { get; private set; }
            public Object OldValue { get; private set; }
            public PropertyValueChangedEventArgs(PropertyInfo affectedProperty, Object newValue, Object oldValue = null)
            {
                this.AffectedProperty = affectedProperty;
                this.NewValue = newValue;
                this.OldValue = oldValue;
            }
        }


    }
}
