using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflexionApp
{
    public class Instancer<T>
    {
        private T MyClass;

        public Instancer()
        {
            Type type = typeof(T);
            //guardo el primer constructor del tipo enviado
            var mainCtor = type.GetConstructors()[0];
            var numParams = mainCtor.GetParameters().Length;
            Object[] paramsForCtor = new Object[numParams];
            for (int i = 0; i < mainCtor.GetParameters().Length; i++)
            {
                var param = mainCtor.GetParameters()[i];
                bool error;
                do
                {
                    Console.Write($"{param.Name} de tipo {param.ParameterType.Name}: ");
                    //para cada parámetro pedir por consola y guardar
                    var paramValue = Console.ReadLine();
                    try
                    {
                        //intento convertir a un objeto del tipo dado
                        var typedParam = Convert.ChangeType(paramValue, param.ParameterType);
                        error = false;
                        paramsForCtor[i] = typedParam;
                    }
                    catch (Exception)
                    {
                        error = true;
                        Console.WriteLine("El dato no corresponde al tipo requerido");
                    }

                } while (error);
            }

            MyClass = (T)mainCtor.Invoke(paramsForCtor);

        }

        public void GetMethodsForExe()
        {
            Type type = typeof(T);
            MethodInfo methodToExe;
            //guardo el primer constructor del tipo enviado
            var methods = type.GetMethods(); //BindingFlags.DeclaredOnly
            for (int i = 0; i < methods.Length; i++)
            {
                var method = methods[i];
                Console.WriteLine($"{i} {method.Name}");
            }
            bool error = true;
            do
            {
                Console.Write("Elige un número para seleccionar el método que quieres ejecutar: ");
                var methodNumber = Console.ReadLine();
                try
                {
                    var intMethodNumber = int.Parse(methodNumber);
                    error = true;
                    if(intMethodNumber >= 0 && intMethodNumber < methods.Length)
                    {
                        error = false;
                        methodToExe = methods[intMethodNumber];
                        methodToExe.Invoke(MyClass, null);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("El dato no es número o no corresponde con ningún método");
                }
            } while (error);
            Console.ReadLine();
        }
    }
}
