.PHONY: all

package-simple:
	zip -r simple simple/*

publish-simple: package-simple
	curl -u ${PLAY_AZURE_SERVERLESS_FUNCTIONS_USER}:${PLAY_AZURE_SERVERLESS_FUNCTIONS_PASSWORD} -X PUT -k -T simple.zip https://play-azure-serverless-functions.scm.azurewebsites.net/api/zip/site/wwwroot
