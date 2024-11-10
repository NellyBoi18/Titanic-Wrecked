# Titanic Wrecked
Nelson Lu

## Project Goals
The primary goal of this project is to provide a **safe and affordable way to explore the Titanic shipwreck** through an immersive deep-sea exploration experience inspired by recent events. The project allows users to:
- Control a submarine
- Dive to the Titanic shipwreck
- Explore the entire Titanic wreck site

## Features and Controls
1. **Diving**: The dive process begins immediately since it takes time to reach the wreck site.
2. **Controls**:
   - Basic movement: `WASD` to move on the x-axis
   - Look around: `Mouse`
   - Dive down: `Left Control`
   - Dive up: `Space`
3. **Depth Meter**: The slider on the left side of the screen acts as both a depth and distance meter, indicating proximity to the shipwreck in both horizontal and vertical axes.
4. **Visual Effects**:
   - Bubbles: Simulate underwater ambiance around the submarine and in light beams.
   - Volumetric Light Beams: Simulate the searchlight cone but require an additional point light at the submarine's front for effective illumination.
5. **Sound Effects**: A looping background track simulates underwater sounds to enhance immersion.
6. **Exploration**: Users can explore the Titanic wreck, interact with illuminated areas, and see light reflections on shiny parts of the wreck. A box collider prevents the submarine from passing through ship walls.
7. **Animated Seaweed**: Seaweed on the seabed appears to move with underwater currents, adding realism.

## Challenges and Solutions
- **Lighting**: Finding the right lighting was challenging; many tutorials used the Volumetric Light Beam asset, which is paid. A free educational version greatly simplified following the tutorials and achieving the desired effect.
- **User Interface**:
   - Depth and Distance Meter: Initially intended to separate depth and map indicators but combined them into a single slider due to development time constraints.
   - Orientation: Early tests showed a risk of players getting disoriented. The depth/distance slider mitigates this by showing relative distance to the shipwreck.
- **Diving Experience**: The dive duration was adjusted for a more immersive experience. Faster movement made close navigation difficult. Planned marine life and seabed features could enhance this experience further.
- **First-Person vs. Third-Person View**: First-person was considered for greater immersion but posed challenges such as requiring a detailed interior model and integrating UI into the cockpit instruments. The third-person view was chosen for simplicity and allowed exterior exploration of the submarine.

## Future Updates
Planned improvements include:
- **Environmental Details**: Adding marine life (e.g., fish, sharks) and more seabed elements (e.g., corals, algae).
- **Titanic Model**: Enhancing the shipwreck model with additional textures and realism, such as algae growth and more intricate interior details.
- **UI Enhancements**:
   - Separate depth meter and map to provide clearer orientation and distance tracking.
- **Improved Controls**: Adjusting controls to allow horizontal movement with the left and right keys rather than just rotation, making navigation smoother.
- **First-Person Cockpit View**: Adding a cockpit view, especially for VR integration, to increase immersion and allow UI elements like the depth meter and map to be part of the submarine’s instrument panel.

## Credits
- **Models**:
  - Titanic Shipwreck – Chevin
  - Titan Submersible – dylanheyes
  - Seaweed – rkuhlf
- **Assets**:
  - Volumetric Light Beam Free – Tsunami (Original Tech Salad)
  - AQUAS Lite – Dogmatic
  - Underwater Sound Effects – Pixabay
