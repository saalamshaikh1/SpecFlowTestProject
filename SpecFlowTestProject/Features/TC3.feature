Feature: TC3

Test Case for registering multiple account using excel data


@DataSource:tcdata.xlsx @Dataset:TestData
Scenario: TC_RegisterMultipleAccount
	Given Open Application URL
	Then Enter Phone Number <PhoneNumber>
	Then Enter Fullname <Fullname>
	Then Enter Password <Password>
	Then Enter Brithday Month <BrithdayMonth>
	Then Enter Birthday Day <BirthdayDay>
	Then Enter Birthday Year <BirthdayYear>
	Then Select Gender <Gender>
	Then Click on slide to get sms code 
	Then  enter sms code <SMSCode>
	Then Click on SIGNUP