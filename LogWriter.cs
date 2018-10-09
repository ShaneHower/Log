class LogWriter
{

        private string path;

        public Program(string path)
        {
            this.path = path;
        }
        
        public void CreateFile()
        {
            if (!File.Exists(this.path))
            {
                var myFile = File.Create(this.path);
                myFile.Close();
                Console.WriteLine("File Created");
               
            }

            else
            {
                Console.WriteLine("File Already Exists");
            }
        }

        public void WriteLog(string message)
        {
            using (TextWriter tw = new StreamWriter(this.path, true))
            {
                tw.WriteLine("{0} : {1}", DateTime.Today, message); 
            }
        }

        public void DisplayLog()
        {
            Process.Start(@"notepad.exe ", this.path);
        }

        public void Print(string message)
        {
            CreateFile();
            WriteLog(message);
        }
