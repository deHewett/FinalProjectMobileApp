using FinalMobileProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FinalMobileProject.ViewModels
{
    class BottlesPageModel
    {
        public ObservableCollection<Bottle> BottleList { get; set; }
        public BottlesPageModel()
        {

       
        BottleList = new ObservableCollection<Bottle>();
            BottleList.Add(new Bottle { Image = "https://hgtvhome.sndimg.com/content/dam/images/hgtv/products/2019/2/26/1/RX_food-52_soma-glass-water-bottle1.jpg.rend.hgtvcom.966.966.suffix/1551197487414.jpeg", Title = "Yellow Bag", Price = "10", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            BottleList.Add(new Bottle { Image = "http://bunewsservice.com/wp-content/uploads/2018/01/self-cleaning-water-bottle-241453-1510179223032-main.640x0c.png", Title = "Recycle Green Bag", Price = "15", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            BottleList.Add(new Bottle { Image = "https://images-na.ssl-images-amazon.com/images/I/41AhHyBinML._SL1000_.jpg", Title = "Eco-Friendly Bag - White", Price = "10", Description = "Our new Ecopack Compostable Retail Bags are plastic free and certified compostable. They meet the new government legislation as they are over 70 micron in thickness. Available in small, medium and large. Size : 40cm(w) X 49cm(h)" });
            BottleList.Add(new Bottle { Image = "https://image.dhgate.com/0x0/f2/albu/g7/M00/5A/17/rBVaSlvWqASAfoJWAAEQIHWDcFI614.jpg", Title = "Compostable Punched Handle Bags", Price = "20", Description = "Take your branding to a new level with customised non-woven totes. These totes our most economical bag option for fundraising, promotional giveaways and special events. Size : 350mm(w) + 90mm(g) x 400mm(h), Minimum order quantity for custom branding is 200 pieces, No minimum order for unbranded bags, Click on request a quote for custom branding or contact us" });
            BottleList.Add(new Bottle { Image = "https://static.independent.co.uk/s3fs-public/thumbnails/image/2019/02/18/16/reusable-water-bottles-istock.jpg?w968h681", Title = "Black Reusable Bag", Price = "10", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            BottleList.Add(new Bottle { Image = "https://myfrugaladventures.com/wp-content/uploads/2016/10/swell-water-bottles.jpg", Title = "Bear Bag", Price = "19.99", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            BottleList.Add(new Bottle { Image = "https://media.utilitydesign.co.uk/catalog/product/cache/1/thumbnail/588x/9df78eab33525d08d6e5fb8d27136e95/r/o/rose-gold.jpg", Title = "Type Recycle Bag", Price = "20", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            BottleList.Add(new Bottle { Image = "http://bunewsservice.com/wp-content/uploads/2018/01/self-cleaning-water-bottle-241453-1510179223032-main.640x0c.png", Title = "Earth Recycle Bag", Price = "25", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });

 }

    }
}
