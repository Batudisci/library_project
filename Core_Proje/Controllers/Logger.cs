namespace Core_Proje.Controllers
{
    public class Logger
    {
        private static readonly Logger logger = new Logger();

        private readonly string filePath = "logs.txt";

        private Logger() {
            // Singleton tasarım deseni kullanılarak yalnızca bir örnek oluşturulmasını sağlar
        }

        public static Logger getLogger()
        {
            return logger;
        }

        /// <summary>
        /// Belirli bir konumda meydana gelen bir olayı ve iletilen mesajı günlüğe kaydeder.
        /// </summary>
        /// <param name="position">Olayın meydana geldiği konum veya işlev adı.</param>
        /// <param name="message">Kaydedilecek ileti veya hata mesajı.</param>
        public void writeLog(string position, string message)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(position + " -> " + message);
            }
        }
    }
}
