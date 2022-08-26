using UnitOfWorkV3.Entities;
using UnitOfWorkV3.Repository;
using UnitOfWorkV3.Services;

Product productA = new Product() { Id = 1, Name = "Manzana"};
Product productB = new Product() { Id = 2, Name = "Pera" };
Product productC = new Product() { Id = 3, Name = "Banana" };

Sale sale = new Sale() { Date = DateTime.Now };
SaleDetail detailA = new SaleDetail() { Product = productA, Quantity = 10 };
SaleDetail detailB = new SaleDetail() { Product = productB, Quantity = 20 };
SaleDetail detailC = new SaleDetail() { Product = productC, Quantity = 30 };

sale.Details.Add(detailA);
sale.Details.Add(detailB);
sale.Details.Add(detailC);

foreach (var detail in sale.Details)
{
    Console.WriteLine(detail.Product.Name + " " + detail.Quantity);
}

var unitOfWork = new UnitOfWorkSqlServer();

var productService = new ProductService(unitOfWork);

var saleService = new SaleService(unitOfWork);
sale.Id = saleService.CreateSale(sale);
Console.WriteLine(sale.Id);

sale = saleService.GetSale(sale.Id);
Console.WriteLine(sale.Date);

foreach (var detail in sale.Details)
{
    Console.WriteLine("Sale: {0} Product: {1}-{2} Quantity: {3}.",detail.IdSale, detail.Product.Id, detail.Product.Name, detail.Quantity);
}