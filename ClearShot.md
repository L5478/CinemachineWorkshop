# ClearShot
1. Open the `ClearshotCamera` scene.
2. `Cinemachine` -> `Create ClearShot Camera`.
3. Reset the transform if necessary.
4. (Optional) Rename `CM ClearShot1` to `ClearShot Camera`
5. Open _cyborg_base, and drag the `LookAtPoint` onto the `Clearshot Camera`'s `Look At` Field.
6. Move `Clearshot Camera`'s first Child (virtual camera) so that it sits on the floor next to the wall and the cyborg.*
7. Click on the `ClearShot Camera` -> `Virtual Camera Children` --> Click on the +.
8. Move the new `Virtual camera` so that it sits on the sidewalk just around the corner of the street. (Approximately X: 11, Y: 0.3, Z: -6)* 
9. On both `Virutal Cameras`, expand the `Cinemachine Collider` and check the `Avoid Obstacles` Checkbox.
10. Move the character forward and around the corner. In the beginning the first `Virtual Camera` should be used, but after moving around the corner it loses vision and the `Clearshot Camera` should switch to the second `Virtual Camera`.

(Optional)
11. Move the `second Virtual Camera` so it is not around the corner anymore, and sitting on the same sidewalk as the `first Virtual Camera`
12. On Both `Virtual Cameras`, expand the `Cinemachine Collider` and set the `Optimal Target Distance` to 1 (at the very bottom).
13. Move the character forward. The `ClearShot Camera` should now switch between the two `Virtual Cameras` based on the target distance to the character.


*Obviously, you could place the cameras wherever you want, however placing it here makes it easier to see the effect the Clearshot Camera has.