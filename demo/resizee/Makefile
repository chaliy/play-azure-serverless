.PHONY: all

RESOURCE_GROUP=chaliy-azure-workplace

login:
	start "" https://aka.ms/devicelogin
	azure login

producer-vm:
	az vm create -n resizee-producer -g $(RESOURCE_GROUP) --image UbuntuLTS \
		--admin-username ops --ssh-key $(HOME)/.ssh/id_rsa.pub \
		--public-ip-address-dns-name 'resizee-producer-$(RESOURCE_GROUP)'
	scp -pr ./producer/. ops@resizee-producer-$(RESOURCE_GROUP).westeurope.cloudapp.azure.com:.

producer-sync:
	rsync -avz ./producer/. ops@resizee-producer-$(RESOURCE_GROUP).westeurope.cloudapp.azure.com:.


producer-ssh:
	ssh ops@resizee-producer-$(RESOURCE_GROUP).westeurope.cloudapp.azure.com

purge:
	az vm delete -n resizee-producer -g $(RESOURCE_GROUP)
