#pragma warning disable CS8618
namespace Creatures{
    public class Animal{

        public string Name {
            get;
            set;
        }

        public int Age {
            get;
            set;
        }

        public virtual void scream(){
            Console.WriteLine("The animal is screaming");
        }
    }

    public class Dog : Animal{
        public override void scream(){
            Console.WriteLine("the dog is barking");
        }
    }
}