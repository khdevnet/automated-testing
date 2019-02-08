FROM openjdk:8-jre

COPY allure-2.0.1.tgz /

RUN apt-get update \
    && apt-get install tar \
    && tar -xvf allure-2.0.1.tgz \
    && chmod -R +x /allure-2.0.1/bin

VOLUME ["/allure-results"]

WORKDIR /allure-2.0.1/bin
CMD ["./allure","serve","-p","80","/allure-results"]