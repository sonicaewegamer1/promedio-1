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
        // Lista de enemigos en el juego
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
        public string Name { get; set; }  // Nombre del jugador
        public int Health { get; set; }  // Vida del jugador
        public int Mana { get; set; }  // Maná del jugador
        public int Damage { get; set; }  // Daño que el jugador puede hacer

        // Método para mostrar el estado del jugador
        public void ShowStatus()
        {
            Console.WriteLine($"Jugador: {Name}, Vida: {Health}, Maná: {Mana}, Daño: {Damage}");
            //leerá los datos que presentamos arriba para ver cuanta vida y dem´s datos tenemos en ese momento, writeline es para que se escriba en la consola
        }

        // Método para usar un item que recupera vida o maná
        public void UseItem(Item item)
        {
            Health += item.HealthRestore;  // Recupera vida
            Mana += item.ManaRestore;  // Recupera maná
            Console.WriteLine($"Usaste {item.Name}. Vida actual: {Health}, Maná actual: {Mana}");
        }
    }


    //---------------------------divición temporal---------------------------------------------------------------(solo para vacilitar mi navegación)
    
    // Clase Enemy, que representa a los enemigos del juego
    internal class Enemy
    {
        public string Name { get; private set; }  // Nombre del enemigo
        public int Health { get; private set; }  // Vida del enemigo
        public int Damage { get; private set; }  // Daño que puede hacer el enemigo
        public string Type { get; private set; }  // Tipo de enemigo (Melee o Rango)

        // Constructor que inicializa al enemigo con sus atributos
        public Enemy(string name, int health, int damage, string type)
        {
            Name = name;  // Asigna el nombre
            Health = health;  // Asigna la vida
            Damage = damage;  // Asigna el daño
            Type = type;  // Asigna el tipo de ataque
        }
    }
      //---------------------------divición temporal---------------------------------------------------------------(solo para vacilitar mi navegación)
    