using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst.IteratorAndLinkerPattern;

public class DinerMenuTestDrive
{
    public static void Start()
    {
        PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
        DinerMenu dinerMenu = new DinerMenu();
        CafeMenu cafeMenu = new CafeMenu();
        Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);
        waitress.PrintMenu();
    }
}
