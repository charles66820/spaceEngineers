public Program() { }

public void Main(string argument, UpdateType updateSource) {
    IMyTextPanel lcd = GridTerminalSystem.GetBlockWithName("LCD") as IMyTextPanel;

    List<string> sprites = new List<string>();
    lcd.GetSprites(sprites);

    lcd.ClearImagesFromSelection();
    lcd.AddImageToSelection(sprites[31], true);
}