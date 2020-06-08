VERSION?=local

.PHONY: build
build:
	@dotnet build

.PHONY: test
test: build
	dotnet test --no-build

.PHONY: docker-build
docker-build:
	docker build -t mustakimali/justaml:$(VERSION) -f Dockerfile .


.PHONY: docker-run
docker-run:
	docker run -it -p 5050:80 mustakimali/justaml:$(VERSION)
	
.PHONY: docker-push
docker-push:
	./Dockerpush.sh

.PHONY: docker-log
docker-log: SHELL:=/bin/bash
docker-log:
	kubectl get po | grep justaml | head -1 | awk '{print $$1}' | xargs -I{} kubectl logs --tail=10 -f {}