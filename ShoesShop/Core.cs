﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoesShop
{
    public class Core
    {
        public static Entities DB = CreateSeededDatabase();

        public static void ResetDatabase()
        {
            DB = CreateSeededDatabase();
        }

        public static Entities CreateSeededDatabase()
        {
            var db = new Entities();
            db.Categories = new List<Categories>
            {
                new Categories { CategoryID = 1, Category = @"Женская обувь" },
                new Categories { CategoryID = 2, Category = @"Мужская обувь" },
            };

            db.Suppliers = new List<Suppliers>
            {
                new Suppliers { SupplierID = 1, Supplier = @"Kari" },
                new Suppliers { SupplierID = 2, Supplier = @"Обувь для вас" },
            };

            db.Producers = new List<Producers>
            {
                new Producers { ProducerID = 1, Producer = @"Kari" },
                new Producers { ProducerID = 2, Producer = @"Marco Tozzi" },
                new Producers { ProducerID = 3, Producer = @"Рос" },
                new Producers { ProducerID = 4, Producer = @"Rieker" },
                new Producers { ProducerID = 5, Producer = @"Alessio Nesca" },
                new Producers { ProducerID = 6, Producer = @"CROSBY" },
            };

            db.ProductType = new List<ProductType>
            {
                new ProductType { ProductTypeID = 1, ProductType1 = @"Ботинки" },
                new ProductType { ProductTypeID = 2, ProductType1 = @"Туфли" },
                new ProductType { ProductTypeID = 3, ProductType1 = @"Кроссовки" },
                new ProductType { ProductTypeID = 4, ProductType1 = @"Полуботинки" },
                new ProductType { ProductTypeID = 5, ProductType1 = @"Кеды" },
                new ProductType { ProductTypeID = 6, ProductType1 = @"Тапочки" },
                new ProductType { ProductTypeID = 7, ProductType1 = @"Сапоги" },
            };

            db.UsersRole = new List<UsersRole>
            {
                new UsersRole { UserRoleID = 1, UserRole = @"Администратор" },
                new UsersRole { UserRoleID = 2, UserRole = @"Менеджер" },
                new UsersRole { UserRoleID = 3, UserRole = @"Клиент" },
            };

            db.Users = new List<Users>
            {
                new Users { UserID = 1, UserRoleID = 1, Login = @"admin", Password = @"admin", Name = @"Администратор" },
                new Users { UserID = 2, UserRoleID = 1, Login = @"94d5ous@gmail.com", Password = @"uzWC67", Name = @"Никифорова Весения Николаевна" },
                new Users { UserID = 3, UserRoleID = 1, Login = @"uth4iz@mail.com", Password = @"2L6KZG", Name = @"Сазонов Руслан Германович" },
                new Users { UserID = 4, UserRoleID = 1, Login = @"yzls62@outlook.com", Password = @"JlFRCZ", Name = @"Одинцов Серафим Артёмович" },
                new Users { UserID = 5, UserRoleID = 2, Login = @"1diph5e@tutanota.com", Password = @"8ntwUp", Name = @"Степанов Михаил Артёмович" },
                new Users { UserID = 6, UserRoleID = 2, Login = @"tjde7c@yahoo.com", Password = @"YOyhfR", Name = @"Ворсин Петр Евгеньевич" },
                new Users { UserID = 7, UserRoleID = 2, Login = @"wpmrc3do@tutanota.com", Password = @"RSbvHv", Name = @"Старикова Елена Павловна" },
                new Users { UserID = 8, UserRoleID = 3, Login = @"5d4zbu@tutanota.com", Password = @"rwVDh9", Name = @"Михайлюк Анна Вячеславовна" },
                new Users { UserID = 9, UserRoleID = 3, Login = @"ptec8ym@yahoo.com", Password = @"LdNyos", Name = @"Ситдикова Елена Анатольевна" },
                new Users { UserID = 10, UserRoleID = 3, Login = @"1qz4kw@mail.com", Password = @"gynQMT", Name = @"Ворсин Петр Евгеньевич" },
                new Users { UserID = 11, UserRoleID = 3, Login = @"4np6se@mail.com", Password = @"AtnDjr", Name = @"Старикова Елена Павловна" },
            };

            db.Status = new List<Status>
            {
                new Status { StatusID = 1, Status1 = @"Новый" },
                new Status { StatusID = 2, Status1 = @"Завершен" },
            };

            db.PickPoint = new List<PickPoint>
            {
                new PickPoint { PickPointID = 1, Address = @"420151, г.Лесной, ул.Вишневая, д.32" },
                new PickPoint { PickPointID = 2, Address = @"125061, г.Лесной, ул.Подгорная, д.8" },
                new PickPoint { PickPointID = 3, Address = @"630370, г.Лесной, ул.Шоссейная, д.24" },
                new PickPoint { PickPointID = 4, Address = @"400562, г.Лесной, ул.Зеленая, д.32" },
                new PickPoint { PickPointID = 5, Address = @"614510, г.Лесной, ул.Маяковского, д.47" },
                new PickPoint { PickPointID = 6, Address = @"410542, г.Лесной, ул.Светлая, д.46" },
                new PickPoint { PickPointID = 7, Address = @"620839, г.Лесной, ул.Цветочная, д.8" },
                new PickPoint { PickPointID = 8, Address = @"443890, г.Лесной, ул.Коммунистическая, д.1" },
                new PickPoint { PickPointID = 9, Address = @"603379, г.Лесной, ул.Спортивная, д.46" },
                new PickPoint { PickPointID = 10, Address = @"603721, г.Лесной, ул.Гоголя, д.41" },
                new PickPoint { PickPointID = 11, Address = @"410172, г.Лесной, ул.Северная, д.13" },
                new PickPoint { PickPointID = 12, Address = @"614611, г.Лесной, ул.Молодежная, д.50" },
                new PickPoint { PickPointID = 13, Address = @"454311, г.Лесной, ул.Новая, д.19" },
                new PickPoint { PickPointID = 14, Address = @"660007, г.Лесной, ул.Октябрьская, д.19" },
                new PickPoint { PickPointID = 15, Address = @"603036, г.Лесной, ул.Садовая, д.4" },
                new PickPoint { PickPointID = 16, Address = @"394060, г.Лесной, ул.Фрунзе, д.43" },
                new PickPoint { PickPointID = 17, Address = @"410661, г.Лесной, ул.Школьная, д.50" },
                new PickPoint { PickPointID = 18, Address = @"625590, г.Лесной, ул.Коммунистическая, д.20" },
                new PickPoint { PickPointID = 19, Address = @"450983, г.Лесной, ул.Комсомольская, д.26" },
                new PickPoint { PickPointID = 20, Address = @"394782, г.Лесной, ул.Чехова, д.3" },
                new PickPoint { PickPointID = 21, Address = @"603002, г.Лесной, ул.Дзержинского, д.28" },
                new PickPoint { PickPointID = 22, Address = @"450558, г.Лесной, ул.Набережная, д.30" },
                new PickPoint { PickPointID = 23, Address = @"344288, г.Лесной, ул.Чехова, д.1" },
                new PickPoint { PickPointID = 24, Address = @"614164, г.Лесной, ул.Степная, д.30" },
                new PickPoint { PickPointID = 25, Address = @"394242, г.Лесной, ул.Коммунистическая, д.43" },
                new PickPoint { PickPointID = 26, Address = @"660540, г.Лесной, ул.Солнечная, д.25" },
                new PickPoint { PickPointID = 27, Address = @"125837, г.Лесной, ул.Шоссейная, д.40" },
                new PickPoint { PickPointID = 28, Address = @"125703, г.Лесной, ул.Партизанская, д.49" },
                new PickPoint { PickPointID = 29, Address = @"625283, г.Лесной, ул.Победы, д.46" },
                new PickPoint { PickPointID = 30, Address = @"614753, г.Лесной, ул.Полевая, д.35" },
                new PickPoint { PickPointID = 31, Address = @"426030, г.Лесной, ул.Маяковского, д.44" },
                new PickPoint { PickPointID = 32, Address = @"450375, г.Лесной, ул.Клубная, д.44" },
                new PickPoint { PickPointID = 33, Address = @"625560, г.Лесной, ул.Некрасова, д.12" },
                new PickPoint { PickPointID = 34, Address = @"630201, г.Лесной, ул.Комсомольская, д.17" },
                new PickPoint { PickPointID = 35, Address = @"190949, г.Лесной, ул.Мичурина, д.26" },
            };

            db.Products = new List<Products>
            {
                new Products { ProductID = 1, Article = @"А112Т4", ProductTypeID = 1, Unit = @"шт.", Price = 4990, SupplierID = 1, ProducerID = 1, CategoryID = 1, Discount = 3, QuantityInStock = 6, Description = @"Женские Ботинки демисезонные kari", Photo = @"1.jpg" },
                new Products { ProductID = 2, Article = @"F635R4", ProductTypeID = 1, Unit = @"шт.", Price = 3244, SupplierID = 2, ProducerID = 2, CategoryID = 1, Discount = 2, QuantityInStock = 13, Description = @"Ботинки Marco Tozzi женские демисезонные, размер 39, цвет бежевый", Photo = @"2.jpg" },
                new Products { ProductID = 3, Article = @"H782T5", ProductTypeID = 2, Unit = @"шт.", Price = 4499, SupplierID = 1, ProducerID = 1, CategoryID = 2, Discount = 4, QuantityInStock = 5, Description = @"Туфли kari мужские классика MYZ21AW-450A, размер 43, цвет: черный", Photo = @"3.jpg" },
                new Products { ProductID = 4, Article = @"G783F5", ProductTypeID = 1, Unit = @"шт.", Price = 5900, SupplierID = 1, ProducerID = 3, CategoryID = 2, Discount = 2, QuantityInStock = 8, Description = @"Мужские ботинки Рос-Обувь кожаные с натуральным мехом", Photo = @"4.jpg" },
                new Products { ProductID = 5, Article = @"J384T6", ProductTypeID = 1, Unit = @"шт.", Price = 3800, SupplierID = 2, ProducerID = 4, CategoryID = 2, Discount = 2, QuantityInStock = 16, Description = @"B3430/14 Полуботинки мужские Rieker", Photo = @"5.jpg" },
                new Products { ProductID = 6, Article = @"D572U8", ProductTypeID = 3, Unit = @"шт.", Price = 4100, SupplierID = 2, ProducerID = 3, CategoryID = 2, Discount = 3, QuantityInStock = 6, Description = @"129615-4 Кроссовки мужские", Photo = @"6.jpg" },
                new Products { ProductID = 7, Article = @"F572H7", ProductTypeID = 2, Unit = @"шт.", Price = 2700, SupplierID = 1, ProducerID = 2, CategoryID = 1, Discount = 2, QuantityInStock = 14, Description = @"Туфли Marco Tozzi женские летние, размер 39, цвет черный", Photo = @"7.jpg" },
                new Products { ProductID = 8, Article = @"D329H3", ProductTypeID = 4, Unit = @"шт.", Price = 1890, SupplierID = 2, ProducerID = 5, CategoryID = 1, Discount = 1, QuantityInStock = 4, Description = @"Полуботинки Alessio Nesca женские 3-30797-47, размер 37, цвет: бордовый", Photo = @"8.jpg" },
                new Products { ProductID = 9, Article = @"B320R5", ProductTypeID = 2, Unit = @"шт.", Price = 4300, SupplierID = 1, ProducerID = 4, CategoryID = 1, Discount = 2, QuantityInStock = 6, Description = @"Туфли Rieker женские демисезонные, размер 41, цвет коричневый", Photo = @"9.jpg" },
                new Products { ProductID = 10, Article = @"G432E4", ProductTypeID = 2, Unit = @"шт.", Price = 2800, SupplierID = 1, ProducerID = 1, CategoryID = 1, Discount = 3, QuantityInStock = 15, Description = @"Туфли kari женские TR-YR-413017, размер 37, цвет: черный", Photo = @"10.jpg" },
                new Products { ProductID = 11, Article = @"S213E3", ProductTypeID = 4, Unit = @"шт.", Price = 2156, SupplierID = 2, ProducerID = 6, CategoryID = 2, Discount = 3, QuantityInStock = 6, Description = @"407700/01-01 Полуботинки мужские CROSBY", Photo = @"1.jpg" },
                new Products { ProductID = 12, Article = @"E482R4", ProductTypeID = 4, Unit = @"шт.", Price = 1800, SupplierID = 1, ProducerID = 1, CategoryID = 1, Discount = 2, QuantityInStock = 14, Description = @"Полуботинки kari женские MYZ20S-149, размер 41, цвет: черный", Photo = @"2.jpg" },
                new Products { ProductID = 13, Article = @"S634B5", ProductTypeID = 5, Unit = @"шт.", Price = 5500, SupplierID = 2, ProducerID = 6, CategoryID = 2, Discount = 3, QuantityInStock = 0, Description = @"Кеды Caprice мужские демисезонные, размер 42, цвет черный", Photo = @"3.jpg" },
                new Products { ProductID = 14, Article = @"K345R4", ProductTypeID = 4, Unit = @"шт.", Price = 2100, SupplierID = 2, ProducerID = 6, CategoryID = 2, Discount = 2, QuantityInStock = 3, Description = @"407700/01-02 Полуботинки мужские CROSBY", Photo = @"4.jpg" },
                new Products { ProductID = 15, Article = @"O754F4", ProductTypeID = 2, Unit = @"шт.", Price = 5400, SupplierID = 2, ProducerID = 4, CategoryID = 1, Discount = 4, QuantityInStock = 18, Description = @"Туфли женские демисезонные Rieker артикул 55073-68/37", Photo = @"5.jpg" },
                new Products { ProductID = 16, Article = @"G531F4", ProductTypeID = 1, Unit = @"шт.", Price = 6600, SupplierID = 1, ProducerID = 1, CategoryID = 1, Discount = 12, QuantityInStock = 9, Description = @"Ботинки женские зимние ROMER арт. 893167-01 Черный", Photo = @"6.jpg" },
                new Products { ProductID = 17, Article = @"J542F5", ProductTypeID = 6, Unit = @"шт.", Price = 500, SupplierID = 1, ProducerID = 1, CategoryID = 2, Discount = 13, QuantityInStock = 0, Description = @"Тапочки мужские Арт.70701-55-67син р.41", Photo = @"7.jpg" },
                new Products { ProductID = 18, Article = @"B431R5", ProductTypeID = 1, Unit = @"шт.", Price = 2700, SupplierID = 2, ProducerID = 4, CategoryID = 2, Discount = 2, QuantityInStock = 5, Description = @"Мужские кожаные ботинки/мужские ботинки", Photo = @"8.jpg" },
                new Products { ProductID = 19, Article = @"P764G4", ProductTypeID = 2, Unit = @"шт.", Price = 6800, SupplierID = 1, ProducerID = 6, CategoryID = 1, Discount = 15, QuantityInStock = 15, Description = @"Туфли женские, ARGO, размер 38", Photo = @"9.jpg" },
                new Products { ProductID = 20, Article = @"C436G5", ProductTypeID = 1, Unit = @"шт.", Price = 10200, SupplierID = 1, ProducerID = 5, CategoryID = 1, Discount = 15, QuantityInStock = 9, Description = @"Ботинки женские, ARGO, размер 40", Photo = @"10.jpg" },
                new Products { ProductID = 21, Article = @"F427R5", ProductTypeID = 1, Unit = @"шт.", Price = 11800, SupplierID = 2, ProducerID = 4, CategoryID = 1, Discount = 15, QuantityInStock = 11, Description = @"Ботинки на молнии с декоративной пряжкой FRAU", Photo = @"1.jpg" },
                new Products { ProductID = 22, Article = @"N457T5", ProductTypeID = 4, Unit = @"шт.", Price = 4600, SupplierID = 1, ProducerID = 6, CategoryID = 1, Discount = 3, QuantityInStock = 13, Description = @"Полуботинки Ботинки черные зимние, мех", Photo = @"2.jpg" },
                new Products { ProductID = 23, Article = @"D364R4", ProductTypeID = 2, Unit = @"шт.", Price = 12400, SupplierID = 1, ProducerID = 1, CategoryID = 1, Discount = 16, QuantityInStock = 5, Description = @"Туфли Luiza Belly женские Kate-lazo черные из натуральной замши", Photo = @"3.jpg" },
                new Products { ProductID = 24, Article = @"S326R5", ProductTypeID = 6, Unit = @"шт.", Price = 9900, SupplierID = 2, ProducerID = 6, CategoryID = 2, Discount = 17, QuantityInStock = 15, Description = @"Мужские кожаные тапочки ""Профиль С.Дали"" ", Photo = @"4.jpg" },
                new Products { ProductID = 25, Article = @"L754R4", ProductTypeID = 4, Unit = @"шт.", Price = 1700, SupplierID = 1, ProducerID = 1, CategoryID = 1, Discount = 2, QuantityInStock = 7, Description = @"Полуботинки kari женские WB2020SS-26, размер 38, цвет: черный", Photo = @"5.jpg" },
                new Products { ProductID = 26, Article = @"M542T5", ProductTypeID = 3, Unit = @"шт.", Price = 2800, SupplierID = 2, ProducerID = 4, CategoryID = 2, Discount = 18, QuantityInStock = 3, Description = @"Кроссовки мужские TOFA", Photo = @"6.jpg" },
                new Products { ProductID = 27, Article = @"D268G5", ProductTypeID = 2, Unit = @"шт.", Price = 4399, SupplierID = 2, ProducerID = 4, CategoryID = 1, Discount = 3, QuantityInStock = 12, Description = @"Туфли Rieker женские демисезонные, размер 36, цвет коричневый", Photo = @"7.jpg" },
                new Products { ProductID = 28, Article = @"T324F5", ProductTypeID = 7, Unit = @"шт.", Price = 4699, SupplierID = 1, ProducerID = 6, CategoryID = 1, Discount = 2, QuantityInStock = 5, Description = @"Сапоги замша Цвет: синий", Photo = @"8.jpg" },
                new Products { ProductID = 29, Article = @"K358H6", ProductTypeID = 6, Unit = @"шт.", Price = 599, SupplierID = 1, ProducerID = 4, CategoryID = 2, Discount = 20, QuantityInStock = 2, Description = @"Тапочки мужские син р.41", Photo = @"9.jpg" },
                new Products { ProductID = 30, Article = @"H535R5", ProductTypeID = 1, Unit = @"шт.", Price = 2300, SupplierID = 2, ProducerID = 4, CategoryID = 1, Discount = 2, QuantityInStock = 7, Description = @"Женские Ботинки демисезонные", Photo = @"10.jpg" },
            };

            db.Orders = new List<Orders>
            {
                new Orders { OrderID = 1, OrderDate = new DateTime(2025, 2, 27), DeliveryDate = new DateTime(2025, 4, 20), AddressPointID = 1, UserID = 5, CodeToReceive = 901, StatusID = 1 },
                new Orders { OrderID = 2, OrderDate = new DateTime(2022, 9, 28), DeliveryDate = new DateTime(2025, 4, 21), AddressPointID = 11, UserID = 2, CodeToReceive = 902, StatusID = 1 },
                new Orders { OrderID = 3, OrderDate = new DateTime(2025, 3, 21), DeliveryDate = new DateTime(2025, 4, 22), AddressPointID = 2, UserID = 3, CodeToReceive = 903, StatusID = 1 },
                new Orders { OrderID = 4, OrderDate = new DateTime(2025, 2, 20), DeliveryDate = new DateTime(2025, 4, 23), AddressPointID = 11, UserID = 4, CodeToReceive = 904, StatusID = 1 },
                new Orders { OrderID = 5, OrderDate = new DateTime(2025, 3, 17), DeliveryDate = new DateTime(2025, 4, 24), AddressPointID = 2, UserID = 5, CodeToReceive = 905, StatusID = 1 },
                new Orders { OrderID = 6, OrderDate = new DateTime(2025, 3, 1), DeliveryDate = new DateTime(2025, 4, 25), AddressPointID = 15, UserID = 2, CodeToReceive = 906, StatusID = 1 },
                new Orders { OrderID = 7, OrderDate = new DateTime(2025, 2, 28), DeliveryDate = new DateTime(2025, 4, 26), AddressPointID = 3, UserID = 3, CodeToReceive = 907, StatusID = 1 },
                new Orders { OrderID = 8, OrderDate = new DateTime(2025, 3, 31), DeliveryDate = new DateTime(2025, 4, 27), AddressPointID = 19, UserID = 4, CodeToReceive = 908, StatusID = 2 },
                new Orders { OrderID = 9, OrderDate = new DateTime(2025, 4, 2), DeliveryDate = new DateTime(2025, 4, 28), AddressPointID = 5, UserID = 5, CodeToReceive = 909, StatusID = 2 },
                new Orders { OrderID = 10, OrderDate = new DateTime(2025, 4, 3), DeliveryDate = new DateTime(2025, 4, 29), AddressPointID = 19, UserID = 5, CodeToReceive = 910, StatusID = 2 },
            };

            db.OrdersProducts = new List<OrdersProducts>
            {
                new OrdersProducts { OrderID = 1, ProductID = 1, Quantity = 2 },
                new OrdersProducts { OrderID = 2, ProductID = 3, Quantity = 1 },
                new OrdersProducts { OrderID = 3, ProductID = 5, Quantity = 10 },
                new OrdersProducts { OrderID = 4, ProductID = 7, Quantity = 5 },
                new OrdersProducts { OrderID = 5, ProductID = 1, Quantity = 2 },
                new OrdersProducts { OrderID = 6, ProductID = 3, Quantity = 1 },
                new OrdersProducts { OrderID = 7, ProductID = 5, Quantity = 10 },
                new OrdersProducts { OrderID = 8, ProductID = 7, Quantity = 5 },
                new OrdersProducts { OrderID = 9, ProductID = 9, Quantity = 5 },
                new OrdersProducts { OrderID = 10, ProductID = 11, Quantity = 5 },
            };

            foreach (var user in db.Users)
                user.UsersRole = db.UsersRole.FirstOrDefault(x => x.UserRoleID == user.UserRoleID);

            foreach (var product in db.Products)
            {
                product.Categories = db.Categories.FirstOrDefault(x => x.CategoryID == product.CategoryID);
                product.Suppliers = db.Suppliers.FirstOrDefault(x => x.SupplierID == product.SupplierID);
                product.Producers = db.Producers.FirstOrDefault(x => x.ProducerID == product.ProducerID);
                product.ProductType = db.ProductType.FirstOrDefault(x => x.ProductTypeID == product.ProductTypeID);
            }

            foreach (var order in db.Orders)
            {
                order.PickPoint = db.PickPoint.FirstOrDefault(x => x.PickPointID == order.AddressPointID);
                order.Status = db.Status.FirstOrDefault(x => x.StatusID == order.StatusID);
                order.Users = db.Users.FirstOrDefault(x => x.UserID == order.UserID);
            }

            foreach (var orderProduct in db.OrdersProducts)
            {
                orderProduct.Orders = db.Orders.FirstOrDefault(x => x.OrderID == orderProduct.OrderID);
                orderProduct.Products = db.Products.FirstOrDefault(x => x.ProductID == orderProduct.ProductID);
            }

            return db;
        }
    }
}