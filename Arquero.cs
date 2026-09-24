public class Arquero : Personaje
{
    public int Agilidad { get; set; }

        private static readonly Random _random = new Random();

    public Arquero(string nombre, int vida, int fuerza, int agilidad)
        : base(nombre, vida, fuerza)
    {
        Agilidad = agilidad;
    }

        public override void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"¡{Nombre} dispara una flecha certera a {objetivo.Nombre}!");
        int danoTotal = Fuerza; 
        objetivo.RecibirDano(danoTotal);
    }

        public override void RecibirDano(int dano)
    {
        int probabilidad = _random.Next(0, 101);

        if (probabilidad < Agilidad)
        {
           Console.WriteLine($"¡{Nombre} esquivó el ataque gracias a su agilidad!");
        }
        else
        {
            base.RecibirDano(dano);
        }
    }
}