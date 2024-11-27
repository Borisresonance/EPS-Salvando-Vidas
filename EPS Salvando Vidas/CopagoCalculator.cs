using System;

public static class CopagoCalculator
{
    public static decimal CalculateCopago(int estrato, string tipoAtencion)
    {
        decimal copago = 0;

        // Check tipoAtencion and calculate based on estrato
        if (tipoAtencion == "Medicina General")
        {
            switch (estrato)
            {
                case 1:
                case 2:
                    copago = 0;
                    break;
                case 3:
                    copago = 10000;
                    break;
                case 4:
                    copago = 15000;
                    break;
                case 5:
                    copago = 20000;
                    break;
                case 6:
                    copago = 30000;
                    break;
            }
        }
        else if (tipoAtencion == "Examen Laboratorio")
        {
            switch (estrato)
            {
                case 1:
                case 2:
                    copago = 0;
                    break;
                case 3:
                    copago = 0;
                    break;
                case 4:
                    copago = 5000;
                    break;
                case 5:
                    copago = 10000;
                    break;
                case 6:
                    copago = 20000;
                    break;
            }
        }

        return copago;
    }
}

