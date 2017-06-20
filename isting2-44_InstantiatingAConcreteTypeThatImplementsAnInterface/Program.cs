namespace Listing2_44_InstantiatingAConcreteTypeThatImplementsAnInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Dog();
        }

        interface IAnimal
        {
            void Move();
        }

        class Dog : IAnimal
        {
            public void Move() { }
            public void Bark() { }
        }
    }
}