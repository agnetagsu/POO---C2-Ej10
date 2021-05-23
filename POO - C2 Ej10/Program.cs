using System;

namespace POO___C2_Ej10
{
    class Serie
    {
        protected int numtemporadas { get; set; }
        protected string titulo { get; set; }
        protected Boolean entregado { get; set; }
        protected string genero { get; set; }
        protected string creador { get; set; }

        public const int temporadasdefecto = 3;
        public const Boolean entregadodefecto = false;
        
        public Serie()
        {
            titulo = "";
            numtemporadas = temporadasdefecto;
            entregado = entregadodefecto;
            genero = "";
            creador = "";

        }
        public Serie(String ntitulo, string ncreador)
        {  
            titulo = ntitulo;
            numtemporadas = temporadasdefecto;
            entregado = entregadodefecto;
            genero = "";
            creador = ncreador;
        }

        public Serie(String ntitulo, int ntemporadas, string ngenero, string ncreador)
        {
            titulo = ntitulo;
            numtemporadas = ntemporadas;
            entregado = entregadodefecto;
            genero = ngenero;
            creador = ncreador;
        }


        static void Main(string[] args)
        {
            Serie miserie = new Serie("CSI",10,"policiaca","Anthony E. Zuiker");

            System.Console.WriteLine("Título: {0}, Temporadas: {1}, Entregado: {2}, Género: {3}, Creador: {4}", miserie.titulo, miserie.numtemporadas, miserie.entregado, miserie.genero,miserie.creador);

        }
    }
}
