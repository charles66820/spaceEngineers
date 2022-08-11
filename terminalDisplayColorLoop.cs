public Program() {
    Runtime.UpdateFrequency = UpdateFrequency.Update10;
}

bool toggle = true;

public void Main(string argument, UpdateType updateSource) {
    IMyTextSurfaceProvider testSurfaceProvinder = Me as IMyTextSurfaceProvider; // Me || GridTerminalSystem 
    Echo(testSurfaceProvinder.SurfaceCount.ToString());
    Echo(testSurfaceProvinder.UseGenericLcd.ToString());
   
    IMyTextSurface display = testSurfaceProvinder.GetSurface(0) as IMyTextSurface;
    IMyTextSurface keyboard = testSurfaceProvinder.GetSurface(1) as IMyTextSurface;
    
    if (toggle) {
        display.BackgroundColor = Color.Blue;
        keyboard.BackgroundColor = Color.Red;
    } else {
        display.BackgroundColor = Color.Red;
        keyboard.BackgroundColor = Color.Blue;
    }
    toggle = !toggle;
}
