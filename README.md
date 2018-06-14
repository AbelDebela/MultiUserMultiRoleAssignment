# Multi-User Multi-Role Assignment / Remove
## Blackbaud CRM Application User Security Project

Assigning permission and roles in Blackbaud CRM is quite a simple task when you are dealing with individual application users. Imagine doing that for an organization with over 300 sites and thousands of users. Not only that, in times where organizations restructure business units & shuffle employees between teams, assigning security roles and permission for users become a nightmare. 

A couple of years ago, when I was dealing with this kind of work, I build this custom view form & it’s components to help me deal with assigning multiple roles to multiple users. All source code is available in GitHub.

First, I created a view form to display all active users and available system roles. You can select multiple users & roles from the list on the view form.

Then you have two choices (buttons) that __assign roles__ for selected users, or __remove roles__ from selected users. Pressing these two buttons calls same record operation with different parameter and assign / remove system roles.

Note that this solution is intended to address standard desktop security features and it doesn’t address mobile devices security features.

![multiroleassignment](https://user-images.githubusercontent.com/11167096/40852133-54ce84d0-657e-11e8-8515-583f23cae3d1.PNG)

![multiroleassignmenttask](https://user-images.githubusercontent.com/11167096/40851771-396d44f2-657d-11e8-93b6-3cc8a47317fc.PNG)
