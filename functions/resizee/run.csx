using ImageResizer;
using ImageResizer.ExtensionMethods;
 
public static void Run(Stream blob, 
					   Stream outputBlob, 
					   TraceWriter log)
{
    var instructions = new Instructions
    {
        Width = 200,
        Mode = FitMode.Carve,
        Scale = ScaleMode.Both
    };
    ImageBuilder.Current.Build(new ImageJob(blob, outputBlob, instructions));
}