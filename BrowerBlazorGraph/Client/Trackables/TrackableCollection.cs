
using System;
using System.Collections.ObjectModel;

namespace BrowerBlazorGraph.Client.Trackables;

public class TrackableCollection<T> : Collection<T>
{
    public TrackableEntity Parent { get; }

    public TrackableCollection(TrackableEntity parent)
    {
        Parent = parent ?? throw new ArgumentNullException(nameof(parent));
    }

    protected override void InsertItem(int index, T item)
    {
        base.InsertItem(index, item);
        Parent.SetModified();
    }

    protected override void RemoveItem(int index)
    {
        base.RemoveItem(index);
        Parent.SetModified();
    }

    protected override void SetItem(int index, T item)
    {
        base.SetItem(index, item);
        Parent.SetModified();
    }

    protected override void ClearItems()
    {
        base.ClearItems();
        Parent.SetModified();
    }
}