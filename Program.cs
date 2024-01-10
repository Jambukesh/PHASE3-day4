// See https://aka.ms/new-console-template for more information
using HandleProjects;
//Console.WriteLine("Hello, World!");

List<Product > products = new List<Product >()
{
new Product(){ Pname="laptop",Pprice  =25000,Pbrand  ="HP",ManufacturingDate=new DateTime (day:12,month:11,year:2022),ExpiryDate=new DateTime(day:12,month:11,year:2030)},
new Product(){ Pname="Mobile",Pprice  =45000,Pbrand  ="OPPO",ManufacturingDate=new DateTime (day:15,month:12,year:2021),ExpiryDate=new DateTime(day:12,month:11,year:2030)},
new Product(){ Pname="SmartWatch",Pprice  =2000,Pbrand  ="Itel",ManufacturingDate=new DateTime (day:12,month:11,year:2022),ExpiryDate=new DateTime(day:12,month:11,year:2030)},
new Product(){ Pname="Shoe",Pprice  =5000,Pbrand  ="Nike",ManufacturingDate=new DateTime (day:12,month:11,year:2022),ExpiryDate=new DateTime(day:12,month:11,year:2024)},

};
Console.WriteLine("Pname\tPprice\tPbrand\tMfdate\tExpdate");
foreach (Product  pd in products )
{
    Console.Write(pd.Pname  + "\t\t");
    Console.Write(pd.Pprice  + "\t\t");
    Console.Write(pd.Pbrand  + "\t\t");
    Console.Write(pd.ManufacturingDate .ToLongDateString() + "\t\t");
    Console.Write(pd.ExpiryDate .ToLongDateString() + "\t\t");
    Console.Write("\n");

}

