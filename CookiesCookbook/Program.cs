FileType fileType = FileType.Json; // Change this to FileType.Txt or FileType.Json as needed

// Use the factory to create the file helper and get the file path
IFileHelper fileHelper = FileHelperFactory.CreateFileHelper(fileType);
string filePath = FileHelperFactory.GetFilePath(fileType);

var ingredientManager = new IngredientManager();
var recipeManager = new RecipeManager(fileHelper);
var userInterface = new UserInterface(ingredientManager);

var cookiesCookbookApp = new CookiesCookBookApp(recipeManager, userInterface);
cookiesCookbookApp.Run(filePath);