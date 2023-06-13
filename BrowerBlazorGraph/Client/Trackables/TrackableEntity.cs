namespace BrowerBlazorGraph.Client.Trackables;

public class TrackableEntity
{
    public bool HasBeenModified { get; set; }

    protected bool SetProperty<T>(ref T field, T value)
    {
        if (!EqualityComparer<T>.Default.Equals(field, value))
        {
            field = value;
            HasBeenModified = true;
            return true;
        }
        return false;
    }

    public void SetModified()
    {
        HasBeenModified = true;
    }
}