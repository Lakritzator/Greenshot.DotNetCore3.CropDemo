using Greenshot.Addons.Core;
using Dapplo.Config;
using Dapplo.Windows.Common.Structs;
using System;
using System.Collections.Generic;
using System.Drawing;
using Greenshot.Core.Enums;
using AutoProperties;

namespace Greenshot.DotNetCore3.CropDemo
{
    public class CoreConfiguration : DictionaryConfigurationBase<ICoreConfiguration>, ICoreConfiguration
    {
        [InterceptIgnore]
        public static ICoreConfiguration Instance { get; } = new CoreConfiguration();
        public string Language { get; set; }
        public string RegionHotkey { get; set; }
        public string WindowHotkey { get; set; }
        public string FullscreenHotkey { get; set; }
        public string LastregionHotkey { get; set; }
        public string IEHotkey { get; set; }
        public bool IsFirstLaunch { get; set; }
        public IList<string> OutputDestinations { get; set; }
        public IList<string> PickerDestinations { get; set; }
        public bool WindowCaptureAllChildLocations { get; set; }
        public bool PlayCameraSound { get; set; }
        public bool ShowTrayNotification { get; set; }
        public bool OutputFileCopyPathToClipboard { get; set; }
        public string OutputFileAsFullpath { get; set; }
        public bool OutputPrintPromptOptions { get; set; }
        public bool OutputPrintAllowRotate { get; set; }
        public bool OutputPrintAllowEnlarge { get; set; }
        public bool OutputPrintAllowShrink { get; set; }
        public bool OutputPrintCenter { get; set; }
        public bool OutputPrintInverted { get; set; }
        public bool OutputPrintGrayscale { get; set; }
        public bool OutputPrintMonochrome { get; set; }
        public byte OutputPrintMonochromeThreshold { get; set; }
        public bool OutputPrintFooter { get; set; }
        public string OutputPrintFooterPattern { get; set; }
        public string NotificationSound { get; set; }
        public bool UseProxy { get; set; }
        public bool IECapture { get; set; }
        public bool IEFieldCapture { get; set; }
        public IList<string> WindowClassesToCheckForIE { get; set; }
        public int AutoCropDifference { get; set; }
        public IList<string> IncludePlugins { get; set; }
        public IList<string> ExcludePlugins { get; set; }
        public IList<string> ExcludeDestinations { get; set; }
        public bool CheckForUpdates { get; set; }
        public int UpdateCheckInterval { get; set; }
        public DateTime LastUpdateCheck { get; set; }
        public bool DisableSettings { get; set; }
        public bool DisableQuickSettings { get; set; }
        public bool HideTrayicon { get; set; }
        public bool HideExpertSettings { get; set; }
        public bool ThumnailPreview { get; set; }
        public bool OptimizeForRDP { get; set; }
        public bool DisableRDPOptimizing { get; set; }
        public bool MinimizeWorkingSetSize { get; set; }
        public bool CheckForUnstable { get; set; }
        public IList<string> ActiveTitleFixes { get; set; }
        public IDictionary<string, string> TitleFixMatcher { get; set; }
        public IDictionary<string, string> TitleFixReplacer { get; set; }
        public IList<string> ExperimentalFeatures { get; set; }
        public bool EnableSpecialDIBClipboardReader { get; set; }
        public bool ZoomerEnabled { get; set; }
        public float ZoomerOpacity { get; set; }
        public int MaxMenuItemLength { get; set; }
        public string MailApiTo { get; set; }
        public string MailApiCC { get; set; }
        public string MailApiBCC { get; set; }
        public string LastSaveWithVersion { get; set; }
        public bool ProcessEXIFOrientation { get; set; }
        public NativeRect LastCapturedRegion { get; set; }
        public Size IconSize { get; set; }
        public int WebRequestTimeout { get; set; }
        public int WebRequestReadWriteTimeout { get; set; }
        public bool IsScrollingCaptureEnabled { get; set; }
        public bool IsPortable { get; set; }
        public ISet<string> Permissions { get; set; }
        public NativeSize Win10BorderCrop { get; set; }
        public bool CaptureMousepointer { get; set; }
        public bool CaptureWindowsInteractive { get; set; }
        public int CaptureDelay { get; set; }
        public ScreenCaptureMode ScreenCaptureMode { get; set; }
        public int ScreenToCapture { get; set; }
        public WindowCaptureModes WindowCaptureMode { get; set; }
        public Color DWMBackgroundColor { get; set; }
        public IList<string> NoGDICaptureForProduct { get; set; }
        public IList<string> NoDWMCaptureForProduct { get; set; }
        public bool WindowCaptureRemoveCorners { get; set; }
        public IList<int> WindowCornerCutShape { get; set; }
    }
}
