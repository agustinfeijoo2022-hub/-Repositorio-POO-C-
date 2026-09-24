﻿Console.WriteLine("=== INICIO DE LA BATALLA ===\n");
Arquero legolas = new Arquero("Legolas", 80, 12, 30);
Guerrero arthur = new Guerrero("Arthur el Valiente", 100, 15, 10);

int ronda = 1;
// Bucle del combate
while (legolas.Vida > 0 && arthur.Vida > 0)
{
    Console.WriteLine($"--- RONDA {ronda} ---");
    // Turno 1
    legolas.Atacar(arthur);
    // Condición de quiebre para evitar ataques de un personaje derrotado
    if (arthur.Vida <= 0) break;
    // Turno 2
    arthur.Atacar(legolas);
    if (legolas.Vida <= 0) break;
    ronda++;
    Console.WriteLine("Presiona ENTER para la siguiente ronda...\n");
    Console.ReadLine();
}
Console.WriteLine("=== FIN DE LA BATALLA ===\n");
// Resolución
if (legolas.Vida > 0)
    Console.WriteLine($"¡{legolas.Nombre} es el vencedor!");
else
    Console.WriteLine($"¡{arthur.Nombre} es el vencedor!");