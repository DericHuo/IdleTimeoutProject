#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.UI;
using FTOptix.Retentivity;
using FTOptix.NativeUI;
using FTOptix.Core;
using FTOptix.CoreBase;
using FTOptix.NetLogic;
#endregion

public class NetLogic : BaseNetLogic
{
    public override void Start()
    {
        var UIFolder = Project.Current.Get<Folder>("UI");
        var mainWindow = UIFolder.Get<WindowType>("MainWindow");
        label1 = InformationModel.MakeObject<Label>("Label1");
        label1.TopMargin = 50;
        label1.LeftMargin = 50;
        label1.Text = "Empty";
        mainWindow.Add(label1);
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }

    [ExportMethod]
    public void Create()
    {
        label1.Text = "Idle Timeout Triggered";
    }

    [ExportMethod]
    public void ResetLabelText()
    {
        label1.Text = "Empty";
    }

    private Label label1;
}
