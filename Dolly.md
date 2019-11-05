# Dolly and Track

1. Open the `DollyCartAndTrackCamera` scene.
2. `Cinemachine` -> `Create Dolly Camera with Track`.
3. Create an empty object, reset the transform and move the track and virtual camera into the object.
4. Select the virtual camera.
5. Drag the `_cyborg_base` object into the `Look At` property of the virtual camera. 
   * Adjust the `Aim` -> `Tracked Object Offset` -> `Y` value to look at the center of the player.
   * Increase the `Lens` -> `Field of View` value.
6. Select the dolly track and add a new waypoint.
7. Move the waypoint to the desired location.
8. Keep adding maypoints along the road.
9. Select the virtual camera
10. Go to `Body` and change the `Path Position` property, note in the game window that the camera will move along the track as you keep changing this value.
11. Drag the `_cyborg_base` object into the `Follow` property of the virtual camera.
12. Go to `Body` -> `Auto Dolly` and check `Enabled`
13. Hit play and move the character around with `WASD`. Note that the camera will move along the track automatically to follow the player.