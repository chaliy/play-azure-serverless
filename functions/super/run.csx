using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    var content = await req.Content.ReadAsStringAsync();
    log.Info($"Trigger function processed: {content}");
    return req.CreateResponse(HttpStatusCode.OK, content);
}
