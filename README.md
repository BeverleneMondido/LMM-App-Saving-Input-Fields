I used these codes on my very first mobile application during my OJT last Aug-Nov 2021. The application is called LMMS app or Lathe Machine 
Maintenance Sheet developed using UNITY Game Engine. This was developed as a substitute to the paper check sheet materials used in Lathe Machine Preventive Maintenance.
The goal is to make the process easier, faster, more convenient and maximize the use of mobile devices.

The application contains 5 scenes:
*Main Menu Scene
*LMMS scene
*Summary Report Scene
*Notes Scene
*Tutorial Guide Scene

# LMM-App-Saving-Input-Fields (used in LMMS Scene)
These codes are useful if you wanted to save any inputs in your input field. Assign this code to your save button and it will
save the entered data. This also contains the code for the entered inputs to reflect on the next scene. This doesn't use any type
of server. It only retrieves whatever is the last saved answer.

# LMM App Summary (used in Summary Report Scene)
This is to display/reflect the inputs entered in the previous scene which is the LMMS(check sheet scene). This can save temporarily the 
data displayed. Once you exit the application, the saved Summary Report will also be deleted. You can't retrieve past informations.

# LMM App NotepadScripts (used in Notes Scene)
This is to save and display the entries on the input field. It also contains the code for the reset and go back buttons.

# LMM App GoBackHome (used in Tutorial Guide)
In Unity, once you insert videos, you don't have to use any codes. Unity has a feature that can be set for the video to be played, stopped and resumed.
Therefore, I only used a "Back To Main Menu" code for the back button.

# LMM App MainManager (used in Main Menu Scene)
My main menu scene has 4 main buttons for the check sheet, summary report, tutorial guides and notes.
I used this code for the buttons to display the required scene. This is simply using the LoadSceneManager in Unity to call each scene.

