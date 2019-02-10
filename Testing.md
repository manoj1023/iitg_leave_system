# Testing of the Project

Report and status of testing of various components is listed here

## Login Page

### Components working fine
* Username textbox
* Password textbox
* Show password checkbox
* User type selector radio button
* Login button

Working fine and no work needed as of now


### Components with issues
* Forgot Password button

Working as expected for unregistered users, with registered users a message citing not availability of service is displayed. Can be changed upon discussion


#### Impact: Low
#### Status: Pending


## Student Page

### Components with issues
* Change password option

**Problem:** When Changing password 2 times in a row, can't use the new passowrd in the 2nd attempt    
**Steps to recreate:** Open a student profile > Edit profile > Change Password once > Try to change password once again using the new password set up in previous step  
**Cause:** The old password is fetched when the student homepage form is loaded, it wasn't updated after changing password 
**Fix:** The hash value stored in the variable *password* has been set to update when the password updates  
**Status:** Fixed in commit **f3038cb967a3cf305237b091b98d5086b1aefad0**
