namespace SportItems;

public class Tennis
{
    private Player player1 { get; set; }
    private Player player2 { get; set; }
    
    public Tennis()
    {
        player1 = new Player() { Name = "Henry", Score = 0, ShowString = string.Empty};

        player2 = new Player() { Name = "Jack" ,Score = 0, ShowString = string.Empty};
    }
    
    public string Score()
    {
        ShowString(player1);

        ShowString(player2);

        if (player1.Score == 0 && player2.Score == 0){
            return "love all";
        }
        if(player1.Score == player2.Score){
            player2.ShowString = "all";
        }

        if( (player1.Score > 2 || player2.Score > 2 ) && player1.Score > player2.Score){
            return $"{player1.Name} adv";
        }
        else if(){

        }
        
        if(player1.Score > 2 && player1.Score == player2.Score){
            return "deuce";
        }

        return $"{player1.ShowString} {player2.ShowString}";

    }

    public void Player1Add(){
        player1.Score++;
    }

    public void Player2Add(){
        player2.Score++;
    }

    public void ShowString(Player player){
        if(player.Score == 0){
            player.ShowString = "love";
        }
        else if(player.Score == 1){
            player.ShowString = "fifteen";
        }
        else if(player.Score == 2){
            player.ShowString = "thirty";
        }
        else if(player.Score == 3){
            player.ShowString = "forty";
        }
    }
}

public class Player{
    public string Name { get; set; }

    public int Score{ get; set; }

    public string ShowString{ get; set;}
}
