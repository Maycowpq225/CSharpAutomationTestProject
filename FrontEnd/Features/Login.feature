Feature: Login

  Scenario: Successful login
    Given User is on the website "https://www.saucedemo.com"
    When User enter with the username "<Username>" and password "<Password>"
    Then User validate he is on the homescreen

    Examples:
      | Username      | Password     |
      | standard_user | secret_sauce |
      | visual_user   | secret_sauce |
