namespace Task2
{
    public class SqlFile : IReadable
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
           
        }
    }

    public class WritableSqlFile : SqlFile, IWritable
    {
        public string SaveText()
        {
           
        }
    }

    public class SqlFileManager
    {
        public List<SqlFile> lstSqlFiles { get; set; }

        public string GetTextFromFiles()
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in lstSqlFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }
        public void SaveTextIntoFiles()
        {
            foreach (var objFile in lstSqlFiles)
            {
                if (objFile is IWritable writable)
                {
                    writable.SaveText();
                }
            }
        }
    }
}