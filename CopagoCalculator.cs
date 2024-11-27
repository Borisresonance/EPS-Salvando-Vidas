using System;

public static class CopagoCalculator
{
    public static int CalculateCopago(int estrato, bool isMedicinaGeneral)
    {
        int copago = 0;

        if (isMedicinaGeneral)
        {
            switch (estrato)
            {
                case 1: case 2: copago = 0; break;
                case 3: copago = 10000; break;
                case 4: copago = 15000; break;
                case 5: copago = 20000; break;
                case 6: copago = 30000; break;
            }
        }
        else
        {
            switch (estrato)
            {
                case 1: case 2: case 3: copago = 0; break;
                case 4: copago = 5000; break;
                case 5: copago = 10000; break;
                case 6: copago = 20000; break;
            }
        }

        return copago;
    }
}

