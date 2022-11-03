using Wood_Pellets;

// Lager

ProductsRegistry.GenericPellets.AddStock(100);

// Customer

Customer customer = new Customer("Gert Hansen", "Algade 3", "12345678", "mail@mail.com");

// Order

Order order1 = new Order(customer, 5, ProductsRegistry.PremiumPellets, "Algade 3");
Order order2 = new Order(customer, 10, ProductsRegistry.GenericPellets, "Algade 5");

Console.WriteLine(OrderRegistry.List[0].Total());

Console.WriteLine(order2.Total());