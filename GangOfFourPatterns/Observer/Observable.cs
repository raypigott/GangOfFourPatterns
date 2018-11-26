using System;
using System.Collections.Concurrent;

namespace GangOfFourPatterns.Observer
{
    public class Observable
    {
        readonly ConcurrentDictionary<object, Action<object>> listeners = new ConcurrentDictionary<object, Action<object>>();

        public void Register(object key, Action<object> listener)
        {
            listeners.TryAdd(key, listener);
        }

        public void Unregister(object key)
        {
            Action<object> listener;
            listeners.TryRemove(key, out listener);
        }

        public void SendEvent(object action)
        {
            foreach (var listener in listeners)
            {
                listener.Value(action);
            }
        }
    }
}