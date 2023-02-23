namespace InterfaceSegregation
{
    public class Developer : IWorkTeamActivities, IDevelopActivities
    {
        public Developer() { }

        public void Comunicate()
        {
            throw new NotImplementedException();
        }

        public void Develop()
        {
            Console.WriteLine("I'm developing the functionalities required");
        }

        public void Plan()
        {
            throw new NotImplementedException();
        }
    }
}