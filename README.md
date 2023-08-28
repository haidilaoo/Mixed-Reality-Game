# Bouncing-Bally
Bouncing Bally is a mixed reality game that requires players to use real-world objects or their own hands to guide a virtual bouncing ball into a randomly positioned house. The game has multiple levels with increasing difficulty, and players must use their creativity and problem-solving skills to clear each level.

## Gameplay: 
When the game is started, the player enters the Main Scene, which acts as the main menu starting screen. Here, players can interact with balls continuously emitting from the top of the screen to become familiar with object interaction during gameplay. This can be considered a tutorial phase without guided instructions.

After warming up, players can trigger the game by writing PLAY anywhere in the webcam's view, bringing them to the gameplay stage. In the gameplay scene, the main player named Bally needs to be brought back home to a point on the screen.

The gameplay begins with a bouncing ball, aka the main player named Bally, being dropped from the top of the playview. The ball Bally bounces around randomly, and the player's objective is to guide it into its house that appears at a random location on the playview/surface. To do this, the player must use real-world objects (such as blocks, ramps, or even their own hands) to create paths for the ball to follow. They can also draw lines with a black marker to help guide the ball.

As the player progresses through the levels, the game becomes more challenging. For example, there may be multiple bouncing balls to guide, or the house may be positioned in a more difficult location. There may also be predetermined barriers in place that the player must work around.

The game can also incorporate conditions such as having different shapes of objects have different physical properties. For example, a curved object may cause the ball to bounce in a different direction, while a flat object may allow the ball to roll more smoothly.

## Equipment needed: 
To play Bouncing Bally, players will need a projector to display the bouncing ball onto a flat surface for the best experience.
<p align="center">
<img src= "https://github.com/haidilaoo/Bouncing-Bally/assets/96616994/435cdffc-ae55-40c0-8249-92479df8b49c"  width="400" height="400" />
</p>

## Conclusion: 
Bouncing Bally is a fun and engaging mixed reality game that challenges players to think creatively and use their problem-solving skills. With multiple levels and increasing difficulty, the game is sure to keep players entertained and engaged.

The game can be integrated with either a Kinect or Intel RealSense camera, along with projection mapping. It can be designed as a mass group interactive game, where people can participate in various ways based on their surroundings and available resources. The game's simplicity and accessibility make it ideal for large group play, as it is easy for participants to understand and engage with.

Ways Bouncing Bally can be utilized in the real world:

1. Physical Education: The game can be utilized in physical education classes to
encourage students to engage in physical activity while simultaneously having
fun. The game can also help students develop hand-eye coordination and spatial
awareness.
2. Cognitive Rehabilitation: The game can be used in cognitive rehabilitation
therapy to help individuals recover from traumatic brain injuries or strokes. The
game's various levels of difficulty and the need to move actual objects around
can provide a cognitive challenge for patients, helping to improve their cognitive
abilities.
3. Entertainment: The game can provide a fun and interactive experience for
individuals of all ages. The game's unique use of mixed reality technology can
help immerse players in a dynamic and engaging environment.

Hence, some potential problems that Bouncing Bally can help address include a lack of physical activity among children, cognitive impairment resulting from traumatic brain injuries or strokes, and the need for engaging and interactive entertainment options.

What I achieved:
1. Object detection and colliders on its contours
2. Basic Text Recognition
3. Particle trail effect on Bally the ball in gameplay(Start scene)
4. Glow effect on falling blue balls in starting scene(Main Text draft scene) (not very
obvious against bright/white backdrops)
5. Gameplay sound effects on bounce/collision, Background music, etc
6. Features currently not in use as it’s kind of buggy: </p>
  a. Line renderer on colliders to allow player to see where are the colliding
     points for better player experience </p>
  b. Ball Player with soft body effect (Prefab is called Ball Player, currently in
     use is Sphere2D)

Key features to be expanded on:
1. Using object recognition to start
2. Virtual buttons rather than using the button UI on Unity </p>
a. Once virtual button is covered using hand/tapped Start Scene is triggered </p>
3. Improving UI of falling balls and balls having a ripple effect after each
bounce/collision
4. Projection map game onto a surface

## Notes: 
1. To toggle background sprite/instruction overlay on and off, press A & S keys.
2. IMPT: Handwritten PLAY may not be detected sometimes and it might be due to the TextRecognition script being only used for only Optical character recognition (OCR), which examines scanned images of printed text and transforms those images into digital texts. Though the most sophisticated OCR models can identify almost every font type, they only work with printed text and dismiss handwritten data. Intelligent Character Recognition (ICR) and Intelligent Word Recognition (IWR) would be better for handwritten text (which atm is not available in the game unfortunately 🙁 ).

 Hence, to start the game you can try placing a typewritten PLAY in the camera view, or alternatively, you can press the space key to start the game scene.

3. Start Scene = where the Game play is done
4. End Scene = Winning scene
5. Other scenes are not in use atm
6. Some scripts are not in use 

