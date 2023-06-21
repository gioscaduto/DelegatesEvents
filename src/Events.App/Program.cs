using Events.App;

NumberGenerator numberGenerator = new();
numberGenerator.AddNumberHandler(g_OnGenerated);
numberGenerator.Start();

static void g_OnGenerated(object sender, NumberEventArgs args)
{
    Console.WriteLine($"Generated number: {args.Number}");
}
