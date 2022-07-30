class Usuario{
    private int id;
    private int pswd;
    private int saldo;
    private int opcion;

    public int Id{
        get{return id;}
        set{id = value;}
    }

    public int Pswd{
        get{return pswd;}
        set{pswd = value;}
    }

    public int Saldo{
        get{return saldo;}
        set{saldo = value;}
    }

     public int Opcion{
        get{return opcion;}
        set{opcion = value;}
    }

    public void PantallaPrincipal(){
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("**Bienvenido al Cajero Automático**\n\n");
        Console.WriteLine("Seleccione el número de la opción\n");
        Console.WriteLine("1.Consulta de Saldo");
        Console.WriteLine("2.Retiros");
        Console.WriteLine("3.Transferencias");
        Console.WriteLine("4.Salir");
        opcion = Convert.ToInt32(Console.ReadLine());
        

        switch(opcion){
            case 1:
            PantallaConsultaSaldo();
            break;
            case 2:
            PatallaRetiros();
            break;
            case 3:
            PantallaTransferencias();
            break;
            case 4:
            PantallaDespedida();
            break;
        }
    }

    public void PantallaConsultaSaldo(){
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("**Saldo Actual**\n\n");
        Console.WriteLine($"Su saldo a la fecha es de:{saldo}\n");
        Console.WriteLine("Presione 1 para volver al menú principal");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch(opcion){
            case 1:
            PantallaPrincipal();
            break;
        }
    }

    public void PatallaRetiros(){
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("**RETIROS**\n\n");
        Console.WriteLine("Seleccione una opción: ");
        Console.WriteLine("1. $50.000");
        Console.WriteLine("2. $100.000");
        Console.WriteLine("3. $200.000");
        Console.WriteLine("4. $300.000");
        Console.WriteLine("5. $400.000");
        Console.WriteLine("6. Otro Valor");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch(opcion){
            case 1:
            saldo = saldo - 50000;
            PantallaConsultaSaldo();
            break;
            case 2:
            saldo = saldo - 100000;
            PantallaConsultaSaldo();
            break;
            case 3:
            saldo = saldo - 200000;
            PantallaConsultaSaldo();
            break;
            case 4:
            saldo = saldo - 300000;
            PantallaConsultaSaldo();
            break;
            case 5:
            saldo = saldo - 400000;
            PantallaConsultaSaldo();
            break;
            case 6:
            PantallaOtroValor();
            break;
        }

    }

    public void PantallaDespedida(){
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("**GRACIAS POR UTILIZAR NUESTRO CAJERO AUTOMÁTICO**");
        Console.ReadKey();
    }

    public void PantallaOtroValor(){
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("**RETIRO OTRO VALOR** \n\n");
        Console.Write("Ingrese el valor a retirar: ");
        int valor = Convert.ToInt32(Console.ReadLine());
        saldo = saldo - valor;

        PantallaConsultaSaldo();
    }
        


    public void PantallaTransferencias(){
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("**TRANSFERENCIAS**");
    }
    

    
}