using System;
using System.Linq;
using System.Reflection;

namespace Refuctobation
{
    public class JimmenyCricket
    {
        public void LikesToEAt(object message)
        {
            var type = typeof (JimmenyCricket).Assembly.GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(IHandler)))
                .Where(t => t.GetMethods().First().GetParameters().First().ParameterType == message.GetType())
                .First();

            type.InvokeMember("Do", BindingFlags.InvokeMethod, null, Activator.CreateInstance(type), new[]{message}, null);
        }
    }
}