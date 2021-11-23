using System;
using System.Windows.Forms;
using System.Reflection;

namespace ReflectionExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiscoverTypeInformation_Click(object sender, EventArgs e)
        {
            string TypeName = txtTypeName.Text;
            Type T = TypeName.GetType();
            //Type T = Type.GetType("TypeName");

            lstMethods.Items.Clear();
            lstProperties.Items.Clear();
            lstMethods.Items.Clear();

            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                lstMethods.Items.Add(method.ReturnType.Name + " " + method.Name);
            }

            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                lstProperties.Items.Add(property.PropertyType.Name + " " + property.Name);
            }

            ConstructorInfo[] constructors = T.GetConstructors();
            foreach(ConstructorInfo constructor in constructors)
            {
                lstConstructors.Items.Add(constructor.ToString());
            }
        }
    }
}
