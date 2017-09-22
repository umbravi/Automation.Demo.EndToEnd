Feature: Login
  In order to access Sentinel
  As a user
  I want to be able to login

  Scenario: Exernal user with a valid credential
    Given "Agent Mulder" has a valid external credential
    And "Agent Mulder" has navigated to the login page
    When "Agent Mulder" logs in
    Then the "My Orders" page is displayed

  Scenario: External user with an invalid username
    Given "Agent Mulder" has navigated to the login page
    When "Agent Mulder" attempts to login with an invalid username
    Then the "login" page is displayed
    And error message "Invalid Username/Password combination." is displayed

  Scenario: External user with an invalid password
    Given "Agent Mulder" has navigated to the login page
    When "Agent Mulder" attempts to login with an invalid password
    Then the "login" page is displayed
    And error message "Invalid Username/Password combination." is displayed

  Scenario: Internal user login with SSO
    Given "Jessica" has authorization to SSO into Sentinel
    When "Jessica" sends a login request
    Then the "My Orders" page is displayed

  Scenario: Login page display terms of use
    Given "Agent Mulder" has navigated to the login page
    When "Agent Mulder" navigates to the terms of use
    Then the "terms of use" page is displayed