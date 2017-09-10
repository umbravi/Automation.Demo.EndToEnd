# Sentinel.EndToEnd
End to end testing framework for Sentinel UI. 
The purpose of the framework is to excercise funciontal testing against the Sentinel UI is a maintainable manner.

## Test Cases
Test cases are simple references to the Page Models that drive testing. Each test will have is own procedure and determines the flow of testing.

## Page Model
The Page model is two parts, the pages and the data model. 
- Each page is a description of the single page it represents with any test actions or validations that will be executed against that specific page.
- The data model contains any types for data generation or setting of application state.

## WebDriver
The WebDriver is Selenium and Protractor abstracted into easy to call methods for initiating the driver, performing actions and validations against the browser, enhanced reporting, and cleaning up the driver after a test.
