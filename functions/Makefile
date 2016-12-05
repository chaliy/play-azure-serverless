.PHONY: all

publish:
	curl -u ${PLAY_AZURE_SERVERLESS_FUNCTIONS_USER}:${PLAY_AZURE_SERVERLESS_FUNCTIONS_PASSWORD} -X PUT -k -T functions.zip https://play-azure-serverless-functions.scm.azurewebsites.net/api/zip/site/wwwroot
	rm *.zip

package-simple:
	zip -r functions simple/*

publish-simple: package-simple publish


package-resizee:
	zip -r functions resizee/*

publish-resizee: package-resizee publish

package-py-simple:
	zip -r functions py-simple/*

publish-py-simple: package-py-simple publish
