using BrowerBlazorGraph.Client.Trackables;
using System.Numerics;

namespace BrowerBlazorGraph.Client.Models;

public class Graph : TrackableEntity
{
    private string _name;
    public string Name { get => _name; set => SetProperty(ref _name, value); }
    public TrackableCollection<Vector2> Values { get; set; }

    public Graph()
    {
        Values = new(this);
    }
}
