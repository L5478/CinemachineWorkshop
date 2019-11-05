# Free Look

1. Open the `FreeLookCamera` scene.
2. Create a new virtual camera from `Cinemachine` -> `Create FreeLook Camera`.
3. Select the virtual camera and rename it to `CM 3rd person camera`.
4. Drag the `_cyborg_base` object into the `Follow` property of the virtual camera.
5. Expand `_cyborg_base` object and drag `LookAtPoint` object to `Look At` property of the virtual camera.
6. Under `Axis Control` check `Invert` from Y Axis and uncheck `Invert` from X Axis.
7. Under `Orbits` modify `TopRig`, `MiddleRig` and `BottomRig` values as you like, to get right kind of camera movement behaviour.
8. Modify `Spline Curvature`, if you like.
9. There are a lot of options you can modify, play around with those.
10. Select the virtual camera and from `Add Extension` list select `CinemacineCollider`.
11. Ignore tag `Player`. Increase `Damping` and `Damping When Occluded` to get smoother camera movement.
12. Add `Noise` to MiddleRig to get a cool "handheld" effect. Select `Basic Multi Channel Perlin` from dropdown list. Choose `Noise Profile` and modify `Gains`, as you like.
13. You're now ready with your awsome free look 3rd person camera. Play around with settings and check out more extensions.