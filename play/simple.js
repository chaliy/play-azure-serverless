const fetch = require('node-fetch');

fetch('https://play-azure-serverless-functions.azurewebsites.net/api/simple')
  .then(res => res.text())
  .then(console.log);
