public Program() {
    Runtime.UpdateFrequency = UpdateFrequency.Update100;
}

bool toggle = true;

public void Main(string argument, UpdateType updateSource) {
    IMyTextSurfaceProvider testSurfaceProvinder = Me as IMyTextSurfaceProvider;
    Echo(testSurfaceProvinder.SurfaceCount.ToString());
    Echo(testSurfaceProvinder.UseGenericLcd.ToString());

    IMyTextSurface display = testSurfaceProvinder.GetSurface(0) as IMyTextSurface; // Me.GetSurface(0) as IMyTextSurface;
    IMyTextSurface keyboard = testSurfaceProvinder.GetSurface(1) as IMyTextSurface; // Me.GetSurface(1) as IMyTextSurface;

    display.ContentType = ContentType.TEXT_AND_IMAGE;
    keyboard.ContentType = ContentType.TEXT_AND_IMAGE;

    // ContentType.NONE
    // ContentType.SCRIPT
    // ContentType.TEXT_AND_IMAGE
    // ContentType.IMAGE

    display.Font = "Monospace";
    display.FontSize = 6;
    display.WriteText("test");
    display.Alignment = TextAlignment.CENTER;

    if (toggle) {
        display.BackgroundColor = Color.Blue;
        keyboard.BackgroundColor = Color.Red;
    } else {
        display.BackgroundColor = Color.Red;
        keyboard.BackgroundColor = Color.Blue;
    }
    toggle = !toggle;
}
