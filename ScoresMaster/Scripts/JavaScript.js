jQuery.getJSON('https://app.sportdataapi.com/api/v1/soccer/matches?apikey=7ccb81a0-7049-11eb-8c76-a5e6c19519e0&season_id=352&date_from=2021-02-24', function (result) {
    console.log(result)
    var Get_Results1 = result.data[1]
    var start_time = Get_Results1.match_start
    var away = Get_Results1.away_team.name
    var home = Get_Results1.home_team.name
    var id = Get_Results1.match_id
    $(".id").append(id)
    $(".time").append(start_time)
    $(".away").append(away)
    $(".home").append(home)
});