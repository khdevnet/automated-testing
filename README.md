# Automated-testing
This example shows benefits of Automated testing, also it contains wordpress Automation tests to display an example. 
## Run Test framework example
### Run Wordpress
```
$ cd ./wordpress
$ docker-compose up
```
### Run Automation UI Tests
```
$ dotnet test framework\WordpressAutomationDotNetCore\Wordpress.Automation.Test\Wordpress.Automation.Test.csproj
```
### Display allure report
```
$ cd ./allure
$ docker build -t=allure-report:latest .
$ docker run --rm -it -v %cd%/allure-results:/allure-results -p 8800:80 allure-report:latest
```

## Automated testing benefits
#### Automated Tests
* Free to run as often as required
* Run at any time
* Quicker
* Generally less error prone
* Automated test code in source control
* Creation and maintenance costs
#### Manual Human Tests
* Cost every test run (staff)
* Limited to staffed hours
* Slower
* Potentially more error prone
* Manual test scripts in external system
* Creation and maintenance costs

### Bugs cost on different stages
![](https://github.com/khdevnet/automated-testing/blob/master/src/bug-fix-costs-on-stages.png)
### Automation tests types
![](https://github.com/khdevnet/automated-testing/blob/master/src/test-types.png)
### Bugs detection and fix flows
![](https://github.com/khdevnet/automated-testing/blob/master/src/bugs-fix-verification.png)
