Create class GameAccount. <br>
This class should have:
<ul>
    <li>UserName – name of user</li>
    <li>CurrentRating – rating of the user</li>
    <li>GamesCount – number of games played</li>
</ul>

Class should have such functions:
<ul>
    <li>WinGame – calls when user wins the game</li>
    <ul>
        <li>opponentName – opponent name</li>
        <li>Rating – rating of game</li>
    </ul>
    <li>LoseGame – calls when user loses the game</li>
    <ul>
        <li>opponentName</li>
        <li>rating</li>
    </ul>
    <li>GetStats – function which shows the game history (opponent; win/lose; rating of game; index of game)</li>
</ul>

Additional fields create if it is neccessary

General rules: <br>
<ul>
    <li>Rating can`t be less than 1.</li>
    <li>Rating of game can`t be less than 0 (in this case program should throw an exception).</li>
    <li>For games separate class is needed. It will consist all needed information about the game.</li>
    <li>Create 2 player`s objects in Main, simulate some games and print a statistic of both players.</li>
</ul>

<hr>

Створити клас GameAccount. <br>
Клас має обов'язково мати поля:
<ul>
    <li>UserName – Ім'я користувача</li>
    <li>CurrentRating – Рейтинг користувача</li>
    <li>GamesCount – Кількість зіграних партій</li>
</ul>

Клас має мати функції:
<ul>
    <li>WinGame – функція яка визивається у разі перемоги</li>
    <ul>
        <li>opponentName – ім'я оппонента</li>
        <li>Rating – рейтинг на який була гра</li>
    </ul>
    <li>LoseGame з полями – функція яка визивається у разі враження</li>
    <ul>
        <li>opponentName</li>
        <li>rating</li>
    </ul>
    <li>GetStats – функція яка показує історію ігор(Проти кого, перемога чи враження, на який рейтинг грали, індекс гри)</li>
</ul>

Додаткові поля та функції створюйте за необхідності

Загальні умови: <br>
<ul>
    <li>Рейтинг не може стати меншим за 1.</li>
    <li>Рейтинг на який грають не може бути від'ємним (у цьому випадку треба викинути помилку).</li>
    <li>Для гри треба створити окремий клас, у якому буде зберігатися потрібна інформація.</li>
    <li>У мейні треба створити 2 об'єкти класу гравця, зробити імітацію декількох ігр та вивести статистику кожного гравця.</li>
</ul>