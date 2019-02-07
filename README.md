# Automated-testing
## Run
### configure allure
```
copy allureConfig.json to Allure.Common.dll folder
```
### run .net tests
```
$ dotnet test framework\WordpressAutomationDotNetCore\Wordpress.Automation.Test\Wordpress.Automation.Test.csproj
```
### display allure report
```
$ docker run --rm -it -v %cd%/allure-results:/allure-results -v %cd%/allure-report:/allu-report -p 8800:80 masterandrey/docker-allure ./allure serve -p 80 /allure-results
```

### High level benefits
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
