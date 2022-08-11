public Program() {
    Runtime.UpdateFrequency = UpdateFrequency.Update1;
}

public void Main(string argument, UpdateType updateSource) {
    var pos = Me.GetPosition();
    Echo(pos.ToString());

    IMyTextPanel lcd = GridTerminalSystem.GetBlockWithName("posLCD") as IMyTextPanel;
    lcd.WriteText("Pos :\n\r");
    lcd.WriteText("X : " + pos.X.ToString() + "\n\r", true);
    lcd.WriteText("Y : " + pos.Y.ToString() + "\n\r", true);
    lcd.WriteText("Z : " + pos.Z.ToString() + "\n\r", true);
}
