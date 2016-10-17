import os
import urlparse
import json

for x in os.environ:
    if x[:12] == "REQ_HEADERS_":
        self._headers[x[12:].lower()] = os.environ[x]
    
    elif x[:10] == "REQ_QUERY_":
        self._query[x[10:].lower()] = os.environ[x]

    else:
        self._env[x.lower()] = str(os.environ[x])

    print('{1} {0}'.format(x.lower(), os.environ[x]))

req = open(os.environ['req'], "r").read()
print('Req:')
print(req)

res = open(os.environ['res'], 'w')
res.write(json.dumps({
    "status": 200,
    "body": "<h1>Yay!</h1>",
    "headers": {
        "Content-Type": "text/html"
    }
}))
