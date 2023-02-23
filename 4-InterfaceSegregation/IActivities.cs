namespace InterfaceSegregation
{
    //Si deseamos que una Interfaz contenga todos las otras actividades...
    public interface IActivities : IWorkTeamActivities, IDevelopActivities, ITestActivities, IDesignActivities
    {
    }
}