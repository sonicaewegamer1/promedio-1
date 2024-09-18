using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promedio_1
{
    // Clase principal que ejecuta el programa
    internal class Program
    {
        static void Main(string[] args)
        {
            // se crea la instancia de dungeon master para crear el juego
            DungeonMaster dungeonMaster = new DungeonMaster();
            // Ejecuta el menú principal del juego
            dungeonMaster.Execute();
        }
    }

    // Clase DungeonMaster, crear mundo y enemigos
    internal class DungeonMaster
    {
        // Jugador que será controlado por el usuario
        private Player player;
        // Lista de enemigos
        private List<Enemy> enemies;
        // Lista de items disponibles en el juego
        private List<Item> items;

        // Constructor que inicializa las listas y el jugador
        public DungeonMaster()
        {
            player = new Player();  // Crea el jugador
            enemies = new List<Enemy>();  // Crea la lista de enemigos
            items = new List<Item>();  // Crea la lista de items
        }
    }

    //private player player; hace referencia a que estoy creando una variable llamada player,de tipo player 

    //---------------------------divición temporal---------------------------------------------------------------(solo para vacilitar mi navegación)
    internal class Player
    {
        public string Name { get; set; }  
        public int Health { get; set; }  
        public int Mana { get; set; }  
        public int Damage { get; set; } 

        // Método para mostrar el estado del jugador
        public void ShowStatus()
        {
            Console.WriteLine($"TU NOMBRE: {Name}, TU VIDA: {Health}, TU MANÁ: {Mana}, TU DAÑO: {Damage}");
            //leerá los datos que presentamos arriba para ver cuanta vida y dem´s datos tenemos en ese momento, writeline es para que se escriba en la consola
        }

        // Método para usar un item que recupera vida o maná
        public void ITem usage(Item item)
        {
            Health += item.HealthRestore;  
            Mana += item.ManaRestore;  
            Console.WriteLine($"EQUIPASTE {item.Name}. tu vida restante: {Health}, tu Maná restante: {Mana}");
        }
    }


    //---------------------------divición temporal---------------------------------------------------------------(solo para vacilitar mi navegación)
    
    // Clase Enemy, que representa a los enemigos del juego
    internal class Enemy
    {
        public string EnemyName { get; private set; }  // Nombre del enemigo
        public int EnemyHealth { get; private set; }  // Vida del enemigo
        public int EnemyDamage { get; private set; }  // Daño que puede hacer el enemigo
        public string EnemyType { get; private set; }  // Tipo de enemigo (Melee o Rango)

        // Constructor que inicializa al enemigo con sus atributos
        public Enemy(string enemyname, int enemyhealth, int enemydamage, string enemytype)
        {
            EnemynameName = enemyname;  // Asigna el nombre
            EnemynameHealth = enemyhealth;  // Asigna la vida
            EnemynameDamage = enemydamage;  // Asigna el daño
            EnemynameType = enemytype;  // Asigna el tipo de ataque
        }
    }
    //---------------------------divición temporal---------------------------------------------------------------(solo para vacilitar mi navegación)
    // Clase Item
    internal class Item
    {
        public string Name { get; private set; }  // Nombre del item
        public int ManaRestore { get; private set; }  // Cuánto maná recupera el item
        public int HealthRecover { get; private set; }  // Cuánta vida recupera el item

        // Constructor que inicializa el item con sus propiedades
        public Item(string name, int manaRestore, int healthRecover)
        {
            Name = name;  // Asigna el nombre del item
            ManaRestore = manaRestore;  // Asigna la cantidad de maná que recupera
            HealthRecover = healthRecover;  // Asigna la cantidad de vida que recupera
        }
    }
}
