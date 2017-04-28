.PHONY: all

RESOURCE_GROUP?=play-azure-serverless

# Create Azure Resource Group to play in
group:
	az group create -n $(RESOURCE_GROUP) -l "West Europe"

# If something going wrang, clean up resource group
clean:
	az group deployment create --mode complete \
		--template-file purge.json \
		--resource-group $(RESOURCE_GROUP) \
		--name Purge

template:
	cat azuredeploy.yaml | python -c "import sys, yaml, json; json.dump(yaml.load(sys.stdin), sys.stdout, indent=4)" > azuredeploy.json

apply: template
	az group deployment create \
		--resource-group $(RESOURCE_GROUP) \
		--template-file azuredeploy.json

console:
	start "" https://$(RESOURCE_GROUP)-functions.scm.azurewebsites.net/
