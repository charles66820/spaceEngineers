public Program() {
    Runtime.UpdateFrequency = UpdateFrequency.Update1;
}

public void Main(string argument, UpdateType updateSource) {
    var pos = Me.GetPosition();
    Echo(pos.ToString());

    IMyTextPanel lcd = GridTerminalSystem.GetBlockWithName("posLCD") as IMyTextPanel;
    lcd.WriteText("Pos :\n\r");
    lcd.WriteText(pos.ToString(),true);
    lcd.ShowPublicTextOnScreen();
}
