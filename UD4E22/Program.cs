using System;

namespace UD4E22
{
    class Program
    {
        static void Main(string[] args)
        {
            String contraseña = "12345678";

            int intentos = 3;

            //Esta variable booleana, nos controlara que en caso de que acierte la condicion cambie
            Boolean acierto = false;

            String password;
            for (int i = 0; i < intentos && !acierto; i++)
            {
                password = "Introduce una contraseña";

                //Comprobamos si coincide, no usamos ==, usamos el metodo equals
                if (password==(contraseña))
                {
                    Console.WriteLine("Enhorabuena, acertaste");
                    acierto = true;
                }
            }

        }
    }
}
