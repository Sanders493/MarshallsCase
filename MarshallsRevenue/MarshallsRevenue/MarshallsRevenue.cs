using static System.Console;

/** This program prompts a user for the number of interior and exterior murals 
 *  scheduled to be painted during the next month. Then, display the total expected
 *  revenue and a statement.
 *  
 *  @author : Sanders Tshinyama, Kamal Yusuf, and Maria Esteban
 *  @version : 1.0 (09-02-2023)
 *  @since : 09-02-2023
 */

public class MarshallsRevenue
{
    public static void Main()
    {
        const int INTERIORMURALSPRICE = 500;
        const int EXTERIORMURALSPRICE = 750;

        int intPrice, extPrice;
        int total;

        Write("Enter the number of interior murals to be painted >> ");
        int interiorMurals = Convert.ToInt32(ReadLine());

        Write("Enter the number of exterior murals to be painted >> ");
        int exteriorMurals = Convert.ToInt32(ReadLine());

        intPrice = INTERIORMURALSPRICE * interiorMurals;
        extPrice = EXTERIORMURALSPRICE * exteriorMurals;
        total = intPrice + extPrice;

        WriteLine("The total revenue will be ${0}.  ${1} for interior murals, and ${2} for exterior murals.",
                total, intPrice, extPrice);

        if (interiorMurals > exteriorMurals)
        {
            WriteLine("More interior murals are scheduled than exterior ones.");
        }
        else
        {
            WriteLine("More exterior murals are scheduled than interior ones.");
        }
    }

}

