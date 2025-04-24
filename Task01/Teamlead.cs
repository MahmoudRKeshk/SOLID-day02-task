namespace Task1
{
    public class TeamLead : ILead, IWork
    {
        public void AssignTask()
        {
           
            Task t = new Task() {Title = "Merge and Deploy", Description = "Task to merge and deploy sharing feature to develop"}; 
            t.AssignTo(new Developer() { Name="Developer1" });
        }
        public void CreateSubTask()
        {
            
        }
        public void WorkOnTask()
        {
            
        }
    }

    public class Manager : ILead
    {
        public void AssignTask()
        {
            
            Task t = new Task() {Title = "Merge and Deploy", Description = "Task to merge and deploy sharing feature to develop"};

            t.AssignTo(new Developer() { Name="Developer1" });
        }
        public void CreateSubTask()
        {
            
        }
    }
}