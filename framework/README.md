# Automation tests framework
### Architecture
![](https://github.com/khdevnet/automated-testing/blob/master/framework/docs/architecture.png)
### Page pattern
![](https://github.com/khdevnet/automated-testing/blob/master/framework/docs/page-pattern.png)
### Framework layers
![](https://github.com/khdevnet/automated-testing/blob/master/framework/docs/framework-layer-layers.png)
## Code style best practices
* Create methods using logical user operations and not with direct element
* NEVER require tests to declare variables
* NEVER require test to use the “new” keyword or create new objects
* NEVER require the tests to manage state on their own
* NEVER expose the browser or DOM to the tests or let them manipulate it directly
* ALWAYS reduce the number of parameters for API calls when possible
* ALWAYS use default values instead of requiring parameters when possible
* PREFER to make the API easier to use over making the internals of the API less complex
* PREFER using enumerations and constants to requiring the test to pass in primitive types
* Use descriptive methods and class names to describe Test Case in your code, use Domain Specific Languages (DSLs)
### Running tests
![](https://github.com/khdevnet/automated-testing/blob/master/framework/docs/runnig-tests.png)
