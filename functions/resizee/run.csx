using ImageResizer;

public static void Run(Stream blob,
    Stream outputBlob,
    TraceWriter log)
{
    log.Info("I am Resizee!");
    var imageBuilder = ImageResizer.ImageBuilder.Current;
    imageBuilder.Build(blob,
        outputBlob,
        new ResizeSettings(150, 150, FitMode.Max, null),
        false);
}
