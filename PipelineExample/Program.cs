// Uses the new Microsoft "simplified" (ha!) console template - no need for namespace, class or public static void main

using Microsoft.Extensions.DependencyInjection;
using PipelineExample;
using PipelineExample.Models;
using PipelineExample.PipelineComponents;

var serviceCollection = new ServiceCollection();

// Setup pipeline - these will be run in the order you add them here
serviceCollection.AddSingleton<IPipelineComponent<InputModel, PricingModel>, PostcodeComponent>()
                .AddSingleton<IPipelineComponent<InputModel, PricingModel>, AgeComponent>()
                .AddSingleton<IPipelineComponent<InputModel, PricingModel>, NcbComponent>()
                .AddSingleton<IPipelineComponent<InputModel, PricingModel>, VehicleLookupComponent>()
                .AddSingleton<IPipelineComponent<InputModel, PricingModel>, PriceCalculatorComponent>();

// Setup pipeline runner - this could be any class you want, doesn't need to be a dedicated pipeline runner
serviceCollection.AddSingleton<IPipelineRunner<InputModel, IndicativePrice>, PipelineRunner>();

// Get pipeline runner
var serviceProvider = serviceCollection.BuildServiceProvider();
var pipelineRunner = serviceProvider.GetRequiredService<IPipelineRunner<InputModel, IndicativePrice>>();

var input = new InputModel
{
    Age = 35,
    Mileage = 23000,
    NcbCurrentlyProtected = true,
    Postcode = "W1A1AA",
    VehicleRegistrationNumber = "A1",
    YearsNoClaimsBonus = 9
};

// Call and use output of pipeline runner
var output = await pipelineRunner.RunPipeline(input);
Console.WriteLine($"Minimum premium: {output.MinimumPremium}");
Console.WriteLine($"Maxium premium: {output.MaximumPremium}");
Console.WriteLine($"Confidence: {output.ConfidenceLevel}");

