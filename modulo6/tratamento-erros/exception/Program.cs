using exception;

int a = 100;
int b = 0;
double resultado = 0;

try
{
    resultado = Dividir(a, b);

    Console.WriteLine("{0} dividido por {1} = {2}", a, b, resultado);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex) //when (a < 0)
{
    Console.WriteLine(ex.Message);
    //throw;
}
finally
{
    Console.WriteLine("Finalmente a divisão foi finalizada!");
}

static double Dividir(int x, int y)
{
    if (y == 0)
        throw new MyClassException("Minha mensagem customizada de erro!");

    return (x / y);
}