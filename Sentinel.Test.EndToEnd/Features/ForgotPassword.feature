Feature: Forgot Password
  In order to access the application when I have forgotten my password
  As a user
  I want to be able to reset my password

  Scenario: Navigate to Forgot My Password page
    Given "Agent Sade" has valid a login credential
    And has navigated to the "Login" page
    And has clicked the "Forgot Password" link
    Then the "Forgot My Password" page is displayed

  Scenario: Valid username entered on Forgot My Password page
    Given "Agent Sade" has navigated to the login page
    When "Agent Sade" provides a valid username
    Then the "Answer Security Questions" page is displayed

  Scenario: Valid anwser to security question on Answer Security Questions page
    Given "Agent Sade" has navigated to the "Answer Security Questions" page
    When "Agent Sade" answers the security question correctly
    Then the "Reset Password" page is displayed

  Scenario: Enable Next button on Reset Password Page
    Given "Agent Sade" has navigated to the "Reset Password" page
    When "Agent Sade" provides a vaild new password in both fields
    Then the "Next" button is enabled

  Scenario: Submit new valid password on Reset Password Page
    Given "Agent Sade" has navigated to the "Reset Password" page
    When "Agent Sade" provides a vaild new password in both fields
    And clicks the "Next" button
    Then the "Successful Password Reset" page is displayed
    And text "The password has be successfully reset" is displayed

  Scenario: Invalid username entered on Forgot My Password page
    Given "Agent Sade" has navigated to the login page
    When "Agent Sade" provides an invalid username
    Then the "Forgot My Password" page is displayed
    And error message "Invalid Username." is displayed

  Scenario: Invalid anwser to security question on Answer Security Questions page
    Given "Agent Sade" has navigated to the "Answer Security Questions" page
    When "Agent Sade" answers the security question incorrectly
    Then the "Answer Security Questions" page is displayed
    And error message "Invalid Answer." is displayed

  Scenario: Enter different passwords with valid formats
    Given "Agent Sade" has navigated to the "Reset Password" page
    When "Agent Sade" provides valid passwords that are different
    Then the "Next" button is disabled
    And error message "Confirmation password is not the same as the new password." is displayed

  Scenario: Enter single password in first field
    Given "Agent Sade" has navigated to the "Reset Password" page
    When "Agent Sade" provides a single password in the first password field
    Then the "Next" button is disabled
    And error message "Confirmation password is not the same as the new password." is displayed

  Scenario: Enter single password in second field
    Given "Agent Sade" has navigated to the "Reset Password" page
    When "Agent Sade" provides a single password in the second password field
    Then the "Next" button is disabled
    And error message "Confirmation password is not the same as the new password." is displayed

  Scenario: Enter first password with invalid format and second password with valid format
    Given "Agent Sade" has navigated to the "Reset Password" page
    When "Agent Sade" provides the first password with and invalid format
    And provides the second password with a valid format
    Then the "Next" button is disabled
    And the first password text box is outlined in red
    And error message "{password formatting text}" is displayed under the first password text box
    And error message "Confirmation password is not the same as the new password." is displayed

  Scenario: Enter first password with valid format and second password with invalid format
    Given "Agent Sade" has navigated to the "Reset Password" page
    When "Agent Sade" provides the first password with and invalid format
    Then the "Next" button is disabled
    And the first password text box is outlined in red
    And error message "{password formatting text}" is displayed
    And error message "Confirmation password is not the same as the new password." is displayed