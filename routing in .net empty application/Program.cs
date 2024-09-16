
  //here we building the intance of our webapplication through createBuilder()
var builder = WebApplication.CreateBuilder(args);

// configuring the custom routing

builder.Services.AddControllersWithViews();


// here we  callin our instance of our webapplication
var app = builder.Build();

// here we are a callback function which print which you pass in the callback function

//app.MapGet("/", () => "My name akash mishra");   ====> you can't called this routing

// adding the middleware for routing
//app.MapDefaultControllerRoute(); // ===> this will only call the home controller index action method

// to define the custome routing 
app.MapControllerRoute(
    
    name:"default",
    pattern:"{controller=user}/{action=Index}/{id?}" // this the way to define the custome routing and the id parameter is optional here because with id we added a ? symbol which id indicate the id parameter is optional  
    );


app.Run();
