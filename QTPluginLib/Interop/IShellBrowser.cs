// Generated by Reflector from c:\program files\qttabbar\QTPluginLib.dll
namespace QTPlugin.Interop
{
  using System;
  using System.Runtime.InteropServices;
  
  [ComImport, Guid("000214E2-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IShellBrowser
  {
    [PreserveSig]
    int GetWindow(out IntPtr phwnd);
    [PreserveSig]
    int ContextSensitiveHelp(bool fEnterMode);
    [PreserveSig]
    int InsertMenusSB(IntPtr hmenuShared, IntPtr lpMenuWidths);
    [PreserveSig]
    int SetMenuSB(IntPtr hmenuShared, IntPtr holemenuRes, IntPtr hwndActiveObject);
    [PreserveSig]
    int RemoveMenusSB(IntPtr hmenuShared);
    [PreserveSig]
    int SetStatusTextSB([MarshalAs(UnmanagedType.BStr)] string pszStatusText);
    [PreserveSig]
    int EnableModelessSB(bool fEnable);
    [PreserveSig]
    int TranslateAcceleratorSB(ref MSG pmsg, ushort wID);
    [PreserveSig]
    int BrowseObject(IntPtr pidl, uint wFlags);
    [PreserveSig]
    int GetViewStateStream(uint grfMode, IntPtr ppStrm);
    [PreserveSig]
    int GetControlWindow(uint id, out IntPtr phwnd);
    [PreserveSig]
    int SendControlMsg(uint id, uint uMsg, IntPtr wParam, IntPtr lParam, out IntPtr pret);
    [PreserveSig]
    int QueryActiveShellView(out IShellView ppshv);
    [PreserveSig]
    int OnViewWindowActive(IShellView pshv);
    [PreserveSig]
    int SetToolbarItems(IntPtr lpButtons, uint nButtons, uint uFlags);
  }
}
