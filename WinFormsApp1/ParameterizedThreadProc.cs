using System.Security.Principal;

namespace WinFormsApp1
{
    internal class ParameterizedThreadProc
    {
        private WindowsIdentity windowsIdentity;

        public ParameterizedThreadProc(WindowsIdentity windowsIdentity)
        {
            this.windowsIdentity = windowsIdentity;
        }
    }
}