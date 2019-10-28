# ARFlyingChess
A Hackathon project, a chess game based on AR

This is a Hackathon project made in 24 hours. It's about a chess game using AR technology.

## Basic Information

This is a game developed on the Unity, the API of AR supported by the Vuforia. This game is finished in ~30 hours, which include 6h planning and 24h programming. It's a chess game, but you don't need a chessboard or chess to play it. All the thing you need is a phone with a camera and some poker cards.

## My team

This project is finished by a group which contains 3 people. I am the leader of the group. One of the members of the group is responsible for the production of the 3D model, and another team member and I are responsible for programming.

## Why we made this game

One of the topics of the Hackathon we attended is *how to make life more enjoyable with technology*, and we want to focus on the keyword *more*. So we chose to put some traditional games on platforms such as mobile phones. We finally decided to use flying chess. Flying chess is a popular board game in China. Each player controls four planes and rolls the dice to move the aircraft. There are no technical difficulties in this game. You just need to roll the dice and decide which plane to move. You don't need to focus that much on how to win because this is the game aiming not at becoming the winner but providing players a chance to chat/communicate with each other. To let people don't just stare at the screen when they play games, we choose to use AR technology to connect real and virtual worlds.

Another benefit of using AR technology is that we don't need a heavy board and pieces to play chess. In our design, we chose to use poker cards as recognition objects to generate chessboards, roll the dice, and control aircraft walking.

If we continue to develop this game in the future, we can integrate a variety of different board games and control them with poker cards. Then, we can play different board games with only one set of cards.

## Photos & Videos

### Photos

![screenshot1](/img/post5/img2.png)
↑ The chessboard generate by AR

![screenshot2](/img/post5/img3.png)
↑ Another red card is used as dice

![screenshot3](/img/post5/img4.png)
↑ After roll the dice, you can choose a plane to fly

![screenshot4](/img/post5/img5.png)
↑ You will find that there's small little blocks stay above the plane. That's used to indicate the number of each plane.

![screenshot5](/img/post5/img6.png)
↑ After you send all the planes to the endpoint. You will get four crowns.

### Videos

<video id="video1" controls="" preload="none" width="100%" height="100%">
    <source id="mp4" src="/video/1.mp4" type="video/mp4">
</video>
↑ Opening animation: the board will be loaded little by little.

<video id="video2" controls="" preload="none" width="100%" height="100%">
    <source id="mp4" src="/video/2.mp4" type="video/mp4">
</video>
↑ Roll the dice and control the plane to fly out. Please note that when the plane encounters a grid of the same color as himself, he will jump to the next grid of that color.

<video id="video3" controls="" preload="none" width="100%" height="100%">
    <source id="mp4" src="/video/3.mp4" type="video/mp4">
</video>
↑ When an airplane hits another aircraft, the impacted aircraft needs to return to the starting point.
