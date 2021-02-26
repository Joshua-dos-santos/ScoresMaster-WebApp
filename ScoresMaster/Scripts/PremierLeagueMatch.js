jQuery.getJSON('https://app.sportdataapi.com/api/v1/soccer/matches?apikey=78b7f4f0-781d-11eb-b7ce-ab513a4a050f&season_id=352&date_from=2021-02-24', function (result) {
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