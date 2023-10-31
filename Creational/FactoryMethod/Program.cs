using Creational.Factory;

namespace Creational.FactoryMethod
{
    class Program
    {
        /*El patrón de diseño Factory Method es un patrón de creación que proporciona una interfaz para crear objetos en una superclase,
         * pero permite a las subclases alterar el tipo de objetos que se crearán. Este patrón promueve la abstracción y la flexibilidad 
         * en la creación de objetos. A continuación, un resumen del patrón Factory Method con un ejemplo en C#:
         * Resumen del patrón Factory Method:
         * Tipo de patrón: Patrón de creación.
         * Propósito: Define una interfaz para crear un objeto,
         * pero deja que las subclases decidan qué clase concreta instanciar. 
         * Proporciona flexibilidad para la creación de objetos y permite la creación de objetos especializados sin cambiar el código cliente.*/
        static void Main(string[] args)
        {
            CharacterFactory factory1 = new WarriorFactory();
            ICharacter character1 = factory1.CreateCharacter();
            character1.Display();

            CharacterFactory factory2 = new MageFactory();
            ICharacter character2 = factory2.CreateCharacter();
            character2.Display();
        }
    }

}