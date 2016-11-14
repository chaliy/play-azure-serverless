.PHONY: all

install:
	sudo apt-get update
	sudo apt-get install git
	# Python
	# sudo apt-get install python-pip
	# sudo pip install azure-cli
	# NodeJS
	curl -sL https://deb.nodesource.com/setup_6.x | sudo -E bash -
	sudo apt-get install -y nodejs
	sudo npm install -g azure-cli

login:
	azure login

upload:
	azure storage blob upload ./images/01.jpg sample-images

stress:
	set -e; \
		export AZURE_STORAGE_CONNECTION_STRING='$(shell \
				azure storage account connectionstring show playazureserverless -g play-azure-serverless \
				| grep -E 'data:.*connectionstring:(.*)' \
				| awk '{print $$3}' )'; \
		python3 stress.py
