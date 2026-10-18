# Assignment 4: Build and Deploy to the Quest

A small VR physics sandbox for the Meta Quest 3, built in Unity 6 with the Meta XR All-in-One SDK.

## Demo Video
[Watch the demo] https://github.com/user-attachments/assets/8ff3ee55-00f9-4be4-b751-c2c571cfa43a


## What It Does
- 6-DOF head tracking and tracked controllers (Camera Rig + Controller Tracking building blocks)
- Grab, stack, and throw blocks using the Grab Interaction building block (works with controllers or hand tracking)
- A 3-2-1 pyramid of blocks to knock down, plus loose blocks for throwing
- Each block gets a random color at startup via a custom `RandomColor.cs` script

## Download
The `.apk` is under [Releases](https://github.com/jacerea/Quest-Assignment4/releases). Sideload it with Meta Quest Developer Hub, then find it in the headset under Library → Unknown Sources.

## Built With
- Unity 6 (6000.5), Universal 3D (URP) template
- Meta XR All-in-One SDK (Building Blocks)
- Developed on macOS; deployed via Build And Run and Meta Quest Developer Hub

## Tutorials and References
- Meta Developer docs: Hello World / Create a VR Scene in Unity (Building Blocks)
- Meta Developer docs: Hand Grab Interaction (Interaction SDK)

