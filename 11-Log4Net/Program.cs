using log4net;

namespace _11_Log4Net
{
    /*
     * This chapter demonstrates the basic usage of log4net in C#.
     * 
     * Key actions to take are:
     * 1: Install log4net using NuGet
     * 2: configure log4net by creating a log4net.config (Add => Application Configuration File)
     * 3: Add AssemblyInfo.cs (Add => Assembly Information File) and point to log4net.config file
     * 4: Try writing some logs
     * 
     * log4net.config
     * => One appender is one log output
     * => File location is relative to EXE (if the fullpath is not provided)
     * => Make sure that, in log4net.config's properties, set 'Copy to Output Directory' setting to 'Copy Always'
     *    If not, the config file will be a missing file for the application so no log file will be generated.
     *    
     * Regarding writing to console, this is used in this example log4net.Appender.ManagedColoredConsoleAppender
     * So the colored text will be written to console.
     * Just for normal logging (black and white), the simpler log4net.Appender.ConsoleAppender can be used
     
     * Sometimes, there might be issues such as the log file is not generated, neither error is shown.
     * In the logger IsDebugEnabled, etc. settings are all false though it seems that all the necessary configuration 
     * is there and the files are in the correction location
     * In that case, to make sure that the config file is loaded correctly, we can explicitly set up such as below:
       FileInfo fiConfig = new FileInfo("test.log4net.config");
       XmlConfigurator.Configure(fiConfig);
       logger = LogManager.GetLogger("TEST");
     * We can check fiConfig variable to see if the file is found properly or not, and also the settings.
     * */
    class Program    
    {
        private static readonly ILog log = LogManager.GetLogger("Log4NetTestProgram");
        static void Main(string[] args)
        {
            int iWrtCnt = 0;
            do
            {
                /*
                 * According to current setting, a new log file will be created once the current file hits the size of 1KB.
                 * Only 10 log files will be kept and older ones will be purged.
                 * */
                iWrtCnt++;
                log.Debug("This is a Debug message");
                log.Info("This is a Info message");
                log.Warn("This is a Warning message");
                log.Error("This is an Error message");
                log.Fatal("This is a Fatal message");
            } while (iWrtCnt < 1000);
        }
    }
}