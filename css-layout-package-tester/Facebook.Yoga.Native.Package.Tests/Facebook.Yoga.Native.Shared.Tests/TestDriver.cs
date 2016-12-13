using System;
using System.Reflection;

namespace Facebook.Yoga.Native.Package.Tests
{
    public class TestDriver
    {
        public bool RunSanityCheck(out string result)
        {
            bool success = false;
            string error = String.Empty;

            result = "Success";

            try
            {
                bool isEnabled = IsExperimentalFeatureEnabled(YogaExperimentalFeature.Rounding);

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

        private bool IsExperimentalFeatureEnabled(YogaExperimentalFeature feature)
        {
            return Native.YGIsExperimentalFeatureEnabled(feature);
        }

        private string GetExecutingAssemblyName()
        {
            Assembly currentAssem = Assembly.GetExecutingAssembly();

            return currentAssem.Location;
        }
    }
}