Feature: Login
  In order to access Sentinel
  As a user
  I want to be able to login
	
  Scenario: External user with a valid credential
    Given "Watson" has a valid external credential
    And "Watson" has navigated to the login page
    When "Watson" logs in
    Then the "Dashboard" page is displayed

  Scenario: External user with an invalid username
    Given "Watson" has navigated to the login page
    When "Watson" attempts to login with an invalid username
    Then the "login" page is displayed
    And error message "Invalid Username/Password combination." is displayed

  Scenario: External user with an invalid password
    Given "Watson" has navigated to the login page
    When "Watson" attempts to login with an invalid password
    Then the "login" page is displayed
    And error message "Invalid Username/Password combination." is displayed
	
  Scenario: External admin user with a valid credential
    Given "Sandiego" has a valid external credential
    And "Sandiego" has navigated to the login page
    When "Sandiego" logs in
    Then the "Dashboard" page is displayed

  Scenario: External admin user with an invalid username
    Given "Sandiego" has navigated to the login page
    When "Sandiego" attempts to login with an invalid username
    Then the "login" page is displayed
    And error message "Invalid Username/Password combination." is displayed

  Scenario: External admin user with an invalid password
    Given "Sandiego" has navigated to the login page
    When "Sandiego" attempts to login with an invalid password
    Then the "login" page is displayed
    And error message "Invalid Username/Password combination." is displayed