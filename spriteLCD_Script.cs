public Program() {
    Runtime.UpdateFrequency = UpdateFrequency.Update100;
}

IMyTextPanel lcd = null;
List<string> sprites = new List<string>();

int index = 0;

public void Main(string argument, UpdateType updateSource) {
    if (lcd == null) lcd = GridTerminalSystem.GetBlockWithName("posLCD") as IMyTextPanel;

    if (lcd != null) {

        if (!sprites.Any()) lcd.GetSprites(sprites);

        if (sprites.Any()) {
            var sprite = sprites[index % sprites.Count];
            lcd.ClearImagesFromSelection();
            lcd.AddImageToSelection(sprite, true);
            index++;
        }
    }
}
