using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionQuest
{
    internal class ReflectionHelper
    {
        public MemberInfo GetNonStaticPublicClassMemberMethodWithLargestArgumentList(string assemblyPath)
        {
            Console.WriteLine("Get the name of a class member which is non static nad has the largest argument list in assembly");
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            Console.ReadLine();
            throw new NotImplementedException("Not implemented D:");
        }

        public MemberInfo FindMethodWithLocalVariablesOfTypeIntAndBool(string assemblyPath)
        {
            Console.WriteLine("Get the name of a method with local variables of type bool and int");
            Assembly assembly = Assembly.LoadFrom(assemblyPath);

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                MethodInfo[] methods = type.GetMethods();
                foreach (MethodInfo method in methods)
                {
                    if (method.GetMethodBody() != null)
                    {
                        LocalVariableInfo[] localVariables = method.GetMethodBody().LocalVariables.ToArray();
                        var localVariablesNames = localVariables.Select(x => x.LocalType.Name.Equals("bool") && 
                        x.LocalType.Name.Equals("int")).ToArray();
                        if (localVariablesNames.Length > 0)
                        {
                            Console.WriteLine(method.Name);
                        }
                    }
                }
            }   
            throw new NotImplementedException("Not implemented D:");
        }

        public MemberInfo GetTypeThatImplementsIEnumerable(string assemblyPath)
        {
            Console.WriteLine("Get the name of a type that implements IEnumerable");
            Assembly assembly = Assembly.LoadFrom(assemblyPath);

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                if (type.IsAssignableFrom(typeof(IEnumerable<>)))
                {
                    Console.WriteLine(type.Name);
                }
            }
            throw new NotImplementedException("Not implemented D:");
        }

        public MemberInfo GetTypeThatHasNestedTypeInSpanish(string assemblyPath)
        {
            Console.WriteLine("Get the name of a class member which has a nested type in spanish");
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            Console.ReadLine();
            throw new NotImplementedException("Not implemented D:");
        }
    }
}
