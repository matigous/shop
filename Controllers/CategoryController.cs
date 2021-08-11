using Microsoft.AspNetCore.Mvc;

// Endpoint -> URL
// http://localhost:5000 https://localhost:5001
// https://meuapp.azurewebsites.net

[Route("categories")]
public class CategoryController : ControllerBase
{

    [HttpGet("")]
    public string Get()
    {
        return "";
    }
}