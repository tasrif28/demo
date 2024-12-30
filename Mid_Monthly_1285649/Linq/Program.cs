using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ProductCategory> categories = new List<ProductCategory>
            {
                new ProductCategory{ProductCategoryID = 1, Name = "Bikes"   },
                new ProductCategory{ProductCategoryID = 2, Name = "Components"  },
                new ProductCategory{ProductCategoryID = 3, Name = "Clothing"    },
                new ProductCategory{ProductCategoryID = 4, Name = "Accessories" },
                new ProductCategory{ProductCategoryID = 5, Name = "Mountain Bikes"  },
                new ProductCategory{ProductCategoryID = 6, Name = "Road Bikes"  },
                new ProductCategory{ProductCategoryID = 7, Name = "Touring Bikes"   },
                new ProductCategory{ProductCategoryID = 8, Name = "Handlebars"  },
                new ProductCategory{ProductCategoryID = 9, Name = "Bottom Brackets" },
                new ProductCategory{ProductCategoryID = 10, Name = "Brakes" },
                new ProductCategory{ProductCategoryID = 11, Name = "Chains" },
                new ProductCategory{ProductCategoryID = 12, Name = "Cranksets"  },
                new ProductCategory{ProductCategoryID = 13, Name = "Derailleurs"    },
                new ProductCategory{ProductCategoryID = 14, Name = "Forks"  },
                new ProductCategory{ProductCategoryID = 15, Name = "Headsets"   },
                new ProductCategory{ProductCategoryID = 16, Name = "Mountain Frames"    },
                new ProductCategory{ProductCategoryID = 17, Name = "Pedals" },
                new ProductCategory{ProductCategoryID = 18, Name = "Road Frames"    },
                new ProductCategory{ProductCategoryID = 19, Name = "Saddles"    },
                new ProductCategory{ProductCategoryID = 20, Name = "Touring Frames" },
                new ProductCategory{ProductCategoryID = 21, Name = "Wheels" },
                new ProductCategory{ProductCategoryID = 22, Name = "Bib-Shorts" },
                new ProductCategory{ProductCategoryID = 23, Name = "Caps"   },
                new ProductCategory{ProductCategoryID = 24, Name = "Gloves" },
                new ProductCategory{ProductCategoryID = 25, Name = "Jerseys"    },
                new ProductCategory{ProductCategoryID = 26, Name = "Shorts" },
                new ProductCategory{ProductCategoryID = 27, Name = "Socks"  },
          
            };

            List<ProductModel> models = new List<ProductModel>
            {
                new ProductModel{ProductModelID = 1, Name = "Classic Vest"   },
                new ProductModel{ProductModelID = 2, Name = "Cycling Cap"    },
                new ProductModel{ProductModelID = 3, Name = "Full-Finger Gloves" },
                new ProductModel{ProductModelID = 4, Name = "Half-Finger Gloves" },
                new ProductModel{ProductModelID = 5, Name = "HL Mountain Frame"  },
                new ProductModel{ProductModelID = 6, Name = "HL Road Frame"  },
                new ProductModel{ProductModelID = 7, Name = "HL Touring Frame"   },
                new ProductModel{ProductModelID = 8, Name = "LL Mountain Frame"  },
                new ProductModel{ProductModelID = 9, Name = "LL Road Frame"  },
                new ProductModel{ProductModelID = 10, Name = "LL Touring Frame"  },
                new ProductModel{ProductModelID = 11, Name = "Long-Sleeve Logo Jersey"   },
                new ProductModel{ProductModelID = 12, Name = "Men's Bib-Shorts"  },
                new ProductModel{ProductModelID = 13, Name = "Men's Sports Shorts"   },
                new ProductModel{ProductModelID = 14, Name = "ML Mountain Frame" },
                new ProductModel{ProductModelID = 15, Name = "ML Mountain Frame-W"   },
              
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductID = 2, Name = "LL Road Frame - Red, 48", ProductNumber = "FR-R38R-48", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 48, Weight = 1070.47, ProductCategoryID = 18, ProductModelID = 9  },
                new Product{ProductID = 3, Name = "LL Road Frame - Red, 52", ProductNumber = "FR-R38R-52", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 52, Weight = 1088.62, ProductCategoryID = 18, ProductModelID = 9  },
                new Product{ProductID = 1, Name = "LL Road Frame - Red, 44", ProductNumber = "FR-R38R-44", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 44, Weight = 1052.33, ProductCategoryID = 18, ProductModelID = 9  },
                new Product{ProductID = 4, Name = "LL Road Frame - Red, 58", ProductNumber = "FR-R38R-58", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 58, Weight = 1115.83, ProductCategoryID = 18, ProductModelID = 9  },
                new Product{ProductID = 14, Name = "HL Mountain Frame - Black, 44", ProductNumber = "FR-M94B-44", Color = "Black", StandardCost = 699.0928, ListPrice = 1349.6, Size = 44, Weight = 1251.91, ProductCategoryID = 16, ProductModelID = 5 },
                new Product{ProductID = 15, Name = "HL Mountain Frame - Black, 48", ProductNumber = "FR-M94B-48", Color = "Black", StandardCost = 699.0928, ListPrice = 1349.6, Size = 48, Weight = 1270.05, ProductCategoryID = 16, ProductModelID = 5 },
                
            };
       

            //Join
            Console.WriteLine();
            Console.WriteLine("Query");
            Console.WriteLine("====================");
            (
             from p in products
             join c in categories on p.ProductCategoryID equals c.ProductCategoryID
             join m in models on p.ProductModelID equals m.ProductModelID
             select new { p.ProductID, p.Name, category = c.Name, model = m.Name, p.Color, p.Weight, p.Size, p.ListPrice }
             ).ToList()
             .ForEach(p =>
             {
                 Console.WriteLine($"{p.ProductID}, {p.Name}, category: {p.category}");
             });

            Console.WriteLine();
            Console.WriteLine("Lambda");
            Console.WriteLine("====================");

            products.Where(p => p.Color == "Black")
                    .ToList()
                    .ForEach(p =>
                    {
                        var category = categories.FirstOrDefault(x => x.ProductCategoryID == p.ProductCategoryID);
                        var model = models.FirstOrDefault(X => X.ProductModelID == p.ProductModelID);

                        Console.WriteLine($"{p.ProductID},{p.Name},Model: {model.Name}");
                    });

            Console.ReadKey();
        }
    }
}
