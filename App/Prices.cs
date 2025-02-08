using System.Diagnostics;

namespace App;

public static class Prices
{

    public static string GetCurrencyAlias(int price, bool isShortNotation, bool isFirstCapital)
    {
        Debug.Assert(price >= 0);
        if (isShortNotation)
        {
            return isFirstCapital ? "Руб." : "руб.";
        }

        if (price / 10 % 10 == 1)
        {
            return isFirstCapital ? "Рублей" : "рублей";
        }

        switch (price % 10)
        {
            case 0:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
                return isFirstCapital ? "Рублей" : "рублей";
            case 1:
                return isFirstCapital ? "Рубль" : "рубль";

            case 2:
            case 3:
            case 4:
                return isFirstCapital ? "Рубля" : "рубля";

        }

        return "oh no";

    }
}