using System;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using ImageResizer;

public static void Run(Stream blob, Stream outputBlob, TraceWriter log)
{
    var imageBuilder = ImageResizer.ImageBuilder.Current;
    imageBuilder.Build(blob, outputBlob, new ResizeSettings(150, 150, FitMode.Max, null), false);
}
