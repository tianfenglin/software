using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software
{
    public partial class UserPy : Form
    {
        public UserPy()
        {
            InitializeComponent();
        }

        private void Try_Runing_Click(object sender, EventArgs e)
        {
            //var engine = IronPython.Hosting.Python.CreateEngine();
            //ScriptScope scope = Python.ImportModule(engine, "math");
            //var options = new Dictionary<string, object>();
            //options["Frames"] = true;
            //options["FullFrames"] = true;
            //options["math"] = true;
            //ScriptRuntime pyRumTime = Python.CreateRuntime();
            //dynamic obj = pyRumTime.UseFile(@"D:\github\software\PyCommon\PyCommon.py");
            var engine = IronPython.Hosting.Python.CreateEngine();
            var scope = Python.ImportModule(engine, "math");
            var source = engine.CreateScriptSourceFromFile(@"D:\github\software\PyCommon\PyCommon.py");
            source.Execute(scope);
            var say_hello = scope.GetVariable<Func<object, object>>("select");
            var aaa = say_hello("C:\\Users\\tian\\Desktop\\人大\\岑巩县");

            var py = Python.CreateEngine();
            List<string> searchPaths = new List<string>();
            searchPaths.Add(@"C:\Users\Admin\AppData\Local\Programs\Python\Python35\Lib)");
            searchPaths.Add(@"C:\Users\Admin\AppData\Local\Programs\Python\Python35\Lib\site-packages)");
            py.SetSearchPaths(searchPaths);
            // object aaa = obj.select("C:\\Users\\tian\\Desktop\\人大\\岑巩县");
            object asd = aaa;
        }
    }
}
