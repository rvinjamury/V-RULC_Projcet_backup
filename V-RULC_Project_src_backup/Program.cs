using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using IPacker;
using System.Data.SqlClient;

namespace TEST
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Item item1 = new Item();
            Pattern itemsFinalPattern = new Pattern();

            //string user_input;
            int bin_width, bin_height;
            RectangularBinPack rec = new RectangularBinPack();
            //..........Taking inputs for truck width and height..............
            //Console.Write("Enter bin Width: ");
            //user_input = Console.ReadLine();
            bin_width = Convert.ToInt32(300);

            //Console.Write("Enter bin Height: ");
            //user_input = Console.ReadLine();
            bin_height = Convert.ToInt32(300);
            //List<Rectangle> elementsToInsert = new List<Rectangle>
            //{
            //    new Rectangle(x:0, y:0, width:50, height:20),
            //    new Rectangle(x:0, y:0, width:20, height:50),
            //    new Rectangle(x:0, y:0, width:30, height:20),
            //    new Rectangle(x:0, y:0, width:30, height:30),
            //    new Rectangle(x:0, y:0, width:40, height:10),
            //    new Rectangle(x:0, y:0, width:10, height:25)
            //};
            //List<Rectangle> insertedElements;
            var form1 = new Form1();
            form1.dimX = bin_width;
            form1.dimY = bin_height;

            //var binPack = new RectangularBinPack(300, 300);
            //form1.dimY = binPack.dimbinHeight;
            //form1.dimX = binPack.dimbinWidth;
            //insertedElements = binPack.packElements(elementsToInsert, RectangularBinPack.FreeRectChoiceHeuristic.RectBestShortSideFit);
            //Application.Run(new Form1());
            //if (insertedElements == null)
            //    Console.WriteLine("Elements cannot be inserted...!!!");
            //else
            //{
            //    for (int i = 0; i < insertedElements.Count; i++)
            //    {
            //        form1.packages.Add(insertedElements[i]);
            //        //form1.boxY.Add();
            //        Console.WriteLine(insertedElements[i].X);
            //        //Console.WriteLine("All boxes are fit to the truck ");
            //    }
            //}

           
            //..........Initialising the items...................
            item1.width.Add(12);
            item1.height.Add(13);
            item1.width.Add(8);
            item1.height.Add(16);
            item1.width.Add(21);
            item1.height.Add(15);
            item1.width.Add(15);
            item1.height.Add(16);
            item1.width.Add(10);
            item1.height.Add(10);
            item1.width.Add(25);
            item1.height.Add(20);
            //itemsFinalPattern.itemPatern = item1;

            //Console.WriteLine("hello"+form1._item.width.ElementAt<int>(0));
            //itemsFinalPattern = rec.packer(form1._item, bin_width, bin_height);
            //if (itemsFinalPattern == null)
            //    Console.WriteLine("Items Packing not Possible...!!!");
            //else
            //{
            //    Console.WriteLine("Pattern of inserted Items:");
            //    for (int i = 0; i < itemsFinalPattern.itemPatern.width.Count; i++)
            //    {
            //        Console.WriteLine("Item: " + (i + 1) + " {X=" + itemsFinalPattern.pos_x[i] + ",Y=" + itemsFinalPattern.pos_y[i] + ",Width=" +
            //            itemsFinalPattern.itemPatern.width[i] + ",Height=" + itemsFinalPattern.itemPatern.height[i] + "}");
            //        //form1.packages.Add(itemsFinalPattern[i]);
            //        form1.packages.Add(new Rectangle(x: itemsFinalPattern.pos_x[i], y: itemsFinalPattern.pos_y[i], width: itemsFinalPattern.itemPatern.width[i], height: itemsFinalPattern.itemPatern.height[i]));

            //    }
            //}
            
            form1.ShowDialog();
            //Console.WriteLine("hello" + form1._item.width.ElementAt<int>(0));
            itemsFinalPattern = rec.packer(form1._item, bin_width, bin_height);
            if (itemsFinalPattern == null)
                Console.WriteLine("Items Packing not Possible...!!!");
            else
            {
                Console.WriteLine("Pattern of inserted Items:" + itemsFinalPattern.itemPatern.width.Count);
                for (int i = 0; i < itemsFinalPattern.itemPatern.width.Count; i++)
                {
                    Console.WriteLine("Item: " + (i + 1) + " {X=" + itemsFinalPattern.pos_x[i] + ",Y=" + itemsFinalPattern.pos_y[i] + ",Width=" +
                        itemsFinalPattern.itemPatern.width[i] + ",Height=" + itemsFinalPattern.itemPatern.height[i] + "}");
                    //form1.packages.Add(itemsFinalPattern[i]);
                    form1.packages.Add(new Rectangle(x: itemsFinalPattern.pos_x[i], y: itemsFinalPattern.pos_y[i], width: itemsFinalPattern.itemPatern.width[i], height: itemsFinalPattern.itemPatern.height[i]));

                }
            }

            //form1.Refresh();
            form1.ShowDialog();

        }
    }
}
