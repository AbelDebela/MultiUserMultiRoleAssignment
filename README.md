# MultiUserMultiRoleAssignment
Blackbaud CRM Application User Security Project

Assigning permission and roles in Blackbaud CRM is quite a simple task when you are dealing with individual application users. Imagine doing that for an organization with over 300 sites and thousands of users. Not only that, in times where organizations restructure business units shuffle employees between teams, assigning roles and security permission for individual users become a nightmare. 

A couple of years ago, when I was dealing with this kind of challenge, I build this custom view form & it’s components to help me with multiple user & multiple role assignment. All source code is available in GitHub.

First, I created a view form to display all active users and available system roles. You can select multiple users & roles from the list on the view form.

Then you have two choices (buttons) that assign roles for selected users, or remove roles from selected users. Pressing these two buttons calls same record operation with different parameter and assign / remove system roles.

Note that this solution is intended to address standard desktop security features and it doesn’t address mobile devices security features.

