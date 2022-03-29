using System;
using System.Collections.Generic;

namespace IntroduccionDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new SportyPersona("josue",31,"guatmealteco");
            //p1.Run();
            // Console.WriteLine(p1.show());

            List<IVolador> patos = new List<IVolador>();
            var pato1 = new Pato();
            var pato2 = new Pato();
            var pato3 = new Pato();
            patos.Add(pato1);
            patos.Add(pato2);
            patos.Add(pato3);

            AVolar(patos);

        }

        static void AVolar(List<IVolador> aves)
        {
            foreach(var ave in aves)
            {
                ave.Vuela();
            }
        }
        interface IVolador
        {
            public void Vuela();

        }
        interface ICaminador
        {
            public void Camina();
        }

        public class Pato : IVolador, ICaminador
        {
            public void Vuela()
            {
                Console.WriteLine("Pato vuela");
            }
            public void Camina()
            {
                Console.WriteLine("Pato camina");
            }
        }

    }


   

    abstract class Persona
    {
        //si las clases son abstractas no puedo crear
        //objetos con ellas sino que ay que crear una clase
        /// 
        /// que erede de esta 
        /// 
        public string name;
        public int age;
        public string nationality;

        public Persona(string name, int age, string natio)
        {
            this.name = name;
            this.age = age;
            this.nationality = natio;
        }

        public string  show()
        {
            return name + " " + age + " " + nationality;
        }
    }

    class SportyPersona : Persona
    {
        public SportyPersona(string name, int age, string natio):base(name,age,natio)
        {

        }

        public void Run()
        {
            Console.WriteLine(name + " esta corriendo");
        }
    }
}
