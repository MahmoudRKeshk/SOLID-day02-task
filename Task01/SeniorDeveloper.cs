namespace Task1
{
    public class SeniorDeveloper : ILead, IWork
    {
        public void AssignTask()
        {
            
            Task t = new Task() {Title = "Code Review", Description = "Review code for the new module"};

            .
            t.AssignTo(new Developer() { Name="Developer2" });
        }
        public void CreateSubTask()
        {
            
        }
        public void WorkOnTask()
        {
            
        }
    }
}
