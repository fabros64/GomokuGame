using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GomokuGame
{
    public static class ControlExtensions
    {
        public static T Clone<T>(this T controlToClone)
            where T : Control
        {
            PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            T instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }

        public static void SetControlProperties(Control ctrl, Hashtable propertyList)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(ctrl);

            foreach (PropertyDescriptor myProperty in properties)
            {
                if (propertyList.Contains(myProperty.Name))
                {
                    Object obj = propertyList[myProperty.Name];
                    myProperty.SetValue(ctrl, obj);
                }
                //...
            }
        }
    }
}
