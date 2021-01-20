using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Deployment.WindowsInstaller;

namespace CustomAction1
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult CustomAction1(Session session)
        {
            MessageBox.Show("Howdy!");

            // session.Log("Begin CustomAction1");

            return ActionResult.Success;
        }
    }
}
