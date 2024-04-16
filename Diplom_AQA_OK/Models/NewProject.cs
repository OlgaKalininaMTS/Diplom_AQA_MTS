using Diplom_AQA_OK.Helpers.Configuration;
using Diplom_AQA_OK.Helpers;
using OpenQA.Selenium;

namespace Diplom_AQA_OK.Models;

public class Project
{
    public string ProjectName { get; set; }
    public string? ProjectKey { get; set; }
    public string? Description { get; set; }
    
}