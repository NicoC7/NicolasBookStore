Athor Name: Nicolas Moreno Cordoba
Creation Date: 10/24/2023 At 10:12
Projec Name: NicolasBookStore

During Class time - 10:15:

I already create the project and comment the port line to run it and it is working right.

I created a repo in github but I cant see it. 

I modifyed the startup and it is working

10:42 Im trying to apply a bootstap style but is not working really well.

11:07 After looking around for the reason of why the bootstrap wasnt working and a short break, I figured it out what was heppening. Basically the href link wasnt the correct one for the new bootstrap file I picked.

11:11 Now I find another issue, I dont know which theme should I select. For that reason I added my two favorite themes. And I can change the theme whenever I want.

11:23 Im adding the new stylesheet and script links in the Layout.cshtml file.

11:35 Now lets add the dropdown to the nav bar.

11:46 I add the dropdown menu but it is not working

Date: 10/26/2023

18:06 I have been trying to fix the dropdown but I havent been able to do it.

18:39 Finally I solved the issue with the dropdown.

Date: 10/30/2023

7:36 Last Time I solved the issue with the Drpdown I just went to the boostrap documentation and I had missing some stuff. So Ill create the 3 new projects.

8:06 So I have finished but it is really wierd because I have no errors but I cant run the project so I will copy the redme and start all over again.

9:34 I have tryed with different versions (3.1, 5.0) and still not working and I have to do something so Im going to copy the readme and I ll try something else later. This sucks :(

12:39 I just got to the lab again lets see how it goes.

1:49 It is not going really well, I follow every single step but I cant run the project. But I have to go to class.

3:01 Again, I have no errors but it doesnt run because I have an error.

3:03 after running it. An error pop out, I tryed to solve it and I could run it but it says "MissingMethodException" and I dont know what to do.

3:06 Maybe its me and I just need to let it go.

3:12 This is like the 10th time I have tryed this. I dont know hy did I choose this course.
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Date: 11/1/2023

8:49 I have been working in this assignment since 7:30 and I thought that I have lost my readme but it was in an other computer. Basically I started from the beginning with the help of the GOAT(Christian) and I could crete the projects but I know the pushes to github wasnt working because we are creting the new projects outside of the folder.So I decided to do it again but inside of the project to solve this issue.

9:18 I decided to crete a new project so I dont have problems pushing it to github.

4:23 I finally could run the project. My mistake was the versions I was using so Used other versions and thats it. Intead of 5.0.11 I used 5.0.17.  :) :P

4:24 Lets continue doing building the project.

4:45 I almost mess the project up because I replace this {controller=Home} with this {area=Customer}

4:52 Im getting thsi error InvalidOperationException: The layout view '~/Views/Shared/_Layout' could not be located. The following locations were searched: ~/Views/Shared/_Layout
Obviously it is not finding the file, Ill figure it out.

4:53 I t was just the missing . cshtml Im feeling so dumb. :') :P

5:03 I can run the project but my buttons are not working and there is no log in and resgister buttons.

5:18 I found out why my buttons wasnt working and appering, it was because I moved them from views>shared to the customer area instead of copy and pasting it. Eventhough I found the problem, Chritian gives me the magic.

5:25 Modifying the database in the appsettings.json ((aspnet-)NicolasBookStore(-61B15D62-E9A3-472E-9480-03636B2E4A43))

5:40 Im about to add the migrations with this command "add-migrations addDefaultIdentityMigration"

5:45 Im not risking it so this is the name 20231101214237_addDefaultIdentityMigration

6:14 For now, there have been no issues. WELLL... Just a misspelling mistake with the MaxLength as MaxLenght

8:01 I'm exhautes so Im going home. Ill work on this tomorrow. Im at the slide number 11.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Date: 11/4/2023

12:27 I have been doing others assignments and I havent given much time to this so its time to finish it. My last advance was at the slide number 11. At this point I havent faced any big problem other than my stupidity.

12:45 I found a typo and I already correct it. I named procedureName all in lowercase.

1:07 I just finish adding the code to connect to the database in the SP_Call.cs	

1:32 You know what Im tired of this. I will do it later. This trash always gives me errors. The param parameter on SP_Call is giving me error and in the UnitOfWork.cs the public void Save and Dispose is giving me error.
Also to solve an error I added in the ApplicationDbContext.cs this code:
        public static implicit operator ApplicationException(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        } 



---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Date:11/7/2023

4:30 I solved all the issues I go back to slides and in rhe CategoryRepository.cs the intellisence get me dirty and I was creating and Application exception intead of an application db context and I can run my project.
And thx good you cancelled the class.

5:00 I was having an issue with the startup so i go back to the UnitOfWork.cs and I noticed that there was missing calling the his interfaces so I added that and the using statement and it worked.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Date: 11/10/2023

10:39 I have to review the powerpoint from 0 and I saw I have missing something IRepository.

10:51 I add this "object GetAll();" in ICategoryRepository to resolve an issue in the Category controller in my Admin Areas Controllers.

11:05 Im getting a really strage error that I dont know how to solve.

1:53 I set a class private instead of public. 

2:02 I added the link to the layout in the dropdown then I run it and its working.

2:56 I'm doing the selete and add button but i need to go to a class.

3:36 I finish my class and I will start working again on this assignment.

3:40 I added the _EditAndBackToListButton.cshtml and the _CreateAndBackToListButton.cshtml files and I added the code.

3:58 I modify the index.cshtml and Upsert.cshtml to apply the buttons functionality.

4:32 I add the API cal for delete. I dont what was happenning that was giving me a lot of errors.

5:13 I finished adding all the code and the slides but I try to add a category and it doesnt work. the problem is with the quick solutions solve errors but they doesnt work to the app to work correctly

5:16 Im starving and exhauted, im going home.

Microsoft.Data.SqlClient.SqlException: 'Cannot open database "NicolasBookStore" requested by the login. The login failed.
Login failed for user 'ACAD\W0823791'.'

This exception was originally thrown at this call stack:
    [External Code]
    NicolasBooks.DataAccess.Repository.UnitOfWork.Save() in UnitOfWork.cs
    NicolasBookStore.Areas.Admin.Controllers.CategoryController.Upsert(NicolasBooks.Models.Category) in CategoryController.cs
    [External Code]

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Date: 11/13/2023

12:51 I change the db connection to public and it doesnt work but it doesnt stop the application so basically what I did is add migrations and it wasnt stoping the app but it didmt add the category.

3:29 The database connection is working

Date: 11/20/2023

1:50 I havent do any changes to the project because it is not even working and now is worst because it is not linked with the database. So I dont know what to do.

21:15 As I couldnt figure out the issue with the database I continue with the part 3 and I already create the CoverType.cs in the Models folder.

21:34 I have added the CoverTypeRepository and ICoverTypeRepository and the CoverTypeRepository is giving an error in the firstordefault extension method that I havent been able to figure out.

21:43 I tryed to update the database and it failed...

21:45 Nothing is working and I dont know what to do, I already tryed everything even starting all over again and didnt worked. I will talk to u tomorrow to see if i can see a light at the end of this dark and long tunnel of adversity and failure.

21:53 I just add the index and upsert view, evendough it is not working im doing it to get the partial marks.

22:12 I will continue with the product to see if I can finish this part today.

22:20 Again I tryed to add the migrations and update the database to the products and it doesnt work...

22:22 So im done with the part 3 section 1 and im going to continue with part 3 section 2.

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Date: 11/27/2023

4:15 I have been working in a copy of the project for a couple of hours and now I will try to solve my issues in this assignment.


