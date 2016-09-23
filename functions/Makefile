.PHONY: all

package-super:
	zip -r super super/*

publish-super: package-super
	curl -u ${PLAY_AZURE_SERVERLESS_FUNCTIONS_USER}:${PLAY_AZURE_SERVERLESS_FUNCTIONS_PASSWORD} -X PUT -k -T super.zip https://play-azure-serverless-functions.scm.azurewebsites.net/api/zip/site/wwwroot
