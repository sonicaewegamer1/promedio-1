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


    //clase 
    