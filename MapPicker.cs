using Sandbox;

namespace MapPicker;
public static class Vote
{
  // Todo - store list of client names, against vote for each map

  // Todo implmement method "init" which accepts a list of maps as {name: "mapname, id: "map_id"}

  public static void BeginVote()
  {
    Log.Info("Created Panel");
    Game.RootPanel = new Hud();
  }

  public static void EndVote()
  {
    Log.Info("Removed Panel");
    Game.RootPanel.DeleteChildren();
  }

  [ConCmd.Server]
  public static void VoteForMap(string mapId)
  {
    Log.Info("Clicked Vote!");
    var clientId = ConsoleSystem.Caller.ToString();

    if (clientId != null)
    {
      // todo - Save vote against the clientId
    }
    else
    {
      Log.Info("Command was called by non-client");
    }
  }

  [GameEvent.Server.ClientDisconnect]
  private static void ClientDisconnect(ClientDisconnectEvent e)
  {
    Log.Info(e.Client);
  }

  [GameEvent.Server.ClientJoined]
  private static void ClientJoined(ClientJoinedEvent e)
  {
    Log.Info(e.Client);
  }

}
