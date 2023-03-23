namespace ProductReviewManagement
{
    class Program
    {
        public static void Main(string[] args) {

            Console.WriteLine("Welcome to  Product  review  Management  problem  statement");
            List<ProductReview> productReviews = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Good", islike = true },
                new ProductReview() { ProductID = 2, UserID = 2, Rating = 4, Review = "Good", islike = true },
                new ProductReview() { ProductID = 1, UserID = 2, Rating = 5, Review = "Good", islike = true },
                new ProductReview() { ProductID = 3, UserID = 3, Rating = 5, Review = "Good", islike = true },
                new ProductReview() { ProductID = 1, UserID = 4, Rating = 5, Review = "Good", islike = true },
                new ProductReview() { ProductID = 5, UserID = 10, Rating = 1, Review = "Bad", islike = false },
                new ProductReview() { ProductID = 1, UserID = 10, Rating = 1, Review = "Good", islike = true },
                new ProductReview() { ProductID = 11, UserID = 10, Rating = 5, Review = "Good", islike = true },
                new ProductReview() { ProductID = 12, UserID = 10, Rating = 5, Review = "nice", islike = false },
                new ProductReview() { ProductID = 13, UserID = 10, Rating = 4, Review = "Good", islike = true },
                new ProductReview() { ProductID = 15, UserID = 10, Rating = 4, Review = "Good", islike = true },
                new ProductReview() { ProductID = 10, UserID = 10, Rating = 4, Review = "Good", islike = true }
            };

                //foreach(var list in productReviews)
                //{
                //    Console.WriteLine("ProductId  : "+list.ProductID+" UserId : "+list.UserID + "rating : " + list.Rating +  "review   : " + list.Review + "islike : " + list.islike);
                //}

                Management management= new Management();
                management.TopRecordsList(productReviews);

                    

            


        }

    }
    }
