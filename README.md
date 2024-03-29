In the book “The 7 Habits of Highly Effective People”, Steven Covey talks about the habit of
“Putting First Things First”, and suggests that Tasks on the To Do list be broken out into four
Quadrants.
• Quadrant I: Important / Urgent
• Quadrant II: Important / Not Urgent
• Quadrant III: Not Important / Urgent
• Quadrant IV: Not Important / Not Urgent
Build an app that allow the users to enter tasks with the following information:
• Task (Required)
• Due Date
• Quadrant (Required)
• Category (Dropdown containing options: Home, School, Work, Church)
• Completed (True/False)
Build a View that lists out all the tasks, laid out on the screen in Quadrants. Allow the user to
Update and Delete the tasks and also to mark as Completed. Only display tasks that have not
been completed. Create a navigation menu to navigate between each view.
Assign each member of your team one of four responsibilities, which I have attempted to divide
up as evenly as possible:
#1: Models / Database / Setup: This individual will build the models and set up the database.
They will populate the database with any info your team deems as necessary. They will also
configure all the needed settings/services/endpoints in the Startup.cs file.
#2: Views -- Create Tasks View & Shared Layout: This individual will be responsible for
creating the Shared Layout and the Add/Edit Task view. The look and feel should be consistent
across the site, with the ability to navigate between the Add/Edit Task and Quadrants views.
#3: Views – Quadrants View: This individual will be responsible for creating the Quadrants
View and the ability for the user to Update and Delete.
#4: Controllers / GitHub / Project Management: This individual will be responsible for the
Controller(s). They will serve as Project Manager and be responsible for merging changes from
the individual branches into the Master branch on GitHub. They will be the point of contact for
the team with me. They will submit the project on behalf of the group.
Work as a team and feel free to help each other out. However, individuals should only make
changes in their assigned tasks. In other words, you can look at the code together and work as
a group to decide the best way to do something, but don’t just jump in and do it for the other
individual. The individual responsible should be writing the code. Everybody in the group
needs to contribute and do their part if they want to receive credit. Maybe a good rule of thumb
we could adopt: You are only allowed to edit the code you are responsible for. Please let me
know if there are any situations where a group member is not contributing.
Notes
- Break the Category out into a separate table to populate the dropdown.
- Build the database using any of the methods we have taken (Model First, Database First, or
building both the Models & Database independently.)
- The website needs to use the Bootstrap Grid system on all pages.
As always, write good clean code. Please let me know if there are any questions.
