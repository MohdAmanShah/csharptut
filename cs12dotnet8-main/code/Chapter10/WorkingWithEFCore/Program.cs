//var resultAdd = AddProduct(categoryId: 6,
// productName: "Bob's Burgers", price: 500M, stock: 72);
//if (resultAdd.affected == 1)
//{
//    WriteLine($"Add product successful with ID: {resultAdd.productId}.");
//}
//ListProducts(productIdsToHighlight: new[] { resultAdd.productId });

//var resultUpdate = IncreaseProductPrice(
// productNameStartsWith: "Bob", amount: 20M);
//if (resultUpdate.affected == 1)
//{
//    WriteLine($"Increase price success for ID: {resultUpdate.productId}.");   
//}
//ListProducts(productIdsToHighlight: new[] { resultUpdate.productId });

//WriteLine("About to delete all products whose name starts with Bob.");
//Write("Press Enter to continue or press any other key to cancel.");
//if (ReadKey(intercept: true).Key == ConsoleKey.Enter)
//{
//    WriteLine();
//    int deleted = DeleteProducts("Bob");
//    WriteLine($"{deleted} products(s) were deleted.");
//}
//else
//{
//    WriteLine("Deletion was canceled.");
//}

//var resultUpdateBetter = IncreaseProductPricesBetter(
// productNameStartsWith: "Bob", amount: 20M);
//if (resultUpdateBetter.affected > 0)
//{
//    WriteLine("Increase product price successful.");
//}
//ListProducts(productIdsToHighlight: resultUpdateBetter.productIds);

WriteLine("About to delete all products whose name starts with Bob.");
Write("Press Enter to continue or any other key to exit: ");
if (ReadKey(intercept: true).Key == ConsoleKey.Enter)
{
    int deleted = DeleteProductsBetter(productNameStartsWith: "Bob");
    WriteLine($"{deleted} product(s) were deleted.");
}
else
{
    WriteLine("Delete was canceled.");
}