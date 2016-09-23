.PHONY: all

package-simple:
	zip -r functions simple/*

package-resizee:
	zip -r functions resizee/*

publish:
	curl -u ${PLAY_AZURE_SERVERLESS_FUNCTIONS_USER}:${PLAY_AZURE_SERVERLESS_FUNCTIONS_PASSWORD} -X PUT -k -T functions.zip https://play-azure-serverless-functions.scm.azurewebsites.net/api/zip/site/wwwroot
	rm *.zip
