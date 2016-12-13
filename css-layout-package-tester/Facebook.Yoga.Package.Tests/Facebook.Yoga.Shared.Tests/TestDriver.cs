using Facebook.Yoga;
using System;
using System.Reflection;

namespace Facebook.Yoga.Package.Tests
{
    public class TestDriver
    {
        public bool RunSanityCheck(out string result)
        {
            bool success = false;
            string error = string.Empty;

            result = "Success";

            try
            {
                var node = new YogaNode();

                node.SetMeasureFunction((_, width, widthMode, height, heightMode) => MeasureOutput.Make(100f, 150f));
                node.CalculateLayout();

                if (Math.Abs(100f - node.LayoutWidth) > 0.01)
                {
                    throw new Exception("Unexpected Width");
                }
                if (Math.Abs(150f - node.LayoutHeight) > 0.01)
                {
                    throw new Exception("Unexpected Height");
                }

                success = true;
            }
            catch (Exception ex)
            {
                error = ex.Message + Environment.NewLine + ex.StackTrace;
            }

            if (success)
            {
                result = string.Format("SUCCESS -----------> {0}", GetExecutingAssemblyName());
            }
            else
            {
                result = string.Format("FAILED -----------> {0}{1}{2}", GetExecutingAssemblyName(), Environment.NewLine + Environment.NewLine, error);
            }

            return success;
        }

        private string GetExecutingAssemblyName()
        {
            Assembly currentAssem = Assembly.GetExecutingAssembly();

            return currentAssem.Location;
        }
    }
}
