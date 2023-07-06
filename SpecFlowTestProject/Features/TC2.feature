Feature: TC2

Test Case for registering with Multiple Browser

@Firefox
#Test case for executing cases in firefox 
Scenario: TCRegisterwithFirefox
	Given Open Application URL
	Then Enter Phone Number
	Then Enter Fullname
	Then Enter Password 
	Then Enter Brithday Month 
	Then Enter Birthday Day 
	Then Enter Birthday Year 
	Then Select Gender 
	Then Click on slide to get sms code 
	Then  enter sms code 
	Then Click on SIGNUP


@Chrome
#Test case for executing cases in Chrome
Scenario: TCRegisterwithChrome
	Given Open Application URL
	Then Enter Phone Number
	Then Enter Fullname
	Then Enter Password 
	Then Enter Brithday Month 
	Then Enter Birthday Day 
	Then Enter Birthday Year 
	Then Select Gender 
	Then Click on slide to get sms code 
	Then  enter sms code 
	Then Click on SIGNUP