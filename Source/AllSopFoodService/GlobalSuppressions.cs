// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Style", "IDE0005:Using directive is unnecessary.", Justification = "<Pending>", Scope = "namespace", Target = "~N:AllSopFoodService")]
[assembly: SuppressMessage("Style", "IDE0005:Using directive is unnecessary.", Justification = "<Pending>", Scope = "namespace", Target = "~N:AllSopFoodService.Model")]
[assembly: SuppressMessage("Style", "IDE0005:Using directive is unnecessary.", Justification = "<Pending>", Scope = "namespace", Target = "~N:AllSopFoodService.Controllers")]
[assembly: SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>", Scope = "member", Target = "~F:AllSopFoodService.Controllers.FoodProductsController._context")]
[assembly: SuppressMessage("Style", "IDE0009:Member access should be qualified.", Justification = "<Pending>", Scope = "member", Target = "~M:AllSopFoodService.Controllers.FoodProductsController.#ctor(AllSopFoodService.Model.FoodDBContext)")]
[assembly: SuppressMessage("Style", "IDE0021:Use expression body for constructors", Justification = "<Pending>", Scope = "member", Target = "~M:AllSopFoodService.Controllers.FoodProductsController.#ctor(AllSopFoodService.Model.FoodDBContext)")]
[assembly: SuppressMessage("Style", "IDE0022:Use expression body for methods", Justification = "<Pending>", Scope = "member", Target = "~M:AllSopFoodService.Controllers.FoodProductsController.GetFoodProducts~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.ActionResult{System.Collections.Generic.IEnumerable{AllSopFoodService.Model.FoodProduct}}}")]
[assembly: SuppressMessage("Style", "IDE0022:Use expression body for methods", Justification = "<Pending>", Scope = "member", Target = "~M:AllSopFoodService.Controllers.FoodProductsController.GetFoodProductsAsync~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.ActionResult{System.Collections.Generic.IEnumerable{AllSopFoodService.Model.FoodProduct}}}")]
[assembly: SuppressMessage("Style", "IDE0009:Member access should be qualified.", Justification = "<Pending>", Scope = "member", Target = "~M:AllSopFoodService.Controllers.FoodProductsController.GetFoodProductsAsync~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.ActionResult{System.Collections.Generic.IEnumerable{AllSopFoodService.Model.FoodProduct}}}")]
[assembly: SuppressMessage("Style", "IDE0009:Member access should be qualified.", Justification = "<Pending>", Scope = "member", Target = "~M:AllSopFoodService.Controllers.FoodProductsController.GetFoodProduct(System.Int32)~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.ActionResult{AllSopFoodService.Model.FoodProduct}}")]
[assembly: SuppressMessage("Style", "VSTHRD200:Use \"Async\" suffix for async methods", Justification = "<Pending>", Scope = "member", Target = "~M:AllSopFoodService.Controllers.FoodProductsController.GetFoodProduct(System.Int32)~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.ActionResult{AllSopFoodService.Model.FoodProduct}}")]
[assembly: SuppressMessage("Usage", "VSTHRD111:Use ConfigureAwait(bool)", Justification = "<Pending>", Scope = "member", Target = "~M:AllSopFoodService.Controllers.FoodProductsController.GetFoodProduct(System.Int32)~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.ActionResult{AllSopFoodService.Model.FoodProduct}}")]
[assembly: SuppressMessage("Style", "IDE0009:Member access should be qualified.", Justification = "<Pending>", Scope = "member", Target = "~M:AllSopFoodService.Controllers.FoodProductsController.PutFoodProductAsync(System.Int32,AllSopFoodService.Model.FoodProduct)~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.IActionResult}")]
[assembly: SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "<Pending>", Scope = "member", Target = "~M:AllSopFoodService.Controllers.FoodProductsController.PutFoodProductAsync(System.Int32,AllSopFoodService.Model.FoodProduct)~System.Threading.Tasks.Task{Microsoft.AspNetCore.Mvc.IActionResult}")]
[assembly: SuppressMessage("Style", "IDE0021:Use expression body for constructors", Justification = "<Pending>", Scope = "member", Target = "~M:AllSopFoodService.Controllers.FoodProductsController.#ctor(AllSopFoodService.Model.FoodDBContext,AllSopFoodService.Mappers.FoodProductstoViewFoodMapper)")]
[assembly: SuppressMessage("Style", "IDE0009:Member access should be qualified.", Justification = "<Pending>", Scope = "member", Target = "~M:AllSopFoodService.Services.ShoppingCartActions.GetCartItems~System.Collections.Generic.List{AllSopFoodService.Model.CartItem}")]
[assembly: SuppressMessage("Style", "IDE0009:Member access should be qualified.", Justification = "<Pending>", Scope = "member", Target = "~M:AllSopFoodService.Services.ShoppingCartActions.AddToCart(System.Int32)")]
[assembly: SuppressMessage("Style", "IDE0009:Member access should be qualified.", Justification = "<Pending>", Scope = "member", Target = "~M:AllSopFoodService.Services.ShoppingCartActions.Dispose")]
[assembly: SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>", Scope = "member", Target = "~F:AllSopFoodService.Services.ShoppingCartActions._httpContextAccessor")]
[assembly: SuppressMessage("Style", "IDE0044:Add readonly modifier", Justification = "<Pending>", Scope = "member", Target = "~F:AllSopFoodService.Services.ShoppingCartActions._db")]
[assembly: SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>", Scope = "member", Target = "~F:AllSopFoodService.Controllers.CartItemsController._usersShoppingCart")]
