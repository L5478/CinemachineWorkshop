# State Driven

1. Open the `StateDrivenCamera` scene.
2. Create a new State-Driven Camera by following `Cinemachine` -> `Create State-Driven Camera`.
4. Select the state-driven camera.
5. Drag and drop the _cyborg_base gameobject into the animated target property of the camera.
5. OPTIONAL: If you want the camera to keep track of the cyborg, drag and drop the _cyborg_base gameobject into the follow and look at properties of the camera.
   * If you want the camera to remain stationary while still looking at the cyborg, only drop the cyborg into the look at property, otherwise, drag and drop the cyborg gameobject into the follow property as well.
6. Duplicate the child camera three additional times.
7. For each child camera, assign the cyborg as a look at and a follow target. 
8. For each child camera, assign a different position
9. In the state list, add a New State by clicking on the + icon in the bottom right
10. Select an animation from the dropdown lists below state. Choose from either one of the following four: movement.walk, draw gun, press air, still jump.
11. Assign one of the child cameras to the state by selecting a camera from the dropdown list next to the animation you just selected
	* When renaming a camera, it might be useful to give it a name that corresponds to the specific animation you want the camera to focus on.
12. Repeat steps 9 - 11 for each of the remaining animations and child cameras.
13. Hit play and move the character around with `WASD`. There are buttons for special actions.
	* Draw Gun animation is triggered by pressing G on the keyboard.
	* Still Jump animation is triggered by pressing J on the keyboard.
	* Press Air animation is triggered by pressing P on the keyboard.
	As different animations are being played, you should see the camera switching to different angles depending on the animation played.