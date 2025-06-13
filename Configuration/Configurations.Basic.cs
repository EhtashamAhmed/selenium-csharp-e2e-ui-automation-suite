using System;

namespace SquarebookAutomation
{
    public partial class Configurations
    {
        protected static readonly string AppURL = "YOUR_WEBAPP_URL";

        protected static string Uniqueness = DateTime.Now.ToString("ddMMyyHHmmss");      

        //LoginCredentials
        protected const string USER_NAME = "YOUR_USERNAME_HERE";
        protected const string PASSWORD = "YOUR_PASSWORD_HERE";

        //Assets
        protected static readonly string CurrentWorkingDir = AppDomain.CurrentDomain.BaseDirectory;
        protected static readonly string PrimaryImage = CurrentWorkingDir + "Assets\\primary.png";
        protected static readonly string SecondaryImage = CurrentWorkingDir + "Assets\\secondary.png";
        protected static readonly string SampleVideo = CurrentWorkingDir + "Assets\\SampleVideo.mp4";
        protected static readonly string SampleDocument = CurrentWorkingDir + "Assets\\SampleDoc.docx";        
        protected static readonly string SamplePDF = CurrentWorkingDir + "Assets\\SampleDoc.pdf";        
    }
}
