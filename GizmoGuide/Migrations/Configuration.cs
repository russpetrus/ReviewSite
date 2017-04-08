namespace GizmoGuide.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GizmoGuide.Models.GizmoGuideContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GizmoGuide.Models.GizmoGuideContext";
        }

        protected override void Seed(GizmoGuide.Models.GizmoGuideContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );


            context.Categories.AddOrUpdate(
                c => c.CategoryID,
                new Category { CategoryID = 1, CategoryName = "Phones" },
                new Category { CategoryID = 2, CategoryName = "TVs" }, 
                new Category { CategoryID = 3, CategoryName= "Laptops"}
                );

            context.Reviews.AddOrUpdate(
                r => r.ReviewID,
                new Review { ReviewID = 1, ReviewDate = DateTime.Now, ProductMake = "Apple", ProductName = "iPhone 7", ModelNumber = "AP235357", ProductDescription = "Apple's latest phone", ImageURL = "https://store.storeimages.cdn-apple.com/4974/as-images.apple.com/is/image/AppleInc/aos/published/images/i/ph/iphone7/gallery2/iphone7-gallery2-2016?wid=835&hei=641&fmt=jpeg&qlt=95&op_sharpen=0&resMode=bicub&op_usm=0.5,0.5,0,0&iccEmbed=0&layer=comp&.v=1473877132504", ReviewContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam vitae interdum enim. Fusce dictum nec eros vitae viverra. Nulla ac augue mi. Sed et hendrerit eros. Praesent lobortis, mi vitae pulvinar ultrices, risus lorem efficitur ipsum, vitae aliquet velit velit sed nisi. Fusce sit amet pulvinar eros. Donec feugiat hendrerit aliquet. Pellentesque ex diam, feugiat quis risus vel, tincidunt fermentum est. Pellentesque sed massa venenatis, suscipit metus a, elementum orci. Pellentesque at dolor pulvinar, euismod neque ac, commodo nulla. Nunc mollis semper rhoncus. Donec eu lectus et diam cursus maximus eget eu risus. Quisque lobortis id leo eu venenatis. Pellentesque mollis consequat aliquet.", Score = 4, CategoryID = 1 },
                new Review { ReviewID = 2, ReviewDate = DateTime.Now, ProductMake = "Samsung", ProductName = "Galaxy s8", ModelNumber = "SMG235357", ProductDescription = "The latest iteration of Samsung's flagship smartphone", ImageURL = "http://s7d2.scene7.com/is/image/SamsungUS/4_learn_desktop_28upade?$cm-g-content-carousel-jpg$", ReviewContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam vitae interdum enim. Fusce dictum nec eros vitae viverra. Nulla ac augue mi. Sed et hendrerit eros. Praesent lobortis, mi vitae pulvinar ultrices, risus lorem efficitur ipsum, vitae aliquet velit velit sed nisi. Fusce sit amet pulvinar eros. Donec feugiat hendrerit aliquet. Pellentesque ex diam, feugiat quis risus vel, tincidunt fermentum est. Pellentesque sed massa venenatis, suscipit metus a, elementum orci. Pellentesque at dolor pulvinar, euismod neque ac, commodo nulla. Nunc mollis semper rhoncus. Donec eu lectus et diam cursus maximus eget eu risus. Quisque lobortis id leo eu venenatis. Pellentesque mollis consequat aliquet.", Score = 3, CategoryID = 1 },
                new Review { ReviewID = 3, ReviewDate = DateTime.Now, ProductMake = "Sony", ProductName ="Bravia", ModelNumber = "SNB1546", ProductDescription = "Imagine a TV that fits seamlessly into your life, enhancing every experience with a picture that’s as beautiful as its design. It’s all about you and your entertainment, delivering an experience that’s both effortless and exciting.", ImageURL = "https://i.ytimg.com/vi/PEgmOkdRDrM/maxresdefault.jpg", ReviewContent = "Praesent non purus at turpis lacinia pellentesque. Quisque ut nisi scelerisque, suscipit orci id, vehicula mauris. Nam accumsan volutpat tincidunt. Nulla facilisi. Curabitur ullamcorper, lacus id aliquam faucibus, ante felis varius odio, ac cursus purus quam vel quam. Proin et elit vulputate ex molestie commodo eu vitae dolor. Nam et lectus ex. Nulla facilisis commodo pellentesque. Aenean viverra elit sit amet tellus pulvinar, quis aliquam nisi pulvinar. Integer accumsan nibh in magna efficitur accumsan. Integer imperdiet malesuada sapien, eget semper enim maximus vitae. Curabitur ac lacinia orci. Quisque sodales mi odio, at feugiat lectus sagittis id. Fusce auctor, odio in imperdiet ultrices, sem nisl laoreet odio, eu semper urna sapien vitae lectus. Etiam posuere ligula tortor, ut eleifend purus rhoncus a. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", Score = 3, CategoryID = 2 },
                new Review { ReviewID = 4, ReviewDate = DateTime.Now, ProductMake = "LG", ProductName ="UHD TV", ModelNumber = "LG1234", ProductDescription = "Not all UHD TVs are the same. LG Super UHD TVs offer a superior 4K experience by incorporating advanced technologies that deliver over a billion rich colors, smoother motion and elevated brightness. HDR Super with Dolby Vision simply provides a better way to watch.", ImageURL = "http://www.lg.com/my/images/AV/features/my_sup_tv_feature_003.jpg", ReviewContent = "Praesent non purus at turpis lacinia pellentesque. Quisque ut nisi scelerisque, suscipit orci id, vehicula mauris. Nam accumsan volutpat tincidunt. Nulla facilisi. Curabitur ullamcorper, lacus id aliquam faucibus, ante felis varius odio, ac cursus purus quam vel quam. Proin et elit vulputate ex molestie commodo eu vitae dolor. Nam et lectus ex. Nulla facilisis commodo pellentesque. Aenean viverra elit sit amet tellus pulvinar, quis aliquam nisi pulvinar. Integer accumsan nibh in magna efficitur accumsan. Integer imperdiet malesuada sapien, eget semper enim maximus vitae. Curabitur ac lacinia orci. Quisque sodales mi odio, at feugiat lectus sagittis id. Fusce auctor, odio in imperdiet ultrices, sem nisl laoreet odio, eu semper urna sapien vitae lectus. Etiam posuere ligula tortor, ut eleifend purus rhoncus a. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", Score = 5, CategoryID = 2 },
                new Review { ReviewID = 5, ReviewDate = DateTime.Now, ProductMake = "Apple", ProductName = "MacBook Pro", ModelNumber = "MBP1316", ProductDescription = "It’s faster and more powerful than before, yet remarkably thinner and lighter. It has the brightest, most colorful Mac notebook display ever. And it introduces the Touch Bar — a Multi-Touch enabled strip of glass built into the keyboard for instant access to the tools you want, right when you want them. The new MacBook Pro is built on groundbreaking ideas. And it’s ready for yours.", ImageURL = "http://cdn.cultofmac.com/wp-content/uploads/2016/11/MacBook-Pro-Touch-Bar.jpg", ReviewContent = "Praesent non purus at turpis lacinia pellentesque. Quisque ut nisi scelerisque, suscipit orci id, vehicula mauris. Nam accumsan volutpat tincidunt. Nulla facilisi. Curabitur ullamcorper, lacus id aliquam faucibus, ante felis varius odio, ac cursus purus quam vel quam. Proin et elit vulputate ex molestie commodo eu vitae dolor. Nam et lectus ex. Nulla facilisis commodo pellentesque. Aenean viverra elit sit amet tellus pulvinar, quis aliquam nisi pulvinar. Integer accumsan nibh in magna efficitur accumsan. Integer imperdiet malesuada sapien, eget semper enim maximus vitae. Curabitur ac lacinia orci. Quisque sodales mi odio, at feugiat lectus sagittis id. Fusce auctor, odio in imperdiet ultrices, sem nisl laoreet odio, eu semper urna sapien vitae lectus. Etiam posuere ligula tortor, ut eleifend purus rhoncus a. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", Score = 5, CategoryID = 3 },
                new Review { ReviewID = 6, ReviewDate = DateTime.Now, ProductMake = "Lenovo", ProductName = "ThinkPad", ModelNumber = "LT1111", ProductDescription = "2017 Lenovo Thinkpad 13 1366x768 Chromebook, Integrated Intel HD Graphics 510, Celeron 3855U Dual-core 1.6GHz, 4GB RAM, 16GB eMMC, 802.11ac, Bluetooth, USB-C, HD Webcam, Chrome OS", ImageURL = "http://cdn2.ubergizmo.com/wp-content/uploads/2017/01/ThinkPad-X1-Carbon-4.jpg", ReviewContent = "Praesent non purus at turpis lacinia pellentesque. Quisque ut nisi scelerisque, suscipit orci id, vehicula mauris. Nam accumsan volutpat tincidunt. Nulla facilisi. Curabitur ullamcorper, lacus id aliquam faucibus, ante felis varius odio, ac cursus purus quam vel quam. Proin et elit vulputate ex molestie commodo eu vitae dolor. Nam et lectus ex. Nulla facilisis commodo pellentesque. Aenean viverra elit sit amet tellus pulvinar, quis aliquam nisi pulvinar. Integer accumsan nibh in magna efficitur accumsan. Integer imperdiet malesuada sapien, eget semper enim maximus vitae. Curabitur ac lacinia orci. Quisque sodales mi odio, at feugiat lectus sagittis id. Fusce auctor, odio in imperdiet ultrices, sem nisl laoreet odio, eu semper urna sapien vitae lectus. Etiam posuere ligula tortor, ut eleifend purus rhoncus a. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", Score = 2, CategoryID = 3 }
                );
            
        }
    }
}
