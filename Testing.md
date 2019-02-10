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


**Impact: Low**    
**Status: Pending**    


## Student Page

### Components with issues
* Change password option

**Problem:** When Changing password 2 times in a row, can't use the new passowrd in the 2nd attempt    
**Steps to recreate:** Open a student profile > Edit profile > Change Password once > Try to change password once again using the new password set up in previous step  
**Cause:** The old password is fetched when the student homepage form is loaded, it wasn't updated after changing password 
**Fix:** The hash value stored in the variable *password* has been set to update when the password updates  
**Status:** Fixed in commit **b79c71ea7961341c64e9f5d75742af71d952cf08**


* Adding ordinary leaves

**Problem:** If applied for 2 consecutive ordinary leaves totaling to more than 5 days, despite telling the user that it's not allowed a leave application is pushed to database   
Also when this situation occurs, the testing for 'OL' being less than 5 is breached through and even extremly long Ordinary leaves (well over 20 days) are pushed to database   
**Cause:** There seems to be missing cases in the If Else chain used in Sub NAApplyButton_Click   
**Fix:** No fix as of now   
**Status:** Pending
**Comments (Siddharth)** OL can't span for more than 5 days in one go, but total can be greater than 5. 
How were you able to save OL with 20 days?
kindly give the steps with exact dates.
thanks   
**Steps To Recreate:** Apply for an ordinary leave > Apply again, the starting date this time should be immediately next to the ending date last time, select the ending date with a 15 days gap and apply


* Mediacal, Academic and Parental Leaves 

**Problem:** For extra long leaves, even if the user declines to apply the application is pushed to DB    
**Steps to recreate:** Open student homepage > Apply > Try to Apply for academic leave of 1 month > When propmted wheather want to continue or not, choose 'No' > The application will still be pushed to DB   
**Cause:**  The boolean variable getting the response always evaluates to true  
**Fix:**  Changing all instances of  
```
Dim ans As Boolean = MessageBox....
```
To
```
Dim ans As DialogResult = Message...
```
And changing all corresponding If-Else conditions with
```
If ans = DialogResult.Yes
```
**Status:** Fixed