// See https://aka.ms/new-console-template for more information




//Tercer condicional(Multiple)

/*
 Determinar la edad y el sexo de una persona y debe imprimir dichos datos y tomar en cuenta lo siguiente:
Si es hembra: Entra gratis.
Si es varon: Entra pagando.
Ambos no pueden entrar si son menores de edad.
Imprimir la edad, sexo y el mensaje.
 */



char genero;
int edad;

Console.Write("genero: ");
genero = Convert.ToChar(Console.ReadLine());

Console.Write("edad: ");
edad = Convert.ToInt32(Console.ReadLine());


if (edad >= 18 && genero == 'f')
{
    Console.WriteLine("Puede pasar gratis.");
}
else if (edad >= 18 && genero == 'm')
{
    Console.WriteLine("Tiene que pagar para pasar.");
}
else 
{
    Console.WriteLine("Larguese a estudiar");
}