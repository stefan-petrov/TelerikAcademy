using System;

namespace Exercise2
{
    abstract class Customer
    {
        protected string name;
        protected int age;

        protected Customer(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        protected Customer(string name)
        {
            this.name = name;
        }
    }
}
