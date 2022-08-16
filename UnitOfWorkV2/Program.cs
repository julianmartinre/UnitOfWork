using UnitOfWorkV2;

Console.WriteLine("Iniciando...");

var unitOfWork = new UnitOfWorkSqlServer();

var productService = new ProductService(unitOfWork);

productService.Add(new Product() { Name = "Producto" + DateTime.Now.Ticks.ToString()});